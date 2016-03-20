using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Sys
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        
        

        private void btnList_Click(object sender, EventArgs e)
        {
            using (StreamReader objR = new StreamReader("D:/box.txt"))
            {
                MessageBox.Show(objR.ReadToEnd());
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void New_Registration()
        {
            if (!MainPnl.Controls.Contains(Registration_F.instance))
            {
                MainPnl.Controls.Add(Registration_F.instance);
            }
            else
                Registration_F.instance.BringToFront();
        }
        private void Search_Reg()
        {
            if (!MainPnl.Controls.Contains(SearchControl.instance))
            {
                MainPnl.Controls.Add(SearchControl.instance);
            }
            else
            {
                SearchControl.instance.BringToFront();
            }
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            

        }

        private void MainPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            lblimage.Hide();
            label1.Hide();
            New_Registration();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lblimage.Hide();
            label1.Hide();
            Search_Reg();    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
