using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonClickerGame
{
    public partial class Form1 : Form
    {
        private int clicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
        
            clicks++;

            valueLabel.Text = clicks.ToString();
        }
    }
}
