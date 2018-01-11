//in the name of GOD
/*
Project   : Packet Analyzer
Developer : Seyyed Mahdi Hassanpour Matikolaei
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

#region structurs
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//1
public struct ethernet_header
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public byte[] dst; //uchar array[6]

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public byte[] src; //uchar array[6]
    //Byte
    public ushort type; //unsigned short int x[5]
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//2
public struct arp_hdr
{

    public ushort hardwareType;
    public ushort protocol_type;
    public byte hardwareSize;
    public byte protocolSize;
    public ushort operationCode;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public byte[] sourceMacAddress;//6byte
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] ipSourceAddress; // Source address
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public byte[] destinationMacAddress;//6byte
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] ipDestinationAddress; // destination address
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//3
public struct ip_hdr
{
    public byte ip_version_IHL;
    public byte ip_tos; // IP type of service
    public ushort ip_total_length; // Total length
    public ushort ip_id; // Unique identifier
    public ushort R_DF_MF_FragmentOffset;//
    public byte ip_ttl; // Time to live
    public byte ip_protocol; // Protocol(TCP,UDP etc)
    public ushort ip_checksum; // IP checksum
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] ipSource; // Source address
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] ipDestination; // destination address
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//4
public struct ipv6_header
{
    public uint version_trafficClass_FlowLabel;
    /*version : 4,
    traffic_class : 8,
    flow_label : 20;*/
    public ushort length;
    public byte next_header;
    public byte hop_limit;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public ushort[] in6_addr_src;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public ushort[] in6_addr_dst;
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//5
public struct udp_hdr
{
    public ushort source_port; // Source port no.
    public ushort dest_port; // Dest. port no.
    public ushort udp_length; // Udp packet length
    public ushort udp_checksum; // Udp checksum (optional)
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//6
public struct tcp_header
{
    public ushort source_port; // source port
    public ushort dest_port; // destination port
    public uint sequence; // sequence number - 32 bits
    public uint acknowledge; // acknowledgement number - 32 bits
    //litte endian

    //unsigned char ns : 1; //Nonce Sum Flag Added in RFC 3540.
    //unsigned char reserved_part1 : 3; //according to rfc
    //unsigned char data_offset : 4; /*The number of 32-bit words in the TCP header.
    //                               This indicates where the data begins.
    //                               The length of the TCP header is always a multiple
    //                               of 32 bits.*/
    public byte ns_reserved_DataOffset;
    //little endian for below flags?? 
    //unsigned char fin : 1; //Finish Flag
    //unsigned char syn : 1; //Synchronise Flag
    //unsigned char rst : 1; //Reset Flag
    //unsigned char psh : 1; //Push Flag
    //unsigned char ack : 1; //Acknowledgement Flag
    //unsigned char urg : 1; //Urgent Flag

    //unsigned char ecn : 1; //ECN-Echo Flag
    //unsigned char cwr : 1; //Congestion Window Reduced Flag
    public byte flags;
    ////////////////////////////////

    public ushort window; // window
    public ushort checksum; // checksum
    public ushort urgent_pointer; // urgent pointer
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//7
public struct icmp_hdr
{
    public byte type; // ICMP Error type
    public byte code; // Type sub code
    public ushort checksum;
    public ushort id;
    public ushort seq;
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//8
public struct dns_header
{
    public ushort transActionIdentification;//2byte

    //unsigned char RD : 1; //recursion desired Flag
    //unsigned char TC : 1; //truncated Flag
    //unsigned char AA : 1; //authorization (just for response) Flag
    //unsigned char OpCode : 4; //0000 standard query/0001reverse query/0010about server statusFlag
    //unsigned char qr : 1; //query/response  Flag
    public byte QR_OPCODE_AA_TC_RD;
    // RD_TC_AA_OPCODE_QR;


    //unsigned char RCode : 4; //reply code Flag
    //unsigned char Unused : 3; //000 reserved
    //unsigned char RA : 1; //recursion available Flag
    public byte EA_UNUSED_RCODE;
    //RCODE_UNUSED_RA;

    public ushort numberOFQuestions;
    public ushort numberOFAnswerRRs;
    public ushort numberOFAuthorityRRs;
    public ushort numberOFAdditionalRRs;
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//9
public struct nbns_header
{
    public ushort transActionIdentification;//2byte

    //unsigned char RD : 1; //recursion desired Flag
    //unsigned char TC : 1; //truncated Flag
    //unsigned char AA : 1; //authorization (just for response) Flag
    //unsigned char OpCode : 4; //0000 standard query/0001reverse query/0010about server statusFlag
    //unsigned char qr : 1; //query/response  Flag
    public byte RD_TC_AA_OPCODE_QR;

    //unsigned char RCode : 4; //reply code Flag
    //unsigned char BD : 1; //BroadCast Packet Flag
    //unsigned char Unused : 2; //000 reserved
    //unsigned char RA : 1; //recursion available Flag
    public byte RCODE_BD_UNUSED_RA;

    public ushort numberOFQuestions;
    public ushort numberOFAnswerRRs;
    public ushort numberOFAuthorityRRs;
    public ushort numberOFAdditionalRRs;

}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//10
public struct llmnr_header
{
    public ushort transActionIdentification;//2byte

    //unsigned char T : 1; //Tentative
    //unsigned char TC : 1; //truncated Flag
    //unsigned char C : 1; //Conflict Flag
    //unsigned char OpCode : 4; //0000 standard query/0001reverse query/0010about server statusFlag
    //unsigned char qr : 1; //query/response  Flag
    public byte T_TC_C_OPCODE_QR;

    //unsigned char RCode : 4; //reply code Flag
    //unsigned char Unused : 4; //0000 reserved
    public byte RCODE_UNUSED;

    public ushort numberOFQuestions;
    public ushort numberOFAnswerRRs;
    public ushort numberOFAuthorityRRs;
    public ushort numberOFAdditionalRRs;
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//11
public struct igmpv2_hdr
{
    public byte type;
    public byte maxResponseTime;
    public ushort headerChecksum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] ip; // multicast address
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//12
public struct icmpv6_hdr
{
    public byte type;
    public byte code;
    public ushort checksum;
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]//13
public struct dhcp_hdr
{
    public byte opcode;//8bit
    public byte hardwareType;
    public byte hardwareAddressLength;
    public byte hopCount;
    public uint transactionID;//32bit
    public ushort secondElapsed;//16bit
    public ushort bootpFlags;//just the left bit is usefull.other its are just for compatibility with bootp protocol
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] clientIpAddress;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] yourIpAddress;//client
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] nextServerIpAddress;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] relayAgentIpAddress;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public byte[] clientMacAddress;//6byte
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public byte[] clientHardwareAddressPadding;//10byte
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] serverHostName;//64byte
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] bootFileName;//128byte
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct Dev_Informattion
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
    public char[] dev_name;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
    public char[] dev_description;
}

#endregion

namespace PacketAnalzerGUI
{
    public partial class Form1 : Form
    {
        #region Dll Imports
        #region Return Headers From C to C#
        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetEthernet(out ethernet_header variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIpv4(out ip_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIpv6(out ipv6_header variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetUdp(out udp_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetTcp(out tcp_header variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIcmp(out icmp_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIgmp(out igmpv2_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetArp(out arp_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIcmpv6(out icmpv6_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetDns(out dns_header variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetDhcp(out dhcp_hdr variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetLlmnr(out llmnr_header variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetNbns(out nbns_header variable);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetSsdp();

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public  static extern IntPtr GetHttp();
        #endregion
        #region Discover Available NetworkInterfaceCards Details-And-Select One NIC For Start Capturing
        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetDevicesDetails(out Dev_Informattion Dev);//

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetCountOfNics();

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetNICdetailsOneByOneFromCsharp();

        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SelectAndOpenNIC(int choosenNIc);
        #endregion
        #region Capture Packet-And-Take Move It From C Buffer To C# Buffer
        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CapturePacket();
        [DllImport("CaptureDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetPayloadLength();

        [DllImport("CaptureDll.dll")]
        public static extern IntPtr GetFrame();
        #endregion
        #endregion
        #region Variables
        #region Public Variables For Detecting Mac Of Each NIC And Select One
        public string mac_Line_Details = ""; 
        public string MacAddressOfSelectedNic = "";
        public bool SelectedInterface_InitializeToReady = false;//وقتی ترو بشه یعنی اینکه همه نیک ها بدرستی گرفته شده و اماده برایانتخاب کردن هستن
        #endregion
        #region Counters-And-Statistics Variables
        int counter_packet = 0, frameTotalLength = 0;
        string typeOfPacket_sendOrRcv = "";
        #region Timer And Charts Variables
        int lastcount = 0, time = 0, totalSendSize = 0, totalRcieveSize = 0, lastSendSize = 0, lastReceveSize = 0;
        int tcpcount = 0, tcplastcount = 0, udpcount = 0, udplastcount = 0, httpcount = 0, httplastcount = 0, dnscount = 0, dnslastcount = 0, icmpcount = 0, icmplastcount = 0;
        int ssdpcount = 0, ssdplastcount = 0, icmpv6count = 0, icmpv6lastcount = 0, igmpv2count = 0, igmpv2lastcount = 0, llmnrcount = 0, llmnrlastcount = 0, nbnscount = 0, nbnslastcount = 0;
        int arpcount = 0, arplastcount = 0, dhcpcount = 0, dhcplastcount = 0, ipv6count = 0, ipv6lastcount = 0;
        #endregion
        #endregion
        #region Misc Varibles
        string SeyyedMahdiHassanPourMatiKolai = "Creator_SeyyedMahdiHassanPourMatiKolai_smahdi1991@gmail.com";//Developer-And-Owener
        public bool form_closed = false;
        #endregion
        #region Structur Variables
        ethernet_header ethvariable;//1
        arp_hdr arpvariable;//2
        ip_hdr ipvariable;//3
        ipv6_header ipv6variable;//4
        udp_hdr udpvariable;//5
        tcp_header tcpvariable;//6
        dns_header dnsvariable;//9
        nbns_header nbnsvariable;//10
        llmnr_header llmnrvariable;//11
        dhcp_hdr dhcpvariable;//12
        icmp_hdr icmpvariable;//13
        icmpv6_hdr icmpv6variable;//14
        igmpv2_hdr igmpv2variable;//15
        #endregion
        #region Structures Dictionary For Saving In Format: <Packet#,Header>
        Dictionary<int, ethernet_header> eth_dictionary = new Dictionary<int, ethernet_header>();
        Dictionary<int, arp_hdr> arp_dictionary = new Dictionary<int, arp_hdr>();
        Dictionary<int, ip_hdr> ip_dictionary = new Dictionary<int, ip_hdr>();
        Dictionary<int, ipv6_header> ipv6_dictionary = new Dictionary<int, ipv6_header>();
        Dictionary<int, udp_hdr> udp_dictionary = new Dictionary<int, udp_hdr>();
        Dictionary<int, tcp_header> tcp_dictionary = new Dictionary<int, tcp_header>();
        Dictionary<int, icmp_hdr> icmp_dictionary = new Dictionary<int, icmp_hdr>();
        Dictionary<int, dns_header> dns_dictionary = new Dictionary<int, dns_header>();
        Dictionary<int, nbns_header> nbns_dictionary = new Dictionary<int, nbns_header>();
        Dictionary<int, llmnr_header> llmnr_dictionary = new Dictionary<int, llmnr_header>();
        Dictionary<int, igmpv2_hdr> igmpv2_dictionary = new Dictionary<int, igmpv2_hdr>();
        Dictionary<int, icmpv6_hdr> icmpv6_dictionary = new Dictionary<int, icmpv6_hdr>();
        Dictionary<int, dhcp_hdr> dhcp_dictionary = new Dictionary<int, dhcp_hdr>();
        Dictionary<int, string> http_dictionary = new Dictionary<int, string>();
        Dictionary<int, string> ssdp_dictionary = new Dictionary<int, string>();
        Dictionary<int, string> payLoad_dictionary = new Dictionary<int, string>();
        Dictionary<int, string> listOfPackets_ForUpdatingListBox_dictionary = new Dictionary<int, string>();
        #endregion
        #endregion

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            PrepareNetworkInterfaceCards_List();//Starting For Discovery Network Interface Cards
            this.Text = "Packet Analyzor..." + SeyyedMahdiHassanPourMatiKolai;

        }//intialize and start Discovery Nework Interface Cards

        #region PrepareNetwork Interface Cards Details  And Selecting By User Choice
        public void PrepareNetworkInterfaceCards_List()
        {
            try
            {
                #region Variables
                Dev_Informattion dv;
                string NICIdNumber = "", deviceName = "", deviceDescription = "";
                bool flag_DetailsExistin_NetWorkInterfaces_List = false;//
                #endregion
                #region Get Number Of NICs-And-Details In Format<the Mac Of NetWork Interface Cards,NIC ID#s(18charachter)>
                int CountOfNICs = GetCountOfNics();// Get The Number Of Available Network Interface Cards 
                string netWorkInterfaces_List = RunCmdCommands("getmac", "");//Get <the Mac Of NetWork Interface Cards,18 character each Network Id#s> 
                #region Example Of NetworkInterfaces List
                /*
                    Physical Address    Transport Name
                    =================== ========================================================
                    1C-75-08-D7-CF-65   Media disconnected
                    90-00-4E-40-4D-3C   \Device\Tcpip_{B1F33576-99E3-4431-8E08-0FE4D0B13C96}
                    90-00-4E-40-4D-3C   Media disconnected
                    44-45-53-54-4F-53   \Device\Tcpip_{7754D373-AB4A-47B6-B3EF-D1CFC40290A4}
                    N/A                 Hardware not present
                    00-50-56-C0-00-01   \Device\Tcpip_{01D87623-3B50-4AD4-9228-4754790DEC2E}
                    00-50-56-C0-00-08   \Device\Tcpip_{CDAE36F1-83A1-43C8-9781-5D1193FCB81D}
                 */
                #endregion
                #endregion

                for (int k = 0; k < CountOfNICs; k++)
                {
                    flag_DetailsExistin_NetWorkInterfaces_List = false;
                    #region Copy Device Name-And-Description Into Dev_InFormattion variable"dv"-And- Pass it From c To C#
                    GetNICdetailsOneByOneFromCsharp();
                    GetDevicesDetails(out dv);  
                    #endregion
                    #region Convert dv.dev_name,dv.dev_description from char[] to string-And- Extract DevID From DeviceName 
                    deviceName = string.Join("", dv.dev_name).ToString().Replace("\0", "");
                    deviceDescription = string.Join("", dv.dev_description).ToString().Replace("\0", "");
                    NICIdNumber = deviceName.Substring(20, 38);//the ID size in NICard Name is 18character 
                    #endregion

                    #region Find Mac Of NetworkInterface Card-And- Add it To "mac_Line_Details"
                    foreach (string item in netWorkInterfaces_List.Split('\n'))
                    {
                        if (item.Contains(NICIdNumber))
                        {
                            flag_DetailsExistin_NetWorkInterfaces_List = true;
                            mac_Line_Details += item + " " + deviceDescription + "\n";
                            break;
                        }
                    }
                    #endregion
                    #region If The Mac wasnt  In NIC_List then Just Add Nics<dev.name,dev.description> to mac_Line_Details
                    if (flag_DetailsExistin_NetWorkInterfaces_List == false)
                    {
                        mac_Line_Details += deviceName + " " + deviceDescription + "\n";
                    }
                    #endregion
                }
                //now in the selectinterface form we have to select one nic 
                SelectedInterface_InitializeToReady = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //1this function will be called from SelectInterface form
        public void Selected_Nic_For_capturing(int choose)
        {
            SelectAndOpenNIC(choose);
            Thread thread_SavePacketsInDictionary = new Thread(delegate() { SavePaketsInDictionarys(); });
            thread_SavePacketsInDictionary.Priority = ThreadPriority.Lowest;
            thread_SavePacketsInDictionary.Start();
        }
        #endregion
        //2
        #region Capture Packets and Save them Into Dictionarys
        public void SavePaketsInDictionarys()
        {
            int k = 0;
            while (form_closed==false)
            {
                k = CapturePacket();
                if (k == -1)
                    continue;
                frameTotalLength = GetEthernet(out ethvariable);
                eth_dictionary.Add(counter_packet, ethvariable);
                DetectTypeOfPacket_SendOrRcv();
                DigestPacketIntoRightDitionarys();
                counter_packet++;//Count Of packets

            }
        }
        public void DetectTypeOfPacket_SendOrRcv()
        {
            #region Source Mac OF Packet
            string hexStringsrc;
            hexStringsrc = ChangeToHex((uint)ethvariable.src[0], 0) + "-" + ChangeToHex((uint)ethvariable.src[1], 0) + "-"
            + ChangeToHex((uint)ethvariable.src[2], 0) + "-" + ChangeToHex((uint)ethvariable.src[3], 0) + "-"
            + ChangeToHex((uint)ethvariable.src[4], 0) + "-" + ChangeToHex((uint)ethvariable.src[5], 0);
            #endregion
            #region Destination Mac Of Packet
            string hexStringdst;
            hexStringdst = ChangeToHex((uint)ethvariable.dst[0], 0) + "-" + ChangeToHex((uint)ethvariable.dst[1], 0) + "-"
                + ChangeToHex((uint)ethvariable.dst[2], 0) + "-" + ChangeToHex((uint)ethvariable.dst[3], 0) + "-"
            + ChangeToHex((uint)ethvariable.dst[4], 0) + "-" + ChangeToHex((uint)ethvariable.dst[5], 0);
            #endregion
            #region If SourceMac==User Selected "NIC.Mac" Then The packet  Sent From this Pc 
            if (hexStringsrc.ToUpper() == MacAddressOfSelectedNic)
            {//snd
                typeOfPacket_sendOrRcv = frameTotalLength.ToString() + ".Byte Sent At:" + time;
                totalSendSize += frameTotalLength;
            }
            #endregion
            #region else if DestinationMac==User Selected "NIC.Mac" Then The packet Recievd To This Pc
            else if (hexStringdst.ToUpper() == MacAddressOfSelectedNic)//age maghsad in ip bod ke ip system mah hast yani recieve shode in payam
            {//rcv
                totalRcieveSize += frameTotalLength;
                typeOfPacket_sendOrRcv = frameTotalLength.ToString() + ".Byte Recievd At:" + time;
            }
            #endregion

        }
        //2
        private void DigestPacketIntoRightDitionarys()
        {
            string payload_CharToString = "",frame_Data="";
            int payload_length=GetPayloadLength();
            #region Ipv4
            if (ethvariable.type == 2048)//ip 0800 hex=02048 dec
            {
                GetIpv4(out ipvariable);
                ip_dictionary.Add(counter_packet, ipvariable);//ipv4 saved 
                #region Udp
                if (ipvariable.ip_protocol == 17)//udp =17
                {
                    udpcount++;
                    GetUdp(out udpvariable);
                    udp_dictionary.Add(counter_packet, udpvariable);//udp saved
                    #region Dns
                    if (udpvariable.dest_port == 53 || udpvariable.source_port == 53)//dns =port53
                    {
                        dnscount++;
                        GetDns(out dnsvariable);
                        dns_dictionary.Add(counter_packet, dnsvariable);//dns saved
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".DNS:" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    #region Ssdp
                    else if (udpvariable.dest_port == 1900 || udpvariable.source_port == 1900)//ssdp=port1900
                    {
                        ssdpcount++;
                        payload_CharToString=System.Runtime.InteropServices.Marshal.PtrToStringAnsi( GetSsdp(),payload_length);
                        ssdp_dictionary.Add(counter_packet, payload_CharToString);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".SSDP:" + typeOfPacket_sendOrRcv);
                        payLoad_dictionary.Add(counter_packet, "");//because Data Saved In Ssdp Dictionary
                        return;
                    }
                    #endregion
                    #region Nbns
                    else if (udpvariable.dest_port == 137 || udpvariable.source_port == 137)//nbns=port137
                    {
                        nbnscount++;
                        GetNbns(out nbnsvariable);
                        nbns_dictionary.Add(counter_packet, nbnsvariable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".NBNS:" + typeOfPacket_sendOrRcv);

                    }
                    #endregion
                    #region Llmnr
                    else if (udpvariable.dest_port == 5355 || udpvariable.source_port == 5355)//llmnr=port5355
                    {
                        llmnrcount++;
                        GetLlmnr(out llmnrvariable);
                        llmnr_dictionary.Add(counter_packet, llmnrvariable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".LLMNR:" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    #region Dhcp
                    else if (udpvariable.dest_port == 68 || udpvariable.dest_port == 67 || udpvariable.source_port == 67 || udpvariable.source_port == 68)
                    {
                        dhcpcount++;
                        GetDhcp(out dhcpvariable);
                        dhcp_dictionary.Add(counter_packet, dhcpvariable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".DHCP" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    else
                    {
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".UDP:" + typeOfPacket_sendOrRcv);
                    }
                }
                #endregion
                #region Tcp
                else if (ipvariable.ip_protocol == 6)//tcp
                {
                    try
                    {
                        tcpcount++;
                        GetTcp(out tcpvariable);
                        tcp_dictionary.Add(counter_packet, tcpvariable);
                        #region Http
                        if (tcpvariable.dest_port == 80 || tcpvariable.source_port == 80)//http
                        {
                            httpcount++;
                            payload_CharToString = System.Runtime.InteropServices.Marshal.PtrToStringAnsi( GetHttp(),payload_length);//out httpvariable);
                            http_dictionary.Add(counter_packet, payload_CharToString);
                            listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".HTTP:" + typeOfPacket_sendOrRcv);
                            payLoad_dictionary.Add(counter_packet, "");
                            return;
                        }
                        #endregion
                        else
                        {
                            listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".TCP:" + typeOfPacket_sendOrRcv);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("tcp error"+ex.Message);
                    }

                }
                #endregion
                #region Icmp
                else if (ipvariable.ip_protocol == 1)
                {
                    icmpcount++;
                    GetIcmp(out icmpvariable);
                    icmp_dictionary.Add(counter_packet, icmpvariable);
                    listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".ICMP:" + typeOfPacket_sendOrRcv);
                }
                #endregion
                #region Igmp
                else if (ipvariable.ip_protocol == 2)
                {
                    try
                    {
                        igmpv2count++;
                        GetIgmp(out igmpv2variable);//inja ye moshkeli hast
                        igmpv2_dictionary.Add(counter_packet, igmpv2variable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".IGMPV2:" + typeOfPacket_sendOrRcv);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("igmp error"+ex.Message); ;
                    }

                }
                #endregion
                else
                {
                    listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".IP:" + typeOfPacket_sendOrRcv);
                }
            }
            #endregion
            #region Ipv6
            else if (ethvariable.type == 34525)//ipv6 =34525dec=86dd hex
            {
                ipv6count++;
                GetIpv6(out ipv6variable);
                ipv6_dictionary.Add(counter_packet, ipv6variable);
                #region Udp
                if (ipv6variable.next_header == 17)//udp
                {

                    GetUdp(out udpvariable);
                    udp_dictionary.Add(counter_packet, udpvariable);//udp saved
                    #region Dns
                    if (udpvariable.dest_port == 53 || udpvariable.source_port == 53)//dns =port53
                    {
                        dnscount++;
                        
                        GetDns(out dnsvariable);
                        dns_dictionary.Add(counter_packet, dnsvariable);//dns saved
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".DNS:" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    #region Ssdp
                    else if (udpvariable.dest_port == 1900 || udpvariable.source_port == 1900)//ssdp=port1900
                    {
                        ssdpcount++;
                        payload_CharToString = System.Runtime.InteropServices.Marshal.PtrToStringAnsi( GetSsdp(),payload_length);//out ssdpvariable);
                        ssdp_dictionary.Add(counter_packet, payload_CharToString);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".SSDP:" + typeOfPacket_sendOrRcv);
                        payLoad_dictionary.Add(counter_packet, "");
                        return;
                    }
                    #endregion
                    #region Nbns
                    else if (udpvariable.dest_port == 137 || udpvariable.source_port == 137)//nbns=port137
                    {
                        nbnscount++;
                        GetNbns(out nbnsvariable);
                        nbns_dictionary.Add(counter_packet, nbnsvariable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".NBNS:" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    #region Llmnrs
                    else if (udpvariable.dest_port == 5355 || udpvariable.source_port == 5355)//llmnr=port5355
                    {
                        llmnrcount++;
                        GetLlmnr(out llmnrvariable);
                        llmnr_dictionary.Add(counter_packet, llmnrvariable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".LLMNR:" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    #region Dhcp
                    else if (udpvariable.dest_port == 68 || udpvariable.dest_port == 67 || udpvariable.source_port == 67 || udpvariable.source_port == 68)
                    {//dhcp port 67,68
                        dhcpcount++;
                        GetDhcp(out dhcpvariable);
                        dhcp_dictionary.Add(counter_packet, dhcpvariable);
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".DHCP:" + typeOfPacket_sendOrRcv);
                    }
                    #endregion
                    else
                    {
                        listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".UDP:" + typeOfPacket_sendOrRcv);
                    }
                }
                #endregion
                #region icmpv6
                else if (ipv6variable.next_header == 58 || ipv6variable.next_header == 0/*HopByHop Mode*/)//icmpv6
                {
                    icmpv6count++;
                    GetIcmpv6(out icmpv6variable);
                    icmpv6_dictionary.Add(counter_packet, icmpv6variable);
                    listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".ICMPV6:" + typeOfPacket_sendOrRcv);
                }
                #endregion
                else
                {
                    listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".IPV6:" + typeOfPacket_sendOrRcv);
                }
            }
            #endregion
            #region Arp
            else if (ethvariable.type == 2054)//arp =2054 dec=0806 hex
            {
                arpcount++;
                GetArp(out arpvariable);
                arp_dictionary.Add(counter_packet, arpvariable);
                listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".ARP:" + typeOfPacket_sendOrRcv);
            }
            #endregion
            else
            {
                listOfPackets_ForUpdatingListBox_dictionary.Add(counter_packet, ".Ethernet:" + typeOfPacket_sendOrRcv);
            }
            #region Payload
                try
                {
                   frame_Data =System.Runtime.InteropServices.Marshal.PtrToStringAnsi( GetFrame(),frameTotalLength);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (frameTotalLength>1514)
                 payLoad_dictionary.Add(counter_packet, "Reassmbled Packet:"+frame_Data);
                
                else
                    payLoad_dictionary.Add(counter_packet, frame_Data);

            #endregion
        }
        #endregion

        #region Filling Protocol Stack When ListBoxOf Packet's Selected Index Changed
        private void listBox_Packets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_ProtocolStack();
        }

        public void Fill_ProtocolStack()
        {
            int selectedPacketNumber = int.Parse(listBox_Packets.SelectedItem.ToString().Split('.')[0]);
            string hexString;
            #region Ethernet
            #region Set "textBox_ETH_Dst_Mac_Address.Text = destination Mac"
            hexString = ChangeToHex((uint)eth_dictionary[selectedPacketNumber].dst[0], 0) + "-" +
                ChangeToHex((uint)eth_dictionary[selectedPacketNumber].dst[1], 0) + "-"
            + ChangeToHex((uint)eth_dictionary[selectedPacketNumber].dst[2], 0) + "-" +
            ChangeToHex((uint)eth_dictionary[selectedPacketNumber].dst[3], 0) + "-"
            + ChangeToHex((uint)eth_dictionary[selectedPacketNumber].dst[4], 0) + "-" +
            ChangeToHex((uint)eth_dictionary[selectedPacketNumber].dst[5], 0);
            textBox_ETH_Dst_Mac_Address.Text = hexString;
            #endregion
            #region Set "textBox_ETH_Src_Mac_Address.Text = Source Mac"
            hexString = ChangeToHex((uint)eth_dictionary[selectedPacketNumber].src[0], 0) + "-" +
                ChangeToHex((uint)eth_dictionary[selectedPacketNumber].src[1], 0) + "-"
            + ChangeToHex((uint)eth_dictionary[selectedPacketNumber].src[2], 0) + "-" +
            ChangeToHex((uint)eth_dictionary[selectedPacketNumber].src[3], 0) + "-"
            + ChangeToHex((uint)eth_dictionary[selectedPacketNumber].src[4], 0) + "-" +
            ChangeToHex((uint)eth_dictionary[selectedPacketNumber].src[5], 0);
            textBox_ETH_Src_Mac_Address.Text = hexString;
            #endregion
            //type
            textBox_ETH_TypeField.Text = ChangeToHex((uint)eth_dictionary[selectedPacketNumber].type, 0);
            #endregion
            #region IP4
            if (eth_dictionary[selectedPacketNumber].type == 2048)//0800 ip
            {
                #region IP HEADER
                textBox_Ip_Version.Text = ((ip_dictionary[selectedPacketNumber].ip_version_IHL & 0xf0) >> 4).ToString();
                textBox_IP_HeardeLength.Text = (((ip_dictionary[selectedPacketNumber].ip_version_IHL & 0x0f)) * 4).ToString();
                textBox_IP_TypeOfService.Text = ip_dictionary[selectedPacketNumber].ip_tos.ToString();
                textBox_Ip_TotalLentgh.Text = ip_dictionary[selectedPacketNumber].ip_total_length.ToString();
                textBox_IP_Identification.Text = ip_dictionary[selectedPacketNumber].ip_id.ToString();
                textBox_IP_DF.Text = ((ip_dictionary[selectedPacketNumber].R_DF_MF_FragmentOffset & 0x4000) >> 14).ToString();
                textBox_IP_MF.Text = ((ip_dictionary[selectedPacketNumber].R_DF_MF_FragmentOffset & 0x2000) >> 13).ToString();
                textBox_Ip_FragemntaionOffset.Text = (ip_dictionary[selectedPacketNumber].R_DF_MF_FragmentOffset & 0x1fff).ToString();
                textBox_IP_TTL.Text = ip_dictionary[selectedPacketNumber].ip_ttl.ToString();
                textBox_IP_Protocol.Text = ip_dictionary[selectedPacketNumber].ip_protocol.ToString();
                textBox_IP_HeaderChecksum.Text = ChangeToHex(ip_dictionary[selectedPacketNumber].ip_checksum, 0);
                hexString = ip_dictionary[selectedPacketNumber].ipSource[0] + "-" +
                    ip_dictionary[selectedPacketNumber].ipSource[1] + "-" +
                    ip_dictionary[selectedPacketNumber].ipSource[2] + "-" +
                   ip_dictionary[selectedPacketNumber].ipSource[3];
                textBox_IP_Src_Add.Text = hexString;
                hexString = ip_dictionary[selectedPacketNumber].ipDestination[0] + "-" +
                  ip_dictionary[selectedPacketNumber].ipDestination[1] + "-" +
                   ip_dictionary[selectedPacketNumber].ipDestination[2] + "-" +
                  ip_dictionary[selectedPacketNumber].ipDestination[3];
                textBox_IP_Dst_Add.Text = hexString;
                tabControl_NetworkLayer.SelectedIndex = 0;
                #endregion
                #region UDP
                if (ip_dictionary[selectedPacketNumber].ip_protocol == 17)//udp
                {
                    #region UDP Header
                    textBox_Udp_SourcePort.Text = udp_dictionary[selectedPacketNumber].source_port.ToString();
                    textBox_Udp_DestinationPort.Text = udp_dictionary[selectedPacketNumber].dest_port.ToString();
                    textBox_Udp_length.Text = udp_dictionary[selectedPacketNumber].udp_length.ToString();
                    textBox_Udp_Checksum.Text = ChangeToHex(udp_dictionary[selectedPacketNumber].udp_checksum, 0);
                    tabControl_TransportLayer.SelectedIndex = 1;//udp tab
                    #endregion
                    #region DNS
                    if (udp_dictionary[selectedPacketNumber].source_port == 53 || udp_dictionary[selectedPacketNumber].dest_port == 53)
                    {
                        textBox_Dns_TransactionID.Text = ChangeToHex(dns_dictionary[selectedPacketNumber].transActionIdentification, 0);
                        textBox_DNS_Qr.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x80) >> 7).ToString();
                        textBox_DNS_Opcode.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x78) >> 3).ToString();
                        textBox_DNS_AA.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x04) >> 3).ToString();
                        textBox_DNS_TC.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x02) >> 1).ToString();
                        textBox_Dns_Rd.Text = (dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x01).ToString();
                        textBox_DNS_ra.Text = ((dns_dictionary[selectedPacketNumber].EA_UNUSED_RCODE & 0x80) >> 7).ToString();
                        textBox_DNS_Unused.Text = ((dns_dictionary[selectedPacketNumber].EA_UNUSED_RCODE & 0x70) >> 4).ToString();
                        textBox_DNS_rcode.Text = (dns_dictionary[selectedPacketNumber].EA_UNUSED_RCODE & 0x0f).ToString();
                        textBox_Dns_Questions.Text = (dns_dictionary[selectedPacketNumber].numberOFQuestions).ToString();
                        textBox_Dns_answers.Text = (dns_dictionary[selectedPacketNumber].numberOFAnswerRRs).ToString();
                        textBox_Dns_Authority.Text = (dns_dictionary[selectedPacketNumber].numberOFAuthorityRRs).ToString();
                        textBox_Dns_Additionals.Text = (dns_dictionary[selectedPacketNumber].numberOFAdditionalRRs).ToString();
                        tabControl_AppLayer.SelectedIndex = 1;
                    }
                    #endregion
                    #region NBNS
                    else if (udp_dictionary[selectedPacketNumber].source_port == 137 || udp_dictionary[selectedPacketNumber].dest_port == 137)
                    {

                        textBox_NBNS_transactionID.Text = ChangeToHex(nbns_dictionary[selectedPacketNumber].transActionIdentification, 0);
                        textBox_NBNS_QR.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x80) >> 7).ToString();
                        textBox_NBNS_opcode.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x78) >> 3).ToString();
                        textBox_NBNS_aa.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x04) >> 3).ToString();
                        textBox_NBNS_tc.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x02) >> 1).ToString();
                        textBox_NBNS_rd.Text = (nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x01).ToString();
                        textBox_NBNS_ra.Text = ((nbns_dictionary[selectedPacketNumber].RCODE_BD_UNUSED_RA & 0x80) >> 7).ToString();
                        textBox_NBNS_BD.Text = ((nbns_dictionary[selectedPacketNumber].RCODE_BD_UNUSED_RA & 0x10) >> 4).ToString();
                        textBox_NBNS_rcode.Text = (nbns_dictionary[selectedPacketNumber].RCODE_BD_UNUSED_RA & 0x0f).ToString();
                        textBox_NBNS_questions.Text = (nbns_dictionary[selectedPacketNumber].numberOFQuestions).ToString();
                        textBox_NBNS_answer.Text = (nbns_dictionary[selectedPacketNumber].numberOFAnswerRRs).ToString();
                        textBox_NBNS_authority.Text = (nbns_dictionary[selectedPacketNumber].numberOFAuthorityRRs).ToString();
                        textBox_NBNS_addtional.Text = (nbns_dictionary[selectedPacketNumber].numberOFAdditionalRRs).ToString();
                        tabControl_AppLayer.SelectedIndex = 2;
                    }
                    #endregion
                    #region LLMNR
                    else if (udp_dictionary[selectedPacketNumber].source_port == 5355 || udp_dictionary[selectedPacketNumber].dest_port == 5355)
                    {
                        textBox_LLMNR_Transaction.Text = ChangeToHex(llmnr_dictionary[selectedPacketNumber].transActionIdentification, 0);
                        textBox_LLMNR_QR.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x80) >> 7).ToString();
                        textBox_LLMNR_opcode.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x78) >> 3).ToString();
                        textBox_LLMNR_C.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x04) >> 3).ToString();
                        textBox_LLMNR_TC.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x02) >> 1).ToString();
                        textBox_LLMNR_T.Text = (llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x01).ToString();
                        textBox_LLMNR_unused.Text = ((llmnr_dictionary[selectedPacketNumber].RCODE_UNUSED & 0xf0) >> 4).ToString();
                        textBox_LLMNR_rcode.Text = (llmnr_dictionary[selectedPacketNumber].RCODE_UNUSED & 0x0f).ToString();
                        textBox_LLMNR_questions.Text = (llmnr_dictionary[selectedPacketNumber].numberOFQuestions).ToString();
                        textBox_LLMNR_answer.Text = (llmnr_dictionary[selectedPacketNumber].numberOFAnswerRRs).ToString();
                        textBox_LLMNR_authority.Text = (llmnr_dictionary[selectedPacketNumber].numberOFAuthorityRRs).ToString();
                        textBox_LLMNR_additional.Text = (llmnr_dictionary[selectedPacketNumber].numberOFAdditionalRRs).ToString();
                        tabControl_AppLayer.SelectedIndex = 3;
                    }
                    #endregion
                    #region SSDP
                    else if (udp_dictionary[selectedPacketNumber].source_port == 1900 || udp_dictionary[selectedPacketNumber].dest_port == 1900)
                    {
                        textBox_SSDP.Text = ssdp_dictionary[selectedPacketNumber];
                        tabControl_AppLayer.SelectedIndex = 5;
                    }
                    #endregion
                    #region DHCP
                    else if (udp_dictionary[selectedPacketNumber].source_port == 68 || udp_dictionary[selectedPacketNumber].dest_port == 67 || udp_dictionary[selectedPacketNumber].source_port == 67 || udp_dictionary[selectedPacketNumber].dest_port == 68)
                    {
                        textBox_DHCP.Text = "OPCode:" + dhcp_dictionary[selectedPacketNumber].opcode.ToString();
                        textBox_DHCP.Text += "\r\n\r\nHardwareType:" + ChangeToHex(dhcp_dictionary[selectedPacketNumber].hardwareType, 0);
                        textBox_DHCP.Text += "\r\n\r\nHardWareAddressLength:" + dhcp_dictionary[selectedPacketNumber].hardwareAddressLength.ToString();
                        textBox_DHCP.Text += "\r\n\r\nHopCount:" + dhcp_dictionary[selectedPacketNumber].hopCount.ToString();
                        textBox_DHCP.Text += "\r\n\r\nTransactionID:" + ChangeToHex((dhcp_dictionary[selectedPacketNumber].transactionID & 0xffff0000) >> 16, 0) + ChangeToHex((dhcp_dictionary[selectedPacketNumber].transactionID & 0x0000ffff), 0);
                        textBox_DHCP.Text += "\r\n\r\nSeconds Elapsed:" + dhcp_dictionary[selectedPacketNumber].secondElapsed.ToString();
                        textBox_DHCP.Text += "\r\n\r\nBootP Flags:" + (dhcp_dictionary[selectedPacketNumber].bootpFlags >> 15);
                        textBox_DHCP.Text += "\r\n\r\nClient IP Address:" + dhcp_dictionary[selectedPacketNumber].clientIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].clientIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].clientIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].clientIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nYour(Client)IP Address:" + dhcp_dictionary[selectedPacketNumber].yourIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].yourIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].yourIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].yourIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nNext Server IP Address:" + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nRelay Agent IP Address:" + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nClient Mac Address:" + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[0], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[1], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[2], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[3], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[4], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[5], 0);
                        textBox_DHCP.Text += "\r\n\r\nClient Hardware Address Padding:" + System.Text.Encoding.Default.GetString(dhcp_dictionary[selectedPacketNumber].clientHardwareAddressPadding);
                        textBox_DHCP.Text += "\r\n\r\nServer Host Name:" + System.Text.Encoding.Default.GetString(dhcp_dictionary[selectedPacketNumber].serverHostName);
                        textBox_DHCP.Text += "\r\n\r\nBootFileName:" + System.Text.Encoding.Default.GetString(dhcp_dictionary[selectedPacketNumber].bootFileName);
                        tabControl_AppLayer.SelectedIndex = 4;//dhcp tab
                    }
                    #endregion
                }
                #endregion
                #region TCP
                else if (ip_dictionary[selectedPacketNumber].ip_protocol == 6)
                {
                    #region TCP Header
                    textBox_Tcp_SourcePort.Text = tcp_dictionary[selectedPacketNumber].source_port.ToString();
                    textBox_Tcp_DestinationPort.Text = tcp_dictionary[selectedPacketNumber].dest_port.ToString();
                    textBox_Tcp_SequencNumber.Text = ChangeToHex(tcp_dictionary[selectedPacketNumber].sequence, 0);
                    textBox_Tcp_AcknowledgeNumber.Text = ChangeToHex(tcp_dictionary[selectedPacketNumber].acknowledge, 0);
                    textBox_Tcp_HeaderLength.Text = (((tcp_dictionary[selectedPacketNumber].ns_reserved_DataOffset & 0xf0) >> 4) * 4).ToString();
                    textBox_Tcp_unused.Text = (tcp_dictionary[selectedPacketNumber].ns_reserved_DataOffset & 0x0f).ToString();

                    textBox_Tcp_cwr.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x80) >> 7).ToString();
                    textBox_Tcp_ecn.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x40) >> 6).ToString();
                    textBox_Tcp_urg.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x20) >> 5).ToString();
                    textBox_Tcp_ack.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x10) >> 4).ToString();
                    textBox_Tcp_psh.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x08) >> 3).ToString();
                    textBox_Tcp_rst.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x04) >> 2).ToString();
                    textBox_Tcp_syn.Text = ((tcp_dictionary[selectedPacketNumber].flags & 0x02) >> 1).ToString();
                    textBox_Tcp_fin.Text = (tcp_dictionary[selectedPacketNumber].flags & 0x01).ToString();

                    textBox_Tcp_WindowSize.Text = tcp_dictionary[selectedPacketNumber].window.ToString();
                    textBox_Tcp_CheckSum.Text = ChangeToHex(tcp_dictionary[selectedPacketNumber].checksum, 0);
                    textBox_Tcp_UrgentPointer.Text = tcp_dictionary[selectedPacketNumber].urgent_pointer.ToString();

                    tabControl_TransportLayer.SelectedIndex = 0;//tcp tab
                    #endregion
                    #region HTTP
                    if (tcp_dictionary[selectedPacketNumber].dest_port == 80 || tcp_dictionary[selectedPacketNumber].source_port == 80)
                    {
                        textBox_HTTP.Text = Regex.Replace(http_dictionary[selectedPacketNumber], "[^a-zA-Z0-9 -]", ".");//http_dictionary[selectedPacketNumber];
                        tabControl_AppLayer.SelectedIndex = 0;//http tab
                    }
                    #endregion
                }
                #endregion
                #region ICMP
                else if (ip_dictionary[selectedPacketNumber].ip_protocol == 1)
                {
                    textBox_ICMP_Type.Text = icmp_dictionary[selectedPacketNumber].type.ToString();
                    textBox_Icmp_Code.Text = icmp_dictionary[selectedPacketNumber].code.ToString();
                    textBox_Icmp_Checksum.Text = ChangeToHex(icmp_dictionary[selectedPacketNumber].checksum, 0);
                    textBox_Icmp_Id.Text = icmp_dictionary[selectedPacketNumber].id.ToString();
                    textBox_Icmp_SequenceNumber.Text = icmp_dictionary[selectedPacketNumber].seq.ToString();
                    tabControl_TransportLayer.SelectedIndex = 2;
                }
                #endregion
                #region IGMPv2
                else if (ip_dictionary[selectedPacketNumber].ip_protocol == 2)
                {
                    textBox_IGMP_type.Text = igmpv2_dictionary[selectedPacketNumber].type.ToString();
                    textBox_IGMP_maxResponse.Text = igmpv2_dictionary[selectedPacketNumber].maxResponseTime.ToString();
                    textBox_IGMP_checksum.Text = ChangeToHex(igmpv2_dictionary[selectedPacketNumber].headerChecksum, 0);
                    textBox_IGMP_multicastaddress.Text = igmpv2_dictionary[selectedPacketNumber].ip[0] +
                        igmpv2_dictionary[selectedPacketNumber].ip[1] +
                        igmpv2_dictionary[selectedPacketNumber].ip[2] +
                        igmpv2_dictionary[selectedPacketNumber].ip[3].ToString();
                    tabControl_TransportLayer.SelectedIndex = 3;
                }
                #endregion
            }
            #endregion
            #region IPV6
            else if (eth_dictionary[selectedPacketNumber].type == 34525)//ipv6
            {
                #region IPV6 Header
                textBox_IPV6_Version.Text = ((ipv6_dictionary[selectedPacketNumber].version_trafficClass_FlowLabel & 0xf0000000) >> 28).ToString();
                textBox_IPV6_trafficlass.Text = ((ipv6_dictionary[selectedPacketNumber].version_trafficClass_FlowLabel & 0x0ff00000) >> 20).ToString();
                textBox_IPV6_flowlabel.Text = ChangeToHex((ipv6_dictionary[selectedPacketNumber].version_trafficClass_FlowLabel & 0x000f0000) >> 16, 0) + ChangeToHex(ipv6_dictionary[selectedPacketNumber].version_trafficClass_FlowLabel, 0);
                textBox_IPV6_payloadlength.Text = ipv6_dictionary[selectedPacketNumber].length.ToString();
                textBox_IPV6_hoplimit.Text = ipv6_dictionary[selectedPacketNumber].hop_limit.ToString();
                textBox_IPV6_nextheader.Text = ipv6_dictionary[selectedPacketNumber].next_header.ToString();
                textBox_IPV6_srcaddress.Text = ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[0], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[1], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[2], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[3], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[4], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[5], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[6], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_src[7], 0);
                textBox_IPV6_dstaddress.Text = ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[0], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[1], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[2], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[3], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[4], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[5], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[6], 0) + ":" +
                    ChangeToHex(ipv6_dictionary[selectedPacketNumber].in6_addr_dst[7], 0);
                tabControl_NetworkLayer.SelectedIndex = 2;
                #endregion
                #region UDP
                if (ipv6_dictionary[selectedPacketNumber].next_header == 17)
                {
                    #region UDP Header
                    textBox_Udp_SourcePort.Text = udp_dictionary[selectedPacketNumber].source_port.ToString();
                    textBox_Udp_DestinationPort.Text = udp_dictionary[selectedPacketNumber].dest_port.ToString();
                    textBox_Udp_length.Text = udp_dictionary[selectedPacketNumber].udp_length.ToString();
                    textBox_Udp_Checksum.Text = ChangeToHex(udp_dictionary[selectedPacketNumber].udp_checksum, 0);
                    tabControl_TransportLayer.SelectedIndex = 1;//udp tab
                    #endregion
                    #region DNS
                    if (udp_dictionary[selectedPacketNumber].source_port == 53 || udp_dictionary[selectedPacketNumber].dest_port == 53)
                    {
                        textBox_Dns_TransactionID.Text = ChangeToHex(dns_dictionary[selectedPacketNumber].transActionIdentification, 0);
                        textBox_DNS_Qr.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x80) >> 7).ToString();
                        textBox_DNS_Opcode.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x78) >> 3).ToString();
                        textBox_DNS_AA.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x04) >> 3).ToString();
                        textBox_DNS_TC.Text = ((dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x02) >> 1).ToString();
                        textBox_Dns_Rd.Text = (dns_dictionary[selectedPacketNumber].QR_OPCODE_AA_TC_RD & 0x01).ToString();
                        textBox_DNS_ra.Text = ((dns_dictionary[selectedPacketNumber].EA_UNUSED_RCODE & 0x80) >> 7).ToString();
                        textBox_DNS_Unused.Text = ((dns_dictionary[selectedPacketNumber].EA_UNUSED_RCODE & 0x70) >> 4).ToString();
                        textBox_DNS_rcode.Text = (dns_dictionary[selectedPacketNumber].EA_UNUSED_RCODE & 0x0f).ToString();
                        textBox_Dns_Questions.Text = (dns_dictionary[selectedPacketNumber].numberOFQuestions).ToString();
                        textBox_Dns_answers.Text = (dns_dictionary[selectedPacketNumber].numberOFAnswerRRs).ToString();
                        textBox_Dns_Authority.Text = (dns_dictionary[selectedPacketNumber].numberOFAuthorityRRs).ToString();
                        textBox_Dns_Additionals.Text = (dns_dictionary[selectedPacketNumber].numberOFAdditionalRRs).ToString();
                        tabControl_AppLayer.SelectedIndex = 1;
                    }
                    #endregion
                    #region NBNS
                    else if (udp_dictionary[selectedPacketNumber].source_port == 137 || udp_dictionary[selectedPacketNumber].dest_port == 137)
                    {

                        textBox_NBNS_transactionID.Text = ChangeToHex(nbns_dictionary[selectedPacketNumber].transActionIdentification, 0);
                        textBox_NBNS_QR.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x80) >> 7).ToString();
                        textBox_NBNS_opcode.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x78) >> 3).ToString();
                        textBox_NBNS_aa.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x04) >> 3).ToString();
                        textBox_NBNS_tc.Text = ((nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x02) >> 1).ToString();
                        textBox_NBNS_rd.Text = (nbns_dictionary[selectedPacketNumber].RD_TC_AA_OPCODE_QR & 0x01).ToString();
                        textBox_NBNS_ra.Text = ((nbns_dictionary[selectedPacketNumber].RCODE_BD_UNUSED_RA & 0x80) >> 7).ToString();
                        textBox_NBNS_BD.Text = ((nbns_dictionary[selectedPacketNumber].RCODE_BD_UNUSED_RA & 0x10) >> 4).ToString();
                        textBox_NBNS_rcode.Text = (nbns_dictionary[selectedPacketNumber].RCODE_BD_UNUSED_RA & 0x0f).ToString();
                        textBox_NBNS_questions.Text = (nbns_dictionary[selectedPacketNumber].numberOFQuestions).ToString();
                        textBox_NBNS_answer.Text = (nbns_dictionary[selectedPacketNumber].numberOFAnswerRRs).ToString();
                        textBox_NBNS_authority.Text = (nbns_dictionary[selectedPacketNumber].numberOFAuthorityRRs).ToString();
                        textBox_NBNS_addtional.Text = (nbns_dictionary[selectedPacketNumber].numberOFAdditionalRRs).ToString();
                        tabControl_AppLayer.SelectedIndex = 2;
                    }
                    #endregion
                    #region LLMNR
                    else if (udp_dictionary[selectedPacketNumber].source_port == 5355 || udp_dictionary[selectedPacketNumber].dest_port == 5355)
                    {
                        textBox_LLMNR_Transaction.Text = ChangeToHex(llmnr_dictionary[selectedPacketNumber].transActionIdentification, 0);
                        textBox_LLMNR_QR.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x80) >> 7).ToString();
                        textBox_LLMNR_opcode.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x78) >> 3).ToString();
                        textBox_LLMNR_C.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x04) >> 3).ToString();
                        textBox_LLMNR_TC.Text = ((llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x02) >> 1).ToString();
                        textBox_LLMNR_T.Text = (llmnr_dictionary[selectedPacketNumber].T_TC_C_OPCODE_QR & 0x01).ToString();
                        textBox_LLMNR_unused.Text = ((llmnr_dictionary[selectedPacketNumber].RCODE_UNUSED & 0xf0) >> 4).ToString();
                        textBox_LLMNR_rcode.Text = (llmnr_dictionary[selectedPacketNumber].RCODE_UNUSED & 0x0f).ToString();
                        textBox_LLMNR_questions.Text = (llmnr_dictionary[selectedPacketNumber].numberOFQuestions).ToString();
                        textBox_LLMNR_answer.Text = (llmnr_dictionary[selectedPacketNumber].numberOFAnswerRRs).ToString();
                        textBox_LLMNR_authority.Text = (llmnr_dictionary[selectedPacketNumber].numberOFAuthorityRRs).ToString();
                        textBox_LLMNR_additional.Text = (llmnr_dictionary[selectedPacketNumber].numberOFAdditionalRRs).ToString();
                        tabControl_AppLayer.SelectedIndex = 3;
                    }
                    #endregion
                    #region SSDP
                    else if (udp_dictionary[selectedPacketNumber].source_port == 1900 || udp_dictionary[selectedPacketNumber].dest_port == 1900)
                    {
                        textBox_SSDP.Text = ssdp_dictionary[selectedPacketNumber];
                        tabControl_AppLayer.SelectedIndex = 5;
                    }
                    #endregion
                    #region DHCP
                    else if (udp_dictionary[selectedPacketNumber].source_port == 68 || udp_dictionary[selectedPacketNumber].dest_port == 67 || udp_dictionary[selectedPacketNumber].source_port == 67 || udp_dictionary[selectedPacketNumber].dest_port == 68)
                    {
                        textBox_DHCP.Text = "OPCode:" + dhcp_dictionary[selectedPacketNumber].opcode.ToString();
                        textBox_DHCP.Text += "\r\n\r\nHardwareType:" + ChangeToHex(dhcp_dictionary[selectedPacketNumber].hardwareType, 0);
                        textBox_DHCP.Text += "\r\n\r\nHardWareAddressLength:" + dhcp_dictionary[selectedPacketNumber].hardwareAddressLength.ToString();
                        textBox_DHCP.Text += "\r\n\r\nHopCount:" + dhcp_dictionary[selectedPacketNumber].hopCount.ToString();
                        textBox_DHCP.Text += "\r\n\r\nTransactionID:" + ChangeToHex((dhcp_dictionary[selectedPacketNumber].transactionID & 0xffff0000) >> 16, 0) + ChangeToHex((dhcp_dictionary[selectedPacketNumber].transactionID & 0x0000ffff), 0);
                        textBox_DHCP.Text += "\r\n\r\nSeconds Elapsed:" + dhcp_dictionary[selectedPacketNumber].secondElapsed.ToString();
                        textBox_DHCP.Text += "\r\n\r\nBootP Flags:" + (dhcp_dictionary[selectedPacketNumber].bootpFlags >> 15);
                        textBox_DHCP.Text += "\r\n\r\nClient IP Address:" + dhcp_dictionary[selectedPacketNumber].clientIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].clientIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].clientIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].clientIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nYour(Client)IP Address:" + dhcp_dictionary[selectedPacketNumber].yourIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].yourIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].yourIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].yourIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nNext Server IP Address:" + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].nextServerIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nRelay Agent IP Address:" + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[0] + "-"
                            + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[1] + "-"
                            + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[2] + "-"
                            + dhcp_dictionary[selectedPacketNumber].relayAgentIpAddress[3];
                        textBox_DHCP.Text += "\r\n\r\nClient Mac Address:" + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[0], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[1], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[2], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[3], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[4], 0) + "-"
                            + ChangeToHex(dhcp_dictionary[selectedPacketNumber].clientMacAddress[5], 0);
                        textBox_DHCP.Text += "\r\n\r\nClient Hardware Address Padding:" + System.Text.Encoding.Default.GetString(dhcp_dictionary[selectedPacketNumber].clientHardwareAddressPadding);
                        textBox_DHCP.Text += "\r\n\r\nServer Host Name:" + System.Text.Encoding.Default.GetString(dhcp_dictionary[selectedPacketNumber].serverHostName);
                        textBox_DHCP.Text += "\r\n\r\nBootFileName:" + System.Text.Encoding.Default.GetString(dhcp_dictionary[selectedPacketNumber].bootFileName);
                        tabControl_AppLayer.SelectedIndex = 4;
                    }
                    #endregion

                }
                #endregion
                #region Icmpv6
                else if (ipv6_dictionary[selectedPacketNumber].next_header == 58)
                {
                    textBox_ICMPv6_type.Text = icmpv6_dictionary[selectedPacketNumber].type.ToString();
                    textBox_ICMPv6_code.Text = icmpv6_dictionary[selectedPacketNumber].code.ToString();
                    textBox_ICMPv6_checksum.Text = ChangeToHex(icmpv6_dictionary[selectedPacketNumber].checksum, 0);
                    tabControl_TransportLayer.SelectedIndex = 4;
                }
                #endregion
            }
            #endregion
            #region ARP
            else if (eth_dictionary[selectedPacketNumber].type == 2054)
            {
                textBox_Arp_HardwareType.Text = arp_dictionary[selectedPacketNumber].hardwareType.ToString();
                textBox_Arp_ProtocolType.Text = ChangeToHex(arp_dictionary[selectedPacketNumber].protocol_type, 0);
                textBox_Arp_HardwareAddressLength.Text = arp_dictionary[selectedPacketNumber].hardwareSize.ToString();
                textBox_Arp_ProtocolAddressLength.Text = arp_dictionary[selectedPacketNumber].protocolSize.ToString();
                textBox_Arp_OperationCode.Text = arp_dictionary[selectedPacketNumber].operationCode.ToString();
                //sourceMacAddress
                hexString = ChangeToHex((uint)arp_dictionary[selectedPacketNumber].sourceMacAddress[0], 0) + "-" +
                ChangeToHex((uint)arp_dictionary[selectedPacketNumber].sourceMacAddress[1], 0) + "-"
            + ChangeToHex((uint)arp_dictionary[selectedPacketNumber].sourceMacAddress[2], 0) + "-" +
            ChangeToHex((uint)arp_dictionary[selectedPacketNumber].sourceMacAddress[3], 0) + "-"
            + ChangeToHex((uint)arp_dictionary[selectedPacketNumber].sourceMacAddress[4], 0) + "-" +
            ChangeToHex((uint)arp_dictionary[selectedPacketNumber].sourceMacAddress[5], 0);
                textBox_Arp_SourceHardWareAddress.Text = hexString;
                //destinationMacAddress
                hexString = ChangeToHex((uint)arp_dictionary[selectedPacketNumber].destinationMacAddress[0], 0) + "-" +
               ChangeToHex((uint)arp_dictionary[selectedPacketNumber].destinationMacAddress[1], 0) + "-"
           + ChangeToHex((uint)arp_dictionary[selectedPacketNumber].destinationMacAddress[2], 0) + "-" +
           ChangeToHex((uint)arp_dictionary[selectedPacketNumber].destinationMacAddress[3], 0) + "-"
           + ChangeToHex((uint)arp_dictionary[selectedPacketNumber].destinationMacAddress[4], 0) + "-" +
           ChangeToHex((uint)arp_dictionary[selectedPacketNumber].destinationMacAddress[5], 0);
                textBox_Arp_DestinationHardwareAddress.Text = hexString;
                //ipSourceAddress
                hexString = arp_dictionary[selectedPacketNumber].ipSourceAddress[0] + "-" +
                   arp_dictionary[selectedPacketNumber].ipSourceAddress[1] + "-" +
                   arp_dictionary[selectedPacketNumber].ipSourceAddress[2] + "-" +
                  arp_dictionary[selectedPacketNumber].ipSourceAddress[3];
                textBox_Arp_SourceIPAddress.Text = hexString;
                //ipDestinationAddress
                hexString = arp_dictionary[selectedPacketNumber].ipDestinationAddress[0] + "-" +
                   arp_dictionary[selectedPacketNumber].ipDestinationAddress[1] + "-" +
                   arp_dictionary[selectedPacketNumber].ipDestinationAddress[2] + "-" +
                  arp_dictionary[selectedPacketNumber].ipDestinationAddress[3];
                textBox_Arp_DestinationIPAddress.Text = hexString;
                tabControl_NetworkLayer.SelectedIndex = 1;

            }
            #endregion
            #region Payload
            if (checkBox_Payload.Checked == true)
             textBox_PayLoad.Text = Regex.Replace(payLoad_dictionary[selectedPacketNumber], "[^a-zA-Z0-9 -]", ".");
            listBox_Packets.Focus();
            
            #endregion

        }
        #endregion

        #region Updating Charts and Statistics By Timer1 Every One Second
        private void timer_1Sec_Tick(object sender, EventArgs e)
        {

            #region Time
            time++;
            label_ShowTimePerSecond.Text = time.ToString();
            #endregion
            #region LastVariables
            lastReceveSize = totalRcieveSize - lastReceveSize;
            lastSendSize = totalSendSize - lastSendSize;
            lastcount = counter_packet - lastcount;
            ipv6lastcount = ipv6count - ipv6lastcount;//
            arplastcount = arpcount - arplastcount;//
            tcplastcount = tcpcount - tcplastcount;//
            udplastcount = udpcount - udplastcount;//
            httplastcount = httpcount - httplastcount;//
            ssdplastcount = ssdpcount - ssdplastcount;//
            dnslastcount = dnscount - dnslastcount;//
            nbnslastcount = nbnscount - nbnslastcount;//
            llmnrlastcount = llmnrcount - llmnrlastcount;//
            dhcplastcount = dhcpcount - dhcplastcount;//
            igmpv2lastcount = igmpv2count - igmpv2lastcount;//
            icmplastcount = icmpcount - icmplastcount;//
            icmpv6lastcount = icmpv6count - icmpv6lastcount;//
            #endregion
            #region Send/Recieve Per Speed
            if (lastSendSize > 1024)
            {
                textBox_TotalSendperSec.Text = (lastSendSize / 1024) + "KB";
                sendSecToolStripMenuItem.Text = "Send/sec:" + textBox_TotalSendperSec.Text;//update system tray status
            }
            else
            {
                textBox_TotalSendperSec.Text = lastSendSize + "B";
                sendSecToolStripMenuItem.Text = "Send/sec:" + textBox_TotalSendperSec.Text;

            }
            if (lastReceveSize > 1024)
            {
                textBox_TotalRecieveperSec.Text = (lastReceveSize / 1024) + "KB";
                recvSecToolStripMenuItem.Text = "Rcv/sec:" + textBox_TotalRecieveperSec.Text;
            }
            else
            {
                textBox_TotalRecieveperSec.Text = lastReceveSize + "B";
                recvSecToolStripMenuItem.Text = "Rcv/sec:" + textBox_TotalRecieveperSec.Text;

            }
            #endregion
            #region Total Traffic
            if (totalSendSize > 1024 && totalSendSize < 1048576)
            {
                textBox_TotalSend.Text = (totalSendSize / 1024) + "KB";
            }
            else if (totalSendSize >= 1048576)
            {
                textBox_TotalSend.Text = (totalSendSize / 1048576) + "MB";
            }
            else
            {
                textBox_TotalSend.Text = totalSendSize + "B";
            }
            if (totalRcieveSize > 1024 && totalRcieveSize < 1048576)
            {
                textBox_TotalRecieve.Text = (totalRcieveSize / 1024) + "KB";
            }
            else if (totalRcieveSize >= 1048576)
            {
                textBox_TotalRecieve.Text = (totalRcieveSize / 1048576) + "MB";
            }
            else
            {
                textBox_TotalRecieve.Text = totalRcieveSize + "B";
            }
            #endregion
            #region Charts
            chart1.Series[0].Points.AddXY(time, lastSendSize);
            chart1.Series[1].Points.AddXY(time, lastReceveSize);
            chart_count.Series[0].Points.AddXY(time, lastcount);
            chart_count.Series[1].Points.AddXY(time, tcplastcount);
            chart_count.Series[2].Points.AddXY(time, udplastcount);
            chart_count.Series[3].Points.AddXY(time, httplastcount);
            chart_count.Series[4].Points.AddXY(time, arplastcount);
            chart_count.Series[5].Points.AddXY(time, ssdplastcount);
            chart_count.Series[6].Points.AddXY(time, dnslastcount);
            chart_count.Series[7].Points.AddXY(time, llmnrlastcount);

            #endregion
            #region LastVariables Updating
            countOfPacketsToolStripMenuItem.Text = "Counts/sec:" + counter_packet.ToString();//updating system tray status
            toolStripStatusLabel1.Text = "Count Of All Packets:" + counter_packet.ToString();
            lastcount = counter_packet;
            lastReceveSize = totalRcieveSize;
            lastSendSize = totalSendSize;
            ipv6lastcount = ipv6count;
            arplastcount = arpcount;
            tcplastcount = tcpcount;
            udplastcount = udpcount;
            httplastcount = httpcount;
            ssdplastcount = ssdpcount;
            dnslastcount = dnscount;
            nbnslastcount = nbnscount;
            llmnrlastcount = llmnrcount;
            dhcplastcount = dhcpcount;
            igmpv2lastcount = igmpv2count;
            icmplastcount = icmpcount;
            icmpv6lastcount = icmpv6count;
            #endregion
        }
        #endregion

        #region Search Packets
        private void button_Search_Click(object sender, EventArgs e)
        {
            listBox_Search.Items.Clear();
            int i = 1, j = 0;
            j = counter_packet;
            while (i < j)
            {
                if (listOfPackets_ForUpdatingListBox_dictionary[i].Split(':')[0].Split('.')[1].ToLower() == textBox_Search.Text.ToLower())
                {
                    listBox_Search.Items.Add(i + listOfPackets_ForUpdatingListBox_dictionary[i]);
                }
                i++;

            }
        }
        #endregion

        #region Update ListOf Packets every 600 Mili Second
        int i_lastCounter_listBox = 0;
        private void timer_2MiliSec_Tick(object sender, EventArgs e)
        {
            int k = 0;
            #region Update Listbox
            if (checkBox_AutoScroll.Checked == true && counter_packet > 0)
            {
                if ((counter_packet - i_lastCounter_listBox) >=10)
                {
                    #region Add To Update ListBox
                    string s1 = "";
                    bool flag_UpdateRange = false;
                    int i_lastcounter_Packet = counter_packet;

                    for (k = 0; k < 1000; k++)
                    {
                        if (k < (i_lastcounter_Packet - i_lastCounter_listBox))
                        {
                            s1 += i_lastCounter_listBox.ToString() + "." + listOfPackets_ForUpdatingListBox_dictionary[i_lastCounter_listBox] + "#";
                            i_lastCounter_listBox++;
                            flag_UpdateRange = true;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (flag_UpdateRange)
                    {
                        listBox_Packets.Items.AddRange(s1.Split('#'));
                        listBox_Packets.Items.RemoveAt(i_lastCounter_listBox);
                    }
                    #endregion
                }

                else if ((counter_packet - i_lastCounter_listBox) < 10)
                {
                    #region Add To Update ListBox
                    for (k = 0; k < (counter_packet - i_lastCounter_listBox) && k < 100; k++)
                    {
                        Thread.Sleep(2);
                        listBox_Packets.Items.Add(i_lastCounter_listBox + listOfPackets_ForUpdatingListBox_dictionary[i_lastCounter_listBox]);
                        i_lastCounter_listBox++;
                    }
                    #endregion
                }
                #region AutoScroll
                listBox_Packets.SelectedIndex = i_lastCounter_listBox - 1;//listBox_Packets.Items.Count - 1;//auto scroll 
                #endregion
            }
            #endregion
        }
        #endregion

        #region Update List Of Programm That Using The Network
        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgrammList_UsingNetwork();
        }
        public void ProgrammList_UsingNetwork()
        {
            string output_Netstat = "", output_Tasklist = "";
            output_Netstat = RunCmdCommands("netstat", "-nao");
            output_Tasklist = RunCmdCommands("tasklist", "");
            int i = 0;
            string str = "", pid = "";
            listBox_listOfProgramm.Items.Clear();
            string[] lines_ofNetstat = output_Netstat.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] lines_ofTasklist = output_Tasklist.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string item in lines_ofNetstat)
            {
                if (i == 3)
                {
                    listBox_listOfProgramm.Items.Add("Programm : Protocol : Local Address : Foreign Address : State : PID");
                }
                if (i > 3)
                {
                    if (item.Contains("TCP"))
                    {
                        str = Regex.Replace(item, @"\s+", " ").Replace(' ', '#').Remove(0, 1);
                        pid = str.Split('#')[4];
                        foreach (string item3 in lines_ofTasklist)
                        {
                            str = Regex.Replace(item3, @"\s+", " ").Replace(' ', '#');

                            if (str.Contains(pid))
                            {
                                listBox_listOfProgramm.Items.Add(str.Split('#')[0] + " :  " + item);
                                break;
                            }

                        }
                    }
                    else if (item.Contains("UDP"))
                    {
                        str = Regex.Replace(item, @"\s+", " ").Replace(' ', '#').Remove(0, 1);
                        pid = str.Split('#')[3];
                        foreach (string item3 in lines_ofTasklist)
                        {
                            str = Regex.Replace(item3, @"\s+", " ").Replace(' ', '#');

                            if (str.Contains(pid))
                            {
                                listBox_listOfProgramm.Items.Add(str.Split('#')[0] + " :  " + item);
                                break;
                            }

                        }
                    }

                }
                i++;
            }
        }
        //if suser select each line.then that line copying to clipboard
        private void listBox_listOfProgramm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox_listOfProgramm.SelectedItem.ToString());
            toolTip1.Show("Copied\"" + listBox_listOfProgramm.SelectedItem.ToString() + "\"", label_listOfProgramm);
        }

        #endregion

        #region Misc Functions
        //change integer to hex value
        public string ChangeToHex(uint value, uint numberOfBytes)
        {
            uint num = value;//16 o 254 o gheire dade bas chek knam debugesh konam
            int length = (int)numberOfBytes;
            int flag = 1;//true
            char[] arrayOfNumbers = new char[8];
            if (numberOfBytes == 0)//default for automatic 
            {
                length = 2;
                if (num > 255)
                    length = 4;
            }

            for (int i = 0; i < length; i++)
            {
                if (flag == 0 && i < length)
                    arrayOfNumbers[i] = '0';
                else if (num < 16)
                {
                    switch (num)
                    {
                        case 15:
                            arrayOfNumbers[i] = 'f';
                            break;
                        case 14:
                            arrayOfNumbers[i] = 'e';
                            break;
                        case 13:
                            arrayOfNumbers[i] = 'd';
                            break;
                        case 12:
                            arrayOfNumbers[i] = 'c';
                            break;
                        case 11:
                            arrayOfNumbers[i] = 'b';
                            break;
                        case 10:
                            arrayOfNumbers[i] = 'a';
                            break;
                        case 9:
                            arrayOfNumbers[i] = '9';
                            break;
                        case 8:
                            arrayOfNumbers[i] = '8';
                            break;
                        case 7:
                            arrayOfNumbers[i] = '7';
                            break;
                        case 6:
                            arrayOfNumbers[i] = '6';
                            break;
                        case 5:
                            arrayOfNumbers[i] = '5';
                            break;
                        case 4:
                            arrayOfNumbers[i] = '4';
                            break;
                        case 3:
                            arrayOfNumbers[i] = '3';
                            break;
                        case 2:
                            arrayOfNumbers[i] = '2';
                            break;
                        case 1:
                            arrayOfNumbers[i] = '1';
                            break;
                        case 0:
                            arrayOfNumbers[i] = '0';
                            break;
                        default:
                            break;
                    }

                    flag = 0;
                }
                else
                {
                    switch (num % 16)
                    {
                        case 15:
                            arrayOfNumbers[i] = 'f';
                            break;
                        case 14:
                            arrayOfNumbers[i] = 'e';
                            break;
                        case 13:
                            arrayOfNumbers[i] = 'd';
                            break;
                        case 12:
                            arrayOfNumbers[i] = 'c';
                            break;
                        case 11:
                            arrayOfNumbers[i] = 'b';
                            break;
                        case 10:
                            arrayOfNumbers[i] = 'a';
                            break;
                        case 9:
                            arrayOfNumbers[i] = '9';
                            break;
                        case 8:
                            arrayOfNumbers[i] = '8';
                            break;
                        case 7:
                            arrayOfNumbers[i] = '7';
                            break;
                        case 6:
                            arrayOfNumbers[i] = '6';
                            break;
                        case 5:
                            arrayOfNumbers[i] = '5';
                            break;
                        case 4:
                            arrayOfNumbers[i] = '4';
                            break;
                        case 3:
                            arrayOfNumbers[i] = '3';
                            break;
                        case 2:
                            arrayOfNumbers[i] = '2';
                            break;
                        case 1:
                            arrayOfNumbers[i] = '1';
                            break;
                        case 0:
                            arrayOfNumbers[i] = '0';
                            break;
                        default:
                            break;

                    }


                    num /= 16;
                }
            }
            string hexString = new string(arrayOfNumbers);
            //reverse hexsting
            char[] charArray = hexString.Replace("\0", "").ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

        //Run Cmd's Command
        private string RunCmdCommands(string name, string args)
        {
            string error = string.Empty;

            ProcessStartInfo psi = new ProcessStartInfo(name, args);

            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            //  psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            psi.CreateNoWindow = true;
            // psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            Process reg;
            reg = Process.Start(psi);
            using (System.IO.StreamReader myOutput = reg.StandardOutput)
            {
                return myOutput.ReadToEnd();

            }
            //  output;
        }

        //Put Programm in System Tray
        #region Systemtray(Notification)
        public void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible != true)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void packetAnalyzurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1_MouseDoubleClick(null, null);
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_closed= true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //about menu
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
        #endregion








    }
}
