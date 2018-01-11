//in the name of GOD
/*
Project   : Packet Analyzer
Developer : Seyyed Mahdi Hassanpour Matikolaei
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PacketAnalzerGUI
{
    public partial class SelectInterface : Form
    {
        Form1 f1;
        int i_timer1;
        public SelectInterface()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            f1 = new Form1();
            i_timer1 = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (label_init.Text=="Initializing...")//not ready yet
            {
                return;
            }
            else if (label_init.Text=="NetworkInterfaceCard Discovery Faild!")
            {
                MessageBox.Show("there is a problem In Discovery Or There is No Interface TO Discovery!");
            }
            else
            {
                //khondan e mac ha az form1 va ezafe kardane ona be listbox1
                listBox1.Items.Clear();
                foreach (var item in f1.mac_Line_Details.Split('\n'))
                {
                    listBox1.Items.Add(item);
                }

                label_init.Text = "to Continue,Please Select One Interface";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label_init.Text=="to Continue,Please Select One Interface")
            {
                f1.MacAddressOfSelectedNic = listBox1.SelectedItem.ToString().Substring(0, 17);
                f1.Selected_Nic_For_capturing(listBox1.SelectedIndex + 1);
                f1.Show();
                f1.notifyIcon1.Visible = true;
                this.Hide();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f1.SelectedInterface_InitializeToReady==true)
            {
                label_init.Text="Ready To Go...";
                label_init.ForeColor=Color.Green;
                timer1.Enabled = false;
            }
            else if (i_timer1>10)//after 10 second ,search will be failed; 
            {
                label_init.Text = "NetworkInterfaceCard Discovery Faild!";
                timer1.Enabled = false;
                label_init.ForeColor = Color.Red;

            }
            i_timer1++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (f1.form_closed==true)
            {
                f1.timer_1Sec.Enabled = false;
                f1.timer_2MiliSec.Enabled = false;
                f1.timer1.Enabled = false;
                f1.timer_1Sec.Stop();
                f1.timer_2MiliSec.Stop();
                f1.timer1.Stop();

                Application.Exit();
            }
        }

        private void SelectInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer2.Enabled = false;
            timer2.Stop(); 
            timer1.Stop();
        }
    }
}
