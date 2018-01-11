namespace PacketAnalzerGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Packets = new System.Windows.Forms.ListBox();
            this.checkBox_AutoScroll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl_TransportLayer = new System.Windows.Forms.TabControl();
            this.tabPage_Tcp = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_Tcp_CheckSum = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_UrgentPointer = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox_Tcp_WindowSize = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_Tcp_cwr = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox_Tcp_ecn = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_Tcp_ack = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_psh = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_urg = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_Tcp_syn = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_fin = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_Tcp_rst = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_HeaderLength = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_AcknowledgeNumber = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_unused = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_Tcp_SequencNumber = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_Tcp_SourcePort = new System.Windows.Forms.TextBox();
            this.textBox_Tcp_DestinationPort = new System.Windows.Forms.TextBox();
            this.tabPage_Udp = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox_Udp_length = new System.Windows.Forms.TextBox();
            this.textBox_Udp_Checksum = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox_Udp_SourcePort = new System.Windows.Forms.TextBox();
            this.textBox_Udp_DestinationPort = new System.Windows.Forms.TextBox();
            this.tabPage_ICMP = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox_Icmp_SequenceNumber = new System.Windows.Forms.TextBox();
            this.textBox_Icmp_Checksum = new System.Windows.Forms.TextBox();
            this.textBox_Icmp_Id = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox_Icmp_Code = new System.Windows.Forms.TextBox();
            this.textBox_ICMP_Type = new System.Windows.Forms.TextBox();
            this.tabPage_IGMP = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IGMP_maxResponse = new System.Windows.Forms.TextBox();
            this.textBox_IGMP_multicastaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IGMP_type = new System.Windows.Forms.TextBox();
            this.textBox_IGMP_checksum = new System.Windows.Forms.TextBox();
            this.tabPage_ICMPv6 = new System.Windows.Forms.TabPage();
            this.textBox_ICMPv6_checksum = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox_ICMPv6_type = new System.Windows.Forms.TextBox();
            this.textBox_ICMPv6_code = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl_AppLayer = new System.Windows.Forms.TabControl();
            this.tabPage_Http = new System.Windows.Forms.TabPage();
            this.textBox_HTTP = new System.Windows.Forms.TextBox();
            this.tabPage_DNS = new System.Windows.Forms.TabPage();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox_Dns_TransactionID = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox_DNS_Unused = new System.Windows.Forms.TextBox();
            this.textBox_DNS_ra = new System.Windows.Forms.TextBox();
            this.textBox_DNS_rcode = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox_DNS_Opcode = new System.Windows.Forms.TextBox();
            this.textBox_DNS_Qr = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox_DNS_TC = new System.Windows.Forms.TextBox();
            this.textBox_DNS_AA = new System.Windows.Forms.TextBox();
            this.textBox_Dns_Rd = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox_Dns_Additionals = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox_Dns_answers = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox_Dns_Authority = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox_Dns_Questions = new System.Windows.Forms.TextBox();
            this.tabPage_NBNS = new System.Windows.Forms.TabPage();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox_NBNS_BD = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox_NBNS_transactionID = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox_NBNS_unused = new System.Windows.Forms.TextBox();
            this.textBox_NBNS_ra = new System.Windows.Forms.TextBox();
            this.textBox_NBNS_rcode = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox_NBNS_opcode = new System.Windows.Forms.TextBox();
            this.textBox_NBNS_QR = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox_NBNS_tc = new System.Windows.Forms.TextBox();
            this.textBox_NBNS_aa = new System.Windows.Forms.TextBox();
            this.textBox_NBNS_rd = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox_NBNS_addtional = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox_NBNS_answer = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox_NBNS_authority = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox_NBNS_questions = new System.Windows.Forms.TextBox();
            this.tabPage_LLMNR = new System.Windows.Forms.TabPage();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_Transaction = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_unused = new System.Windows.Forms.TextBox();
            this.textBox_LLMNR_rcode = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_opcode = new System.Windows.Forms.TextBox();
            this.textBox_LLMNR_QR = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_TC = new System.Windows.Forms.TextBox();
            this.textBox_LLMNR_C = new System.Windows.Forms.TextBox();
            this.textBox_LLMNR_T = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_additional = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_answer = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_authority = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox_LLMNR_questions = new System.Windows.Forms.TextBox();
            this.tabPage_DHCP = new System.Windows.Forms.TabPage();
            this.textBox_DHCP = new System.Windows.Forms.TextBox();
            this.tabPage_SSDP = new System.Windows.Forms.TabPage();
            this.textBox_SSDP = new System.Windows.Forms.TextBox();
            this.tabControl_NetworkLayer = new System.Windows.Forms.TabControl();
            this.tabPage_IP = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_IP_Dst_Add = new System.Windows.Forms.TextBox();
            this.textBox_IP_HeaderChecksum = new System.Windows.Forms.TextBox();
            this.textBox_IP_Src_Add = new System.Windows.Forms.TextBox();
            this.textBox_IP_Identification = new System.Windows.Forms.TextBox();
            this.textBox_IP_TTL = new System.Windows.Forms.TextBox();
            this.textBox_IP_Protocol = new System.Windows.Forms.TextBox();
            this.textBox_IP_DF = new System.Windows.Forms.TextBox();
            this.textBox_Ip_Version = new System.Windows.Forms.TextBox();
            this.textBox_IP_HeardeLength = new System.Windows.Forms.TextBox();
            this.textBox_IP_MF = new System.Windows.Forms.TextBox();
            this.textBox_Ip_TotalLentgh = new System.Windows.Forms.TextBox();
            this.textBox_Ip_FragemntaionOffset = new System.Windows.Forms.TextBox();
            this.textBox_IP_TypeOfService = new System.Windows.Forms.TextBox();
            this.tabPage_ARP = new System.Windows.Forms.TabPage();
            this.textBox_Arp_DestinationIPAddress = new System.Windows.Forms.TextBox();
            this.textBox_Arp_DestinationHardwareAddress = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox_Arp_OperationCode = new System.Windows.Forms.TextBox();
            this.textBox_Arp_SourceIPAddress = new System.Windows.Forms.TextBox();
            this.textBox_Arp_SourceHardWareAddress = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox_Arp_ProtocolType = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox_Arp_HardwareType = new System.Windows.Forms.TextBox();
            this.textBox_Arp_HardwareAddressLength = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox_Arp_ProtocolAddressLength = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tabPage_IPV6 = new System.Windows.Forms.TabPage();
            this.textBox_IPV6_dstaddress = new System.Windows.Forms.TextBox();
            this.textBox_IPV6_hoplimit = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.textBox_IPV6_srcaddress = new System.Windows.Forms.TextBox();
            this.textBox_IPV6_nextheader = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.textBox_IPV6_flowlabel = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.textBox_IPV6_Version = new System.Windows.Forms.TextBox();
            this.textBox_IPV6_trafficlass = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.textBox_IPV6_payloadlength = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.tabControl_Linklayer = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_ETH_TypeField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ETH_Src_Mac_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ETH_Dst_Mac_Address = new System.Windows.Forms.TextBox();
            this.textBox_PayLoad = new System.Windows.Forms.TextBox();
            this.checkBox_Payload = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer_1Sec = new System.Windows.Forms.Timer(this.components);
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.textBox_TotalRecieveperSec = new System.Windows.Forms.TextBox();
            this.textBox_TotalSendperSec = new System.Windows.Forms.TextBox();
            this.chart_count = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label108 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Search = new System.Windows.Forms.Button();
            this.listBox_Search = new System.Windows.Forms.ListBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_ShowTimePerSecond = new System.Windows.Forms.Label();
            this.timer_2MiliSec = new System.Windows.Forms.Timer(this.components);
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.textBox_TotalRecieve = new System.Windows.Forms.TextBox();
            this.textBox_TotalSend = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox_listOfProgramm = new System.Windows.Forms.ListBox();
            this.label_listOfProgramm = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recvSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOfPacketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetAnalyzurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl_TransportLayer.SuspendLayout();
            this.tabPage_Tcp.SuspendLayout();
            this.tabPage_Udp.SuspendLayout();
            this.tabPage_ICMP.SuspendLayout();
            this.tabPage_IGMP.SuspendLayout();
            this.tabPage_ICMPv6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl_AppLayer.SuspendLayout();
            this.tabPage_Http.SuspendLayout();
            this.tabPage_DNS.SuspendLayout();
            this.tabPage_NBNS.SuspendLayout();
            this.tabPage_LLMNR.SuspendLayout();
            this.tabPage_DHCP.SuspendLayout();
            this.tabPage_SSDP.SuspendLayout();
            this.tabControl_NetworkLayer.SuspendLayout();
            this.tabPage_IP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_ARP.SuspendLayout();
            this.tabPage_IPV6.SuspendLayout();
            this.tabControl_Linklayer.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_count)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Packets
            // 
            this.listBox_Packets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Packets.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox_Packets.FormattingEnabled = true;
            this.listBox_Packets.HorizontalScrollbar = true;
            this.listBox_Packets.Location = new System.Drawing.Point(6, 21);
            this.listBox_Packets.Name = "listBox_Packets";
            this.listBox_Packets.Size = new System.Drawing.Size(193, 195);
            this.listBox_Packets.TabIndex = 1;
            this.listBox_Packets.SelectedIndexChanged += new System.EventHandler(this.listBox_Packets_SelectedIndexChanged);
            // 
            // checkBox_AutoScroll
            // 
            this.checkBox_AutoScroll.AutoSize = true;
            this.checkBox_AutoScroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBox_AutoScroll.Location = new System.Drawing.Point(3, 3);
            this.checkBox_AutoScroll.Name = "checkBox_AutoScroll";
            this.checkBox_AutoScroll.Size = new System.Drawing.Size(130, 17);
            this.checkBox_AutoScroll.TabIndex = 2;
            this.checkBox_AutoScroll.Text = "AutoScroll(PacketList)";
            this.checkBox_AutoScroll.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tabControl_NetworkLayer, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tabControl_Linklayer, 0, 3);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(224, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.46243F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.53757F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(361, 677);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl_TransportLayer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 213);
            this.panel3.TabIndex = 2;
            // 
            // tabControl_TransportLayer
            // 
            this.tabControl_TransportLayer.Controls.Add(this.tabPage_Tcp);
            this.tabControl_TransportLayer.Controls.Add(this.tabPage_Udp);
            this.tabControl_TransportLayer.Controls.Add(this.tabPage_ICMP);
            this.tabControl_TransportLayer.Controls.Add(this.tabPage_IGMP);
            this.tabControl_TransportLayer.Controls.Add(this.tabPage_ICMPv6);
            this.tabControl_TransportLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_TransportLayer.Location = new System.Drawing.Point(0, 0);
            this.tabControl_TransportLayer.Name = "tabControl_TransportLayer";
            this.tabControl_TransportLayer.SelectedIndex = 0;
            this.tabControl_TransportLayer.Size = new System.Drawing.Size(355, 213);
            this.tabControl_TransportLayer.TabIndex = 1;
            // 
            // tabPage_Tcp
            // 
            this.tabPage_Tcp.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Tcp.Controls.Add(this.label36);
            this.tabPage_Tcp.Controls.Add(this.label37);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_CheckSum);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_UrgentPointer);
            this.tabPage_Tcp.Controls.Add(this.label35);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_WindowSize);
            this.tabPage_Tcp.Controls.Add(this.label34);
            this.tabPage_Tcp.Controls.Add(this.label33);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_cwr);
            this.tabPage_Tcp.Controls.Add(this.label32);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_ecn);
            this.tabPage_Tcp.Controls.Add(this.textBox11);
            this.tabPage_Tcp.Controls.Add(this.label29);
            this.tabPage_Tcp.Controls.Add(this.label30);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_ack);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_psh);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_urg);
            this.tabPage_Tcp.Controls.Add(this.label27);
            this.tabPage_Tcp.Controls.Add(this.label25);
            this.tabPage_Tcp.Controls.Add(this.label28);
            this.tabPage_Tcp.Controls.Add(this.label24);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_syn);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_fin);
            this.tabPage_Tcp.Controls.Add(this.label26);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_rst);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_HeaderLength);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_AcknowledgeNumber);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_unused);
            this.tabPage_Tcp.Controls.Add(this.label23);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_SequencNumber);
            this.tabPage_Tcp.Controls.Add(this.label21);
            this.tabPage_Tcp.Controls.Add(this.label22);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_SourcePort);
            this.tabPage_Tcp.Controls.Add(this.textBox_Tcp_DestinationPort);
            this.tabPage_Tcp.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Tcp.Name = "tabPage_Tcp";
            this.tabPage_Tcp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Tcp.Size = new System.Drawing.Size(347, 187);
            this.tabPage_Tcp.TabIndex = 0;
            this.tabPage_Tcp.Text = "TCP";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label36.Location = new System.Drawing.Point(170, 144);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(72, 13);
            this.label36.TabIndex = 50;
            this.label36.Text = "UrgentPointer";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label37.Location = new System.Drawing.Point(11, 142);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 13);
            this.label37.TabIndex = 49;
            this.label37.Text = "CheckSum";
            // 
            // textBox_Tcp_CheckSum
            // 
            this.textBox_Tcp_CheckSum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_CheckSum.Location = new System.Drawing.Point(10, 157);
            this.textBox_Tcp_CheckSum.Multiline = true;
            this.textBox_Tcp_CheckSum.Name = "textBox_Tcp_CheckSum";
            this.textBox_Tcp_CheckSum.Size = new System.Drawing.Size(154, 18);
            this.textBox_Tcp_CheckSum.TabIndex = 47;
            // 
            // textBox_Tcp_UrgentPointer
            // 
            this.textBox_Tcp_UrgentPointer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_UrgentPointer.Location = new System.Drawing.Point(173, 157);
            this.textBox_Tcp_UrgentPointer.Multiline = true;
            this.textBox_Tcp_UrgentPointer.Name = "textBox_Tcp_UrgentPointer";
            this.textBox_Tcp_UrgentPointer.Size = new System.Drawing.Size(155, 18);
            this.textBox_Tcp_UrgentPointer.TabIndex = 48;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label35.Location = new System.Drawing.Point(277, 109);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(66, 13);
            this.label35.TabIndex = 46;
            this.label35.Text = "WindowSize";
            // 
            // textBox_Tcp_WindowSize
            // 
            this.textBox_Tcp_WindowSize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_WindowSize.Location = new System.Drawing.Point(277, 125);
            this.textBox_Tcp_WindowSize.Multiline = true;
            this.textBox_Tcp_WindowSize.Name = "textBox_Tcp_WindowSize";
            this.textBox_Tcp_WindowSize.Size = new System.Drawing.Size(66, 18);
            this.textBox_Tcp_WindowSize.TabIndex = 45;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(115, 108);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(18, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "fin";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label33.Location = new System.Drawing.Point(168, 109);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 13);
            this.label33.TabIndex = 43;
            this.label33.Text = "psh";
            // 
            // textBox_Tcp_cwr
            // 
            this.textBox_Tcp_cwr.AutoSize = true;
            this.textBox_Tcp_cwr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_Tcp_cwr.Location = new System.Drawing.Point(253, 109);
            this.textBox_Tcp_cwr.Name = "textBox_Tcp_cwr";
            this.textBox_Tcp_cwr.Size = new System.Drawing.Size(24, 13);
            this.textBox_Tcp_cwr.TabIndex = 42;
            this.textBox_Tcp_cwr.Text = "cwr";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label32.Location = new System.Drawing.Point(231, 109);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 13);
            this.label32.TabIndex = 41;
            this.label32.Text = "ecn";
            // 
            // textBox_Tcp_ecn
            // 
            this.textBox_Tcp_ecn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_ecn.Location = new System.Drawing.Point(232, 125);
            this.textBox_Tcp_ecn.Multiline = true;
            this.textBox_Tcp_ecn.Name = "textBox_Tcp_ecn";
            this.textBox_Tcp_ecn.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_ecn.TabIndex = 38;
            // 
            // textBox11
            // 
            this.textBox11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox11.Location = new System.Drawing.Point(255, 125);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(18, 18);
            this.textBox11.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label29.Location = new System.Drawing.Point(211, 109);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 13);
            this.label29.TabIndex = 37;
            this.label29.Text = "urg";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label30.Location = new System.Drawing.Point(190, 109);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 13);
            this.label30.TabIndex = 36;
            this.label30.Text = "ack";
            // 
            // textBox_Tcp_ack
            // 
            this.textBox_Tcp_ack.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_ack.Location = new System.Drawing.Point(192, 125);
            this.textBox_Tcp_ack.Multiline = true;
            this.textBox_Tcp_ack.Name = "textBox_Tcp_ack";
            this.textBox_Tcp_ack.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_ack.TabIndex = 33;
            // 
            // textBox_Tcp_psh
            // 
            this.textBox_Tcp_psh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_psh.Location = new System.Drawing.Point(171, 125);
            this.textBox_Tcp_psh.Multiline = true;
            this.textBox_Tcp_psh.Name = "textBox_Tcp_psh";
            this.textBox_Tcp_psh.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_psh.TabIndex = 34;
            // 
            // textBox_Tcp_urg
            // 
            this.textBox_Tcp_urg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_urg.Location = new System.Drawing.Point(213, 125);
            this.textBox_Tcp_urg.Multiline = true;
            this.textBox_Tcp_urg.Name = "textBox_Tcp_urg";
            this.textBox_Tcp_urg.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_urg.TabIndex = 35;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(150, 109);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(18, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "rst";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(67, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 31;
            this.label25.Text = "UnUsed";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(130, 109);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "syn";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(6, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Acknowledge#";
            // 
            // textBox_Tcp_syn
            // 
            this.textBox_Tcp_syn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_syn.Location = new System.Drawing.Point(132, 124);
            this.textBox_Tcp_syn.Multiline = true;
            this.textBox_Tcp_syn.Name = "textBox_Tcp_syn";
            this.textBox_Tcp_syn.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_syn.TabIndex = 28;
            // 
            // textBox_Tcp_fin
            // 
            this.textBox_Tcp_fin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_fin.Location = new System.Drawing.Point(114, 124);
            this.textBox_Tcp_fin.Multiline = true;
            this.textBox_Tcp_fin.Name = "textBox_Tcp_fin";
            this.textBox_Tcp_fin.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_fin.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(6, 109);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "TCPLength";
            // 
            // textBox_Tcp_rst
            // 
            this.textBox_Tcp_rst.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_rst.Location = new System.Drawing.Point(151, 125);
            this.textBox_Tcp_rst.Multiline = true;
            this.textBox_Tcp_rst.Name = "textBox_Tcp_rst";
            this.textBox_Tcp_rst.Size = new System.Drawing.Size(18, 18);
            this.textBox_Tcp_rst.TabIndex = 30;
            // 
            // textBox_Tcp_HeaderLength
            // 
            this.textBox_Tcp_HeaderLength.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_HeaderLength.Location = new System.Drawing.Point(9, 125);
            this.textBox_Tcp_HeaderLength.Multiline = true;
            this.textBox_Tcp_HeaderLength.Name = "textBox_Tcp_HeaderLength";
            this.textBox_Tcp_HeaderLength.Size = new System.Drawing.Size(39, 18);
            this.textBox_Tcp_HeaderLength.TabIndex = 28;
            // 
            // textBox_Tcp_AcknowledgeNumber
            // 
            this.textBox_Tcp_AcknowledgeNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_AcknowledgeNumber.Location = new System.Drawing.Point(3, 84);
            this.textBox_Tcp_AcknowledgeNumber.Multiline = true;
            this.textBox_Tcp_AcknowledgeNumber.Name = "textBox_Tcp_AcknowledgeNumber";
            this.textBox_Tcp_AcknowledgeNumber.Size = new System.Drawing.Size(266, 18);
            this.textBox_Tcp_AcknowledgeNumber.TabIndex = 23;
            // 
            // textBox_Tcp_unused
            // 
            this.textBox_Tcp_unused.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_unused.Location = new System.Drawing.Point(67, 125);
            this.textBox_Tcp_unused.Multiline = true;
            this.textBox_Tcp_unused.Name = "textBox_Tcp_unused";
            this.textBox_Tcp_unused.Size = new System.Drawing.Size(46, 18);
            this.textBox_Tcp_unused.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(5, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Sequence#";
            // 
            // textBox_Tcp_SequencNumber
            // 
            this.textBox_Tcp_SequencNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_SequencNumber.Location = new System.Drawing.Point(2, 47);
            this.textBox_Tcp_SequencNumber.Multiline = true;
            this.textBox_Tcp_SequencNumber.Name = "textBox_Tcp_SequencNumber";
            this.textBox_Tcp_SequencNumber.Size = new System.Drawing.Size(264, 18);
            this.textBox_Tcp_SequencNumber.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(136, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "DestinationPort";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(6, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "SourcePort";
            // 
            // textBox_Tcp_SourcePort
            // 
            this.textBox_Tcp_SourcePort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_SourcePort.Location = new System.Drawing.Point(3, 16);
            this.textBox_Tcp_SourcePort.Multiline = true;
            this.textBox_Tcp_SourcePort.Name = "textBox_Tcp_SourcePort";
            this.textBox_Tcp_SourcePort.Size = new System.Drawing.Size(115, 18);
            this.textBox_Tcp_SourcePort.TabIndex = 17;
            // 
            // textBox_Tcp_DestinationPort
            // 
            this.textBox_Tcp_DestinationPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Tcp_DestinationPort.Location = new System.Drawing.Point(139, 16);
            this.textBox_Tcp_DestinationPort.Multiline = true;
            this.textBox_Tcp_DestinationPort.Name = "textBox_Tcp_DestinationPort";
            this.textBox_Tcp_DestinationPort.Size = new System.Drawing.Size(130, 18);
            this.textBox_Tcp_DestinationPort.TabIndex = 18;
            // 
            // tabPage_Udp
            // 
            this.tabPage_Udp.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Udp.Controls.Add(this.label39);
            this.tabPage_Udp.Controls.Add(this.label40);
            this.tabPage_Udp.Controls.Add(this.textBox_Udp_length);
            this.tabPage_Udp.Controls.Add(this.textBox_Udp_Checksum);
            this.tabPage_Udp.Controls.Add(this.label31);
            this.tabPage_Udp.Controls.Add(this.label38);
            this.tabPage_Udp.Controls.Add(this.textBox_Udp_SourcePort);
            this.tabPage_Udp.Controls.Add(this.textBox_Udp_DestinationPort);
            this.tabPage_Udp.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Udp.Name = "tabPage_Udp";
            this.tabPage_Udp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Udp.Size = new System.Drawing.Size(347, 187);
            this.tabPage_Udp.TabIndex = 1;
            this.tabPage_Udp.Text = "UDP";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label39.Location = new System.Drawing.Point(157, 88);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(103, 13);
            this.label39.TabIndex = 62;
            this.label39.Text = "Checksum (optional)";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label40.Location = new System.Drawing.Point(12, 88);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(103, 13);
            this.label40.TabIndex = 61;
            this.label40.Text = "UDP Packet Lentgh";
            // 
            // textBox_Udp_length
            // 
            this.textBox_Udp_length.Location = new System.Drawing.Point(9, 101);
            this.textBox_Udp_length.Multiline = true;
            this.textBox_Udp_length.Name = "textBox_Udp_length";
            this.textBox_Udp_length.Size = new System.Drawing.Size(109, 18);
            this.textBox_Udp_length.TabIndex = 59;
            // 
            // textBox_Udp_Checksum
            // 
            this.textBox_Udp_Checksum.Location = new System.Drawing.Point(160, 101);
            this.textBox_Udp_Checksum.Multiline = true;
            this.textBox_Udp_Checksum.Name = "textBox_Udp_Checksum";
            this.textBox_Udp_Checksum.Size = new System.Drawing.Size(100, 18);
            this.textBox_Udp_Checksum.TabIndex = 60;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label31.Location = new System.Drawing.Point(157, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 13);
            this.label31.TabIndex = 58;
            this.label31.Text = "DestinationPort";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label38.Location = new System.Drawing.Point(12, 26);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 13);
            this.label38.TabIndex = 57;
            this.label38.Text = "SourcePort";
            // 
            // textBox_Udp_SourcePort
            // 
            this.textBox_Udp_SourcePort.Location = new System.Drawing.Point(9, 39);
            this.textBox_Udp_SourcePort.Multiline = true;
            this.textBox_Udp_SourcePort.Name = "textBox_Udp_SourcePort";
            this.textBox_Udp_SourcePort.Size = new System.Drawing.Size(109, 18);
            this.textBox_Udp_SourcePort.TabIndex = 55;
            // 
            // textBox_Udp_DestinationPort
            // 
            this.textBox_Udp_DestinationPort.Location = new System.Drawing.Point(160, 39);
            this.textBox_Udp_DestinationPort.Multiline = true;
            this.textBox_Udp_DestinationPort.Name = "textBox_Udp_DestinationPort";
            this.textBox_Udp_DestinationPort.Size = new System.Drawing.Size(100, 18);
            this.textBox_Udp_DestinationPort.TabIndex = 56;
            // 
            // tabPage_ICMP
            // 
            this.tabPage_ICMP.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_ICMP.Controls.Add(this.label44);
            this.tabPage_ICMP.Controls.Add(this.label41);
            this.tabPage_ICMP.Controls.Add(this.label45);
            this.tabPage_ICMP.Controls.Add(this.label42);
            this.tabPage_ICMP.Controls.Add(this.textBox_Icmp_SequenceNumber);
            this.tabPage_ICMP.Controls.Add(this.textBox_Icmp_Checksum);
            this.tabPage_ICMP.Controls.Add(this.textBox_Icmp_Id);
            this.tabPage_ICMP.Controls.Add(this.label43);
            this.tabPage_ICMP.Controls.Add(this.textBox_Icmp_Code);
            this.tabPage_ICMP.Controls.Add(this.textBox_ICMP_Type);
            this.tabPage_ICMP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ICMP.Name = "tabPage_ICMP";
            this.tabPage_ICMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ICMP.Size = new System.Drawing.Size(347, 187);
            this.tabPage_ICMP.TabIndex = 2;
            this.tabPage_ICMP.Text = "ICMP";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label44.Location = new System.Drawing.Point(2, 111);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(96, 13);
            this.label44.TabIndex = 31;
            this.label44.Text = "Sequence Number";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label41.Location = new System.Drawing.Point(197, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 13);
            this.label41.TabIndex = 33;
            this.label41.Text = "CheckSum";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label45.Location = new System.Drawing.Point(2, 62);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(18, 13);
            this.label45.TabIndex = 30;
            this.label45.Text = "ID";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label42.Location = new System.Drawing.Point(110, 17);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 13);
            this.label42.TabIndex = 32;
            this.label42.Text = "Code";
            // 
            // textBox_Icmp_SequenceNumber
            // 
            this.textBox_Icmp_SequenceNumber.Location = new System.Drawing.Point(1, 125);
            this.textBox_Icmp_SequenceNumber.Multiline = true;
            this.textBox_Icmp_SequenceNumber.Name = "textBox_Icmp_SequenceNumber";
            this.textBox_Icmp_SequenceNumber.Size = new System.Drawing.Size(255, 18);
            this.textBox_Icmp_SequenceNumber.TabIndex = 228;
            // 
            // textBox_Icmp_Checksum
            // 
            this.textBox_Icmp_Checksum.Location = new System.Drawing.Point(198, 37);
            this.textBox_Icmp_Checksum.Multiline = true;
            this.textBox_Icmp_Checksum.Name = "textBox_Icmp_Checksum";
            this.textBox_Icmp_Checksum.Size = new System.Drawing.Size(58, 16);
            this.textBox_Icmp_Checksum.TabIndex = 30;
            // 
            // textBox_Icmp_Id
            // 
            this.textBox_Icmp_Id.Location = new System.Drawing.Point(2, 76);
            this.textBox_Icmp_Id.Multiline = true;
            this.textBox_Icmp_Id.Name = "textBox_Icmp_Id";
            this.textBox_Icmp_Id.Size = new System.Drawing.Size(254, 19);
            this.textBox_Icmp_Id.TabIndex = 29;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label43.Location = new System.Drawing.Point(7, 17);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(94, 13);
            this.label43.TabIndex = 31;
            this.label43.Text = "Type OF Message";
            // 
            // textBox_Icmp_Code
            // 
            this.textBox_Icmp_Code.Location = new System.Drawing.Point(112, 37);
            this.textBox_Icmp_Code.Multiline = true;
            this.textBox_Icmp_Code.Name = "textBox_Icmp_Code";
            this.textBox_Icmp_Code.Size = new System.Drawing.Size(58, 16);
            this.textBox_Icmp_Code.TabIndex = 29;
            // 
            // textBox_ICMP_Type
            // 
            this.textBox_ICMP_Type.Location = new System.Drawing.Point(6, 37);
            this.textBox_ICMP_Type.Multiline = true;
            this.textBox_ICMP_Type.Name = "textBox_ICMP_Type";
            this.textBox_ICMP_Type.Size = new System.Drawing.Size(63, 16);
            this.textBox_ICMP_Type.TabIndex = 28;
            // 
            // tabPage_IGMP
            // 
            this.tabPage_IGMP.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_IGMP.Controls.Add(this.label1);
            this.tabPage_IGMP.Controls.Add(this.label2);
            this.tabPage_IGMP.Controls.Add(this.textBox_IGMP_maxResponse);
            this.tabPage_IGMP.Controls.Add(this.textBox_IGMP_multicastaddress);
            this.tabPage_IGMP.Controls.Add(this.label3);
            this.tabPage_IGMP.Controls.Add(this.label4);
            this.tabPage_IGMP.Controls.Add(this.textBox_IGMP_type);
            this.tabPage_IGMP.Controls.Add(this.textBox_IGMP_checksum);
            this.tabPage_IGMP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_IGMP.Name = "tabPage_IGMP";
            this.tabPage_IGMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_IGMP.Size = new System.Drawing.Size(347, 187);
            this.tabPage_IGMP.TabIndex = 3;
            this.tabPage_IGMP.Text = "IGMPv2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(167, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Multicast Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Checksum";
            // 
            // textBox_IGMP_maxResponse
            // 
            this.textBox_IGMP_maxResponse.Location = new System.Drawing.Point(170, 39);
            this.textBox_IGMP_maxResponse.Multiline = true;
            this.textBox_IGMP_maxResponse.Name = "textBox_IGMP_maxResponse";
            this.textBox_IGMP_maxResponse.Size = new System.Drawing.Size(115, 18);
            this.textBox_IGMP_maxResponse.TabIndex = 67;
            // 
            // textBox_IGMP_multicastaddress
            // 
            this.textBox_IGMP_multicastaddress.Location = new System.Drawing.Point(170, 98);
            this.textBox_IGMP_multicastaddress.Multiline = true;
            this.textBox_IGMP_multicastaddress.Name = "textBox_IGMP_multicastaddress";
            this.textBox_IGMP_multicastaddress.Size = new System.Drawing.Size(116, 18);
            this.textBox_IGMP_multicastaddress.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(167, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Maximum Response Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Type";
            // 
            // textBox_IGMP_type
            // 
            this.textBox_IGMP_type.Location = new System.Drawing.Point(6, 36);
            this.textBox_IGMP_type.Multiline = true;
            this.textBox_IGMP_type.Name = "textBox_IGMP_type";
            this.textBox_IGMP_type.Size = new System.Drawing.Size(115, 18);
            this.textBox_IGMP_type.TabIndex = 63;
            // 
            // textBox_IGMP_checksum
            // 
            this.textBox_IGMP_checksum.Location = new System.Drawing.Point(6, 101);
            this.textBox_IGMP_checksum.Multiline = true;
            this.textBox_IGMP_checksum.Name = "textBox_IGMP_checksum";
            this.textBox_IGMP_checksum.Size = new System.Drawing.Size(116, 18);
            this.textBox_IGMP_checksum.TabIndex = 64;
            // 
            // tabPage_ICMPv6
            // 
            this.tabPage_ICMPv6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_ICMPv6.Controls.Add(this.textBox_ICMPv6_checksum);
            this.tabPage_ICMPv6.Controls.Add(this.label103);
            this.tabPage_ICMPv6.Controls.Add(this.textBox_ICMPv6_type);
            this.tabPage_ICMPv6.Controls.Add(this.textBox_ICMPv6_code);
            this.tabPage_ICMPv6.Controls.Add(this.label104);
            this.tabPage_ICMPv6.Controls.Add(this.label105);
            this.tabPage_ICMPv6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_ICMPv6.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ICMPv6.Name = "tabPage_ICMPv6";
            this.tabPage_ICMPv6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ICMPv6.Size = new System.Drawing.Size(347, 187);
            this.tabPage_ICMPv6.TabIndex = 4;
            this.tabPage_ICMPv6.Text = "ICMPv6";
            // 
            // textBox_ICMPv6_checksum
            // 
            this.textBox_ICMPv6_checksum.Location = new System.Drawing.Point(6, 130);
            this.textBox_ICMPv6_checksum.Multiline = true;
            this.textBox_ICMPv6_checksum.Name = "textBox_ICMPv6_checksum";
            this.textBox_ICMPv6_checksum.Size = new System.Drawing.Size(79, 18);
            this.textBox_ICMPv6_checksum.TabIndex = 94;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label103.Location = new System.Drawing.Point(4, 67);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(32, 13);
            this.label103.TabIndex = 99;
            this.label103.Text = "Code";
            // 
            // textBox_ICMPv6_type
            // 
            this.textBox_ICMPv6_type.Location = new System.Drawing.Point(5, 25);
            this.textBox_ICMPv6_type.Multiline = true;
            this.textBox_ICMPv6_type.Name = "textBox_ICMPv6_type";
            this.textBox_ICMPv6_type.Size = new System.Drawing.Size(70, 18);
            this.textBox_ICMPv6_type.TabIndex = 93;
            // 
            // textBox_ICMPv6_code
            // 
            this.textBox_ICMPv6_code.Location = new System.Drawing.Point(5, 80);
            this.textBox_ICMPv6_code.Multiline = true;
            this.textBox_ICMPv6_code.Name = "textBox_ICMPv6_code";
            this.textBox_ICMPv6_code.Size = new System.Drawing.Size(70, 18);
            this.textBox_ICMPv6_code.TabIndex = 97;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label104.Location = new System.Drawing.Point(8, 12);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(31, 13);
            this.label104.TabIndex = 95;
            this.label104.Text = "Type";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label105.Location = new System.Drawing.Point(5, 117);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(57, 13);
            this.label105.TabIndex = 96;
            this.label105.Text = "Checksum";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl_AppLayer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 142);
            this.panel4.TabIndex = 3;
            // 
            // tabControl_AppLayer
            // 
            this.tabControl_AppLayer.Controls.Add(this.tabPage_Http);
            this.tabControl_AppLayer.Controls.Add(this.tabPage_DNS);
            this.tabControl_AppLayer.Controls.Add(this.tabPage_NBNS);
            this.tabControl_AppLayer.Controls.Add(this.tabPage_LLMNR);
            this.tabControl_AppLayer.Controls.Add(this.tabPage_DHCP);
            this.tabControl_AppLayer.Controls.Add(this.tabPage_SSDP);
            this.tabControl_AppLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_AppLayer.Location = new System.Drawing.Point(0, 0);
            this.tabControl_AppLayer.Name = "tabControl_AppLayer";
            this.tabControl_AppLayer.SelectedIndex = 0;
            this.tabControl_AppLayer.Size = new System.Drawing.Size(355, 142);
            this.tabControl_AppLayer.TabIndex = 0;
            // 
            // tabPage_Http
            // 
            this.tabPage_Http.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Http.Controls.Add(this.textBox_HTTP);
            this.tabPage_Http.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Http.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Http.Name = "tabPage_Http";
            this.tabPage_Http.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Http.Size = new System.Drawing.Size(347, 116);
            this.tabPage_Http.TabIndex = 0;
            this.tabPage_Http.Text = "HTTP";
            // 
            // textBox_HTTP
            // 
            this.textBox_HTTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_HTTP.ForeColor = System.Drawing.Color.Blue;
            this.textBox_HTTP.Location = new System.Drawing.Point(3, 3);
            this.textBox_HTTP.Multiline = true;
            this.textBox_HTTP.Name = "textBox_HTTP";
            this.textBox_HTTP.Size = new System.Drawing.Size(341, 110);
            this.textBox_HTTP.TabIndex = 0;
            // 
            // tabPage_DNS
            // 
            this.tabPage_DNS.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_DNS.Controls.Add(this.label67);
            this.tabPage_DNS.Controls.Add(this.textBox_Dns_TransactionID);
            this.tabPage_DNS.Controls.Add(this.label56);
            this.tabPage_DNS.Controls.Add(this.label65);
            this.tabPage_DNS.Controls.Add(this.label66);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_Unused);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_ra);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_rcode);
            this.tabPage_DNS.Controls.Add(this.label60);
            this.tabPage_DNS.Controls.Add(this.label61);
            this.tabPage_DNS.Controls.Add(this.label62);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_Opcode);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_Qr);
            this.tabPage_DNS.Controls.Add(this.label63);
            this.tabPage_DNS.Controls.Add(this.label64);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_TC);
            this.tabPage_DNS.Controls.Add(this.textBox_DNS_AA);
            this.tabPage_DNS.Controls.Add(this.textBox_Dns_Rd);
            this.tabPage_DNS.Controls.Add(this.label58);
            this.tabPage_DNS.Controls.Add(this.textBox_Dns_Additionals);
            this.tabPage_DNS.Controls.Add(this.label59);
            this.tabPage_DNS.Controls.Add(this.textBox_Dns_answers);
            this.tabPage_DNS.Controls.Add(this.label55);
            this.tabPage_DNS.Controls.Add(this.textBox_Dns_Authority);
            this.tabPage_DNS.Controls.Add(this.label57);
            this.tabPage_DNS.Controls.Add(this.textBox_Dns_Questions);
            this.tabPage_DNS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DNS.Name = "tabPage_DNS";
            this.tabPage_DNS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DNS.Size = new System.Drawing.Size(347, 116);
            this.tabPage_DNS.TabIndex = 1;
            this.tabPage_DNS.Text = "DNS";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label67.Location = new System.Drawing.Point(1, 5);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(126, 13);
            this.label67.TabIndex = 78;
            this.label67.Text = "Transaction Identification";
            // 
            // textBox_Dns_TransactionID
            // 
            this.textBox_Dns_TransactionID.Location = new System.Drawing.Point(6, 20);
            this.textBox_Dns_TransactionID.Multiline = true;
            this.textBox_Dns_TransactionID.Name = "textBox_Dns_TransactionID";
            this.textBox_Dns_TransactionID.Size = new System.Drawing.Size(75, 18);
            this.textBox_Dns_TransactionID.TabIndex = 77;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label56.Location = new System.Drawing.Point(294, 42);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(39, 13);
            this.label56.TabIndex = 76;
            this.label56.Text = "Rcode";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label65.Location = new System.Drawing.Point(251, 40);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(22, 13);
            this.label65.TabIndex = 75;
            this.label65.Text = "RA";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label66.Location = new System.Drawing.Point(294, 76);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(46, 13);
            this.label66.TabIndex = 74;
            this.label66.Text = "UnUsed";
            // 
            // textBox_DNS_Unused
            // 
            this.textBox_DNS_Unused.Location = new System.Drawing.Point(297, 92);
            this.textBox_DNS_Unused.Multiline = true;
            this.textBox_DNS_Unused.Name = "textBox_DNS_Unused";
            this.textBox_DNS_Unused.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_Unused.TabIndex = 71;
            // 
            // textBox_DNS_ra
            // 
            this.textBox_DNS_ra.Location = new System.Drawing.Point(254, 56);
            this.textBox_DNS_ra.Multiline = true;
            this.textBox_DNS_ra.Name = "textBox_DNS_ra";
            this.textBox_DNS_ra.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_ra.TabIndex = 73;
            // 
            // textBox_DNS_rcode
            // 
            this.textBox_DNS_rcode.Location = new System.Drawing.Point(297, 58);
            this.textBox_DNS_rcode.Multiline = true;
            this.textBox_DNS_rcode.Name = "textBox_DNS_rcode";
            this.textBox_DNS_rcode.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_rcode.TabIndex = 72;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label60.Location = new System.Drawing.Point(223, 42);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(23, 13);
            this.label60.TabIndex = 70;
            this.label60.Text = "RD";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label61.Location = new System.Drawing.Point(252, 77);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(23, 13);
            this.label61.TabIndex = 69;
            this.label61.Text = "QR";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label62.Location = new System.Drawing.Point(294, 4);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(46, 13);
            this.label62.TabIndex = 68;
            this.label62.Text = "OpCode";
            // 
            // textBox_DNS_Opcode
            // 
            this.textBox_DNS_Opcode.Location = new System.Drawing.Point(298, 20);
            this.textBox_DNS_Opcode.Multiline = true;
            this.textBox_DNS_Opcode.Name = "textBox_DNS_Opcode";
            this.textBox_DNS_Opcode.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_Opcode.TabIndex = 66;
            // 
            // textBox_DNS_Qr
            // 
            this.textBox_DNS_Qr.Location = new System.Drawing.Point(254, 91);
            this.textBox_DNS_Qr.Multiline = true;
            this.textBox_DNS_Qr.Name = "textBox_DNS_Qr";
            this.textBox_DNS_Qr.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_Qr.TabIndex = 67;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label63.Location = new System.Drawing.Point(254, 4);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(21, 13);
            this.label63.TabIndex = 65;
            this.label63.Text = "AA";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label64.Location = new System.Drawing.Point(224, 4);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(21, 13);
            this.label64.TabIndex = 64;
            this.label64.Text = "TC";
            // 
            // textBox_DNS_TC
            // 
            this.textBox_DNS_TC.Location = new System.Drawing.Point(224, 20);
            this.textBox_DNS_TC.Multiline = true;
            this.textBox_DNS_TC.Name = "textBox_DNS_TC";
            this.textBox_DNS_TC.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_TC.TabIndex = 61;
            // 
            // textBox_DNS_AA
            // 
            this.textBox_DNS_AA.Location = new System.Drawing.Point(255, 20);
            this.textBox_DNS_AA.Multiline = true;
            this.textBox_DNS_AA.Name = "textBox_DNS_AA";
            this.textBox_DNS_AA.Size = new System.Drawing.Size(18, 18);
            this.textBox_DNS_AA.TabIndex = 63;
            // 
            // textBox_Dns_Rd
            // 
            this.textBox_Dns_Rd.Location = new System.Drawing.Point(224, 56);
            this.textBox_Dns_Rd.Multiline = true;
            this.textBox_Dns_Rd.Name = "textBox_Dns_Rd";
            this.textBox_Dns_Rd.Size = new System.Drawing.Size(18, 18);
            this.textBox_Dns_Rd.TabIndex = 62;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label58.Location = new System.Drawing.Point(110, 77);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(109, 13);
            this.label58.TabIndex = 32;
            this.label58.Text = "NumberOfAddtitionals";
            // 
            // textBox_Dns_Additionals
            // 
            this.textBox_Dns_Additionals.Location = new System.Drawing.Point(114, 90);
            this.textBox_Dns_Additionals.Multiline = true;
            this.textBox_Dns_Additionals.Name = "textBox_Dns_Additionals";
            this.textBox_Dns_Additionals.Size = new System.Drawing.Size(75, 18);
            this.textBox_Dns_Additionals.TabIndex = 31;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label59.Location = new System.Drawing.Point(110, 45);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(113, 13);
            this.label59.TabIndex = 30;
            this.label59.Text = "NumberOfAnswerRRS";
            // 
            // textBox_Dns_answers
            // 
            this.textBox_Dns_answers.Location = new System.Drawing.Point(114, 58);
            this.textBox_Dns_answers.Multiline = true;
            this.textBox_Dns_answers.Name = "textBox_Dns_answers";
            this.textBox_Dns_answers.Size = new System.Drawing.Size(75, 18);
            this.textBox_Dns_answers.TabIndex = 29;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label55.Location = new System.Drawing.Point(4, 77);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(96, 13);
            this.label55.TabIndex = 28;
            this.label55.Text = "NumberOfAuthority";
            // 
            // textBox_Dns_Authority
            // 
            this.textBox_Dns_Authority.Location = new System.Drawing.Point(7, 90);
            this.textBox_Dns_Authority.Multiline = true;
            this.textBox_Dns_Authority.Name = "textBox_Dns_Authority";
            this.textBox_Dns_Authority.Size = new System.Drawing.Size(69, 18);
            this.textBox_Dns_Authority.TabIndex = 27;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label57.Location = new System.Drawing.Point(2, 45);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(102, 13);
            this.label57.TabIndex = 25;
            this.label57.Text = "NumberOfQuestions";
            // 
            // textBox_Dns_Questions
            // 
            this.textBox_Dns_Questions.Location = new System.Drawing.Point(5, 58);
            this.textBox_Dns_Questions.Multiline = true;
            this.textBox_Dns_Questions.Name = "textBox_Dns_Questions";
            this.textBox_Dns_Questions.Size = new System.Drawing.Size(75, 18);
            this.textBox_Dns_Questions.TabIndex = 23;
            // 
            // tabPage_NBNS
            // 
            this.tabPage_NBNS.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_NBNS.Controls.Add(this.label81);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_BD);
            this.tabPage_NBNS.Controls.Add(this.label68);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_transactionID);
            this.tabPage_NBNS.Controls.Add(this.label69);
            this.tabPage_NBNS.Controls.Add(this.label70);
            this.tabPage_NBNS.Controls.Add(this.label71);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_unused);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_ra);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_rcode);
            this.tabPage_NBNS.Controls.Add(this.label72);
            this.tabPage_NBNS.Controls.Add(this.label73);
            this.tabPage_NBNS.Controls.Add(this.label74);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_opcode);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_QR);
            this.tabPage_NBNS.Controls.Add(this.label75);
            this.tabPage_NBNS.Controls.Add(this.label76);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_tc);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_aa);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_rd);
            this.tabPage_NBNS.Controls.Add(this.label77);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_addtional);
            this.tabPage_NBNS.Controls.Add(this.label78);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_answer);
            this.tabPage_NBNS.Controls.Add(this.label79);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_authority);
            this.tabPage_NBNS.Controls.Add(this.label80);
            this.tabPage_NBNS.Controls.Add(this.textBox_NBNS_questions);
            this.tabPage_NBNS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NBNS.Name = "tabPage_NBNS";
            this.tabPage_NBNS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NBNS.Size = new System.Drawing.Size(347, 116);
            this.tabPage_NBNS.TabIndex = 2;
            this.tabPage_NBNS.Text = "NBNS";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label81.Location = new System.Drawing.Point(187, 2);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(110, 13);
            this.label81.TabIndex = 106;
            this.label81.Text = "BroadCastPacketFlag";
            // 
            // textBox_NBNS_BD
            // 
            this.textBox_NBNS_BD.Location = new System.Drawing.Point(238, 15);
            this.textBox_NBNS_BD.Multiline = true;
            this.textBox_NBNS_BD.Name = "textBox_NBNS_BD";
            this.textBox_NBNS_BD.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_BD.TabIndex = 105;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label68.Location = new System.Drawing.Point(0, 2);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(126, 13);
            this.label68.TabIndex = 104;
            this.label68.Text = "Transaction Identification";
            // 
            // textBox_NBNS_transactionID
            // 
            this.textBox_NBNS_transactionID.Location = new System.Drawing.Point(5, 15);
            this.textBox_NBNS_transactionID.Multiline = true;
            this.textBox_NBNS_transactionID.Name = "textBox_NBNS_transactionID";
            this.textBox_NBNS_transactionID.Size = new System.Drawing.Size(75, 18);
            this.textBox_NBNS_transactionID.TabIndex = 103;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label69.Location = new System.Drawing.Point(265, 75);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(39, 13);
            this.label69.TabIndex = 102;
            this.label69.Text = "Rcode";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label70.Location = new System.Drawing.Point(237, 77);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(22, 13);
            this.label70.TabIndex = 101;
            this.label70.Text = "RA";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label71.Location = new System.Drawing.Point(302, 75);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(46, 13);
            this.label71.TabIndex = 100;
            this.label71.Text = "UnUsed";
            // 
            // textBox_NBNS_unused
            // 
            this.textBox_NBNS_unused.Location = new System.Drawing.Point(305, 91);
            this.textBox_NBNS_unused.Multiline = true;
            this.textBox_NBNS_unused.Name = "textBox_NBNS_unused";
            this.textBox_NBNS_unused.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_unused.TabIndex = 97;
            // 
            // textBox_NBNS_ra
            // 
            this.textBox_NBNS_ra.Location = new System.Drawing.Point(240, 93);
            this.textBox_NBNS_ra.Multiline = true;
            this.textBox_NBNS_ra.Name = "textBox_NBNS_ra";
            this.textBox_NBNS_ra.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_ra.TabIndex = 99;
            // 
            // textBox_NBNS_rcode
            // 
            this.textBox_NBNS_rcode.Location = new System.Drawing.Point(270, 92);
            this.textBox_NBNS_rcode.Multiline = true;
            this.textBox_NBNS_rcode.Name = "textBox_NBNS_rcode";
            this.textBox_NBNS_rcode.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_rcode.TabIndex = 98;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label72.Location = new System.Drawing.Point(237, 41);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(23, 13);
            this.label72.TabIndex = 96;
            this.label72.Text = "RD";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label73.Location = new System.Drawing.Point(304, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(23, 13);
            this.label73.TabIndex = 95;
            this.label73.Text = "QR";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label74.Location = new System.Drawing.Point(303, 41);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(46, 13);
            this.label74.TabIndex = 94;
            this.label74.Text = "OpCode";
            // 
            // textBox_NBNS_opcode
            // 
            this.textBox_NBNS_opcode.Location = new System.Drawing.Point(305, 57);
            this.textBox_NBNS_opcode.Multiline = true;
            this.textBox_NBNS_opcode.Name = "textBox_NBNS_opcode";
            this.textBox_NBNS_opcode.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_opcode.TabIndex = 92;
            // 
            // textBox_NBNS_QR
            // 
            this.textBox_NBNS_QR.Location = new System.Drawing.Point(305, 15);
            this.textBox_NBNS_QR.Multiline = true;
            this.textBox_NBNS_QR.Name = "textBox_NBNS_QR";
            this.textBox_NBNS_QR.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_QR.TabIndex = 93;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label75.Location = new System.Drawing.Point(280, 41);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(21, 13);
            this.label75.TabIndex = 91;
            this.label75.Text = "AA";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label76.Location = new System.Drawing.Point(260, 41);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(21, 13);
            this.label76.TabIndex = 90;
            this.label76.Text = "TC";
            // 
            // textBox_NBNS_tc
            // 
            this.textBox_NBNS_tc.Location = new System.Drawing.Point(260, 57);
            this.textBox_NBNS_tc.Multiline = true;
            this.textBox_NBNS_tc.Name = "textBox_NBNS_tc";
            this.textBox_NBNS_tc.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_tc.TabIndex = 87;
            // 
            // textBox_NBNS_aa
            // 
            this.textBox_NBNS_aa.Location = new System.Drawing.Point(283, 57);
            this.textBox_NBNS_aa.Multiline = true;
            this.textBox_NBNS_aa.Name = "textBox_NBNS_aa";
            this.textBox_NBNS_aa.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_aa.TabIndex = 89;
            // 
            // textBox_NBNS_rd
            // 
            this.textBox_NBNS_rd.Location = new System.Drawing.Point(238, 57);
            this.textBox_NBNS_rd.Multiline = true;
            this.textBox_NBNS_rd.Name = "textBox_NBNS_rd";
            this.textBox_NBNS_rd.Size = new System.Drawing.Size(18, 18);
            this.textBox_NBNS_rd.TabIndex = 88;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label77.Location = new System.Drawing.Point(102, 78);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(109, 13);
            this.label77.TabIndex = 86;
            this.label77.Text = "NumberOfAddtitionals";
            // 
            // textBox_NBNS_addtional
            // 
            this.textBox_NBNS_addtional.Location = new System.Drawing.Point(106, 91);
            this.textBox_NBNS_addtional.Multiline = true;
            this.textBox_NBNS_addtional.Name = "textBox_NBNS_addtional";
            this.textBox_NBNS_addtional.Size = new System.Drawing.Size(74, 18);
            this.textBox_NBNS_addtional.TabIndex = 85;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label78.Location = new System.Drawing.Point(104, 44);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(113, 13);
            this.label78.TabIndex = 84;
            this.label78.Text = "NumberOfAnswerRRS";
            // 
            // textBox_NBNS_answer
            // 
            this.textBox_NBNS_answer.Location = new System.Drawing.Point(105, 57);
            this.textBox_NBNS_answer.Multiline = true;
            this.textBox_NBNS_answer.Name = "textBox_NBNS_answer";
            this.textBox_NBNS_answer.Size = new System.Drawing.Size(75, 18);
            this.textBox_NBNS_answer.TabIndex = 83;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label79.Location = new System.Drawing.Point(3, 78);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(96, 13);
            this.label79.TabIndex = 82;
            this.label79.Text = "NumberOfAuthority";
            // 
            // textBox_NBNS_authority
            // 
            this.textBox_NBNS_authority.Location = new System.Drawing.Point(6, 91);
            this.textBox_NBNS_authority.Multiline = true;
            this.textBox_NBNS_authority.Name = "textBox_NBNS_authority";
            this.textBox_NBNS_authority.Size = new System.Drawing.Size(69, 18);
            this.textBox_NBNS_authority.TabIndex = 81;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label80.Location = new System.Drawing.Point(1, 44);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(102, 13);
            this.label80.TabIndex = 80;
            this.label80.Text = "NumberOfQuestions";
            // 
            // textBox_NBNS_questions
            // 
            this.textBox_NBNS_questions.Location = new System.Drawing.Point(4, 57);
            this.textBox_NBNS_questions.Multiline = true;
            this.textBox_NBNS_questions.Name = "textBox_NBNS_questions";
            this.textBox_NBNS_questions.Size = new System.Drawing.Size(75, 18);
            this.textBox_NBNS_questions.TabIndex = 79;
            // 
            // tabPage_LLMNR
            // 
            this.tabPage_LLMNR.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_LLMNR.Controls.Add(this.label82);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_Transaction);
            this.tabPage_LLMNR.Controls.Add(this.label83);
            this.tabPage_LLMNR.Controls.Add(this.label85);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_unused);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_rcode);
            this.tabPage_LLMNR.Controls.Add(this.label86);
            this.tabPage_LLMNR.Controls.Add(this.label87);
            this.tabPage_LLMNR.Controls.Add(this.label88);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_opcode);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_QR);
            this.tabPage_LLMNR.Controls.Add(this.label89);
            this.tabPage_LLMNR.Controls.Add(this.label90);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_TC);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_C);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_T);
            this.tabPage_LLMNR.Controls.Add(this.label91);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_additional);
            this.tabPage_LLMNR.Controls.Add(this.label92);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_answer);
            this.tabPage_LLMNR.Controls.Add(this.label93);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_authority);
            this.tabPage_LLMNR.Controls.Add(this.label94);
            this.tabPage_LLMNR.Controls.Add(this.textBox_LLMNR_questions);
            this.tabPage_LLMNR.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LLMNR.Name = "tabPage_LLMNR";
            this.tabPage_LLMNR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LLMNR.Size = new System.Drawing.Size(347, 116);
            this.tabPage_LLMNR.TabIndex = 3;
            this.tabPage_LLMNR.Text = "LLMNR";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label82.Location = new System.Drawing.Point(-1, 6);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(126, 13);
            this.label82.TabIndex = 104;
            this.label82.Text = "Transaction Identification";
            // 
            // textBox_LLMNR_Transaction
            // 
            this.textBox_LLMNR_Transaction.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_Transaction.Location = new System.Drawing.Point(4, 21);
            this.textBox_LLMNR_Transaction.Multiline = true;
            this.textBox_LLMNR_Transaction.Name = "textBox_LLMNR_Transaction";
            this.textBox_LLMNR_Transaction.Size = new System.Drawing.Size(75, 18);
            this.textBox_LLMNR_Transaction.TabIndex = 103;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label83.Location = new System.Drawing.Point(304, 1);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(39, 13);
            this.label83.TabIndex = 102;
            this.label83.Text = "Rcode";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label85.Location = new System.Drawing.Point(304, 78);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(46, 13);
            this.label85.TabIndex = 100;
            this.label85.Text = "UnUsed";
            // 
            // textBox_LLMNR_unused
            // 
            this.textBox_LLMNR_unused.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_unused.Location = new System.Drawing.Point(307, 95);
            this.textBox_LLMNR_unused.Multiline = true;
            this.textBox_LLMNR_unused.Name = "textBox_LLMNR_unused";
            this.textBox_LLMNR_unused.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_unused.TabIndex = 97;
            // 
            // textBox_LLMNR_rcode
            // 
            this.textBox_LLMNR_rcode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_rcode.Location = new System.Drawing.Point(307, 18);
            this.textBox_LLMNR_rcode.Multiline = true;
            this.textBox_LLMNR_rcode.Name = "textBox_LLMNR_rcode";
            this.textBox_LLMNR_rcode.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_rcode.TabIndex = 98;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label86.Location = new System.Drawing.Point(223, 76);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(14, 13);
            this.label86.TabIndex = 96;
            this.label86.Text = "T";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label87.Location = new System.Drawing.Point(306, 40);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(23, 13);
            this.label87.TabIndex = 95;
            this.label87.Text = "QR";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label88.Location = new System.Drawing.Point(252, 78);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(46, 13);
            this.label88.TabIndex = 94;
            this.label88.Text = "OpCode";
            // 
            // textBox_LLMNR_opcode
            // 
            this.textBox_LLMNR_opcode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_opcode.Location = new System.Drawing.Point(258, 94);
            this.textBox_LLMNR_opcode.Multiline = true;
            this.textBox_LLMNR_opcode.Name = "textBox_LLMNR_opcode";
            this.textBox_LLMNR_opcode.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_opcode.TabIndex = 92;
            // 
            // textBox_LLMNR_QR
            // 
            this.textBox_LLMNR_QR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_QR.Location = new System.Drawing.Point(308, 56);
            this.textBox_LLMNR_QR.Multiline = true;
            this.textBox_LLMNR_QR.Name = "textBox_LLMNR_QR";
            this.textBox_LLMNR_QR.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_QR.TabIndex = 93;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label89.Location = new System.Drawing.Point(256, 41);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(14, 13);
            this.label89.TabIndex = 91;
            this.label89.Text = "C";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label90.Location = new System.Drawing.Point(255, 2);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(21, 13);
            this.label90.TabIndex = 90;
            this.label90.Text = "TC";
            // 
            // textBox_LLMNR_TC
            // 
            this.textBox_LLMNR_TC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_TC.Location = new System.Drawing.Point(255, 18);
            this.textBox_LLMNR_TC.Multiline = true;
            this.textBox_LLMNR_TC.Name = "textBox_LLMNR_TC";
            this.textBox_LLMNR_TC.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_TC.TabIndex = 87;
            // 
            // textBox_LLMNR_C
            // 
            this.textBox_LLMNR_C.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_C.Location = new System.Drawing.Point(255, 57);
            this.textBox_LLMNR_C.Multiline = true;
            this.textBox_LLMNR_C.Name = "textBox_LLMNR_C";
            this.textBox_LLMNR_C.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_C.TabIndex = 89;
            // 
            // textBox_LLMNR_T
            // 
            this.textBox_LLMNR_T.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_T.Location = new System.Drawing.Point(224, 92);
            this.textBox_LLMNR_T.Multiline = true;
            this.textBox_LLMNR_T.Name = "textBox_LLMNR_T";
            this.textBox_LLMNR_T.Size = new System.Drawing.Size(18, 18);
            this.textBox_LLMNR_T.TabIndex = 88;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label91.Location = new System.Drawing.Point(107, 77);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(109, 13);
            this.label91.TabIndex = 86;
            this.label91.Text = "NumberOfAddtitionals";
            // 
            // textBox_LLMNR_additional
            // 
            this.textBox_LLMNR_additional.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_additional.Location = new System.Drawing.Point(109, 90);
            this.textBox_LLMNR_additional.Multiline = true;
            this.textBox_LLMNR_additional.Name = "textBox_LLMNR_additional";
            this.textBox_LLMNR_additional.Size = new System.Drawing.Size(69, 18);
            this.textBox_LLMNR_additional.TabIndex = 85;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label92.Location = new System.Drawing.Point(106, 39);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(113, 13);
            this.label92.TabIndex = 84;
            this.label92.Text = "NumberOfAnswerRRS";
            // 
            // textBox_LLMNR_answer
            // 
            this.textBox_LLMNR_answer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_answer.Location = new System.Drawing.Point(109, 56);
            this.textBox_LLMNR_answer.Multiline = true;
            this.textBox_LLMNR_answer.Name = "textBox_LLMNR_answer";
            this.textBox_LLMNR_answer.Size = new System.Drawing.Size(75, 18);
            this.textBox_LLMNR_answer.TabIndex = 83;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label93.Location = new System.Drawing.Point(2, 77);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(96, 13);
            this.label93.TabIndex = 82;
            this.label93.Text = "NumberOfAuthority";
            // 
            // textBox_LLMNR_authority
            // 
            this.textBox_LLMNR_authority.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_authority.Location = new System.Drawing.Point(5, 90);
            this.textBox_LLMNR_authority.Multiline = true;
            this.textBox_LLMNR_authority.Name = "textBox_LLMNR_authority";
            this.textBox_LLMNR_authority.Size = new System.Drawing.Size(69, 18);
            this.textBox_LLMNR_authority.TabIndex = 81;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label94.Location = new System.Drawing.Point(0, 40);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(102, 13);
            this.label94.TabIndex = 80;
            this.label94.Text = "NumberOfQuestions";
            // 
            // textBox_LLMNR_questions
            // 
            this.textBox_LLMNR_questions.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_LLMNR_questions.Location = new System.Drawing.Point(3, 53);
            this.textBox_LLMNR_questions.Multiline = true;
            this.textBox_LLMNR_questions.Name = "textBox_LLMNR_questions";
            this.textBox_LLMNR_questions.Size = new System.Drawing.Size(75, 18);
            this.textBox_LLMNR_questions.TabIndex = 79;
            // 
            // tabPage_DHCP
            // 
            this.tabPage_DHCP.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_DHCP.Controls.Add(this.textBox_DHCP);
            this.tabPage_DHCP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DHCP.Name = "tabPage_DHCP";
            this.tabPage_DHCP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DHCP.Size = new System.Drawing.Size(347, 116);
            this.tabPage_DHCP.TabIndex = 4;
            this.tabPage_DHCP.Text = "DHCP";
            // 
            // textBox_DHCP
            // 
            this.textBox_DHCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_DHCP.ForeColor = System.Drawing.Color.Blue;
            this.textBox_DHCP.Location = new System.Drawing.Point(3, 3);
            this.textBox_DHCP.Multiline = true;
            this.textBox_DHCP.Name = "textBox_DHCP";
            this.textBox_DHCP.Size = new System.Drawing.Size(341, 110);
            this.textBox_DHCP.TabIndex = 1;
            // 
            // tabPage_SSDP
            // 
            this.tabPage_SSDP.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_SSDP.Controls.Add(this.textBox_SSDP);
            this.tabPage_SSDP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SSDP.Name = "tabPage_SSDP";
            this.tabPage_SSDP.Size = new System.Drawing.Size(347, 116);
            this.tabPage_SSDP.TabIndex = 5;
            this.tabPage_SSDP.Text = "SSDP";
            // 
            // textBox_SSDP
            // 
            this.textBox_SSDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SSDP.ForeColor = System.Drawing.Color.Blue;
            this.textBox_SSDP.Location = new System.Drawing.Point(0, 0);
            this.textBox_SSDP.Multiline = true;
            this.textBox_SSDP.Name = "textBox_SSDP";
            this.textBox_SSDP.Size = new System.Drawing.Size(347, 116);
            this.textBox_SSDP.TabIndex = 51;
            // 
            // tabControl_NetworkLayer
            // 
            this.tabControl_NetworkLayer.Controls.Add(this.tabPage_IP);
            this.tabControl_NetworkLayer.Controls.Add(this.tabPage_ARP);
            this.tabControl_NetworkLayer.Controls.Add(this.tabPage_IPV6);
            this.tabControl_NetworkLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_NetworkLayer.Location = new System.Drawing.Point(3, 370);
            this.tabControl_NetworkLayer.Name = "tabControl_NetworkLayer";
            this.tabControl_NetworkLayer.SelectedIndex = 0;
            this.tabControl_NetworkLayer.Size = new System.Drawing.Size(355, 212);
            this.tabControl_NetworkLayer.TabIndex = 0;
            // 
            // tabPage_IP
            // 
            this.tabPage_IP.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_IP.Controls.Add(this.panel2);
            this.tabPage_IP.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabPage_IP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_IP.Name = "tabPage_IP";
            this.tabPage_IP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_IP.Size = new System.Drawing.Size(347, 186);
            this.tabPage_IP.TabIndex = 0;
            this.tabPage_IP.Text = "IP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_IP_Dst_Add);
            this.panel2.Controls.Add(this.textBox_IP_HeaderChecksum);
            this.panel2.Controls.Add(this.textBox_IP_Src_Add);
            this.panel2.Controls.Add(this.textBox_IP_Identification);
            this.panel2.Controls.Add(this.textBox_IP_TTL);
            this.panel2.Controls.Add(this.textBox_IP_Protocol);
            this.panel2.Controls.Add(this.textBox_IP_DF);
            this.panel2.Controls.Add(this.textBox_Ip_Version);
            this.panel2.Controls.Add(this.textBox_IP_HeardeLength);
            this.panel2.Controls.Add(this.textBox_IP_MF);
            this.panel2.Controls.Add(this.textBox_Ip_TotalLentgh);
            this.panel2.Controls.Add(this.textBox_Ip_FragemntaionOffset);
            this.panel2.Controls.Add(this.textBox_IP_TypeOfService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 180);
            this.panel2.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label20.Location = new System.Drawing.Point(2, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Destination Ip Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(2, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Source Ip Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(238, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "HeaderCheckSum";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label17.Location = new System.Drawing.Point(135, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Protocol";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(6, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "TTL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(238, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "FragmentOffset";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(206, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "MF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(186, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "DF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(2, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Identification";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(226, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total Length";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(131, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "TypeOfService";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(67, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "IHL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(4, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "IPVersion\r\n";
            // 
            // textBox_IP_Dst_Add
            // 
            this.textBox_IP_Dst_Add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_Dst_Add.Location = new System.Drawing.Point(1, 164);
            this.textBox_IP_Dst_Add.Multiline = true;
            this.textBox_IP_Dst_Add.Name = "textBox_IP_Dst_Add";
            this.textBox_IP_Dst_Add.Size = new System.Drawing.Size(337, 18);
            this.textBox_IP_Dst_Add.TabIndex = 12;
            // 
            // textBox_IP_HeaderChecksum
            // 
            this.textBox_IP_HeaderChecksum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_HeaderChecksum.Location = new System.Drawing.Point(241, 94);
            this.textBox_IP_HeaderChecksum.Multiline = true;
            this.textBox_IP_HeaderChecksum.Name = "textBox_IP_HeaderChecksum";
            this.textBox_IP_HeaderChecksum.Size = new System.Drawing.Size(75, 18);
            this.textBox_IP_HeaderChecksum.TabIndex = 10;
            // 
            // textBox_IP_Src_Add
            // 
            this.textBox_IP_Src_Add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_Src_Add.Location = new System.Drawing.Point(2, 129);
            this.textBox_IP_Src_Add.Multiline = true;
            this.textBox_IP_Src_Add.Name = "textBox_IP_Src_Add";
            this.textBox_IP_Src_Add.Size = new System.Drawing.Size(336, 19);
            this.textBox_IP_Src_Add.TabIndex = 11;
            // 
            // textBox_IP_Identification
            // 
            this.textBox_IP_Identification.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_Identification.Location = new System.Drawing.Point(0, 55);
            this.textBox_IP_Identification.Multiline = true;
            this.textBox_IP_Identification.Name = "textBox_IP_Identification";
            this.textBox_IP_Identification.Size = new System.Drawing.Size(169, 19);
            this.textBox_IP_Identification.TabIndex = 4;
            // 
            // textBox_IP_TTL
            // 
            this.textBox_IP_TTL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_TTL.Location = new System.Drawing.Point(6, 94);
            this.textBox_IP_TTL.Multiline = true;
            this.textBox_IP_TTL.Name = "textBox_IP_TTL";
            this.textBox_IP_TTL.Size = new System.Drawing.Size(122, 19);
            this.textBox_IP_TTL.TabIndex = 8;
            // 
            // textBox_IP_Protocol
            // 
            this.textBox_IP_Protocol.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_Protocol.Location = new System.Drawing.Point(136, 94);
            this.textBox_IP_Protocol.Multiline = true;
            this.textBox_IP_Protocol.Name = "textBox_IP_Protocol";
            this.textBox_IP_Protocol.Size = new System.Drawing.Size(91, 18);
            this.textBox_IP_Protocol.TabIndex = 9;
            // 
            // textBox_IP_DF
            // 
            this.textBox_IP_DF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_DF.Location = new System.Drawing.Point(186, 55);
            this.textBox_IP_DF.Multiline = true;
            this.textBox_IP_DF.Name = "textBox_IP_DF";
            this.textBox_IP_DF.Size = new System.Drawing.Size(18, 20);
            this.textBox_IP_DF.TabIndex = 5;
            // 
            // textBox_Ip_Version
            // 
            this.textBox_Ip_Version.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Ip_Version.Location = new System.Drawing.Point(3, 21);
            this.textBox_Ip_Version.Multiline = true;
            this.textBox_Ip_Version.Name = "textBox_Ip_Version";
            this.textBox_Ip_Version.Size = new System.Drawing.Size(58, 16);
            this.textBox_Ip_Version.TabIndex = 0;
            // 
            // textBox_IP_HeardeLength
            // 
            this.textBox_IP_HeardeLength.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_HeardeLength.Location = new System.Drawing.Point(64, 21);
            this.textBox_IP_HeardeLength.Multiline = true;
            this.textBox_IP_HeardeLength.Name = "textBox_IP_HeardeLength";
            this.textBox_IP_HeardeLength.Size = new System.Drawing.Size(63, 16);
            this.textBox_IP_HeardeLength.TabIndex = 1;
            // 
            // textBox_IP_MF
            // 
            this.textBox_IP_MF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_MF.Location = new System.Drawing.Point(209, 55);
            this.textBox_IP_MF.Multiline = true;
            this.textBox_IP_MF.Name = "textBox_IP_MF";
            this.textBox_IP_MF.Size = new System.Drawing.Size(18, 20);
            this.textBox_IP_MF.TabIndex = 6;
            // 
            // textBox_Ip_TotalLentgh
            // 
            this.textBox_Ip_TotalLentgh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Ip_TotalLentgh.Location = new System.Drawing.Point(223, 21);
            this.textBox_Ip_TotalLentgh.Multiline = true;
            this.textBox_Ip_TotalLentgh.Name = "textBox_Ip_TotalLentgh";
            this.textBox_Ip_TotalLentgh.Size = new System.Drawing.Size(129, 16);
            this.textBox_Ip_TotalLentgh.TabIndex = 3;
            // 
            // textBox_Ip_FragemntaionOffset
            // 
            this.textBox_Ip_FragemntaionOffset.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Ip_FragemntaionOffset.Location = new System.Drawing.Point(241, 56);
            this.textBox_Ip_FragemntaionOffset.Multiline = true;
            this.textBox_Ip_FragemntaionOffset.Name = "textBox_Ip_FragemntaionOffset";
            this.textBox_Ip_FragemntaionOffset.Size = new System.Drawing.Size(97, 19);
            this.textBox_Ip_FragemntaionOffset.TabIndex = 7;
            // 
            // textBox_IP_TypeOfService
            // 
            this.textBox_IP_TypeOfService.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IP_TypeOfService.Location = new System.Drawing.Point(133, 21);
            this.textBox_IP_TypeOfService.Multiline = true;
            this.textBox_IP_TypeOfService.Name = "textBox_IP_TypeOfService";
            this.textBox_IP_TypeOfService.Size = new System.Drawing.Size(73, 16);
            this.textBox_IP_TypeOfService.TabIndex = 2;
            // 
            // tabPage_ARP
            // 
            this.tabPage_ARP.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_DestinationIPAddress);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_DestinationHardwareAddress);
            this.tabPage_ARP.Controls.Add(this.label50);
            this.tabPage_ARP.Controls.Add(this.label51);
            this.tabPage_ARP.Controls.Add(this.label54);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_OperationCode);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_SourceIPAddress);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_SourceHardWareAddress);
            this.tabPage_ARP.Controls.Add(this.label52);
            this.tabPage_ARP.Controls.Add(this.label53);
            this.tabPage_ARP.Controls.Add(this.label46);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_ProtocolType);
            this.tabPage_ARP.Controls.Add(this.label47);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_HardwareType);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_HardwareAddressLength);
            this.tabPage_ARP.Controls.Add(this.label49);
            this.tabPage_ARP.Controls.Add(this.textBox_Arp_ProtocolAddressLength);
            this.tabPage_ARP.Controls.Add(this.label48);
            this.tabPage_ARP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ARP.Name = "tabPage_ARP";
            this.tabPage_ARP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ARP.Size = new System.Drawing.Size(347, 186);
            this.tabPage_ARP.TabIndex = 1;
            this.tabPage_ARP.Text = "ARP";
            // 
            // textBox_Arp_DestinationIPAddress
            // 
            this.textBox_Arp_DestinationIPAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_DestinationIPAddress.Location = new System.Drawing.Point(218, 163);
            this.textBox_Arp_DestinationIPAddress.Multiline = true;
            this.textBox_Arp_DestinationIPAddress.Name = "textBox_Arp_DestinationIPAddress";
            this.textBox_Arp_DestinationIPAddress.Size = new System.Drawing.Size(120, 18);
            this.textBox_Arp_DestinationIPAddress.TabIndex = 82;
            // 
            // textBox_Arp_DestinationHardwareAddress
            // 
            this.textBox_Arp_DestinationHardwareAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_DestinationHardwareAddress.Location = new System.Drawing.Point(9, 163);
            this.textBox_Arp_DestinationHardwareAddress.Multiline = true;
            this.textBox_Arp_DestinationHardwareAddress.Name = "textBox_Arp_DestinationHardwareAddress";
            this.textBox_Arp_DestinationHardwareAddress.Size = new System.Drawing.Size(154, 18);
            this.textBox_Arp_DestinationHardwareAddress.TabIndex = 81;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label50.Location = new System.Drawing.Point(12, 150);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(153, 13);
            this.label50.TabIndex = 83;
            this.label50.Text = "Destination HardWare Address";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label51.Location = new System.Drawing.Point(215, 150);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(114, 13);
            this.label51.TabIndex = 84;
            this.label51.Text = "Destination IP Address";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label54.Location = new System.Drawing.Point(6, 74);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(81, 13);
            this.label54.TabIndex = 80;
            this.label54.Text = "Operation Code";
            // 
            // textBox_Arp_OperationCode
            // 
            this.textBox_Arp_OperationCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_OperationCode.Location = new System.Drawing.Point(5, 90);
            this.textBox_Arp_OperationCode.Multiline = true;
            this.textBox_Arp_OperationCode.Name = "textBox_Arp_OperationCode";
            this.textBox_Arp_OperationCode.Size = new System.Drawing.Size(333, 19);
            this.textBox_Arp_OperationCode.TabIndex = 79;
            // 
            // textBox_Arp_SourceIPAddress
            // 
            this.textBox_Arp_SourceIPAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_SourceIPAddress.Location = new System.Drawing.Point(218, 127);
            this.textBox_Arp_SourceIPAddress.Multiline = true;
            this.textBox_Arp_SourceIPAddress.Name = "textBox_Arp_SourceIPAddress";
            this.textBox_Arp_SourceIPAddress.Size = new System.Drawing.Size(120, 18);
            this.textBox_Arp_SourceIPAddress.TabIndex = 72;
            // 
            // textBox_Arp_SourceHardWareAddress
            // 
            this.textBox_Arp_SourceHardWareAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_SourceHardWareAddress.Location = new System.Drawing.Point(9, 127);
            this.textBox_Arp_SourceHardWareAddress.Multiline = true;
            this.textBox_Arp_SourceHardWareAddress.Name = "textBox_Arp_SourceHardWareAddress";
            this.textBox_Arp_SourceHardWareAddress.Size = new System.Drawing.Size(154, 18);
            this.textBox_Arp_SourceHardWareAddress.TabIndex = 71;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label52.Location = new System.Drawing.Point(12, 114);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(131, 13);
            this.label52.TabIndex = 73;
            this.label52.Text = "SourceHardWare Address";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label53.Location = new System.Drawing.Point(215, 114);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(114, 13);
            this.label53.TabIndex = 74;
            this.label53.Text = "Destination IP Address";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label46.Location = new System.Drawing.Point(215, 37);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(123, 13);
            this.label46.TabIndex = 70;
            this.label46.Text = "Protocol Address Length";
            // 
            // textBox_Arp_ProtocolType
            // 
            this.textBox_Arp_ProtocolType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_ProtocolType.Location = new System.Drawing.Point(218, 16);
            this.textBox_Arp_ProtocolType.Multiline = true;
            this.textBox_Arp_ProtocolType.Name = "textBox_Arp_ProtocolType";
            this.textBox_Arp_ProtocolType.Size = new System.Drawing.Size(120, 18);
            this.textBox_Arp_ProtocolType.TabIndex = 64;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label47.Location = new System.Drawing.Point(8, 37);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(130, 13);
            this.label47.TabIndex = 69;
            this.label47.Text = "Hardware Address Length";
            // 
            // textBox_Arp_HardwareType
            // 
            this.textBox_Arp_HardwareType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_HardwareType.Location = new System.Drawing.Point(9, 16);
            this.textBox_Arp_HardwareType.Multiline = true;
            this.textBox_Arp_HardwareType.Name = "textBox_Arp_HardwareType";
            this.textBox_Arp_HardwareType.Size = new System.Drawing.Size(154, 18);
            this.textBox_Arp_HardwareType.TabIndex = 763;
            // 
            // textBox_Arp_HardwareAddressLength
            // 
            this.textBox_Arp_HardwareAddressLength.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_HardwareAddressLength.Location = new System.Drawing.Point(9, 50);
            this.textBox_Arp_HardwareAddressLength.Multiline = true;
            this.textBox_Arp_HardwareAddressLength.Name = "textBox_Arp_HardwareAddressLength";
            this.textBox_Arp_HardwareAddressLength.Size = new System.Drawing.Size(154, 18);
            this.textBox_Arp_HardwareAddressLength.TabIndex = 67;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label49.Location = new System.Drawing.Point(12, 3);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(83, 13);
            this.label49.TabIndex = 65;
            this.label49.Text = "HardWare Type";
            // 
            // textBox_Arp_ProtocolAddressLength
            // 
            this.textBox_Arp_ProtocolAddressLength.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Arp_ProtocolAddressLength.Location = new System.Drawing.Point(218, 50);
            this.textBox_Arp_ProtocolAddressLength.Multiline = true;
            this.textBox_Arp_ProtocolAddressLength.Name = "textBox_Arp_ProtocolAddressLength";
            this.textBox_Arp_ProtocolAddressLength.Size = new System.Drawing.Size(120, 18);
            this.textBox_Arp_ProtocolAddressLength.TabIndex = 68;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label48.Location = new System.Drawing.Point(215, 3);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 13);
            this.label48.TabIndex = 66;
            this.label48.Text = "Protocol Type";
            // 
            // tabPage_IPV6
            // 
            this.tabPage_IPV6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_dstaddress);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_hoplimit);
            this.tabPage_IPV6.Controls.Add(this.label84);
            this.tabPage_IPV6.Controls.Add(this.label95);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_srcaddress);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_nextheader);
            this.tabPage_IPV6.Controls.Add(this.label97);
            this.tabPage_IPV6.Controls.Add(this.label98);
            this.tabPage_IPV6.Controls.Add(this.label99);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_flowlabel);
            this.tabPage_IPV6.Controls.Add(this.label100);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_Version);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_trafficlass);
            this.tabPage_IPV6.Controls.Add(this.label101);
            this.tabPage_IPV6.Controls.Add(this.textBox_IPV6_payloadlength);
            this.tabPage_IPV6.Controls.Add(this.label102);
            this.tabPage_IPV6.Location = new System.Drawing.Point(4, 22);
            this.tabPage_IPV6.Name = "tabPage_IPV6";
            this.tabPage_IPV6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_IPV6.Size = new System.Drawing.Size(347, 186);
            this.tabPage_IPV6.TabIndex = 2;
            this.tabPage_IPV6.Text = "IPV6";
            // 
            // textBox_IPV6_dstaddress
            // 
            this.textBox_IPV6_dstaddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_dstaddress.Location = new System.Drawing.Point(144, 155);
            this.textBox_IPV6_dstaddress.Multiline = true;
            this.textBox_IPV6_dstaddress.Name = "textBox_IPV6_dstaddress";
            this.textBox_IPV6_dstaddress.Size = new System.Drawing.Size(193, 18);
            this.textBox_IPV6_dstaddress.TabIndex = 100;
            // 
            // textBox_IPV6_hoplimit
            // 
            this.textBox_IPV6_hoplimit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_hoplimit.Location = new System.Drawing.Point(5, 153);
            this.textBox_IPV6_hoplimit.Multiline = true;
            this.textBox_IPV6_hoplimit.Name = "textBox_IPV6_hoplimit";
            this.textBox_IPV6_hoplimit.Size = new System.Drawing.Size(113, 18);
            this.textBox_IPV6_hoplimit.TabIndex = 99;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label84.Location = new System.Drawing.Point(8, 140);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(51, 13);
            this.label84.TabIndex = 101;
            this.label84.Text = "Hop Limit";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label95.Location = new System.Drawing.Point(141, 142);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(101, 13);
            this.label95.TabIndex = 102;
            this.label95.Text = "Destination Address";
            // 
            // textBox_IPV6_srcaddress
            // 
            this.textBox_IPV6_srcaddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_srcaddress.Location = new System.Drawing.Point(144, 119);
            this.textBox_IPV6_srcaddress.Multiline = true;
            this.textBox_IPV6_srcaddress.Name = "textBox_IPV6_srcaddress";
            this.textBox_IPV6_srcaddress.Size = new System.Drawing.Size(193, 18);
            this.textBox_IPV6_srcaddress.TabIndex = 94;
            // 
            // textBox_IPV6_nextheader
            // 
            this.textBox_IPV6_nextheader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_nextheader.Location = new System.Drawing.Point(5, 117);
            this.textBox_IPV6_nextheader.Multiline = true;
            this.textBox_IPV6_nextheader.Name = "textBox_IPV6_nextheader";
            this.textBox_IPV6_nextheader.Size = new System.Drawing.Size(113, 18);
            this.textBox_IPV6_nextheader.TabIndex = 93;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label97.Location = new System.Drawing.Point(8, 104);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(67, 13);
            this.label97.TabIndex = 95;
            this.label97.Text = "Next Header";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label98.Location = new System.Drawing.Point(141, 106);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(82, 13);
            this.label98.TabIndex = 96;
            this.label98.Text = "Source Address";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label99.Location = new System.Drawing.Point(136, 39);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(81, 13);
            this.label99.TabIndex = 92;
            this.label99.Text = "Payload Length";
            // 
            // textBox_IPV6_flowlabel
            // 
            this.textBox_IPV6_flowlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_flowlabel.Location = new System.Drawing.Point(139, 18);
            this.textBox_IPV6_flowlabel.Multiline = true;
            this.textBox_IPV6_flowlabel.Name = "textBox_IPV6_flowlabel";
            this.textBox_IPV6_flowlabel.Size = new System.Drawing.Size(151, 18);
            this.textBox_IPV6_flowlabel.TabIndex = 86;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label100.Location = new System.Drawing.Point(4, 39);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(65, 13);
            this.label100.TabIndex = 91;
            this.label100.Text = "Traffic Class";
            // 
            // textBox_IPV6_Version
            // 
            this.textBox_IPV6_Version.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_Version.Location = new System.Drawing.Point(5, 18);
            this.textBox_IPV6_Version.Multiline = true;
            this.textBox_IPV6_Version.Name = "textBox_IPV6_Version";
            this.textBox_IPV6_Version.Size = new System.Drawing.Size(113, 18);
            this.textBox_IPV6_Version.TabIndex = 85;
            // 
            // textBox_IPV6_trafficlass
            // 
            this.textBox_IPV6_trafficlass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_trafficlass.Location = new System.Drawing.Point(5, 52);
            this.textBox_IPV6_trafficlass.Multiline = true;
            this.textBox_IPV6_trafficlass.Name = "textBox_IPV6_trafficlass";
            this.textBox_IPV6_trafficlass.Size = new System.Drawing.Size(113, 18);
            this.textBox_IPV6_trafficlass.TabIndex = 89;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label101.Location = new System.Drawing.Point(8, 5);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(55, 13);
            this.label101.TabIndex = 87;
            this.label101.Text = "IP Version";
            // 
            // textBox_IPV6_payloadlength
            // 
            this.textBox_IPV6_payloadlength.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_IPV6_payloadlength.Location = new System.Drawing.Point(139, 52);
            this.textBox_IPV6_payloadlength.Multiline = true;
            this.textBox_IPV6_payloadlength.Name = "textBox_IPV6_payloadlength";
            this.textBox_IPV6_payloadlength.Size = new System.Drawing.Size(151, 18);
            this.textBox_IPV6_payloadlength.TabIndex = 90;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label102.Location = new System.Drawing.Point(136, 5);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(58, 13);
            this.label102.TabIndex = 88;
            this.label102.Text = "Flow Label";
            // 
            // tabControl_Linklayer
            // 
            this.tabControl_Linklayer.Controls.Add(this.tabPage4);
            this.tabControl_Linklayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Linklayer.Location = new System.Drawing.Point(3, 588);
            this.tabControl_Linklayer.Name = "tabControl_Linklayer";
            this.tabControl_Linklayer.SelectedIndex = 0;
            this.tabControl_Linklayer.Size = new System.Drawing.Size(355, 86);
            this.tabControl_Linklayer.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.ForeColor = System.Drawing.Color.Maroon;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(347, 60);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Ethernet 802.3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_ETH_TypeField);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_ETH_Src_Mac_Address);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_ETH_Dst_Mac_Address);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 54);
            this.panel1.TabIndex = 1;
            // 
            // textBox_ETH_TypeField
            // 
            this.textBox_ETH_TypeField.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_ETH_TypeField.Location = new System.Drawing.Point(265, 26);
            this.textBox_ETH_TypeField.Multiline = true;
            this.textBox_ETH_TypeField.Name = "textBox_ETH_TypeField";
            this.textBox_ETH_TypeField.Size = new System.Drawing.Size(62, 17);
            this.textBox_ETH_TypeField.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Type";
            // 
            // textBox_ETH_Src_Mac_Address
            // 
            this.textBox_ETH_Src_Mac_Address.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_ETH_Src_Mac_Address.Location = new System.Drawing.Point(141, 26);
            this.textBox_ETH_Src_Mac_Address.Multiline = true;
            this.textBox_ETH_Src_Mac_Address.Name = "textBox_ETH_Src_Mac_Address";
            this.textBox_ETH_Src_Mac_Address.Size = new System.Drawing.Size(113, 17);
            this.textBox_ETH_Src_Mac_Address.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Source Mac Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destination Mac Address";
            // 
            // textBox_ETH_Dst_Mac_Address
            // 
            this.textBox_ETH_Dst_Mac_Address.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_ETH_Dst_Mac_Address.Location = new System.Drawing.Point(3, 26);
            this.textBox_ETH_Dst_Mac_Address.Multiline = true;
            this.textBox_ETH_Dst_Mac_Address.Name = "textBox_ETH_Dst_Mac_Address";
            this.textBox_ETH_Dst_Mac_Address.Size = new System.Drawing.Size(127, 17);
            this.textBox_ETH_Dst_Mac_Address.TabIndex = 0;
            // 
            // textBox_PayLoad
            // 
            this.textBox_PayLoad.ForeColor = System.Drawing.Color.Blue;
            this.textBox_PayLoad.Location = new System.Drawing.Point(3, 305);
            this.textBox_PayLoad.Multiline = true;
            this.textBox_PayLoad.Name = "textBox_PayLoad";
            this.textBox_PayLoad.Size = new System.Drawing.Size(211, 374);
            this.textBox_PayLoad.TabIndex = 28;
            // 
            // checkBox_Payload
            // 
            this.checkBox_Payload.AutoSize = true;
            this.checkBox_Payload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBox_Payload.Location = new System.Drawing.Point(3, 287);
            this.checkBox_Payload.Name = "checkBox_Payload";
            this.checkBox_Payload.Size = new System.Drawing.Size(98, 17);
            this.checkBox_Payload.TabIndex = 29;
            this.checkBox_Payload.Text = "Show PayLoad";
            this.checkBox_Payload.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            this.chart1.BorderlineColor = System.Drawing.Color.LightGoldenrodYellow;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(576, 9);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "SendTraffic";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Recieve";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(379, 299);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // timer_1Sec
            // 
            this.timer_1Sec.Enabled = true;
            this.timer_1Sec.Interval = 1000;
            this.timer_1Sec.Tick += new System.EventHandler(this.timer_1Sec_Tick);
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label106.Location = new System.Drawing.Point(951, 37);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(107, 13);
            this.label106.TabIndex = 34;
            this.label106.Text = "TrafficRecieved/Sec";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label107.Location = new System.Drawing.Point(952, 17);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(86, 13);
            this.label107.TabIndex = 33;
            this.label107.Text = "TrafficSend/Sec";
            // 
            // textBox_TotalRecieveperSec
            // 
            this.textBox_TotalRecieveperSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_TotalRecieveperSec.Location = new System.Drawing.Point(1060, 35);
            this.textBox_TotalRecieveperSec.Name = "textBox_TotalRecieveperSec";
            this.textBox_TotalRecieveperSec.Size = new System.Drawing.Size(62, 20);
            this.textBox_TotalRecieveperSec.TabIndex = 32;
            // 
            // textBox_TotalSendperSec
            // 
            this.textBox_TotalSendperSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox_TotalSendperSec.Location = new System.Drawing.Point(1060, 14);
            this.textBox_TotalSendperSec.Name = "textBox_TotalSendperSec";
            this.textBox_TotalSendperSec.Size = new System.Drawing.Size(62, 20);
            this.textBox_TotalSendperSec.TabIndex = 31;
            // 
            // chart_count
            // 
            this.chart_count.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chart_count.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            chartArea2.Name = "ChartArea1";
            this.chart_count.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_count.Legends.Add(legend2);
            this.chart_count.Location = new System.Drawing.Point(826, 57);
            this.chart_count.Name = "chart_count";
            this.chart_count.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series3.MarkerBorderWidth = 4;
            series3.MarkerSize = 1;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Name = "Count/sec";
            series3.ToolTip = "Number Of Packets Per Second";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series4.Name = "TCP";
            series4.ToolTip = "Number Of Tcp Packets";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.MarkerSize = 8;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series5.Name = "UDP";
            series5.ToolTip = "Number Of Udp Packets";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Legend = "Legend1";
            series6.Name = "HTTP";
            series6.ToolTip = "Number Of Http Packets";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Legend = "Legend1";
            series7.Name = "ARP";
            series7.ToolTip = "Number Of Arp Packets";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series8.Legend = "Legend1";
            series8.Name = "SSDP";
            series8.ToolTip = "Number Of Ssdp Packets";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series9.Legend = "Legend1";
            series9.Name = "DNS";
            series9.ToolTip = "Number Of Dns Packets";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series10.Legend = "Legend1";
            series10.Name = "LLMNR";
            series10.ToolTip = "Number Of Llmnr Packets";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.Legend = "Legend1";
            series11.MarkerSize = 10;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series11.Name = "IPV6";
            series11.ToolTip = "Number Of Ipv6 Packets";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.Legend = "Legend1";
            series12.MarkerSize = 10;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series12.Name = "ICMPV6";
            series12.ToolTip = "Number Of Icmpv6 Packets";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series13.Legend = "Legend1";
            series13.MarkerSize = 10;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series13.Name = "ICMP";
            series13.ToolTip = "Number Of Icmp Packets";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series14.Legend = "Legend1";
            series14.MarkerSize = 10;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series14.Name = "IGMPV2";
            series14.ToolTip = "Number Of Igmpv2 Packets";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series15.Legend = "Legend1";
            series15.Name = "DHCP";
            series15.ToolTip = "Number Of Dhcp Packets";
            this.chart_count.Series.Add(series3);
            this.chart_count.Series.Add(series4);
            this.chart_count.Series.Add(series5);
            this.chart_count.Series.Add(series6);
            this.chart_count.Series.Add(series7);
            this.chart_count.Series.Add(series8);
            this.chart_count.Series.Add(series9);
            this.chart_count.Series.Add(series10);
            this.chart_count.Series.Add(series11);
            this.chart_count.Series.Add(series12);
            this.chart_count.Series.Add(series13);
            this.chart_count.Series.Add(series14);
            this.chart_count.Series.Add(series15);
            this.chart_count.Size = new System.Drawing.Size(417, 251);
            this.chart_count.TabIndex = 35;
            this.chart_count.Text = "chart2";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.ForeColor = System.Drawing.Color.Red;
            this.label108.Location = new System.Drawing.Point(2, 6);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(106, 13);
            this.label108.TabIndex = 38;
            this.label108.Text = "TimeElapsedPerSec:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(213, 249);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.checkBox_AutoScroll);
            this.tabPage1.Controls.Add(this.listBox_Packets);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(205, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PacketList";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.button_Search);
            this.tabPage2.Controls.Add(this.listBox_Search);
            this.tabPage2.Controls.Add(this.textBox_Search);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(205, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // button_Search
            // 
            this.button_Search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Search.Location = new System.Drawing.Point(114, 6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 40;
            this.button_Search.Text = "StartSearch";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // listBox_Search
            // 
            this.listBox_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listBox_Search.FormattingEnabled = true;
            this.listBox_Search.HorizontalScrollbar = true;
            this.listBox_Search.Location = new System.Drawing.Point(6, 32);
            this.listBox_Search.Name = "listBox_Search";
            this.listBox_Search.Size = new System.Drawing.Size(192, 186);
            this.listBox_Search.TabIndex = 40;
            // 
            // textBox_Search
            // 
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Search.Location = new System.Drawing.Point(6, 6);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(102, 20);
            this.textBox_Search.TabIndex = 40;
            // 
            // label_ShowTimePerSecond
            // 
            this.label_ShowTimePerSecond.AutoSize = true;
            this.label_ShowTimePerSecond.ForeColor = System.Drawing.Color.Red;
            this.label_ShowTimePerSecond.Location = new System.Drawing.Point(125, 7);
            this.label_ShowTimePerSecond.Name = "label_ShowTimePerSecond";
            this.label_ShowTimePerSecond.Size = new System.Drawing.Size(32, 13);
            this.label_ShowTimePerSecond.TabIndex = 40;
            this.label_ShowTimePerSecond.Text = "0Sec";
            // 
            // timer_2MiliSec
            // 
            this.timer_2MiliSec.Enabled = true;
            this.timer_2MiliSec.Interval = 600;
            this.timer_2MiliSec.Tick += new System.EventHandler(this.timer_2MiliSec_Tick);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label109.Location = new System.Drawing.Point(1126, 37);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(31, 13);
            this.label109.TabIndex = 44;
            this.label109.Text = "Total";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label110.Location = new System.Drawing.Point(1125, 20);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(31, 13);
            this.label110.TabIndex = 43;
            this.label110.Text = "Total";
            // 
            // textBox_TotalRecieve
            // 
            this.textBox_TotalRecieve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_TotalRecieve.Location = new System.Drawing.Point(1163, 35);
            this.textBox_TotalRecieve.Name = "textBox_TotalRecieve";
            this.textBox_TotalRecieve.Size = new System.Drawing.Size(80, 20);
            this.textBox_TotalRecieve.TabIndex = 42;
            // 
            // textBox_TotalSend
            // 
            this.textBox_TotalSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox_TotalSend.Location = new System.Drawing.Point(1163, 14);
            this.textBox_TotalSend.Name = "textBox_TotalSend";
            this.textBox_TotalSend.Size = new System.Drawing.Size(80, 20);
            this.textBox_TotalSend.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox_listOfProgramm
            // 
            this.listBox_listOfProgramm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBox_listOfProgramm.FormattingEnabled = true;
            this.listBox_listOfProgramm.Location = new System.Drawing.Point(591, 335);
            this.listBox_listOfProgramm.Name = "listBox_listOfProgramm";
            this.listBox_listOfProgramm.Size = new System.Drawing.Size(643, 342);
            this.listBox_listOfProgramm.TabIndex = 45;
            this.toolTip1.SetToolTip(this.listBox_listOfProgramm, "Select Item For Copy it To ClipBoard");
            this.listBox_listOfProgramm.SelectedIndexChanged += new System.EventHandler(this.listBox_listOfProgramm_SelectedIndexChanged);
            // 
            // label_listOfProgramm
            // 
            this.label_listOfProgramm.AutoSize = true;
            this.label_listOfProgramm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_listOfProgramm.Location = new System.Drawing.Point(589, 319);
            this.label_listOfProgramm.Name = "label_listOfProgramm";
            this.label_listOfProgramm.Size = new System.Drawing.Size(154, 13);
            this.label_listOfProgramm.TabIndex = 46;
            this.label_listOfProgramm.Text = "ListOfProgramm Using Network";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Packet Analyzur";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendSecToolStripMenuItem,
            this.recvSecToolStripMenuItem,
            this.countOfPacketsToolStripMenuItem,
            this.packetAnalyzurToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 114);
            // 
            // sendSecToolStripMenuItem
            // 
            this.sendSecToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sendSecToolStripMenuItem.Name = "sendSecToolStripMenuItem";
            this.sendSecToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sendSecToolStripMenuItem.Text = "SendPerSec:";
            // 
            // recvSecToolStripMenuItem
            // 
            this.recvSecToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.recvSecToolStripMenuItem.Name = "recvSecToolStripMenuItem";
            this.recvSecToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.recvSecToolStripMenuItem.Text = "RecvPerSec:";
            // 
            // countOfPacketsToolStripMenuItem
            // 
            this.countOfPacketsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countOfPacketsToolStripMenuItem.Name = "countOfPacketsToolStripMenuItem";
            this.countOfPacketsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.countOfPacketsToolStripMenuItem.Text = "CountOfPackets:";
            // 
            // packetAnalyzurToolStripMenuItem
            // 
            this.packetAnalyzurToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.packetAnalyzurToolStripMenuItem.Name = "packetAnalyzurToolStripMenuItem";
            this.packetAnalyzurToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.packetAnalyzurToolStripMenuItem.Text = "PacketAnalyzur";
            this.packetAnalyzurToolStripMenuItem.Click += new System.EventHandler(this.packetAnalyzurToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1246, 22);
            this.statusStrip1.TabIndex = 47;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel2.Text = "About";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "Count/sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1246, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_listOfProgramm);
            this.Controls.Add(this.listBox_listOfProgramm);
            this.Controls.Add(this.label109);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.textBox_TotalRecieve);
            this.Controls.Add(this.textBox_TotalSend);
            this.Controls.Add(this.label_ShowTimePerSecond);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label108);
            this.Controls.Add(this.chart_count);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.label107);
            this.Controls.Add(this.textBox_TotalRecieveperSec);
            this.Controls.Add(this.textBox_TotalSendperSec);
            this.Controls.Add(this.checkBox_Payload);
            this.Controls.Add(this.textBox_PayLoad);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Packet Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl_TransportLayer.ResumeLayout(false);
            this.tabPage_Tcp.ResumeLayout(false);
            this.tabPage_Tcp.PerformLayout();
            this.tabPage_Udp.ResumeLayout(false);
            this.tabPage_Udp.PerformLayout();
            this.tabPage_ICMP.ResumeLayout(false);
            this.tabPage_ICMP.PerformLayout();
            this.tabPage_IGMP.ResumeLayout(false);
            this.tabPage_IGMP.PerformLayout();
            this.tabPage_ICMPv6.ResumeLayout(false);
            this.tabPage_ICMPv6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl_AppLayer.ResumeLayout(false);
            this.tabPage_Http.ResumeLayout(false);
            this.tabPage_Http.PerformLayout();
            this.tabPage_DNS.ResumeLayout(false);
            this.tabPage_DNS.PerformLayout();
            this.tabPage_NBNS.ResumeLayout(false);
            this.tabPage_NBNS.PerformLayout();
            this.tabPage_LLMNR.ResumeLayout(false);
            this.tabPage_LLMNR.PerformLayout();
            this.tabPage_DHCP.ResumeLayout(false);
            this.tabPage_DHCP.PerformLayout();
            this.tabPage_SSDP.ResumeLayout(false);
            this.tabPage_SSDP.PerformLayout();
            this.tabControl_NetworkLayer.ResumeLayout(false);
            this.tabPage_IP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_ARP.ResumeLayout(false);
            this.tabPage_ARP.PerformLayout();
            this.tabPage_IPV6.ResumeLayout(false);
            this.tabPage_IPV6.PerformLayout();
            this.tabControl_Linklayer.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_count)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Packets;
        private System.Windows.Forms.CheckBox checkBox_AutoScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl_TransportLayer;
        private System.Windows.Forms.TabPage tabPage_Tcp;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox_Tcp_CheckSum;
        private System.Windows.Forms.TextBox textBox_Tcp_UrgentPointer;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox_Tcp_WindowSize;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label textBox_Tcp_cwr;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox_Tcp_ecn;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_Tcp_ack;
        private System.Windows.Forms.TextBox textBox_Tcp_psh;
        private System.Windows.Forms.TextBox textBox_Tcp_urg;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_Tcp_syn;
        private System.Windows.Forms.TextBox textBox_Tcp_fin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_Tcp_rst;
        private System.Windows.Forms.TextBox textBox_Tcp_HeaderLength;
        private System.Windows.Forms.TextBox textBox_Tcp_AcknowledgeNumber;
        private System.Windows.Forms.TextBox textBox_Tcp_unused;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_Tcp_SequencNumber;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_Tcp_SourcePort;
        private System.Windows.Forms.TextBox textBox_Tcp_DestinationPort;
        private System.Windows.Forms.TabPage tabPage_Udp;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox_Udp_length;
        private System.Windows.Forms.TextBox textBox_Udp_Checksum;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox_Udp_SourcePort;
        private System.Windows.Forms.TextBox textBox_Udp_DestinationPort;
        private System.Windows.Forms.TabPage tabPage_ICMP;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox_Icmp_SequenceNumber;
        private System.Windows.Forms.TextBox textBox_Icmp_Checksum;
        private System.Windows.Forms.TextBox textBox_Icmp_Id;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox_Icmp_Code;
        private System.Windows.Forms.TextBox textBox_ICMP_Type;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl_AppLayer;
        private System.Windows.Forms.TabPage tabPage_Http;
        private System.Windows.Forms.TextBox textBox_HTTP;
        private System.Windows.Forms.TabPage tabPage_DNS;
        private System.Windows.Forms.TabControl tabControl_NetworkLayer;
        private System.Windows.Forms.TabPage tabPage_IP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_IP_Dst_Add;
        private System.Windows.Forms.TextBox textBox_IP_HeaderChecksum;
        private System.Windows.Forms.TextBox textBox_IP_Src_Add;
        private System.Windows.Forms.TextBox textBox_IP_Identification;
        private System.Windows.Forms.TextBox textBox_IP_TTL;
        private System.Windows.Forms.TextBox textBox_IP_Protocol;
        private System.Windows.Forms.TextBox textBox_IP_DF;
        private System.Windows.Forms.TextBox textBox_Ip_Version;
        private System.Windows.Forms.TextBox textBox_IP_HeardeLength;
        private System.Windows.Forms.TextBox textBox_IP_MF;
        private System.Windows.Forms.TextBox textBox_Ip_TotalLentgh;
        private System.Windows.Forms.TextBox textBox_Ip_FragemntaionOffset;
        private System.Windows.Forms.TextBox textBox_IP_TypeOfService;
        private System.Windows.Forms.TabPage tabPage_ARP;
        private System.Windows.Forms.TextBox textBox_Arp_DestinationIPAddress;
        private System.Windows.Forms.TextBox textBox_Arp_DestinationHardwareAddress;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBox_Arp_OperationCode;
        private System.Windows.Forms.TextBox textBox_Arp_SourceIPAddress;
        private System.Windows.Forms.TextBox textBox_Arp_SourceHardWareAddress;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox_Arp_ProtocolType;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox_Arp_HardwareType;
        private System.Windows.Forms.TextBox textBox_Arp_HardwareAddressLength;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox_Arp_ProtocolAddressLength;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TabControl tabControl_Linklayer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_ETH_TypeField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ETH_Src_Mac_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ETH_Dst_Mac_Address;
        private System.Windows.Forms.TextBox textBox_PayLoad;
        private System.Windows.Forms.CheckBox checkBox_Payload;
        private System.Windows.Forms.TabPage tabPage_IGMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IGMP_maxResponse;
        private System.Windows.Forms.TextBox textBox_IGMP_multicastaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IGMP_type;
        private System.Windows.Forms.TextBox textBox_IGMP_checksum;
        private System.Windows.Forms.TabPage tabPage_NBNS;
        private System.Windows.Forms.TabPage tabPage_LLMNR;
        private System.Windows.Forms.TabPage tabPage_DHCP;
        private System.Windows.Forms.TabPage tabPage_SSDP;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox_DNS_Unused;
        private System.Windows.Forms.TextBox textBox_DNS_ra;
        private System.Windows.Forms.TextBox textBox_DNS_rcode;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox_DNS_Opcode;
        private System.Windows.Forms.TextBox textBox_DNS_Qr;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox_DNS_TC;
        private System.Windows.Forms.TextBox textBox_DNS_AA;
        private System.Windows.Forms.TextBox textBox_Dns_Rd;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox_Dns_Additionals;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox_Dns_answers;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox_Dns_Authority;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox_Dns_Questions;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox textBox_Dns_TransactionID;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox textBox_NBNS_BD;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox textBox_NBNS_transactionID;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox textBox_NBNS_unused;
        private System.Windows.Forms.TextBox textBox_NBNS_ra;
        private System.Windows.Forms.TextBox textBox_NBNS_rcode;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox textBox_NBNS_opcode;
        private System.Windows.Forms.TextBox textBox_NBNS_QR;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox textBox_NBNS_tc;
        private System.Windows.Forms.TextBox textBox_NBNS_aa;
        private System.Windows.Forms.TextBox textBox_NBNS_rd;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox textBox_NBNS_addtional;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox textBox_NBNS_answer;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBox_NBNS_authority;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox textBox_NBNS_questions;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox textBox_LLMNR_Transaction;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox textBox_LLMNR_unused;
        private System.Windows.Forms.TextBox textBox_LLMNR_rcode;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox textBox_LLMNR_opcode;
        private System.Windows.Forms.TextBox textBox_LLMNR_QR;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox textBox_LLMNR_TC;
        private System.Windows.Forms.TextBox textBox_LLMNR_C;
        private System.Windows.Forms.TextBox textBox_LLMNR_T;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox textBox_LLMNR_additional;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.TextBox textBox_LLMNR_answer;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TextBox textBox_LLMNR_authority;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox textBox_LLMNR_questions;
        private System.Windows.Forms.TextBox textBox_SSDP;
        private System.Windows.Forms.TextBox textBox_DHCP;
        private System.Windows.Forms.TabPage tabPage_IPV6;
        private System.Windows.Forms.TextBox textBox_IPV6_dstaddress;
        private System.Windows.Forms.TextBox textBox_IPV6_hoplimit;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TextBox textBox_IPV6_srcaddress;
        private System.Windows.Forms.TextBox textBox_IPV6_nextheader;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TextBox textBox_IPV6_flowlabel;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox textBox_IPV6_Version;
        private System.Windows.Forms.TextBox textBox_IPV6_trafficlass;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox textBox_IPV6_payloadlength;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TabPage tabPage_ICMPv6;
        private System.Windows.Forms.TextBox textBox_ICMPv6_checksum;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox textBox_ICMPv6_type;
        private System.Windows.Forms.TextBox textBox_ICMPv6_code;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Timer timer_1Sec;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox textBox_TotalRecieveperSec;
        private System.Windows.Forms.TextBox textBox_TotalSendperSec;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_count;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ShowTimePerSecond;
        public System.Windows.Forms.Timer timer_2MiliSec;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TextBox textBox_TotalRecieve;
        private System.Windows.Forms.TextBox textBox_TotalSend;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox_listOfProgramm;
        private System.Windows.Forms.Label label_listOfProgramm;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sendSecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recvSecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countOfPacketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetAnalyzurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

    }
}

