using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addis_River_Side_Attendance_System
{
    class Database
    {
        string url = "Server=ELROE;database=EMS;uid=Elroe;pwd=Elroe";
        public void addEmployee (Employee emp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(url))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addEmp", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@finame", emp.finame);
                    cmd.Parameters.AddWithValue("@faname", emp.faname);
                    cmd.Parameters.AddWithValue("@gfname", emp.gfname);
                    cmd.Parameters.AddWithValue("@dob", emp.dob);
                    cmd.Parameters.AddWithValue("@gender", emp.gen);
                    cmd.Parameters.AddWithValue("@hdate", emp.hdate);
                    cmd.Parameters.AddWithValue("@phonenum", emp.pnum);
                    cmd.Parameters.AddWithValue("@acc", emp.acc);
                    cmd.Parameters.AddWithValue("@fid", emp.fid);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Successful");
                }
            }
            catch 
            {
                MessageBox.Show("Unuccessful!");
            }
        }
        public void editEmployee(Employee emp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(url))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_editEmp", con);
                    cmd.CommandType = CommandType.StoredProcedure;                    
                    cmd.Parameters.AddWithValue("@finame", emp.finame);
                    cmd.Parameters.AddWithValue("@faname", emp.faname);
                    cmd.Parameters.AddWithValue("@gfname", emp.gfname);
                    cmd.Parameters.AddWithValue("@dob", emp.dob);
                    cmd.Parameters.AddWithValue("@gender", emp.gen);
                    cmd.Parameters.AddWithValue("@hdate", emp.hdate);
                    cmd.Parameters.AddWithValue("@phonenum", emp.pnum);
                    cmd.Parameters.AddWithValue("@acc", emp.acc);
                    cmd.Parameters.AddWithValue("@fid", emp.fid);
                    cmd.Parameters.AddWithValue("@ldate", emp.ldate);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successful");
                }
            }
            catch
            {
                MessageBox.Show("Unuccessful!");
            }
        }

        public void addAdmin(Admin a)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(url))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@finame", a.finame);
                    cmd.Parameters.AddWithValue("@faname", a.faname);
                    cmd.Parameters.AddWithValue("@gfname", a.gfname);
                    cmd.Parameters.AddWithValue("@uname", a.uname);
                    cmd.Parameters.AddWithValue("@pw", a.pw);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successful");
                }
            }
            catch
            {
                MessageBox.Show("Unuccessful!");
            }
        }

        public void deleteEmp(Employee emp)
        {
            ;
        }

        public DataTable searchEmp(string name)
        {
            string query;
            if (name.Contains(" "))
            {
                string finame, faname;
                int idx, len;
                idx = name.IndexOf(" ");
                len = name.Length;
                finame = name.Substring(0, idx);
                faname = name.Substring(idx + 1);
                query = "EXEC spSearch @finame=" + finame + " , @faname=" + faname;          
            }
            else if(name!="")
            {
                query = "EXEC spSearchAll @name=" + name;
            }
            else
            {
                query = "EXEC spSearchAll ";
            }

            SqlConnection con = new SqlConnection(url);
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(ds, "Users");
                dt = ds.Tables["Users"];
            }
            catch
            {

            }
            return dt;
        }

    }
}
