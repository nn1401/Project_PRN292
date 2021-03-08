using Project_PRN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class UserDAO
    {
        public List<Users> getAllUser()
        {
            List<Users> list = new List<Users>();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Users";
                SqlDataAdapter dap = new SqlDataAdapter(statement, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new Users(row["userId"].ToString(), row["password"].ToString(), row["fullName"].ToString(), row["address"].ToString(), row["phone"].ToString(), new Roles(int.Parse(row["roleId"].ToString()))));
                }
                return list;
            }
            catch (System.Exception)
            {
            }
            return null;
        }


        public Users getUserById(string id)
        {
            Users user = new Users();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Users where userid = '" + id + "'";
                SqlCommand cmd = new SqlCommand(statement, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string userId = dr["userId"].ToString();
                    string password = dr["password"].ToString();
                    string fullName = dr["fullName"].ToString();
                    string address = dr["address"].ToString();
                    string phone = dr["phone"].ToString();
                    Roles roleId = new Roles(int.Parse(dr["roleId"].ToString()));
                    user = new Users(userId, password, fullName, address, phone, roleId);
                }
                return user;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public Users getUserByIdAndPassword(string userName, string password)
        {
            Users user = new Users();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Users where userid = '" + userName + "' and [password] = '" + password + "'";
                SqlCommand cmd = new SqlCommand(statement, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string userId = dr["userId"].ToString();
                    string passwordd = dr["password"].ToString();
                    string fullName = dr["fullName"].ToString();
                    string address = dr["address"].ToString();
                    string phone = dr["phone"].ToString();
                    Roles roleId = new Roles(int.Parse(dr["roleId"].ToString()));
                    user = new Users(userId, passwordd, fullName, address, phone, roleId);
                }
                return user;
            }
            catch (Exception)
            {
            }
            return null;
        }




    }
}
