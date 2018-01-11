//in the name of GOD
/*
Project   : Packet Analyzer
Developer : Seyyed Mahdi Hassanpour Matikolaei
*/
#include <stdio.h>
#include <string.h>
#include "winsock2.h"   //need winsock for inet_ntoa and ntohs methods
#include <string.h>
#define HAVE_REMOTE
#include "pcap.h"   //Winpcap :)
#pragma comment(lib , "ws2_32.lib") //For winsock
#pragma comment(lib , "wpcap.lib") //For winpcap


//-------------------Structurs--------------------------------------

//Ethernet Header
typedef struct ethernet_header
{
	UCHAR dest[6];//6byte
	UCHAR source[6];//6byte
	USHORT type;//2byte
} ETHER_HDR;
//Arp Header
typedef struct arp_hdr
{
	unsigned short hardwareType;
	unsigned short protocol_type;
	unsigned char hardwareSize;
	unsigned char protocolSize;
	unsigned short operationCode;
	unsigned char sourceMacAddress[6];//6byte
	unsigned char ipSourceAddress[4]; // Source address
	unsigned char destinationMacAddress[6];//6byte
	unsigned char ipDestinationAddress[4]; // destination address
}ARP_HDR;
//Ip header (v4)
typedef struct ip_hdr
{// for BYTE_ORDER == __LITTLE_ENDIAN
	unsigned char ip_header_len : 4; // 4-bit header length (in 32-bit words) normally=5 (Means 20 Bytes may be 24 also)
	unsigned char ip_version : 4; // 4-bit IPv4 version


	unsigned char ip_tos; // IP type of service
	unsigned short ip_total_length; // Total length
	unsigned short ip_id; // Unique identifier

	unsigned short R_DF_MF_FragmentOffset;//چون لیتتل اندین ذخیره میشه با استفاده از ntohs
	//برعکسش میکنم و سپس س بیت اول که برای ام اف و دی اف و ریزرود هست رو با استفاده از اند کردن با مثلا 0x8000
	//بدست میارم و نشون میدم

	unsigned char ip_ttl; // Time to live
	unsigned char ip_protocol; // Protocol(TCP,UDP etc)
	unsigned short ip_checksum; // IP checksum
	unsigned char ipSource[4]; // Source address
	unsigned char ipDestination[4]; // destination address
} IPV4_HDR;
//ip header v6
typedef struct ipv6_header
{
	unsigned int version_trafficClass_FlowLabel;
	unsigned short  length;
	unsigned char  next_header;
	unsigned char  hop_limit;

	unsigned short  in6_addr_src[8];
	unsigned short in6_addr_dst[8];
} IPV6_HDR;
//UDP header
typedef struct udp_hdr
{
	unsigned short source_port; // Source port no.
	unsigned short dest_port; // Dest. port no.
	unsigned short udp_length; // Udp packet length
	unsigned short udp_checksum; // Udp checksum (optional)
} UDP_HDR;
// TCP header
typedef struct tcp_header
{
	unsigned short source_port; // source port//نوع اصلیش شورت هست
	unsigned short dest_port; // destination port
	unsigned int sequence; // sequence number - 32 bits
	unsigned int acknowledge; // acknowledgement number - 32 bits
	//litte endian
	unsigned char ns : 1; //Nonce Sum Flag Added in RFC 3540.
	unsigned char reserved_part1 : 3; //according to rfc
	unsigned char data_offset : 4; /*The number of 32-bit words in the TCP header.
								   This indicates where the data begins.
								   The length of the TCP header is always a multiple
								   of 32 bits.*/
	//little endian for below flags?? 
	unsigned char fin : 1; //Finish Flag
	unsigned char syn : 1; //Synchronise Flag
	unsigned char rst : 1; //Reset Flag
	unsigned char psh : 1; //Push Flag
	unsigned char ack : 1; //Acknowledgement Flag
	unsigned char urg : 1; //Urgent Flag

	unsigned char ecn : 1; //ECN-Echo Flag
	unsigned char cwr : 1; //Congestion Window Reduced Flag

	////////////////////////////////

	unsigned short window; // window
	unsigned short checksum; // checksum
	unsigned short urgent_pointer; // urgent pointer
} TCP_HDR;
// ICMP header
typedef struct icmp_hdr
{
	BYTE type; // ICMP Error type
	BYTE code; // Type sub code
	USHORT checksum;
	USHORT id;
	USHORT seq;
} ICMP_HDR;
// DNS header
typedef struct dns_header
{
	unsigned short transActionIdentification;//2byte

	unsigned char RD : 1; //recursion desired Flag
	unsigned char TC : 1; //truncated Flag
	unsigned char AA : 1; //authorization (just for response) Flag
	unsigned char OpCode : 4; //0000 standard query/0001reverse query/0010about server statusFlag
	unsigned char qr : 1; //query/response  Flag



	unsigned char RCode : 4; //reply code Flag
	unsigned char Unused : 3; //000 reserved
	unsigned char RA : 1; //recursion available Flag


	unsigned short numberOFQuestions;
	unsigned short numberOFAnswerRRs;
	unsigned short numberOFAuthorityRRs;
	unsigned short numberOFAdditionalRRs;

}   DNS_HDR;
// NBNS header
typedef struct nbns_header
{
	unsigned short transActionIdentification;//2byte

	unsigned char RD : 1; //recursion desired Flag
	unsigned char TC : 1; //truncated Flag
	unsigned char AA : 1; //authorization (just for response) Flag
	unsigned char OpCode : 4; //0000 standard query/0001reverse query/0010about server statusFlag
	unsigned char qr : 1; //query/response  Flag

	unsigned char RCode : 4; //reply code Flag
	unsigned char BD : 1; //BroadCast Packet Flag
	unsigned char Unused : 2; //000 reserved
	unsigned char RA : 1; //recursion available Flag

	unsigned short numberOFQuestions;
	unsigned short numberOFAnswerRRs;
	unsigned short numberOFAuthorityRRs;
	unsigned short numberOFAdditionalRRs;

}   NBNS_HDR;
// LLMNR header
typedef struct llmnr_header
{
	unsigned short transActionIdentification;//2byte

	unsigned char T : 1; //Tentative
	unsigned char TC : 1; //truncated Flag
	unsigned char C : 1; //Conflict Flag
	unsigned char OpCode : 4; //0000 standard query/0001reverse query/0010about server statusFlag
	unsigned char qr : 1; //query/response  Flag

	unsigned char RCode : 4; //reply code Flag
	unsigned char Unused : 4; //0000 reserved

	unsigned short numberOFQuestions;
	unsigned short numberOFAnswerRRs;
	unsigned short numberOFAuthorityRRs;
	unsigned short numberOFAdditionalRRs;

}   LLMNR_HDR;
// IGMPV2 header
typedef struct igmpv2_hdr
{
	unsigned char type;
	unsigned char maxResponseTime;
	unsigned short headerChecksum;
	unsigned char ip[4]; // multicast address
} IGMP_HDR;
// ICMPV6 header
typedef struct icmpv6_hdr
{
	unsigned char type;
	unsigned char code;
	unsigned short checksum;
} ICMPV6_HDR;
// DHCP header
typedef struct dhcp_hdr
{
	unsigned char opcode;
	unsigned char hardwareType;
	unsigned char hardwareAddressLength;
	unsigned char hopCount;
	unsigned int transactionID;//32bit
	unsigned short secondElapsed;
	unsigned short bootpFlags;//just the left bit is usefull.other its are just for compatibility with bootp protocol
	unsigned char clientIpAddress[4];
	unsigned char yourIpAddress[4];//client
	unsigned char nextServerIpAddress[4];
	unsigned char relayAgentIpAddress[4];
	unsigned char clientMacAddress[6];//6byte
	unsigned char clientHardwareAddressPadding[10];//10byte
	unsigned char serverHostName[64];//64byte
	unsigned char bootFileName[128];//128byte
} DHCP_HDR;
//Devices Structure name,description
typedef struct Dev_Information{
	char dev_name[100];//-name	0x00bd1228 "rpcap://\\Device\\NPF_{B1F33576-99E3-4431-8E08-0FE4D0B13C96}"	
	char dev_description[100];//+description	0x00bd3390 "Network adapter 'Microsoft' on local host"	
}Device_Details;


//-------------------Prototyps------------------------------------------------

__declspec(dllexport) int GetEthernet(ETHER_HDR*);//
__declspec(dllexport)  int GetIpv4(IPV4_HDR * ip);//
__declspec(dllexport)  int GetIpv6(IPV6_HDR * ip);//
__declspec(dllexport)  int GetUdp(UDP_HDR * udp);//
__declspec(dllexport)  int GetTcp(TCP_HDR * tcp);//
__declspec(dllexport)  int GetIcmp(ICMP_HDR * icmp);//
__declspec(dllexport)  int GetIgmp(IGMP_HDR * igmp);//
__declspec(dllexport)  int GetArp(ARP_HDR * arp);//
__declspec(dllexport)  int GetIcmpv6(ICMPV6_HDR * icmpv6);//
__declspec(dllexport)  int GetDns(DNS_HDR * dns);//
__declspec(dllexport)  int GetDhcp(DHCP_HDR * dhcp);//
__declspec(dllexport)  int GetLlmnr(LLMNR_HDR * llmnr);//
__declspec(dllexport)  int GetNbns(NBNS_HDR * nbns);//
__declspec(dllexport)  const char * GetSsdp();//
__declspec(dllexport)  const char * GetHttp();//
__declspec(dllexport)  void GetDevicesDetails(Device_Details *Dev);//
__declspec(dllexport) int GetCountOfNics();//
__declspec(dllexport) void GetNICdetailsOneByOneFromCsharp();//
__declspec(dllexport) int SelectAndOpenNIC(int choosenNIC);//
__declspec(dllexport) int CapturePacket();//
__declspec(dllexport)  const char *  GetFrame();
__declspec(dllexport)  int GetPayloadLength();

void ProcessPacket(unsigned char*, int);
void FillingPayload(u_char* , int );
void PrintIpHeader(u_char*, int);
void Print_ARP_Packet(u_char*, int);
void PrintIcmpPacket(u_char*, int);
void print_udp_packet(u_char*, int);
void PrintTcpPacket(u_char*, int);
int Print_DNS_Header(u_char*, int);
int Print_NBNS_Header(u_char*, int);
void Print_Ipv6_Packet(u_char*, int);
int Print_LLMNR_Header(u_char*, int);
void PrintIgmpPacket(u_char*, int);
int PrintIcmpv6Packet(u_char*, int);
int Print_DHCP_Packet(u_char*, int);

//-----------------Variables-------------------------------
ETHER_HDR *ethhdr;//
ARP_HDR *arpHeader;//
IPV4_HDR *iphdr;//
IPV6_HDR *ipv6hdr;//
TCP_HDR *tcpheader;//
UDP_HDR *udpheader;//
ICMP_HDR *icmpheader;//
DNS_HDR *dnsheader;//
NBNS_HDR *nbnsheader;//
LLMNR_HDR *llmnrheader;//
IGMP_HDR *igmpheader;//
ICMPV6_HDR *icmpv6header;//
DHCP_HDR *dhcpheader;//
u_char *data;
int turn = 1;//0 yani c# 1 yani c
unsigned int choosenNIC;
Device_Details nic_details;
unsigned short IpHeaderLength = 0, IPTotalLength = 0, TransportHeaderLength = 0, ApplicationLayerLength = 0;//baraye inke betonam andaze kole http ro tahskhis bedam va bekhonam
int FrameTotalLength = 0,payLoadLentgh=0,ipHeaderVersion=0;
pcap_if_t *alldevs, *d;
int CountOfNics = 0;
pcap_t *fp;
char  errbuf[PCAP_ERRBUF_SIZE];
unsigned int result;
unsigned char *pkt_data;
time_t seconds;
struct tm tbreak;
struct pcap_pkthdr *header;


//------------------Functions---------------------------------------

__declspec(dllexport)  int GetCountOfNics()
{
	if (pcap_findalldevs_ex(PCAP_SRC_IF_STRING, NULL, &alldevs, errbuf) == -1)
		return -1;// printf("Error in pcap_findalldevs_ex: %s\n", errbuf);

	/* Count of the NICs */
	for (d = alldevs; d != NULL; d = d->next)
	{
		++CountOfNics;
	}
	d = alldevs;
	return CountOfNics;
}
__declspec(dllexport)  void GetNICdetailsOneByOneFromCsharp()
{
		strcpy(nic_details.dev_description, d->description);
		strcpy(nic_details.dev_name, d->name);
		d=d->next;
}
__declspec(dllexport)  int SelectAndOpenNIC(int choosenNIC)
{
	for (d = alldevs, CountOfNics = 0; CountOfNics < choosenNIC - 1; d = d->next, CountOfNics++);

	/* Open the device */
	if ((fp = pcap_open(d->name, 100 /*snaplen*/, PCAP_OPENFLAG_PROMISCUOUS /*flags*/, 20 /*read timeout*/, NULL /* remote authentication */, errbuf)
		) == NULL)
	{
		return -3;
	}

}
__declspec(dllexport)  int CapturePacket()
{
	if ((result = pcap_next_ex(fp, &header, &pkt_data)) >= 0)
	{
		if (result == 0)
			return -1; // Timeout elapsed
		else
		{
			FrameTotalLength = header->caplen;
			payLoadLentgh = 0;
			ProcessPacket(pkt_data, FrameTotalLength);
			
			return 0;
		}
		
		
	}
return -1;
}
__declspec(dllexport)  int GetPayloadLength()
{
	return payLoadLentgh;
}
__declspec(dllexport)  const char *  GetFrame()//,PAYLOAD_64k *payload_64k)
{
	return pkt_data;
}

//=============GetDevices======================
__declspec(dllexport) void GetDevicesDetails(Device_Details *Dev)
{
	*Dev = *&nic_details;
}
//=============GetEthernet =========================
__declspec(dllexport)  int GetEthernet(ETHER_HDR * et)
{
	*et = *ethhdr;
	return FrameTotalLength;
}
//=============GetIpv4 =========================
__declspec(dllexport)  int GetIpv4(IPV4_HDR * ip)
{
	*ip = *iphdr;
	return 0;
}
//=============GetIpv6 =========================
__declspec(dllexport)  int GetIpv6(IPV6_HDR * ip)
{
	*ip = *ipv6hdr;
	return 0;
}
//=============GetUdp =========================
__declspec(dllexport)  int GetUdp(UDP_HDR * udp)
{
	*udp = *udpheader;
	return 0;
}
//=============GetTcp =========================
__declspec(dllexport)  int GetTcp(TCP_HDR * tcp)
{
	*tcp = *tcpheader;
	return 0;
}
//=============GetIcmp =========================
__declspec(dllexport)  int GetIcmp(ICMP_HDR * icmp)
{
	*icmp = *icmpheader;
	return 0;
}
//=============GetIgmp =========================
__declspec(dllexport)  int GetIgmp(IGMP_HDR * igmp)
{
	*igmp = *igmpheader;
	return 0;
}
//=============GetArp =========================
__declspec(dllexport)  int GetArp(ARP_HDR * arp)
{
	*arp = *arpHeader;
	return 0;
}
//=============GetIcmpv6 =========================
__declspec(dllexport)  int GetIcmpv6(ICMPV6_HDR * icmpv6)
{
	*icmpv6 = *icmpv6header;
	return 0;
}
//=============GetDNS =========================
__declspec(dllexport)  int GetDns(DNS_HDR * dns)
{
	*dns = *dnsheader;
	return 0;
}
//=============GetDHCP =========================
__declspec(dllexport)  int GetDhcp(DHCP_HDR * dhcp)
{
	*dhcp = *dhcpheader;
	return 0;
}
//=============GetLLmnr =========================
__declspec(dllexport)  int GetLlmnr(LLMNR_HDR * llmnr)
{
	*llmnr = *llmnrheader;
	return 0;
}
//=============GetNbns =========================
__declspec(dllexport)  int GetNbns(NBNS_HDR * nbns)
{
	*nbns = *nbnsheader;
	return 0;
}
//=============GetSSdp =========================
__declspec(dllexport)  const char * GetSsdp()
{
	//*ssdp = *(&ssdpheader);
	return data;
}
//=============GetHTTP =========================
__declspec(dllexport)  const char * GetHttp()
{
	//*http = *(&httpheader);
	return data;
}


//=============process packet=========================
 void ProcessPacket(unsigned char* Buffer, int Size)
{

	//Ethernet header
	ethhdr = (ETHER_HDR *)Buffer;
	//Ip packets
	ethhdr->type = ntohs(ethhdr->type);
	if (ethhdr->type == 0x0800)
	{
		//ip header
		iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
		switch (iphdr->ip_protocol) //Check the Protocol and do accordingly...
		{
			case 1: //ICMP Protocol
				PrintIcmpPacket(Buffer, Size);
				break;

			case 2: //IGMP Protocol
				PrintIgmpPacket(Buffer, Size);
				break;

			case 6: //TCP Protocol
				PrintTcpPacket(Buffer, Size);
				break;

			case 17: //UDP Protocol
				print_udp_packet(Buffer, Size);
				break;

			default: //Some Other Protocol
				break;
		}
	}
	else if (ethhdr->type == 0x0806)//arp packet
	{
		Print_ARP_Packet(Buffer, Size);
	}
	else if (ethhdr->type == 0x86dd)//ipv6 packets
	{
		Print_Ipv6_Packet(Buffer, Size);
	}

}
//=============IPV4 Header=========================
void PrintIpHeader(unsigned char* Buffer, int Size)
{

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	// ip header
	iphdr->R_DF_MF_FragmentOffset = ntohs(iphdr->R_DF_MF_FragmentOffset);
	iphdr->ip_total_length = ntohs(iphdr->ip_total_length);
	iphdr->ip_id = ntohs(iphdr->ip_id);
	iphdr->ip_checksum = ntohs(iphdr->ip_checksum);

	IPTotalLength = iphdr->ip_total_length;
	IpHeaderLength = (unsigned int)iphdr->ip_header_len * 4;

}
//=============IPV6 Header=========================
void Print_Ipv6_Packet(unsigned char* Buffer, int Size)
{
	int data_size = 0;
	ipv6hdr = (IPV6_HDR *)(Buffer + sizeof(ETHER_HDR));
	//print ipv6 header
	ipv6hdr->version_trafficClass_FlowLabel = ntohl(ipv6hdr->version_trafficClass_FlowLabel);
	ipv6hdr->length = ntohs(ipv6hdr->length);
	for (size_t i = 0; i < 8; i++)
	{
		ipv6hdr->in6_addr_src[i] = ntohs(ipv6hdr->in6_addr_src[i]);
		ipv6hdr->in6_addr_dst[i] = ntohs(ipv6hdr->in6_addr_dst[i]);
	}
	IPTotalLength = ipv6hdr->length;
	IpHeaderLength = 40;//tole header ipv6 40byte ast
	ipHeaderVersion = 6;
	if (ipv6hdr->next_header == 17)//udp packet
		print_udp_packet(Buffer, Size);
	else if (ipv6hdr->next_header == 58 || ipv6hdr->next_header == 0)//icmpv6 packet
		payLoadLentgh=PrintIcmpv6Packet(Buffer, Size);
	else
	{
		data = (Buffer + sizeof(ETHER_HDR)+sizeof(IPV6_HDR));
		data_size = (Size - sizeof(ETHER_HDR)-sizeof(IPV6_HDR));
		payLoadLentgh = data_size;
	}
}
//=============ARP Header=========================
void Print_ARP_Packet(u_char *Buffer, int Size)
{
	int header_size = 0, data_size;
	arpHeader = (ARP_HDR *)(Buffer + sizeof(ETHER_HDR));
	data = (Buffer + sizeof(ETHER_HDR)+sizeof(ARP_HDR));
	data_size = (Size - sizeof(ETHER_HDR)-sizeof(ARP_HDR));
	//print Arp Header
	arpHeader->hardwareType = ntohs(arpHeader->hardwareType);
	arpHeader->protocol_type = ntohs(arpHeader->protocol_type);
	arpHeader->operationCode = ntohs(arpHeader->operationCode);
	payLoadLentgh = data_size;
}
//=============ICMP Header=========================
void PrintIcmpPacket(u_char* Buffer, int Size)
{
	int iphdrlen = 0, icmphdrlen = 0, data_size = 0;

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	iphdrlen = iphdr->ip_header_len * 4;

	icmpheader = (ICMP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));

	data = (Buffer + sizeof(ETHER_HDR)+iphdrlen + sizeof(ICMP_HDR));
	data_size = (Size - sizeof(ETHER_HDR)-iphdrlen - sizeof(ICMP_HDR));
	//ip header
	PrintIpHeader(Buffer, Size);
	//icmp
	icmpheader->checksum = ntohs(icmpheader->checksum);
	icmpheader->id = ntohs(icmpheader->id);
	icmpheader->seq = ntohs(icmpheader->seq);
}
//=============ICMPV6 Header=========================
int  PrintIcmpv6Packet(u_char* Buffer, int Size)
{
	int  data_size = 0;

	icmpv6header = (ICMPV6_HDR*)(Buffer + sizeof(IPV6_HDR)+sizeof(ETHER_HDR));
	data = (Buffer + sizeof(ETHER_HDR)+sizeof(IPV6_HDR)+sizeof(ICMPV6_HDR));
	data_size = (Size - sizeof(ETHER_HDR)-sizeof(IPV6_HDR)-sizeof(ICMPV6_HDR));
	//icmpv6
	icmpv6header->checksum = ntohs(icmpv6header->checksum);
	return data_size;
}
//=============IGMP Header=========================
void PrintIgmpPacket(u_char* Buffer, int Size)
{
	int iphdrlen = 0, icmphdrlen = 0, data_size = 0;

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	iphdrlen = iphdr->ip_header_len * 4;

	igmpheader = (IGMP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));

	data = (Buffer + sizeof(ETHER_HDR)+iphdrlen + sizeof(IGMP_HDR));
	data_size = (Size - sizeof(ETHER_HDR)-iphdrlen - sizeof(IGMP_HDR));

	//IGMP Packet
	PrintIpHeader(Buffer, Size);
	igmpheader->headerChecksum = ntohs(igmpheader->headerChecksum);
	payLoadLentgh = data_size;
}
//=============UDP Header=========================
void print_udp_packet(u_char *Buffer, int Size)
{
	int  data_size = 0;
	if (ipHeaderVersion == 6)
	{
		udpheader = (UDP_HDR*)(Buffer + sizeof(IPV6_HDR)+sizeof(ETHER_HDR));
		data = (Buffer + sizeof(ETHER_HDR)+sizeof(IPV6_HDR)+sizeof(UDP_HDR));
		data_size = (Size - sizeof(ETHER_HDR)-sizeof(IPV6_HDR)-sizeof(UDP_HDR));
		ipHeaderVersion = 0;
	}
	else {
		//print ip header
		PrintIpHeader(Buffer, Size);
		int iphdrlen = iphdr->ip_header_len * 4;
		udpheader = (UDP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));
		data = (Buffer + sizeof(ETHER_HDR)+iphdrlen + sizeof(UDP_HDR));
		data_size = (Size - sizeof(ETHER_HDR)-iphdrlen - sizeof(UDP_HDR));
	}
	//udp header
	udpheader->source_port = ntohs(udpheader->source_port);
	udpheader->dest_port = ntohs(udpheader->dest_port);
	udpheader->udp_length = ntohs(udpheader->udp_length);
	udpheader->udp_checksum = ntohs(udpheader->udp_checksum);

	TransportHeaderLength = 8;//udp 8byte hast
	if (udpheader->source_port == 53 || udpheader->dest_port == 53)
		data_size = Print_DNS_Header(data, data_size);
	else if (udpheader->source_port == 137 || udpheader->dest_port == 137)
		data_size = Print_NBNS_Header(data, data_size);
	else if (udpheader->source_port == 5355 || udpheader->dest_port == 5355)
		data_size = Print_LLMNR_Header(data, data_size);
	else if (udpheader->source_port == 68 || udpheader->dest_port == 67 || udpheader->source_port == 67 || udpheader->dest_port == 68)
		data_size = Print_DHCP_Packet(data, data_size);
	else
	{
		payLoadLentgh = data_size;
	}
  	
}
//=============TCP Header=========================
void PrintTcpPacket(u_char* Buffer, int Size)
{
	unsigned short iphdrlen;
	int header_size = 0, tcphdrlen, data_size;
	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	iphdrlen = iphdr->ip_header_len * 4;
	tcpheader = (TCP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));
	tcphdrlen = tcpheader->data_offset * 4;
	data = (Buffer + sizeof(ETHER_HDR)+iphdrlen + tcphdrlen);
	data_size = (Size - sizeof(ETHER_HDR)-iphdrlen - tcphdrlen);
	//print ip header
	PrintIpHeader(Buffer, Size);
	//print tcp header
	tcpheader->source_port = ntohs(tcpheader->source_port);
	tcpheader->dest_port = ntohs(tcpheader->dest_port);
	tcpheader->sequence = ntohl(tcpheader->sequence);
	tcpheader->acknowledge = ntohl(tcpheader->acknowledge);
	tcpheader->window = ntohs(tcpheader->window);
	tcpheader->checksum = ntohs(tcpheader->checksum);

	TransportHeaderLength = tcphdrlen;

	payLoadLentgh = data_size;
}
//=============DNS Header=========================
int Print_DNS_Header(u_char* Buffer, int Size)
{
	int data_size = 0;

	dnsheader = (DNS_HDR*)(Buffer);
	data = (Buffer + sizeof(DNS_HDR));
	data_size = (Size - sizeof(DNS_HDR));

	dnsheader->transActionIdentification = ntohs(dnsheader->transActionIdentification);
	dnsheader->numberOFQuestions = ntohs(dnsheader->numberOFQuestions);
	dnsheader->numberOFAnswerRRs = ntohs(dnsheader->numberOFAnswerRRs);
	dnsheader->numberOFAuthorityRRs = ntohs(dnsheader->numberOFAuthorityRRs);
	dnsheader->numberOFAdditionalRRs = ntohs(dnsheader->numberOFAdditionalRRs);

	return data_size;
}
//=============NBNS Header=========================
int Print_NBNS_Header(u_char* Buffer, int Size)
{
	int data_size = 0;

	nbnsheader = (NBNS_HDR*)(Buffer);

	data = (Buffer + sizeof(NBNS_HDR));
	data_size = (Size - sizeof(NBNS_HDR));

	nbnsheader->transActionIdentification = ntohs(nbnsheader->transActionIdentification);
	nbnsheader->numberOFQuestions = ntohs(nbnsheader->numberOFQuestions);
	nbnsheader->numberOFAnswerRRs = ntohs(nbnsheader->numberOFAnswerRRs);
	nbnsheader->numberOFAuthorityRRs = ntohs(nbnsheader->numberOFAuthorityRRs);
	nbnsheader->numberOFAdditionalRRs = ntohs(nbnsheader->numberOFAdditionalRRs);

	return data_size;
}
//=============LLMNR Header=========================
int Print_LLMNR_Header(u_char* Buffer, int Size)
{
	int data_size = 0;

	llmnrheader = (LLMNR_HDR*)(Buffer);
	data = (Buffer + sizeof(LLMNR_HDR));
	data_size = (Size - sizeof(LLMNR_HDR));

	llmnrheader->transActionIdentification = ntohs(llmnrheader->transActionIdentification);
	llmnrheader->numberOFQuestions = ntohs(llmnrheader->numberOFQuestions);
	llmnrheader->numberOFAnswerRRs = ntohs(llmnrheader->numberOFAnswerRRs);
	llmnrheader->numberOFAuthorityRRs = ntohs(llmnrheader->numberOFAuthorityRRs);
	llmnrheader->numberOFAdditionalRRs = ntohs(llmnrheader->numberOFAdditionalRRs);

	return data_size;
}
//=============DHCP Header=========================
int Print_DHCP_Packet(u_char* Buffer, int Size)
{
	int data_size = 0;

	dhcpheader = (DHCP_HDR*)(Buffer);

	data = (Buffer + sizeof(DHCP_HDR));
	data_size = (Size - sizeof(DHCP_HDR));

	//dhcp header
	dhcpheader->transactionID = ntohl(dhcpheader->transactionID);
	dhcpheader->secondElapsed = ntohs(dhcpheader->secondElapsed);
	dhcpheader->bootpFlags = ntohs(dhcpheader->bootpFlags);

	return data_size;
}
