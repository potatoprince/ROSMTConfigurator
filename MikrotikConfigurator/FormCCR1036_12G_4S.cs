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
        }

        public void showVar() { MessageBox.Show(_chosenStend); }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _chosenStend;
        }
    }
}
