using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Sys
{
    public partial class Registration_F : UserControl
    {
        private static Registration_F inst;
        public static Registration_F instance
        {
            get
            {
                if (inst == null)
                    inst = new Registration_F();
                return inst;
            }
        }

        public Registration_F()
        {
            InitializeComponent();
            ComboBatch.Items.Add(12);
            ComboBatch.Items.Add(13);
            ComboBatch.Items.Add(14);
            ComboBatch.Items.Add(15);

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            int batch = 0;
            Student std = new Student();
            if (TxtRollNo.Text.Count() == 7)
            {
                if (TxtFName.Text.Count() > 0)
                {
                    batch = Convert.ToInt32(ComboBatch.SelectedItem);
                    if (batch >= 12 && batch <= 15)
                    {
                        if (TxtDept.Text.Count() > 0)
                        {
                            std.RollNo = TxtRollNo.Text;
                            std.Batch = batch;
                            std.FirstName = TxtFName.Text;
                            std.LastName = TxtLName.Text;
                            std.Department = TxtDept.Text;
                            Model db = new Model();
                            if (db.insertStudent(std))
                            {
                                MessageBox.Show("Student is REGISTERED for party!");
                                emptyTexts();
                            }
                        }
                        else MessageBox.Show("Error! Mention Department");
                    }
                    else
                        MessageBox.Show("Error! Wrong Batch Entry");
                }
                else MessageBox.Show("Error! Please First Name Required");
            }
            else MessageBox.Show("Error! Roll No. is invalid");

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void LblRefresh_Click(object sender, EventArgs e)
        {
            emptyTexts();
        }
        private void emptyTexts()
        {
            TxtDept.Text = TxtFName.Text = TxtLName.Text = TxtRollNo.Text = "";
            ComboBatch.Name = "select Batch";
        }

        private void Registration_F_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
