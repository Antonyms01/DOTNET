using Microsoft.Extensions.Configuration;
using Q1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class demo
    {
        private static string connectionstring;

        public demo(IConfiguration config)                      //Iconfiguration:set & get config value
        {
            connectionstring = config.GetConnectionString("Default"); //To make connection with json//return connection string
        }


        public List<employee> getAll()
        {
            List<employee> list_data = new List<employee>();


            using (SqlConnection connect = new SqlConnection(connectionstring))    //In sqlconnection all methods are overridden & it has getter & setter
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("Sp_emp", connect);
                    Console.WriteLine("Connection Established");
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = cmd.ExecuteReader(); //return type is object for ExecuteReader //Fires the query
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            Console.WriteLine("{0},{1},{2}", read["id"], read["name"], read["salary"]);
                            list_data.Add(new employee { id = Convert.ToInt32(read[0]), name = read[1].ToString(), salary = Convert.ToInt32(read[2]) });
                            Console.WriteLine("================================================================================");
                        }


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return list_data;
            }
        }
        public static void addemp(employee emp)
        {
            SqlConnection connect = null;
            using (connect = new SqlConnection(connectionstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Sp_emp_store", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = emp.id;
                    cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = emp.name;
                    cmd.Parameters.Add("@psalary", SqlDbType.Float).Value = emp.salary;

                    connect.Open();
                    Console.WriteLine("Command Executed");
                    cmd.ExecuteNonQuery();
                   

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connect.Close();
                }
            }


        }

        public static void delemp(int a)
        {
            SqlConnection connect = null;
            using(connect = new SqlConnection(connectionstring))
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("sp_del", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pid",  a);
                    cmd.ExecuteNonQuery();
                   


                }
                catch(Exception e) { Console.WriteLine(e); }
            }

        }

        public static void emp_update(int x,string n,float s)
        {
            SqlConnection connect = null;
            using( connect = new SqlConnection(connectionstring))
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("emp_update", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pid", x);
                    cmd.Parameters.AddWithValue("@pname",n);
                    cmd.Parameters.AddWithValue("@psalary", s);

                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
               { Console.WriteLine(e.Message); }
            }
        }
    }
}

