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
        public Form1()
        {
            List<string> _routers = new List<string>(); //router list

            InitializeComponent();

            // Add all the routers you've got
            _routers.Add("RBM33G");
            _routers.Add("RB3011UiAS");
            _routers.Add("RB2011UiAS");
            _routers.Add("RB493AH");
            _routers.Add("LtAP-2HnD");
            _routers.Add("CRS305-1G-4S+");
            _routers.Add("CCR1036-12G-4S");
            _routers.Add("CCR1036-8G-2S+");
            _routers.Add("CCR1016-12G");
            _routers.Add("CCR1009-8G-1S-1S+");
            _routers.Add("CCR1009-7G-1C-1S+");

            // Make listbox datasource your routers
            listBox1.DataSource = _routers;
        }


    }
}
