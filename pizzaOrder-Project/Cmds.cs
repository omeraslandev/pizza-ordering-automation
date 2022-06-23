using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pizzaOrder_Project
{
    public class Cmds
    {
        private static string constring = "Connectionstring";
        public SqlConnection con = new SqlConnection(constring);

        public void loginTheSystem(string Username)
        {
            SqlCommand selectcmd = new SqlCommand("select * from Userss where Username=@Username", con);
            selectcmd.Parameters.AddWithValue("@Username", Username);

            SqlDataReader reader = selectcmd.ExecuteReader();
            while (reader.Read())
            {
                User.Username = reader["Username"].ToString();
                User.Password = reader["Password"].ToString();
                User.Adress = reader["Adress"].ToString();
                User.Phone = reader["Phone"].ToString();
                User.AccountDate = reader["Date"].ToString();
                User.ID = int.Parse(reader["ID"].ToString());

                break;
            }
        }
        public bool RepeatControl(string Username)
        {
            con.Open();
            SqlCommand repeatcmd = new SqlCommand("select * from Userss where Username=@Username", con);
            repeatcmd.Parameters.AddWithValue("@Username", Username);
            SqlDataReader dr = repeatcmd.ExecuteReader();
            if (dr.Read())//tekrar ediyorsa,
            {
                con.Close();
                return false;
            }

            else//tekrar etmiyorsa,
            {
                con.Close();
                return true;
            }
        }

        public void Update(string Tag,string NewText,string OldText)
        {
            con.Open();

            string query = $"update Userss set {Tag}=@NewTag where {Tag}=@OldTag";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NewTag", NewText);
            cmd.Parameters.AddWithValue("@OldTag", OldText);

            cmd.ExecuteNonQuery();

            con.Close();
        }
        public DataTable OrderHistory()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Orders where Username=@Username", con);

            cmd.Parameters.AddWithValue("@Username", User.Username);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            con.Close();

            return dt;
        }
        public int OrderNumber()
        {
            return OrderHistory().Rows.Count;
        }
    }

}