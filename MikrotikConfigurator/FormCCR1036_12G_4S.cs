using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikrotikConfigurator
{
    public partial class FormCCR1036_12G_4S : Form
    {
        string _chosenStend;
        
        public FormCCR1036_12G_4S(string chosenStend)
        {
            InitializeComponent();

            _chosenStend = chosenStend;

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = true;
            textBox1.ReadOnly = true;

            hideMacTextbox();
            //showMacTextbox();

            

            string[] _boardCount = new string[] {"","1","2","3","4","5"};

            comboBox1.DataSource = _boardCount;
            comboBox1.SelectedIndex = 0;

            setTextboxFocus();
            checkBoardCount();
             
        }
        private void setTextboxFocus()
        {
            textBox2.GotFocus += textBox2_GotFocus;
            textBox3.GotFocus += textBox3_GotFocus;
            textBox4.GotFocus += textBox4_GotFocus;
            textBox5.GotFocus += textBox5_GotFocus;
            textBox6.GotFocus += textBox6_GotFocus;
            textBox7.GotFocus += textBox7_GotFocus;
            textBox8.GotFocus += textBox8_GotFocus;
            textBox9.GotFocus += textBox9_GotFocus;
            textBox10.GotFocus += textBox10_GotFocus;
            textBox11.GotFocus += textBox11_GotFocus;
            textBox12.GotFocus += textBox12_GotFocus;
            textBox13.GotFocus += textBox13_GotFocus;
        }
        private void textBox2_GotFocus (object sender, EventArgs e)

        {
            if (textBox2.Text.Contains("MAC-DST"))
            textBox2.Clear();
        }
        private void textBox3_GotFocus(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("MAC-DST"))
                textBox3.Clear();
        }
        private void textBox4_GotFocus(object sender, EventArgs e)
        {
            if (textBox4.Text.Contains("MAC-DST"))
                textBox4.Clear();
        }
        private void textBox5_GotFocus(object sender, EventArgs e)
        {
            if (textBox5.Text.Contains("MAC-DST"))
                textBox5.Clear();
        }
        private void textBox6_GotFocus(object sender, EventArgs e)
        {
            if (textBox6.Text.Contains("MAC-DST"))
                textBox6.Clear();
        }
        private void textBox7_GotFocus(object sender, EventArgs e)
        {
            if (textBox7.Text.Contains("MAC-DST"))
                textBox7.Clear();
        }
        private void textBox8_GotFocus(object sender, EventArgs e)
        {
            if (textBox8.Text.Contains("MAC-DST"))
                textBox8.Clear();
        }
        private void textBox9_GotFocus(object sender, EventArgs e)
        {
            if (textBox9.Text.Contains("MAC-DST"))
                textBox9.Clear();
        }
        private void textBox10_GotFocus(object sender, EventArgs e)
        {
            if (textBox10.Text.Contains("MAC-DST"))
                textBox10.Clear();
        }
        private void textBox11_GotFocus(object sender, EventArgs e)
        {
            if (textBox11.Text.Contains("MAC-DST"))
                textBox11.Clear();
        }
        private void textBox12_GotFocus(object sender, EventArgs e)
        {
            if (textBox12.Text.Contains("MAC-DST"))
                textBox12.Clear();
        }
        private void textBox13_GotFocus(object sender, EventArgs e)
        {
            if (textBox13.Text.Contains("MAC-DST"))
                textBox13.Clear();
        }

        public void showVar() { MessageBox.Show(_chosenStend); }


        enum stendIP
        {
            Termo_Ch_01_UP = 111, Termo_Ch_01_DOWN = 112, Termo_Ch_02_UP = 114, Termo_Ch_02_DOWN = 115,
            Termo_Ch_03_UP = 116, Termo_Ch_03_DOWN = 117,/*Termo_Ch_04_UP,Termo_Ch_04_DOWN,*/Termo_Ch_05 = 113, Termo_Ch_06 = 130,
            Termo_N1_UP = 118, Termo_N1_MIDDLE = 119, Termo_N1_DOWN = 120, Termo_N2_UP = 121, Termo_N2_MIDDLE = 122, Termo_N2_DOWN = 123,
            Termo_N3_UP = 124, Termo_N3_MIDDLE = 125, Termo_N3_DOWN = 125, Termo_N3_SFPplus = 126, Termo_N4_UP = 127, Termo_N4_DOWN = 128,
            t24h_n0_left = 21, t24h_n0_right = 22, t24h_n1_left = 11, t24h_n1_right = 12, t24h_n2_left = 13, t24h_n2_right = 14,
            t24h_n3_up = 15, t24h_n3_middle = 16, t24h_n3_down = 17, t24h_n4_up = 18, t24h_n4_middle = 19, t24h_n4_down = 20
        };
         
       int tgIP = 0;
        public  void set_stendIP (string stendIP)
        {
            int getIP = (int)(stendIP)Enum.Parse(typeof(stendIP), stendIP);
            tgIP = getIP;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var nl = Environment.NewLine;
            set_stendIP(_chosenStend);
            textBox1.Text = "";
            string textPacketTemplate = "";
            string textStream = "";

            string trafficGenerator = "";
            if (boardCount == 1 || boardCount <= 5)
            {
                trafficGenerator = "/tool traffic-generator packet-template" + nl + "add interface=ether1 ip-dst=172.22." + tgIP + ".21" +
                   " mac-dst=" + textBox2.Text + " name=e1e2 random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001"+nl+
                   "add interface=ether2 ip-dst=172.21."+tgIP+".21 mac-dst="+textBox4.Text+" name=e2e1"+
                   " random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001"+nl;
                textBox1.Text = trafficGenerator;
            }
            if (boardCount == 2 || boardCount > 2)
            {
                trafficGenerator = "add interface=ether3 ip-dst=172.24." + tgIP + ".21 mac-dst="+textBox6.Text+" name=e3e4" +
                    "random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001"+nl+"add interface=ether4 ip-dst=172.23." +tgIP+" .21 "+
                    "mac-dst=" + textBox5.Text + " name=e4e3 random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001"+nl;

                textBox1.Text += trafficGenerator;
            }
            if (boardCount == 3 || boardCount > 3  )
            {
                trafficGenerator = "add interface=ether5 ip-dst=172.26." + tgIP + ".21 mac-dst=" + textBox8.Text + " name=e5e6" +
                    " random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl + "add interface=ether6" +
                    " ip-dst=172.25." + tgIP + ".21 mac-dst=" + textBox7.Text + " name=e6e5 " +
                    "random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl;


                textBox1.Text += trafficGenerator;

            }
            if (boardCount == 4 || boardCount > 4)
            {
                trafficGenerator = "add interface=ether7 ip-dst=172.28." + tgIP + ".21 mac-dst=" + textBox10.Text + " name=e7e8" +
                    " random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl + "add interface=ether8" +
                    " ip-dst=172.27." + tgIP + ".21 mac-dst=" + textBox9.Text + " name=e8e7 " +
                    "random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl;


                textBox1.Text += trafficGenerator;

            }
            if (boardCount == 5 )
            {
                trafficGenerator = "add interface=ether9 ip-dst=172.29." + tgIP + ".21 mac-dst=" + textBox10.Text + " name=e9e10" +
                    " random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl + "add interface=ether10" +
                    " ip-dst=172.30." + tgIP + ".21 mac-dst=" + textBox9.Text + " name=e10e9 " +
                    "random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl;


                textBox1.Text += trafficGenerator;

            }
            if (boardCount > 1)
            {
                trafficGenerator = "add interface=sfp1 ip-dst=172.22." + tgIP + ".102 mac-dst=" + textBox13.Text + " name=sfp1" +
                   " random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl + "add interface=sfp2" +
                   " ip-dst=172.21." + tgIP + ".102 mac-dst=" + textBox3.Text + " name=sfp2 " +
                   "random-ranges=29:8:1-21,34:16:60000-60001,36:16:50000-50001" + nl;


                textBox1.Text += trafficGenerator;
                textPacketTemplate = textBox1.Text;
            }

            // MAKE TRAFFIC-GENERATOR STREAM

            if (boardCount == 1 || boardCount <= 5)
            {
                trafficGenerator = "/tool traffic-generator stream"+nl+
                    "add id=0 mbps=950 name=e1e2 packet-size=512 tx-template=e1e2"+nl+
                    "add id=1 mbps=950 name=e2e1 packet-size=512 tx-template=e2e1"+nl;
                textBox1.Text = trafficGenerator;
            }
            if (boardCount == 2 || boardCount > 2)
            {
                trafficGenerator = 
                    "add id=2 mbps=950 name=e3e4 packet-size=512 tx-template=e3e4" + nl +
                    "add id=3 mbps=950 name=e4e3 packet-size=512 tx-template=e4e3" + nl;

                textBox1.Text += trafficGenerator;
            }
            if (boardCount == 3 || boardCount > 3)
            {
                trafficGenerator =
                    "add id=4 mbps=950 name=e5e6 packet-size=512 tx-template=e5e6" + nl +
                    "add id=5 mbps=950 name=e6e5 packet-size=512 tx-template=e6e5" + nl;

                textBox1.Text += trafficGenerator;

            }
            if (boardCount == 4 || boardCount > 4)
            {
                trafficGenerator =
                    "add id=6 mbps=950 name=e7e8 packet-size=512 tx-template=e7e8" + nl +
                    "add id=7 mbps=950 name=e8e7 packet-size=512 tx-template=e8e7" + nl;


                textBox1.Text += trafficGenerator;

            }
            if (boardCount == 5)
            {
                trafficGenerator =
                   "add id=8 mbps=950 name=e9e10 packet-size=512 tx-template=e9e10" + nl +
                   "add id=9 mbps=950 name=e9e10 packet-size=512 tx-template=e10e9" + nl;


                textBox1.Text += trafficGenerator;

            }
            if (boardCount > 1)
            {
                trafficGenerator =
                      "add id=10 mbps=950 name=sfp1 packet-size=512 tx-template=sfp1" + nl +
                      "add id=11 mbps=950 name=sfp2 packet-size=512 tx-template=sfp2" + nl;

                textBox1.Text += trafficGenerator;
                textStream = textBox1.Text;
            }
            textBox1.Text = textPacketTemplate + textStream;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void hideMacTextbox()
        {
            
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
        }
        private void showMacTextbox()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
        }

        int boardCount = 1;
        private void checkBoardCount()
        {
            if (comboBox1.SelectedItem.ToString().Contains("1"))
            {
                boardCount = 1;

            }
            if (comboBox1.SelectedItem.ToString().Contains("2"))
            {
                boardCount = 2;

            }
            if (comboBox1.SelectedItem.ToString().Contains("3"))
            {
                boardCount = 3;

            }
            if (comboBox1.SelectedItem.ToString().Contains("4"))
            {
                boardCount = 4;

            }

            if (comboBox1.SelectedItem.ToString().Contains("5"))
            {
                boardCount = 5;

            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

            hideMacTextbox();
            checkBoardCount();
            if (boardCount >=1)
            {
                textBox3.Visible = true;
                textBox13.Visible = true;
            }

            if (boardCount == 1)
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
            }

            if (boardCount == 2) 
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }
            if (boardCount == 3)
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;

            }
            if (boardCount == 4)
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
            }
            if (boardCount == 5)
            {
                showMacTextbox();

            }
        }


    }
}
