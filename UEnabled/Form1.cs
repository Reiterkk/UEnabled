using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstLaender.Items.Add("Lichtenstein");
            LstLaender.Items.Add("Malta");
            LstLaender.Items.Add("Andorra");
            LstLaender.Items.Add("San Marino");
            LstLaender.Items.Add("Monacco");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CmdLoeschen.Enabled = false;
        }

        private void LstLaender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstLaender.SelectedIndices.Count == 0 || LstLaender.Items.Count == 0)
            {
                CmdLoeschen.Enabled = false;
            }
            else
            {
                CmdLoeschen.Enabled = true;
            }
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            int index = LstLaender.SelectedIndex;
            LstLaender.Items.RemoveAt(index);
        }
    }
}
