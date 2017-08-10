using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.DAL
{
   public class EmployeeDataAccessLayer
    {
        public string SaveEmployee(string FirstName, string LastName, string EmailId, long MobileNo, string CurrentCountry, string HomeCountry, string Address, int ZipCode)
        {
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            try
            {
                
                
                mysqlconnection.Open();
                String mysql = "INSERT INTO Employee_Details(Employee_Name,Last_Name,Email,Mobile_Number,Current_Country,Home_Country,Address, ZipCode) Values ('"
                    + FirstName + "','" + LastName + "','" + EmailId + "'," + MobileNo + ",'" + CurrentCountry + "','" + HomeCountry + "','" + Address + "'," + ZipCode + ")";
                SqlCommand employeedetails = new SqlCommand(mysql, mysqlconnection);
                int result = employeedetails.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                }
                return "failed";                
            }



            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                mysqlconnection.Close();
            }
        }
    }
}
