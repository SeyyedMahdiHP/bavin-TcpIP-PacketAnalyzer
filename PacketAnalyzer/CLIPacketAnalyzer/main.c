//به نام الله 
//سید مهدی حسن پور متی کلایی
//پروژه آنالیز بسته های شبکه
// https://github.com/SeyyedMahdiHP/MyOtherProjects/PacketAnalyzer
// smahdi1991@gmail.com
// seyyedmahdihp@gmail.com
// under MIT license 
/* to compile this project with visual studio, you have to first install winpcap:
// https://www.winpcap.org/install/bin/WinPcap_4_1_3.exe
, then copy all files and folders under include directory in WpdPack, and paste them into C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\include
and copy all files and folder under Lib directory in Wpdpack, and paste them into C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\lib
https://www.winpcap.org/install/bin/WpdPack_4_1_2.zip
*/
#include "stdio.h"
#include "winsock2.h"   //need winsock for inet_ntoa and ntohs methods
#include <string.h>
#define HAVE_REMOTE
#include "pcap.h"   //Winpcap :)

#pragma comment(lib , "ws2_32.lib") //For winsock
#pragma comment(lib , "wpcap.lib") //For winpcap

//some packet processing functions
void ProcessPacket(u_char*, int); //This will decide how to digest
void print_ethernet_header(u_char*);
void PrintIpHeader(u_char*, int);
void Print_ARP_Packet(u_char*, int);
void PrintIcmpPacket(u_char*, int);
void print_udp_packet(u_char*, int);
void PrintTcpPacket(u_char*, int);
void PrintData(u_char*, int);
int Print_Http_Header(u_char*, int);
int Print_DNS_Header(u_char*, int);
int Print_NBNS_Header(u_char*, int);
void Print_Ipv6_Packet(u_char*, int);
int Print_LLMNR_Header(u_char*, int);
int Print_SSDP_Header(u_char*, int);
void PrintIgmpPacket(u_char*, int);
int PrintIcmpv6Packet(u_char*, int);
int Print_DHCP_Packet(u_char*, int);
void  ShowValueInHex(unsigned int, int);
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
	/*version : 4,
	traffic_class : 8,
	flow_label : 20;*/
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

typedef struct icmp_hdr
{
	BYTE type; // ICMP Error type
	BYTE code; // Type sub code
	USHORT checksum;
	USHORT id;
	USHORT seq;
} ICMP_HDR;

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

typedef struct igmpv2_hdr
{
	unsigned char type;
	unsigned char maxResponseTime;
	unsigned short headerChecksum;
	unsigned char ip[4]; // multicast address
} IGMP_HDR;

typedef struct icmpv6_hdr
{
	unsigned char type;
	unsigned char code;
	unsigned short checksum;
} ICMPV6_HDR;

typedef struct dhcp_hdr
{
	unsigned char opcode;
	unsigned char hardwareType;
	unsigned char hardwareAddressLength;
	unsigned char hopCount;
	unsigned int transactionID;
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

typedef struct http_hdr
{
	char header[1500];//maximum ethernet mtu
}HTTP_HDR;

typedef struct Dev_Informattion {
	char dev_name[100];
	char dev_description[100];
}Device_Details;

int tcp = 0, udp = 0, icmp = 0, others = 0, igmp = 0, total = 0, i, j;

ETHER_HDR *ethhdr;
ARP_HDR *arpHeader;
IPV4_HDR *iphdr;
IPV6_HDR *ipv6hdr;
TCP_HDR *tcpheader;
UDP_HDR *udpheader;
ICMP_HDR *icmpheader;
DNS_HDR *dnsheader;
NBNS_HDR *nbnsheader;
LLMNR_HDR *llmnrheader;
IGMP_HDR *igmpheader;
ICMPV6_HDR *icmpv6header;
DHCP_HDR *dhcpheader;
HTTP_HDR *httpheader;
HTTP_HDR hk;//
u_char *data;

Device_Details nic_details, *dv;
unsigned short IpHeaderLength = 0, IPTotalLength = 0, TransportHeaderLength = 0, ApplicationLayerLength = 0;//baraye inke betonam andaze kole http ro tahskhis bedam va bekhonam


int main()
{

	pcap_if_t *alldevs, *d;
	int i = 0;
	char  errbuf[PCAP_ERRBUF_SIZE], datebuffer[100];
	/////////
	unsigned int res;
	unsigned int chosenNumber;
	unsigned char *pkt_data;
	time_t seconds;
	struct tm tbreak;
	pcap_t *fp;
	struct pcap_pkthdr *header;


	/* The user didn't provide a packet source: Retrieve the local device list */
	if (pcap_findalldevs_ex(PCAP_SRC_IF_STRING, NULL, &alldevs, errbuf) == -1)
	{
		printf("Error in pcap_findalldevs_ex: %s\n", errbuf);
		return -1;
	}

	/* Print the list */
	for (d = alldevs; d != NULL; d = d->next)
	{
		strcpy(nic_details.dev_description, d->description);
		strcpy(nic_details.dev_name, d->name);
		//*dv = *&nic_details;

		/* nic_details[i].dev_description = d->description;
		nic_details[i].dev_name = d->name;*/
		printf("%d. %s\n    ", ++i, d->name);//-name	0x00bd1228 "rpcap://\\Device\\NPF_{B1F33576-99E3-4431-8E08-0FE4D0B13C96}"	char *


		if (d->description)
		{
			printf(" (%s)\n", d->description);//+description	0x00bd3390 "Network adapter 'Microsoft' on local host"	char *

		}
		else
		{
			printf(" (No description available)\n");
		}
	}

	if (i == 0)
	{
		printf("No interfaces found! Exiting.\n");
		return -1;
	}

	//pcap_freealldevs(alldevs);age dg kari b device ha nadarim
	printf("Enter the interface number you would like to sniff : ");
	scanf("%d", &chosenNumber);


	/* Jump to the selected adapter */
	for (d = alldevs, i = 0; i < chosenNumber - 1; d = d->next, i++);

	/* Open the device */
	if ((fp = pcap_open(d->name,
		100 /*snaplen*/,
		PCAP_OPENFLAG_PROMISCUOUS /*flags*/,
		20 /*read timeout*/,
		NULL /* remote authentication */,
		errbuf)
		) == NULL)
	{
		printf("\nError opening adapter\n");
		return -1;
	}

	//read packets in a loop :)
	while ((res = pcap_next_ex(fp, &header, &pkt_data)) >= 0)
	{
		if (res == 0)
		{
			// Timeout elapsed
			continue;
		}
		seconds = header->ts.tv_sec;
		localtime_s(&tbreak, &seconds);
		strftime(datebuffer, 80, "%d-%b-%Y %I:%M:%S %p", &tbreak);
		//print pkt timestamp and pkt len
		//fprintf(logfile , "\nNext Packet : %ld:%ld (Packet Length : %ld bytes) " , header->ts.tv_sec, header->ts.tv_usec, header->len);

		printf("\nNext Packet : %s.%ld (Packet Length : %ld bytes) ", datebuffer, header->ts.tv_usec, header->len);
		//fprintf(logfile , "\nNext Packet : %s.%ld (Packet Length : %ld bytes) " , buffer , header->ts.tv_usec, header->len);

		ProcessPacket(pkt_data, header->caplen);
	}

	if (res == -1)
	{
		printf("Error reading the packets: %s\n", pcap_geterr(fp));
		return -1;
	}

	return 0;
}
/*
while( c#flag==ture);
mutex baraye inja bayad estefade beshe

}

if (res == -1)
{
printf("Error reading the packets: %s\n", pcap_geterr(fp));
return -1;
}

return 0;
}
void test(struct* t1)
{
t1 = ETHER_HDR;
//mutex bayad inja estefade beshe
}
*/
void ProcessPacket(u_char* Buffer, int Size)
{
	//Ethernet header
	ethhdr = (ETHER_HDR *)Buffer;//یعنی 14 بایت اول بافر که حاوی هدر دیتا لینک هست رو بریز توی شی از استراکچر هدر اترنت
	++total;

	//Ip packets
	if (ntohs(ethhdr->type) == 0x0800)
	{
		//ip header
		iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));//یعنی 20 بایت بعد از 14 بایت اول که همون بایت های مربوط به هدر لایه آی پی هستن رو بگیر بریز توی شی استراکچر هدر آی پی

		switch (iphdr->ip_protocol) //Check the Protocol and do accordingly...
		{
		case 1: //ICMP Protocol
			icmp++;
			PrintIcmpPacket(Buffer, Size);
			break;

		case 2: //IGMP Protocol
			igmp++;
			PrintIgmpPacket(Buffer, Size);
			break;

		case 6: //TCP Protocol
			tcp++;
			PrintTcpPacket(Buffer, Size);
			break;

		case 17: //UDP Protocol
			udp++;
			print_udp_packet(Buffer, Size);
			break;

		default: //Some Other Protocol
			others++;
			break;
		}
	}
	else if (ntohs(ethhdr->type) == 0x0806)//arp packet
	{
		arpHeader = (ARP_HDR *)(Buffer + sizeof(ETHER_HDR));
		Print_ARP_Packet(Buffer, Size);
	}
	else if (ntohs(ethhdr->type) == 0x86dd)//ipv6 packets
	{
		ipv6hdr = (IPV6_HDR *)(Buffer + sizeof(ETHER_HDR));
		Print_Ipv6_Packet(Buffer, Size);
	}

	printf("TCP : %d UDP : %d ICMP : %d IGMP : %d Others : %d Total : %d\r", tcp, udp, icmp, igmp, others, total);
}

/*
Print the Ethernet header
*/
void print_ethernet_header(u_char* buffer)
{
	ETHER_HDR *eth = (ETHER_HDR *)buffer;//چهارده بایت اول جای که بافر به اونجا اشاره میکنه و میریزه توی شیی از جنس استراکچر اترنت که در بالا تعریف کردیم
										 //به ترتیب  شش بایت اول توی اولین فیلد که دستنیشن و بعدی سورس و بعدی تایپ

										 //write on screen cosole
	printf("\n");
	printf("Ethernet Header\n");
	//ShowValueInHex(eth->dest[0], 0);
	printf(" |-Destination Address : %.2X-%.2X-%.2X-%.2X-%.2X-%.2X \n", eth->dest[0], eth->dest[1], eth->dest[2], eth->dest[3], eth->dest[4], eth->dest[5]);
	printf(" |-Source Address      : %.2X-%.2X-%.2X-%.2X-%.2X-%.2X \n", eth->source[0], eth->source[1], eth->source[2], eth->source[3], eth->source[4], eth->source[5]);
	printf(" |-Protocol            : 0x%.4x \n", ntohs(eth->type));//read Net TO Host conversion for Short values
	if (ntohs(eth->type) == 2048)
	{
		printf("\nnnnnnnnnnnnnnnnnn\n");
	}
	ShowValueInHex(ntohs(eth->type), 0);

	/* 0
	You'll need ntohs (read Net TO Host conversion for Short values) whenever you are encountering a 16 bit value in received via network. The reason is endianess of different systems when encoding those numbers into multibytes.
	*/

}

/*
Print the IP header for IP packets
*/
void PrintIpHeader(unsigned char* Buffer, int Size)
{

	unsigned short swap_R_DF_MF_FOffset;
	int iphdrlen = 0;

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));//یعنی اول 14 بایت از جایی که بافر به اون اشاره میکنه به جلو بریم و به خونه 15 اشاره کنیم و بعدش از خونه 15هم به بعد به اندازه 20 بایت 
	iphdrlen = iphdr->ip_header_len * 4;
	swap_R_DF_MF_FOffset = ntohs(iphdr->R_DF_MF_FragmentOffset);

	//print Ethernet header
	print_ethernet_header(Buffer);
	//print ip header
	printf("\n");
	printf("IP Header\n");
	printf(" |-IP Version : %d\n", (unsigned int)iphdr->ip_version);
	printf(" |-IP Header Length : %d DWORDS or %d Bytes\n", (unsigned int)iphdr->ip_header_len, iphdrlen);
	printf(" |-Type Of Service : %d\n", (unsigned int)iphdr->ip_tos);
	printf(" |-IP Total Length : %d Bytes(Size of Packet)\n", ntohs(iphdr->ip_total_length));
	printf(" |-Identification :%#2x\n", ntohs(iphdr->ip_id));
	printf(" |-Reserved bit  Flag : %d\n", (swap_R_DF_MF_FOffset & 0x8000) >> 15);//(swap_R_DF_MF_FOffset& 0x8000)>0 ? 1:0
	printf(" |-Dont Fragment Flag : %d\n", (swap_R_DF_MF_FOffset & 0x4000) >> 14);//به جای راه حل قبلی که هزینه بیشتری هم داشت بیت ها رو شیفت میدم به راست و سپس از روشون میخونم
	printf(" |-More Fragment Flag : %d\n", (swap_R_DF_MF_FOffset & 0x2000) > 13);
	printf(" |- Fragment Offset : %d\n", swap_R_DF_MF_FOffset & 0x1fff);
	printf(" |-TTL : %d\n", (unsigned int)iphdr->ip_ttl);
	printf(" |-Protocol : %d\n", (unsigned int)iphdr->ip_protocol);
	printf(" |-Checksum : %#2x\n", ntohs(iphdr->ip_checksum));
	printf(" |-Source IP : %u,%u,%u,%u\n", iphdr->ipSource[0], iphdr->ipSource[1], iphdr->ipSource[2], iphdr->ipSource[3]);
	printf(" |-Source IP : %u,%u,%u,%u\n", iphdr->ipDestination[0], iphdr->ipDestination[1], iphdr->ipDestination[2], iphdr->ipDestination[3]);

	IPTotalLength = ntohs(iphdr->ip_total_length);
	IpHeaderLength = (unsigned int)iphdr->ip_header_len * 4;

}

/*
Print the IPv6 header for IPv6 packets
*/
void Print_Ipv6_Packet(unsigned char* Buffer, int Size)
{
	int data_size = 0;
	//print ethernet header
	print_ethernet_header(Buffer);
	//print ipv6 header
	printf("\n");
	printf("IPv6 Header\n");
	//ipv6hdr->version_trafficClass_FlowLabel = ntohl(ipv6hdr->version_trafficClass_FlowLabel);//اینو اینجا انجام بدم و بعدش دیگه هربار ntohlنکنم
	printf(" |-IP Version : %u\n", (ntohl(ipv6hdr->version_trafficClass_FlowLabel) & 0xf0000000) >> 28);

	printf(" |-IP Traffic Class  : %u DWORDS\n", (ntohl(ipv6hdr->version_trafficClass_FlowLabel) & 0x0ff00000) >> 20);
	printf(" |-IP FLOW Label: %4x\n", (ntohl(ipv6hdr->version_trafficClass_FlowLabel) & 0x000fffff));
	printf(" |-IP PayLoad Length : %u Bytes\n", ntohs(ipv6hdr->length));
	printf(" |-IP Next Header : %d\n", ipv6hdr->next_header);
	printf(" |-IP Hop Limit : %d\n", ipv6hdr->hop_limit);
	printf(" |-IP Source Address : %#2x,%#2x,%#2x,%#2x,%#2x,%#2x,%#2x,%#2x\n", ntohs(ipv6hdr->in6_addr_src[0]), ntohs(ipv6hdr->in6_addr_src[1]), ntohs(ipv6hdr->in6_addr_src[2])
		, ntohs(ipv6hdr->in6_addr_src[3]), ntohs(ipv6hdr->in6_addr_src[4]), ntohs(ipv6hdr->in6_addr_src[5]), ntohs(ipv6hdr->in6_addr_src[6]), ntohs(ipv6hdr->in6_addr_src[7]));
	printf(" |-IP Destination Address : %#2x,%#2x,%#2x,%#2x,%#2x,%#2x,%#2x,%#2x\n", ntohs(ipv6hdr->in6_addr_dst[0]), ntohs(ipv6hdr->in6_addr_dst[1]), ntohs(ipv6hdr->in6_addr_dst[2])
		, ntohs(ipv6hdr->in6_addr_dst[3]), ntohs(ipv6hdr->in6_addr_dst[4]), ntohs(ipv6hdr->in6_addr_dst[5]), ntohs(ipv6hdr->in6_addr_dst[6]), ntohs(ipv6hdr->in6_addr_dst[7]));

	IPTotalLength = ipv6hdr->length;
	IpHeaderLength = 40;//tole header ipv6 40byte ast
	if (ipv6hdr->next_header == 17)//udp packet
		print_udp_packet(Buffer, Size);
	else if (ipv6hdr->next_header == 58)//icmpv6 packet
		PrintIcmpv6Packet(Buffer, Size);
	else
	{
		data = (Buffer + sizeof(ETHER_HDR) + sizeof(IPV6_HDR));
		data_size = (Size - sizeof(ETHER_HDR) - sizeof(IPV6_HDR));
		printf("\nData Payload\n");
		PrintData(data, data_size);
	}
}

void Print_ARP_Packet(u_char *Buffer, int Size)
{
	int header_size = 0, data_size;

	arpHeader = (ARP_HDR *)(Buffer + sizeof(ETHER_HDR));
	data = (Buffer + sizeof(ETHER_HDR) + sizeof(ARP_HDR));
	data_size = (Size - sizeof(ETHER_HDR) - sizeof(ARP_HDR));
	//print ethernet header
	print_ethernet_header(Buffer);
	//print Arp Header
	printf("\n\nARP Header\n\n");
	printf(" |-Hardware Type : %u\n", ntohs(arpHeader->hardwareType));
	printf(" |-Protocol  Type: 0x%.4x \n", ntohs(arpHeader->protocol_type));
	printf(" |-Hardware Address size in Byte : %d\n", arpHeader->hardwareSize);
	printf(" |-Protocol Address size in Byte : %d\n", arpHeader->protocolSize);
	printf(" |-Operation Code : %u\n", ntohs(arpHeader->operationCode));
	printf(" |-Source Address      : %.2X-%.2X-%.2X-%.2X-%.2X-%.2X \n", arpHeader->sourceMacAddress[0], arpHeader->sourceMacAddress[1], arpHeader->sourceMacAddress[2]
		, arpHeader->sourceMacAddress[3], arpHeader->sourceMacAddress[4], arpHeader->sourceMacAddress[5]);
	printf(" |-Source IP : %u,%u,%u,%u\n", arpHeader->ipSourceAddress[0], arpHeader->ipSourceAddress[1], arpHeader->ipSourceAddress[2], arpHeader->ipSourceAddress[3]);
	printf(" |-Destination Address      : %.2X-%.2X-%.2X-%.2X-%.2X-%.2X \n", arpHeader->destinationMacAddress[0], arpHeader->destinationMacAddress[0], arpHeader->destinationMacAddress[2]
		, arpHeader->destinationMacAddress[3], arpHeader->destinationMacAddress[4], arpHeader->destinationMacAddress[5]);
	printf(" |-Destination IP :  %u,%u,%u,%u\n", arpHeader->ipDestinationAddress[0], arpHeader->ipDestinationAddress[1], arpHeader->ipDestinationAddress[2]
		, arpHeader->ipDestinationAddress[3]);


	printf("\nData Payload\n");

	PrintData(data, data_size);

	printf("\n###########################################################\n");
}

/*
Print the TCP header for TCP packets
*/
void PrintTcpPacket(u_char* Buffer, int Size)
{
	unsigned short iphdrlen;//این اگه intبشه فک نکنم تغییری ایجاد بشه
	int header_size = 0, tcphdrlen, data_size;
	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	iphdrlen = iphdr->ip_header_len * 4;
	tcpheader = (TCP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));
	tcphdrlen = tcpheader->data_offset * 4;
	data = (Buffer + sizeof(ETHER_HDR) + iphdrlen + tcphdrlen);
	data_size = (Size - sizeof(ETHER_HDR) - iphdrlen - tcphdrlen);
	//print ip header
	PrintIpHeader(Buffer, Size);
	//print tcp header
	printf("\n");
	printf("TCP Header\n");
	printf(" |-Source Port : %u\n", ntohs(tcpheader->source_port));
	printf(" |-Destination Port : %u\n", ntohs(tcpheader->dest_port));
	printf(" |-Sequence Number : %#4x\n", ntohl(tcpheader->sequence));
	printf(" |-Acknowledge Number : %#4x\n", ntohl(tcpheader->acknowledge));
	printf(" |-Header Length : %d DWORDS or %d BYTES\n", (unsigned int)tcpheader->data_offset, (unsigned int)tcpheader->data_offset * 4);
	printf(" |-CWR Flag : %d\n", (unsigned int)tcpheader->cwr);
	printf(" |-ECN Flag : %d\n", (unsigned int)tcpheader->ecn);
	printf(" |-Urgent Flag : %d\n", (unsigned int)tcpheader->urg);
	printf(" |-Acknowledgement Flag : %d\n", (unsigned int)tcpheader->ack);
	printf(" |-Push Flag : %d\n", (unsigned int)tcpheader->psh);
	printf(" |-Reset Flag : %d\n", (unsigned int)tcpheader->rst);
	printf(" |-Synchronise Flag : %d\n", (unsigned int)tcpheader->syn);
	printf(" |-Finish Flag : %d\n", (unsigned int)tcpheader->fin);
	printf(" |-Window : %d\n", ntohs(tcpheader->window));
	printf(" |-Checksum : %#2x\n", ntohs(tcpheader->checksum));
	printf(" |-Urgent Pointer : %d\n", tcpheader->urgent_pointer);
	printf("\n\n");

	TransportHeaderLength = tcphdrlen;

	////////////http///برای گرفتن 
	if (ntohs(tcpheader->source_port) == 80 || ntohs(tcpheader->dest_port) == 80)
		data_size = Print_Http_Header(data, data_size);


	printf("\nData Payload\n");

	PrintData(data, data_size);

	printf("\n###########################################################\n");

}


int Print_Http_Header(u_char* Buffer, int Size)
{
	ApplicationLayerLength = IPTotalLength - IpHeaderLength - TransportHeaderLength;//max app layer mishe 1514 -14-20-20 bekhatere mss ethernet

	int i = 0, data_size;
	char first10ByteOfTCPdata[10];
	data = Buffer;//اشاره گر دیتا الان به خونه ای اشاره میکنه که به اندازه تقریبا 58 بایت بعد از جایی که اشاره گر بافر اشاره میکنه .یعنی ابتدای هدر لایه اپلیکیشن
	data_size = Size;



	for (i = 0; i < 9; i++)
	{
		first10ByteOfTCPdata[i] = data[i];
	}
	i = 0;
	first10ByteOfTCPdata[9] = '\0';


	if (strstr(first10ByteOfTCPdata, "GET") != NULL || strstr(first10ByteOfTCPdata, "POST") != NULL || strstr(first10ByteOfTCPdata, "HEAD") != NULL)
	{

		first10ByteOfTCPdata[4] = '\0';
		printf("\n\nHTTP Request Packet\n");
		printf("\n\nMethode:%s\r\nURL:", first10ByteOfTCPdata);
		while (i < ApplicationLayerLength)
		{
			if (data[i] != 7)//code ascii haft male bogh zadan hast
				printf("%c", data[i]);
			hk.header[i] = data[i];
			i++;

		}httpheader = &hk;
		printf("\r\n*****end of http*******\r\n");
		data += i;
		data_size -= i;
		return data_size;

	}
	else if (strstr(first10ByteOfTCPdata, "HTTP/1.1") != NULL)
	{
		first10ByteOfTCPdata[8] = '\0';
		printf("\n\nHTTP Response Packet\n");
		printf("\n\nHttp Version:%s\r\nStatus Code:", first10ByteOfTCPdata);
		while (i < ApplicationLayerLength)
		{
			if (data[i] != 7)
				printf("%c", data[i]);
			i++;
		}
		printf("\r\n*****end of http*******\r\n");
		data += i;
		data_size -= i;
		return data_size;
	}
	else//age ina noe methodesh moshakhas nabod
	{
		while (i < ApplicationLayerLength)
		{
			if (data[i] != 7)
				printf("%c", data[i]);
			i++;
		}
		printf("\r\n*****Application Layer*******\r\n");
		data += i;
		data_size -= i;
		return data_size;
	}


}

/*
Print the UDP header for UDP packets
*/
void print_udp_packet(u_char *Buffer, int Size)
{

	int iphdrlen = 0, data_size = 0;

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	if (iphdr->ip_version == 6)
	{
		udpheader = (UDP_HDR*)(Buffer + sizeof(IPV6_HDR) + sizeof(ETHER_HDR));//بعنی 8بایت بعد از 34 بایت اول بافر که بایت های مربوط به یو دی پی هستن رو بگیر بریز تو شی یودی پی   
		data = (Buffer + sizeof(ETHER_HDR) + sizeof(IPV6_HDR) + sizeof(UDP_HDR));
		data_size = (Size - sizeof(ETHER_HDR) - sizeof(IPV6_HDR) - sizeof(UDP_HDR));
	}
	else {
		//print ip header
		PrintIpHeader(Buffer, Size);
		iphdrlen = iphdr->ip_header_len * 4;
		udpheader = (UDP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));//بعنی 8بایت بعد از 34 بایت اول بافر که بایت های مربوط به یو دی پی هستن رو بگیر بریز تو شی یودی پی   
		data = (Buffer + sizeof(ETHER_HDR) + iphdrlen + sizeof(UDP_HDR));
		data_size = (Size - sizeof(ETHER_HDR) - iphdrlen - sizeof(UDP_HDR));
	}
	printf("\nUDP Header\n");
	printf(" |-Source Port : %d\n", ntohs(udpheader->source_port));
	printf(" |-Destination Port : %d\n", ntohs(udpheader->dest_port));
	printf(" |-UDP Length : %d\n", ntohs(udpheader->udp_length));
	printf(" |-UDP Checksum : %#2x\n", ntohs(udpheader->udp_checksum));

	TransportHeaderLength = 8;//udp 8byte hast

	if (ntohs(udpheader->source_port) == 53 || ntohs(udpheader->dest_port) == 53)
		data_size = Print_DNS_Header(data, data_size);
	else if (ntohs(udpheader->source_port) == 137 || ntohs(udpheader->dest_port) == 137)
		data_size = Print_NBNS_Header(data, data_size);
	else if (ntohs(udpheader->source_port) == 5355 || ntohs(udpheader->dest_port) == 5355)
		data_size = Print_LLMNR_Header(data, data_size);
	else if (ntohs(udpheader->source_port) == 1900 || ntohs(udpheader->dest_port) == 1900)
		data_size = Print_SSDP_Header(data, data_size);
	else if (ntohs(udpheader->source_port) == 68 || ntohs(udpheader->dest_port) == 67)
		data_size = Print_DHCP_Packet(data, data_size);




	printf("Data Payload\n");
	PrintData(data, data_size);
	printf("\n###########################################################\n");

}

/*
DNS PROTOCOL
*/
int Print_DNS_Header(u_char* Buffer, int Size)
{
	int data_size = 0;

	dnsheader = (DNS_HDR*)(Buffer);

	data = (Buffer + sizeof(DNS_HDR));
	data_size = (Size - sizeof(DNS_HDR));

	printf("\n");
	printf("DNS Header\n");
	printf(" |-TransAction ID : 0x%.2x \n", ntohs(dnsheader->transActionIdentification));

	printf(" |-Respones Type : %d\n", (unsigned int)(dnsheader->qr));
	printf(" |-OpCode : %d\n", (unsigned int)(dnsheader->OpCode));
	printf(" |-Authorative : %d\n", (unsigned int)(dnsheader->AA));
	printf(" |-Truncated : %d \n ", (unsigned int)dnsheader->TC);
	printf(" |-Recursive Desired Flag : %d\n", (unsigned int)dnsheader->RD);
	printf(" |-Recursive Available Flag : %d\n", (unsigned int)dnsheader->RA);
	printf(" |-Unuesd Flag : %d\n", (unsigned int)dnsheader->Unused);
	printf(" |-Reply Code Flag : %d\n", (unsigned int)dnsheader->RCode);

	printf(" |-Number Of Questions : %u\n", ntohs(dnsheader->numberOFQuestions));
	printf(" |-Number Of AnswerRRs : %u\n", ntohs(dnsheader->numberOFAnswerRRs));
	printf(" |-Number Of AuthorityRRs : %u\n", ntohs(dnsheader->numberOFAuthorityRRs));
	printf(" |-Number Of AdditionalRRs : %u\n", ntohs(dnsheader->numberOFAdditionalRRs));
	printf("\n\n");

	return data_size;
}

/*
LLMNR PROTOCOL
*/
int Print_LLMNR_Header(u_char* Buffer, int Size)
{
	int data_size = 0;

	llmnrheader = (LLMNR_HDR*)(Buffer);//بعنی 8بایت بعد از 34 بایت اول بافر که بایت های مربوط به یو دی پی هستن رو بگیر بریز تو شی یودی پی

	data = (Buffer + sizeof(LLMNR_HDR));
	data_size = (Size - sizeof(LLMNR_HDR));

	printf("\n");
	printf("LLMNR Header\n");
	printf(" |-TransAction ID : 0x%.2x \n", ntohs(llmnrheader->transActionIdentification));

	printf(" |-Respones Type : %d\n", (unsigned int)(llmnrheader->qr));//تو این بیت با وایر شارک فرق میکنه جوابش؟
	printf(" |-OpCode : %d\n", (unsigned int)(llmnrheader->OpCode));
	printf(" |-Conflict : %d\n", (unsigned int)(llmnrheader->C));
	printf(" |-Truncated : %d \n ", (unsigned int)llmnrheader->TC);
	printf(" |-Tentative Flag : %d\n", (unsigned int)llmnrheader->T);

	printf(" |-Unuesd Flag : %d\n", (unsigned int)llmnrheader->Unused);
	printf(" |-Reply Code Flag : %d\n", (unsigned int)llmnrheader->RCode);

	printf(" |-Number Of Questions : %u\n", ntohs(llmnrheader->numberOFQuestions));
	printf(" |-Number Of AnswerRRs : %u\n", ntohs(llmnrheader->numberOFAnswerRRs));
	printf(" |-Number Of AuthorityRRs : %u\n", ntohs(llmnrheader->numberOFAuthorityRRs));
	printf(" |-Number Of AdditionalRRs : %u\n", ntohs(llmnrheader->numberOFAdditionalRRs));
	printf("\n\n");

	return data_size;
}
/*
NBNS PROTOCOL
*/

int Print_NBNS_Header(u_char* Buffer, int Size)
{
	int data_size = 0;

	nbnsheader = (NBNS_HDR*)(Buffer);

	data = (Buffer + sizeof(NBNS_HDR));
	data_size = (Size - sizeof(NBNS_HDR));

	printf("\n");
	printf("NBNS Header\n");
	printf(" |-TransAction ID : 0x%.2x \n", ntohs(nbnsheader->transActionIdentification));

	printf(" |-Respones Type : %d\n", (unsigned int)(nbnsheader->qr));
	printf(" |-OpCode : %d\n", (unsigned int)(nbnsheader->OpCode));
	printf(" |-Authorative : %d\n", (unsigned int)(nbnsheader->AA));
	printf(" |-Truncated : %d \n ", (unsigned int)nbnsheader->TC);
	printf(" |-Recursive Desired Flag : %d\n", (unsigned int)nbnsheader->RD);
	printf(" |-Recursive Available Flag : %d\n", (unsigned int)nbnsheader->RA);
	printf(" |-BroadCast Flag : %d\n", (unsigned int)nbnsheader->BD);
	printf(" |-Reply Code Flag : %d\n", (unsigned int)nbnsheader->RCode);

	printf(" |-Number Of Questions : %u\n", ntohs(nbnsheader->numberOFQuestions));
	printf(" |-Number Of AnswerRRs : %u\n", ntohs(nbnsheader->numberOFAnswerRRs));
	printf(" |-Number Of AuthorityRRs : %u\n", ntohs(nbnsheader->numberOFAuthorityRRs));
	printf(" |-Number Of AdditionalRRs : %u\n", ntohs(nbnsheader->numberOFAdditionalRRs));
	printf("\n\n");

	return data_size;
}


/*
SSDP Protocol
*/

int Print_SSDP_Header(u_char* Buffer, int Size)
{
	ApplicationLayerLength = IPTotalLength - IpHeaderLength - TransportHeaderLength;//max app layer mishe 1514 -14-20-8 bekhatere mss ethernet
	int i = 0, data_size;
	char first10ByteOfUDPdata[10];
	data = Buffer;//اشاره گر دیتا الان به خونه ای اشاره میکنه که به اندازه تقریبا 58 بایت بعد از جایی که اشاره گر بافر اشاره میکنه .یعنی ابتدای هدر لایه اپلیکیشن
	data_size = Size;



	for (i = 0; i < 9; i++)
	{
		first10ByteOfUDPdata[i] = data[i];
	}
	i = 0;
	first10ByteOfUDPdata[9] = '\0';



	if (strstr(first10ByteOfUDPdata, "HTTP/1.1") != NULL)
	{
		first10ByteOfUDPdata[8] = '\0';
		printf("\n\nSSDP Response Packet\n");
		printf("\n\nRequest Version (That SSDP is Using):%s\r\nStatus Code:", first10ByteOfUDPdata);
		while (i < ApplicationLayerLength)
		{
			if (data[i] != 7)
				printf("%c", data[i]);
			i++;
		}
		printf("\r\n*****end of SSDP*******\r\n");
		data += i;
		data_size -= i;
		return data_size;
	}
	else if (strstr(first10ByteOfUDPdata, "NOTIFY") != NULL || strstr(first10ByteOfUDPdata, "M-SEARCH") != NULL)
	{
		if (strstr(first10ByteOfUDPdata, "NOTIFY") != NULL)
		{

			first10ByteOfUDPdata[6] = '\0';
		}
		else if (strstr(first10ByteOfUDPdata, "M-SEARCH") != NULL)
		{//M-SEARCH
			first10ByteOfUDPdata[8] = '\0';
		}
		printf("\n\nSSDP Request Packet\n");
		printf("\n\nMethode:%s\r\nURI:", first10ByteOfUDPdata);
		while (i < ApplicationLayerLength)
		{
			if (data[i] != 7)
				printf("%c", data[i]);
			i++;
		}
		printf("\r\n*****end of SSDP*******\r\n");
		data += i;
		data_size -= i;
		return data_size;

	}
	else
	{
		while (i < ApplicationLayerLength)
		{
			if (data[i] != 7)
				printf("%c", data[i]);
			i++;

		}
		printf("\r\n*****Application Layer*******\r\n");
		data += i;
		data_size -= i;
		return data_size;
	}


}

void PrintIcmpPacket(u_char* Buffer, int Size)
{
	int iphdrlen = 0, icmphdrlen = 0, data_size = 0;

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	iphdrlen = iphdr->ip_header_len * 4;

	icmpheader = (ICMP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));

	data = (Buffer + sizeof(ETHER_HDR) + iphdrlen + sizeof(ICMP_HDR));
	data_size = (Size - sizeof(ETHER_HDR) - iphdrlen - sizeof(ICMP_HDR));

	printf("\n\nICMP Packet\n");
	PrintIpHeader(Buffer, Size);

	printf("\n");

	printf("ICMP Header\n");
	printf(" |-Type : %d", (unsigned int)(icmpheader->type));

	if ((unsigned int)(icmpheader->type) == 11)
	{
		printf(" (TTL Expired)\n");
	}
	else if ((unsigned int)(icmpheader->type) == 0)
	{
		printf(" (ICMP Echo Reply)\n");
	}

	printf(" |-Code : %d\n", (unsigned int)(icmpheader->code));
	printf(" |-Checksum : %d\n", ntohs(icmpheader->checksum));
	printf(" |-ID : %d\n", ntohs(icmpheader->id));
	printf(" |-Sequence : %d\n", ntohs(icmpheader->seq));
	printf("\n");

	printf("IP Header\n");
	PrintData((u_char*)iphdr, iphdrlen);

	printf("ICMP Header\n");
	PrintData((u_char*)icmpheader, sizeof(ICMP_HDR));

	printf("Data Payload\n");
	PrintData(data, data_size);

	printf("\n###########################################################\n");
}

/*
IGMPV2 Protocol
*/

void PrintIgmpPacket(u_char* Buffer, int Size)
{
	int iphdrlen = 0, icmphdrlen = 0, data_size = 0;

	iphdr = (IPV4_HDR *)(Buffer + sizeof(ETHER_HDR));
	iphdrlen = iphdr->ip_header_len * 4;

	igmpheader = (IGMP_HDR*)(Buffer + iphdrlen + sizeof(ETHER_HDR));

	data = (Buffer + sizeof(ETHER_HDR) + iphdrlen + sizeof(IGMP_HDR));
	data_size = (Size - sizeof(ETHER_HDR) - iphdrlen - sizeof(IGMP_HDR));

	printf("\n\nIGMP Packet\n");
	PrintIpHeader(Buffer, Size);

	printf("\n");

	printf("IGMP Header\n");
	printf(" |-Type : %#2x\n", (unsigned int)(igmpheader->type));
	printf(" |-MAX Response Time : %u\n", (unsigned int)(igmpheader->maxResponseTime));
	printf(" |-Checksum : %#.2x\n", ntohs(igmpheader->headerChecksum));
	printf(" |-MUltiCast Address : %u,%u,%u,%u\n", igmpheader->ip[0], igmpheader->ip[1], igmpheader->ip[2], igmpheader->ip[3]);
	printf("\n");


	printf("Data Payload\n");
	PrintData(data, data_size);

	printf("\n###########################################################\n");
}

/*
icmpv6 header
*/
int  PrintIcmpv6Packet(u_char* Buffer, int Size)
{
	int  data_size = 0;

	icmpv6header = (ICMPV6_HDR*)(Buffer + sizeof(IPV6_HDR) + sizeof(ETHER_HDR));
	data = (Buffer + sizeof(ETHER_HDR) + sizeof(IPV6_HDR) + sizeof(ICMPV6_HDR));
	data_size = (Size - sizeof(ETHER_HDR) - sizeof(IPV6_HDR) - sizeof(ICMPV6_HDR));


	printf("\nICMPV6 Header\n\n");
	printf(" |-Type : %u\n", (unsigned int)(icmpv6header->type));
	printf(" |-CODE : %u\n", (unsigned int)(icmpv6header->code));
	printf(" |-Checksum : %#.2x\n", ntohs(icmpv6header->checksum));
	printf("\n");

	printf("\nData Payload\n");
	PrintData(data, data_size);

	return data_size;
}

/*
DHCP Protocol
*/
int Print_DHCP_Packet(u_char* Buffer, int Size)
{
	int data_size = 0;

	dhcpheader = (DHCP_HDR*)(Buffer);

	data = (Buffer + sizeof(DHCP_HDR));
	data_size = (Size - sizeof(DHCP_HDR));

	printf("\n");
	printf("DHCP Header\n");
	printf(" |-Message Type(OPCODE) : %d \n", dhcpheader->opcode);

	printf(" |-Hardware Type : %#2x\n", dhcpheader->hardwareType);
	printf(" |-Hardware address length : %d\n", dhcpheader->hardwareAddressLength);
	printf(" |-Hop Count : %d\n", dhcpheader->hopCount);
	printf(" |-Transaction ID : %#4x \n ", ntohl(dhcpheader->transactionID));
	printf(" |-Seconds elapsed: %d\n", ntohs(dhcpheader->secondElapsed));
	printf(" |-Bootp flags: %d\n", ntohs(dhcpheader->bootpFlags) >> 15);
	printf(" |-Client Ip Address : %u,%u,%u,%u\n", dhcpheader->clientIpAddress[0], dhcpheader->clientIpAddress[1], dhcpheader->clientIpAddress[2]
		, dhcpheader->clientIpAddress[3]);
	printf(" |-Your (client) IP address: %u,%u,%u,%u\n", dhcpheader->yourIpAddress[0], dhcpheader->yourIpAddress[1], dhcpheader->yourIpAddress[2]
		, dhcpheader->yourIpAddress[3]);
	printf(" |-Next server IP address: %u,%u,%u,%u\n", dhcpheader->nextServerIpAddress[0], dhcpheader->nextServerIpAddress[1], dhcpheader->nextServerIpAddress[2]
		, dhcpheader->nextServerIpAddress[3]);
	printf(" |-Relay agent IP address: %u,%u,%u,%u\n", dhcpheader->relayAgentIpAddress[0], dhcpheader->relayAgentIpAddress[1], dhcpheader->relayAgentIpAddress[2]
		, dhcpheader->relayAgentIpAddress[3]);
	printf(" |-Client Mac Address : %.2X-%.2X-%.2X-%.2X-%.2X-%.2X \n", dhcpheader->clientMacAddress[0], dhcpheader->clientMacAddress[1], dhcpheader->clientMacAddress[2]
		, dhcpheader->clientMacAddress[3], dhcpheader->clientMacAddress[4], dhcpheader->clientMacAddress[5]);
	printf("Client hardware address padding: %s\n", dhcpheader->clientHardwareAddressPadding);
	printf("Server Host Name: %s\n", dhcpheader->serverHostName);
	printf("Boot file name: %s", dhcpheader->bootFileName);


	printf("\n\n");

	return data_size;
}

/*
Print the hex values of the data
*/
void PrintData(u_char* data, int Size)
{
	unsigned char a, line[17], c;//لاین رو 16 تاییی تعریف کردیم تا در هر خط 16 کاراکتر یا بایت نمایش داده بشه (مثل وایر شارک)
	int j;

	//loop over each character and print
	for (i = 0; i < Size; i++)
	{
		c = data[i];

		//Print the hex value for every character , with a space//x
		//printf(" %.2x,%x,%d,%c", (unsigned int) c,c,c,c);//در خونه ای که سی به اون اشاره میکنه یک مقدار عددی ذخیر شده اما بسته به نیاز ما میتونه به صورت کارکاتر یا هگز یا دسیمال نشون داده بشه  	
		printf(" %.2x", (unsigned int)c);//for example 45 00 05 78  45  66   40  00  37 ad  6b 05 90  84 11
										 //real data that saved in charachters hole :   69 46 46 120 69 102   64  46  55 46 107 46 46  46 46
										 //نمایش کد های هگز داده ها(هر بایت  یا کاراکتر در هگز با دو بخش 4 بیتی که هر بخش بین 0 تا اف هست نمایش داده میشه)

										 //Add the character to data line
		a = (c >= 32 && c <= 128) ? c : '.';

		line[i % 16] = a;

		//if last character of a line , then print the line - 16 characters in 1 line
		if ((i != 0 && (i + 1) % 16 == 0) || i == Size - 1)
		{
			line[i % 16 + 1] = '\0';

			//print a big gap of 10 characters between hex and characters
			printf("          ");


			//Print additional spaces for last lines which might be less than 16 characters in length
			for (j = strlen(line); j < 16; j++)//
			{
				printf("   ");

			}

			printf("%s \n", line);//for example E..xEf@.7..k...چاپ 16 کارکتر موجود در لاین که در بالا مقدار هگزشونو چاچ کرده بودیم
								  //برای چاپ رشته اصلی داده(مثلا یک حرف یا عدد اصلی که از لینک دریافت کردیم نه به صورت هگز بلکه به صورت کارکتر) که در قالب مجموعه ای از کاراکتر ها است از ابتدای جایی که لاین به اون اشاره میکنه تا پایان مجموعه کاراکترکه آخرش با 
								  //%0مشخص میشه
								  //که در اینجا در حلقه فور اولی هر وقت در لاین یه کاراکتر قرار میگیره میایم توی if
								  //سپس چاپش میکنیم
		}
	}

	printf("\n");

}


//print in hex
void  ShowValueInHex(unsigned int value, int numberOfBytes)
{
	int num = value, length = numberOfBytes;
	char flag = 1;//true
	unsigned char arrayOfNumbers[8];

	if (numberOfBytes == 0)//default for automatic 
	{
		length = 2;
		if (num > 255)
		{
			length = 4;
		}
	}
	for (int i = 0; i < length; i++)
	{
		if (flag == 0 && i < length)
			arrayOfNumbers[i] = 0;
		else if (num < 16)
		{
			switch (num)
			{
			case 15:
				arrayOfNumbers[i] = 'F';
				break;
			case 14:
				arrayOfNumbers[i] = 'E';
				break;
			case 13:
				arrayOfNumbers[i] = 'D';
				break;
			case 12:
				arrayOfNumbers[i] = 'C';
				break;
			case 11:
				arrayOfNumbers[i] = 'B';
				break;
			case 10:
				arrayOfNumbers[i] = 'A';
				break;
			default:
				arrayOfNumbers[i] = num;
				break;
			}

			flag = 0;
		}
		else
		{
			switch (num % 16)
			{
			case 15:
				arrayOfNumbers[i] = 'F';
				break;
			case 14:
				arrayOfNumbers[i] = 'E';
				break;
			case 13:
				arrayOfNumbers[i] = 'D';
				break;
			case 12:
				arrayOfNumbers[i] = 'C';
				break;
			case 11:
				arrayOfNumbers[i] = 'B';
				break;
			case 10:
				arrayOfNumbers[i] = 'A';
				break;
			default:
				arrayOfNumbers[i] = num % 16;
				break;
			}


			num /= 16;
		}


	}
	for (int i = length - 1; i >= 0; i--)
	{
		if (arrayOfNumbers[i] > 9)
			printf("%c", arrayOfNumbers[i]);
		else
			printf("%u", arrayOfNumbers[i]);

	}
	/*if (num<16)
	{
	printf("%u", num);

	}
	else
	{
	num /= 16;
	ShowValueInHex(num);
	printf("%u", value % 16);

	}
	*/

}