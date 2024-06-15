
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp;

internal class EmpDAL
{
    private string _connectionString;
    public EmpDAL(IConfiguration iconfiguration)
    {
        _connectionString = iconfiguration.GetConnectionString("Default");
    }
    public List<emp> GetList()
    {
        var listEmployee = new List<emp>();
        try
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_emp_GET_LIST", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listEmployee.Add(new emp
                    {
                        Id = Convert.ToInt32(rdr["Id"]),
                        Name = rdr["Name"].ToString(),
                        Salary = Convert.ToSingle(rdr["Salary"])
                    });
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return listEmployee;
    }

}