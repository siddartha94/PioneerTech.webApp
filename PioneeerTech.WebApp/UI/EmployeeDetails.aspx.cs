using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerTechSystem.DAL;
using PioneerTech.Models.models;

namespace PioneeerTech.WebApp.UI
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeDataAccessLayer empobj = new EmployeeDataAccessLayer();
                List<int> EmpIDList = empobj.GetEmployeeID();
                int i = 0;
                foreach (int EmpID in EmpIDList)
                {
                    EmployeeIDDropDownList.Items.Insert(i, new ListItem(EmpID.ToString()));
                    i++;
                }

            }
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsModel emp = new EmployeeDetailsModel()
                {
                    Employee_Name = First_NameTextBox.Text,
                    Last_Name = Last_NameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Mobile_Number = Convert.ToInt64(Mobile_NumberTextBox.Text),
                    Address = Address1TextBox.Text,
                    Current_Country = Current_CountryTextBox.Text,
                    Home_Country = Home_CountryTextBox.Text,
                    ZipCode = Convert.ToInt32(ZipCodeTextBox.Text),
                };
                EmployeeDataAccessLayer employeedata = new EmployeeDataAccessLayer();
                string emdata = employeedata.SaveEmployee(emp);
                if (emdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter the values: " +ex.Message);
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            First_NameTextBox.Text = string.Empty;
            Last_NameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            Mobile_NumberTextBox.Text = string.Empty;
            Address1TextBox.Text = string.Empty;
            Current_CountryTextBox.Text = string.Empty;
            Home_CountryTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;

        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            EmployeeDetailsModel emdatamodels = new EmployeeDetailsModel();
            EmployeeDataAccessLayer emdataaccess = new EmployeeDataAccessLayer();
            emdatamodels = emdataaccess.GetEmployeeDetails(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            First_NameTextBox.Text = emdatamodels.Employee_Name;
            Last_NameTextBox.Text = emdatamodels.Last_Name;
            EmailTextBox.Text = emdatamodels.Email;
            Mobile_NumberTextBox.Text = emdatamodels.Mobile_Number.ToString();
            Address1TextBox.Text = emdatamodels.Address;

            Current_CountryTextBox.Text = emdatamodels.Current_Country;
            Home_CountryTextBox.Text = emdatamodels.Home_Country;
            ZipCodeTextBox.Text = emdatamodels.ZipCode.ToString();
        }
    }
}