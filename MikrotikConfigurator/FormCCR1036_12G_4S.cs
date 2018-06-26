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
            textBox1.WordWrap = false;
            textBox1.ReadOnly = true;

            hideMacTextbox();
            //showMacTextbox();

            

            string[] _boardCount = new string[] {"","1","2","3","4","5"};

            comboBox1.DataSource = _boardCount;
            comboBox1.SelectedIndex = 0;

            setTextboxFocus();
             
        }
        private void setTextboxFocus()
        {
            textBox2.GotFocus += textBox2_GotFocus;
            textBox4.GotFocus += textBox4_GotFocus;
            textBox5.GotFocus += textBox5_GotFocus;
            textBox6.GotFocus += textBox6_GotFocus;
            textBox7.GotFocus += textBox7_GotFocus;
            textBox8.GotFocus += textBox8_GotFocus;
            textBox9.GotFocus += textBox9_GotFocus;
            textBox10.GotFocus += textBox10_GotFocus;
            textBox11.GotFocus += textBox11_GotFocus;
            textBox12.GotFocus += textBox12_GotFocus;

        }
        private void textBox2_GotFocus (object sender, EventArgs e)
        {
            textBox2.Clear();
        }
        private void textBox4_GotFocus(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
        private void textBox5_GotFocus(object sender, EventArgs e)
        {
            textBox5.Clear();
        }
        private void textBox6_GotFocus(object sender, EventArgs e)
        {
            textBox6.Clear();
        }
        private void textBox7_GotFocus(object sender, EventArgs e)
        {
            textBox7.Clear();
        }
        private void textBox8_GotFocus(object sender, EventArgs e)
        {
            textBox8.Clear();
        }
        private void textBox9_GotFocus(object sender, EventArgs e)
        {
            textBox9.Clear();
        }
        private void textBox10_GotFocus(object sender, EventArgs e)
        {
            textBox10.Clear();
        }
        private void textBox11_GotFocus(object sender, EventArgs e)
        {
            textBox11.Clear();
        }
        private void textBox12_GotFocus(object sender, EventArgs e)
        {
            textBox12.Clear();
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
           
            set_stendIP(_chosenStend);
            textBox1.Text += tgIP.ToString(); 


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void hideMacTextbox()
        {
            
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
        }
        private void showMacTextbox()
        {
            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {

            hideMacTextbox();

            if (comboBox1.SelectedItem.ToString().Equals("1"))
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
            }

            if (comboBox1.SelectedItem.ToString().Equals("2")) 
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString().Equals("3"))
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;

            }
            if (comboBox1.SelectedItem.ToString().Equals("4"))
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
            if (comboBox1.SelectedItem.ToString().Equals("5"))
            {
                showMacTextbox();

            }
        }


    }
}
