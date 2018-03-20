using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_SimulatorAlgorithm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Selection f1 = new Selection();
            f1.Visible = true;
            this.Visible = false;
          
      
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Insertion f2 = new Insertion();
            f2.Visible = true;
            this.Visible = false;

        }
    }
}
