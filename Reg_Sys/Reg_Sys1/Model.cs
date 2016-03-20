using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
namespace Reg_Sys
{
    class Model
    {
        private SqlConnection con;
        public Model()
        {
            string constr=ConfigurationSettings.AppSettings["Reg_DbCon"];
            con = new SqlConnection("Data Source=UNIQUENESS;Initial Catalog=Reg_Db;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //con = new SqlConnection(constr);
        }
        public DataSet GetDataSet( string SQL)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds);
            con.Close();

            return ds;
        }
        DataSet GetDataSetAll(string sqlCommand)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand(sqlCommand, new SqlConnection(con.ConnectionString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            return ds;
        }
        public DataSet getAllReg()
        {

            string cmdstring = "select * from Student_tbl ";
            return  GetDataSet(cmdstring);
        } 
        public bool insertStudent(Student st)
        {
            
            if (con!=null)
            {
                con.Open();

                string cmdstring = "insert into Student_tbl (RollNo, FirstName,LastName,Batch,Dept) values (\'" + st.RollNo+ "\', \'" + st.FirstName+ "\', \'" + st.LastName+ "\'," + st.Batch+ ",\'" + st.Department+ "\')";// "insert into Student_tbl (Id,RollNo, FirstName,LastName,Batch,Dept) values (@val6,@val1, @val2, @val3,@val4,@val5)";
                SqlCommand ing= new SqlCommand(cmdstring, con);
                if(ing.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Inserted!");
                }
                //using (SqlCommand insert = new SqlCommand())
                //{
                //    insert.CommandText = cmdstring;
                //    //insert.Parameters.AddWithValue("@val1", st.RollNo);
                //    insert.Parameters.AddWithValue("@val1", st.RollNo);
                //    insert.Parameters.AddWithValue("@val2", st.FirstName);
                //    insert.Parameters.AddWithValue("@val3", st.LastName);
                //    insert.Parameters.AddWithValue("@val4", st.Batch);
                //    insert.Parameters.AddWithValue("@val5", st.Department);
                //    insert.Connection = con;
                //    try
                //    {
                //        if (insert.ExecuteNonQuery() > 0)
                //            return true;
                //    }
                //    catch (SqlException e)
                //    {
                //        MessageBox.Show(e.ToString());
                //    }
                    }

            return false;
        }
        }
    }
