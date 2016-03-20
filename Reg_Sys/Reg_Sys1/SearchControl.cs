using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

namespace Reg_Sys
{
    public partial class SearchControl : UserControl
    {
        String connectionString = "Data Source=UNIQUENESS;Initial Catalog=Reg_Db;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static SearchControl inst;
        public static SearchControl instance
        {
            get
            {
                if (inst == null)
                    inst = new SearchControl();
                return inst;
            }
        }
        public SearchControl()
        {
            InitializeComponent();
        }
        
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                
                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        public interface IReportViewerMessages3 : IReportViewerMessages2,
    IReportViewerMessages
        {

        }
        private void SearchControl_Load(object sender, EventArgs e)
        {

            ReportViewer v = new ReportViewer();
            ComboSearchBy.Items.Add("Roll No.");
            ComboSearchBy.Items.Add("First Name");
            ComboSearchBy.Items.Add("Department");
            ComboSearchBy.Items.Add("Batch");
            ComboSearchBy.Items.Add("All Registered");
            AllRegistered();
        }

        private void SearchByRollNo(string rollno)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Student_tbl where RollNo = \'"+rollno+"\'");
        }
        private void SearchByFirstName(string FirstName)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Student_tbl where FirstName = \'" + FirstName+ "\'");
        }
        private void SearchByDept(string Dept)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Student_tbl where Dept = \'" + Dept + "\'");
        }
        private void SearchByBatch(string batch)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Student_tbl where Batch = \'" + batch + "\'");
        }
        private void AllRegistered()
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Student_tbl");
        }
        private void Submit_Click(object sender, EventArgs e)
        {   
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            GetData(dataAdapter.SelectCommand.CommandText);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (ComboSearchBy.SelectedItem == "Roll No.")
            {
                SearchByRollNo(TxtSearch.Text);
            }
            else if (ComboSearchBy.SelectedItem == "First Name") 
            {
                SearchByFirstName(TxtSearch.Text);
            }
            else if (ComboSearchBy.SelectedItem == "Department") 
            {
                SearchByDept(TxtSearch.Text);
            }
            else if (ComboSearchBy.SelectedItem == "Batch") 
            {
                SearchByBatch(TxtSearch.Text);
            }
            else if (ComboSearchBy.SelectedItem == "All Registered")
            {
                AllRegistered();
            }
            else
            {
                MessageBox.Show("Please Select Search By First...!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
