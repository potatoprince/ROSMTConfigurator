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
    public partial class Form1 : Form
    {
        string availableRouters = "";
        

        public Form1()
        {
            InitializeComponent();

            string[] _division = new string[] { "Endurance", "RMA" };
            comboBox1.DataSource = _division;
            comboBox1.SelectedIndex = 0;


            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //router list
            List<string> _routersEndurance = new List<string>();
            List<string> _routersRMA = new List<string>();
  
            
           


            if (comboBox1.SelectedItem.ToString().Equals("RMA"))
            {
                _routersRMA.Add("CCR1009-7G-1C-1S+");
                _routersRMA.Add("CCR1099-8G-1S-1S+");
                _routersRMA.Add("CCR1016-12G");
                _routersRMA.Add("CCR1036-8G-2S+");
                _routersRMA.Add("RB2011UiAS");
                _routersRMA.Add("RB3011UiAS");

                listBox1.DataSource = _routersRMA;
                availableRouters = string.Join(" ", _routersRMA.ToArray());
            }

            if (comboBox1.SelectedItem.ToString().Equals("Endurance"))
            {
                _routersEndurance.Add("Audience");
                _routersEndurance.Add("CCR1036-12G-4S");
                _routersEndurance.Add("CRS305-1G-4S+");
                _routersEndurance.Add("hAPac^2");
                _routersEndurance.Add("RB760iGS (hEX s)");
                _routersEndurance.Add("RBcAPGi-5acD2ND");
                _routersEndurance.Add("RB_LtAP-2HnD");
                _routersEndurance.Add("RBM33G");
                _routersEndurance.Add("RBSXTsqG-5acD");
                _routersEndurance.Add("RB493AH");

                listBox1.DataSource = _routersEndurance;
           
                availableRouters = string.Join(" ", _routersEndurance.ToArray());
            }

            if (comboBox1.SelectedIndex == 0)
            {
                string[] _stend = new string[]  {"Termo_Ch_01_UP","Termo_Ch_01_DOWN","Termo_Ch_02_UP","Termo_Ch_02_DOWN",
                "Termo_Ch_03_UP","Termo_Ch_03_DOWN","Termo_Ch_04_UP","Termo_Ch_04_DOWN","Termo_Ch_05","Termo_Ch_06",
                "Termo_N1_UP","Termo_N1_MIDDLE","Termo_N1_DOWN","Termo_N2_UP","Termo_N2_MIDDLE","Termo_N2_DOWN",
                "Termo_N3_UP","Termo_N3_MIDDLE","Termo_N3_DOWN","Termo_N3_SFP+","Termo_N4_UP","Termo_N4_DOWN",
                "t24h_n0_left","t24h_n0_right","t24h_n1_left","t24h_n1_right","t24h_n2_left","t24h_n2_right",
                "t24h_n3_up","t24h_n3_middle","t24h_n3_down","t24h_n4_up","t24h_n4_middle","t24h_n4_down"};

                comboBox2.DataSource = _stend;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string[] _stend = new string[] {"t24h_A1_U","t24h_A1_D","t24h_A2_U","t24h_A2_D","t24h_A3_SFP+",
                "t24h_A3_SFP","t24h_A4_U","t24h_A4_D","t24h_A5_U","t24h_A5_D","t24h_B1_U","t24h_B1_D","t24h_B2_U",
                "t24h_B2_D","t24h_B3_U","t24h_B3_SFP+","t24h_B3_D_1100","t24h_B3_D_1072_1","t24h_B3_D_1072_2",
                "t24h_B4_U","t24h_B5_U","t24h_SFP+_1","t24h_RAM"};
                comboBox2.DataSource = _stend;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var nl = Environment.NewLine;

            string alwaysWrite = "/system clock " +nl+"set time-zone-name=Europe/Riga " + nl +
                "/system ntp client" +nl+"set enabled=yes primary-ntp=10.155.0.1"+nl+"/ip dns"+nl+"set servers= 10.155.0.1"+nl+nl ;

            if (listBox1.SelectedItem.ToString().Equals("CCR1036-12G-4S"))
            {
                string config = "/interface bridge" + nl + "add name=e1e2" + nl + "add name=e3e4" + nl + "add name=e5e6" + nl +
                    "add name=e7e8" + nl + "add name=e9e10" + nl + "add name=e11e12" + nl + "add name=s1s2" + nl + "add name=s3s4" + nl + nl +
                    "/interface bridge port" + nl + "add bridge=e1e2 interface=ether1" + nl + "add bridge=e1e2 interface=ether2" + nl +
                    "add bridge=e3e4 interface=ether3" + nl + "add bridge=e3e4 interface=ether4" + nl +
                    "add bridge=e5e6 interface=ether5" + nl + "add bridge=e5e6 interface=ether6" + nl +
                    "add bridge=e7e8 interface=ether7" + nl + "add bridge=e7e8 interface=ether8" + nl +
                    "add bridge=e9e10 interface=ether9" + nl + "add bridge=e9e10 interface=ether10" + nl +
                    "add bridge=e11e12 interface=ether11" + nl + "add bridge=e11e12 interface=ether12" + nl +
                    "add bridge=s1s2 interface=sfp1" + nl + "add bridge=s1s2 interface=sfp2" + nl +
                    "add bridge=s3s4 interface=sfp3" + nl + "add bridge=s3s4 interface=sfp4" + nl;

                textBox1.Text = alwaysWrite + config ;
                
            }



           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
