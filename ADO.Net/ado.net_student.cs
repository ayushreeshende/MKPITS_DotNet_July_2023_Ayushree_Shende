using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ado.net_student
{
    class studentClass

    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=student_mkpsample";
        public string Insertstudent22(int rno, string name, string gender, string hobby, string city, string dob)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "insert into student22 values(@rno,@name,@gender,@hobby,@city,@dob)";
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@rno", rno);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@hobby", hobby);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "record save successfully";
                }

            }
        }
        public string Updatestudent22(int rno, string name, string gender, string hobby, string city, string dob)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "update student22 set name=@name,gender=@gender,hobby=@hobby,city=@city,dob=@dob where rno=@rno";

                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@rno", rno);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@hobby", hobby);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "record update successfully";
                }
            }
        }
        public string Deletestudent22(int rno, string name)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "delete from student22 where rno=@rno or name=@name";
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@rno", rno);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "record delete successfully";
                }
            }
        }

        public List<studentclass> searchstudent(int rno)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "select * from students where rno=@rno";
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@rno", rno);
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<studentclass> li = new List<studentclass>();
                    while (dr.Read())
                    {
                        li.Add(new studentclass(Convert.ToInt32(dr["rno"].ToString()), dr["name"].ToString(), dr["gender"].ToString(), dr["hobby"].ToString(), dr["city"].ToString(), dr["dob"].ToString()));
                    }
                    return li;

                }
            }
        }

    }
}

