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

            
           
         

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (listBox1.DataSource.ToString().Contains(listBox1.SelectedItem.ToString()))
            //{
            //    textBox1.Text = "contains";
            //}
            textBox1.Text = availableRouters;
            //textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
