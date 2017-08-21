using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerTech.Models.models;
using System.Windows.Forms;
using System.Data;

namespace PioneerTechSystem.DAL
{
    public class EmployeeDataAccessLayer
    {

        public string SaveEmployee(EmployeeDetailsModel employee)
        {
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            try
            {


                mysqlconnection.Open();
                String mysql = "INSERT INTO Employee_Details(Employee_Name,Last_Name,Email,Mobile_Number,Current_Country,Home_Country,Address, ZipCode) Values ('"
                    + employee.Employee_Name + "','" + employee.Last_Name + "','" + employee.Email + "'," + employee.Mobile_Number + ",'" + employee.Current_Country + "','" + employee.Home_Country + "','" + employee.Address + "'," + employee.ZipCode + ")";
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

        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();


            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Employee_Details");
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeeiddata = command.ExecuteReader();
            while (employeeiddata.Read())
            {
                empid.Add(
                   employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

               );
            }
            return empid;
        }





        public EmployeeDetailsModel GetEmployeeDetails(int employeeid)
        {
            EmployeeDetailsModel empdmodel = new EmployeeDetailsModel();

            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True"; SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Employee_Details WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeedatareader = command.ExecuteReader();
            while (employeedatareader.Read())
            {
                empdmodel.EmployeeID = employeedatareader.GetInt32(employeedatareader.GetOrdinal("EmployeeID"));
                empdmodel.Employee_Name = employeedatareader.GetString(employeedatareader.GetOrdinal("First_Name"));
                empdmodel.Last_Name = employeedatareader.GetString(employeedatareader.GetOrdinal("Last_Name"));
                empdmodel.Email = employeedatareader.GetString(employeedatareader.GetOrdinal("Email"));
                empdmodel.Mobile_Number = employeedatareader.GetInt64(employeedatareader.GetOrdinal("Mobile_Number"));
                empdmodel.Address = employeedatareader.GetString(employeedatareader.GetOrdinal("Address"));
                empdmodel.Current_Country = employeedatareader.GetString(employeedatareader.GetOrdinal("Current_Country"));
                empdmodel.Home_Country = employeedatareader.GetString(employeedatareader.GetOrdinal("Home_Country"));
                empdmodel.ZipCode = employeedatareader.GetInt32(employeedatareader.GetOrdinal("ZipCode"));
            }


            return empdmodel;
        }
        public string Editemployee(EmployeeDetailsModel emmodel)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True"; SqlConnection mysqlconnection = new SqlConnection(connectionstring); 
                mysqlconnection.Open();
                string sql = @"UPDATE Employee_Details SET First_Name='" + emmodel.Employee_Name + "',Last_Name='" + emmodel.Last_Name + "',Mobile_Number=" + emmodel.Mobile_Number + ",Address='" + emmodel.Address + "',Current_Country='" + emmodel.Current_Country + "',Home_Country='" + emmodel.Home_Country + "',ZipCode=" + emmodel.ZipCode + " WHERE EmployeeID=" + emmodel.EmployeeID + "";
                SqlCommand command;
                command = new SqlCommand(sql, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                    //MessageBox.Show("Details have been updated:");
                }
                return "failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }

        }
    }
    public class EducationDataAccess
    {
        public String SaveEducation(EducationDetailsModel education)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqleducationdetails = @"INSERT INTO Education_Details(Course,specialization,Passing_Year)VALUES('" + education.Course + "'," + "'" + education.specialization + "'," + "" + education.Passing_Year + ")";
                SqlCommand command;
                command = new SqlCommand(sqleducationdetails, mysqlconnection);
                result = command.ExecuteNonQuery();
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
                
            }







        }
        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
           SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Employee_Details");

            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeeiddata = command.ExecuteReader();
            while (employeeiddata.Read())
            {
                empid.Add(
                    employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                );

            }

            return empid;
        }
        public EducationDetailsModel GetEducationDetails(int employeeid)
        {
            EducationDetailsModel detailsmodel = new EducationDetailsModel();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";


            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Education_Details WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader educationdatareader = command.ExecuteReader();
            while (educationdatareader.Read())
            {
                detailsmodel.EmployeeID = educationdatareader.GetInt32(educationdatareader.GetOrdinal("EmployeeID"));
                detailsmodel.Course = educationdatareader.GetString(educationdatareader.GetOrdinal("Course"));
                detailsmodel.specialization = educationdatareader.GetString(educationdatareader.GetOrdinal("Specialisation"));
                detailsmodel.Passing_Year = educationdatareader.GetInt32(educationdatareader.GetOrdinal("Passing_Year"));


            }
            return detailsmodel;
        }

        public string Editeducation(EducationDetailsModel edumodel)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sql = @"UPDATE Education_Details SET CourseType='" + edumodel.Course + "',CourseSpecialisation='" + edumodel.specialization + "',YearOfPass=" + edumodel.Passing_Year + " WHERE EmployeeID=" + edumodel.EmployeeID + "";
                SqlCommand command;
                command = new SqlCommand(sql, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                    //MessageBox.Show("Details have been updated:");
                }
                mysqlconnection.Close();
                return "failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }
        }
    }



    public class TechnicalDataAccess
    {
        public int SaveTechnical(TechnicalDetailsModel technical)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqltechnicaldetails = @"INSERT INTO Technical_Details(UI,Programming_Languages,Data_Bases)VALUES('" + technical.UI+ "'," + "'" + technical.Programming_Languages + "'," + "'" + technical.Data_Bases+ "')";
                SqlCommand command;
                command = new SqlCommand(sqltechnicaldetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has been occured, please contact administrator: " + ex.Message);
            }
            return result;
        }
        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Employee_Details");

            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeeiddata = command.ExecuteReader();
            while (employeeiddata.Read())
            {
                empid.Add(
                    employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                );

            }
            return empid;
        }
        public TechnicalDetailsModel GetTechnicalDetails(int employeeid)
        {
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
            TechnicalDetailsModel techdetails = new TechnicalDetailsModel();
            
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Technical_Details WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader technicaldatareader = command.ExecuteReader();
            while (technicaldatareader.Read())
            {
                techdetails.EmployeeID = technicaldatareader.GetInt32(technicaldatareader.GetOrdinal("EmployeeID"));
                techdetails.UI = technicaldatareader.GetString(technicaldatareader.GetOrdinal("UI"));
                techdetails.Programming_Languages = technicaldatareader.GetString(technicaldatareader.GetOrdinal("Programming_Languages"));
                 techdetails.Data_Bases = technicaldatareader.GetString(technicaldatareader.GetOrdinal("Databases"));
            }
            return techdetails;
        }
        public string EditTechnical(TechnicalDetailsModel technicaldetails)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sql = @"UPDATE Technical_Details SET UI='" + technicaldetails.UI + "',Programming_Languages='" + technicaldetails.Programming_Languages + "',Data_Bases='" + technicaldetails.Data_Bases + "' WHERE EmployeeID=" + technicaldetails.EmployeeID + "";
                SqlCommand command;
                command = new SqlCommand(sql, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                }
                mysqlconnection.Close();
                return "failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }
        }

    }
    public class CompanyDataAccess
    {
        public int SaveCompany(CompanyDetailsModel company)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlcompanydetails = @"INSERT INTO Company_Details(Employer_Name,Company_Details,Contact_NO,Location_C,Website)VALUES('" + company.Employer_Name + "'," + "" + company.Company_Details + "," + "" + company.Contact_NO + "," + "'" + company.Location_C + "'," + "'" + company.Website + "')";
                SqlCommand command;
                command = new SqlCommand(sqlcompanydetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
        public List<int> GetEmployeeID()
        {
            
            List<int> empid = new List<int>();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Employee_Details");

            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeeiddata = command.ExecuteReader();
            while (employeeiddata.Read())
            {
                empid.Add(
                    employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                );

            }
            return empid;
        }
        public CompanyDetailsModel GetCompanyDetails(int employeeid)
        {
            CompanyDetailsModel details = new CompanyDetailsModel();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";


            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Company_Details WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader companydatareader = command.ExecuteReader();
            while (companydatareader.Read())
            {
                details.EmployeeID = companydatareader.GetInt32(companydatareader.GetOrdinal("EmployeeID"));
                details.Employer_Name = companydatareader.GetString(companydatareader.GetOrdinal("Employer_Name"));
                details.Contact_NO = companydatareader.GetInt64(companydatareader.GetOrdinal("Contact_Number"));
                details.Location_C= companydatareader.GetString(companydatareader.GetOrdinal("Location"));
                details.Website = companydatareader.GetString(companydatareader.GetOrdinal("Website"));
            }

            return details;
        }
        public string EditCompany(CompanyDetailsModel companydetails)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sql = @"UPDATE Company_Details SET Employer_Name='" + companydetails.Employer_Name + "',Contact_Number='" + companydetails.Contact_NO + "',Location='" + companydetails.Location_C + "',Website='" + companydetails.Website + "' WHERE EmployeeID=" + companydetails.EmployeeID + "";
                SqlCommand command;
                command = new SqlCommand(sql, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                    //MessageBox.Show("Details have been updated:");
                }
                return "failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }
        }
    }
    public class ProjectDataAccess
    {
        public String SaveProject(ProjectDetailsModel project)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlprojectdetails = @"INSERT INTO Project_Details(EmployeeID,Project_ID,client,Location_tx,Roles_SW)VALUES(" + project.EmployeeID + "," + "'" + project.Project_ID + "'," + "'" + project.Client + "'," + "'" + project.Location_tx + "'," + "'" + project.Roles_SW + "')";
                SqlCommand command;
                command = new SqlCommand(sqlprojectdetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                }
                mysqlconnection.Close();
                return "failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact the administartor: " + ex.Message;
            }
            
        }
        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Employee_Details");

            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeeiddata = command.ExecuteReader();
            while (employeeiddata.Read())
            {
                empid.Add(
                    employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                );

            }
            return empid;
        }
        public ProjectDetailsModel GetProjectDetails(int employeeid)
        {
            ProjectDetailsModel prjdetails = new ProjectDetailsModel();
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM Project_Details WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader projectdatareader = command.ExecuteReader();
            while (projectdatareader.Read())
            {
                prjdetails.EmployeeID = projectdatareader.GetInt32(projectdatareader.GetOrdinal("EmployeeID"));
                prjdetails.Project_ID = projectdatareader.GetInt32(projectdatareader.GetOrdinal("Project_ID"));
                prjdetails.Client= projectdatareader.GetString(projectdatareader.GetOrdinal("Client"));
                prjdetails.Location_tx = projectdatareader.GetString(projectdatareader.GetOrdinal("Location_tx"));
                prjdetails.Roles_SW = projectdatareader.GetString(projectdatareader.GetOrdinal("Roles"));
            }
            return prjdetails;
        }
        public string EditProject(ProjectDetailsModel projectdetails)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sql = @"UPDATE Project_Details SET EmployeeID=" + projectdetails.EmployeeID + ",Project_Name='" + projectdetails.Project_ID + "',Client_Name='" + projectdetails.Client + "',Location = '" + projectdetails.Location_tx + "',Roles='" + projectdetails.Roles_SW + "' WHERE EmployeeID=" + projectdetails.EmployeeID + "";
                SqlCommand command;
                command = new SqlCommand(sql, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                }
                mysqlconnection.Close();
                return "failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }
        }
    }
}




















































