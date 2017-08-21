using PioneerTech.Models.models;
using PioneerTechSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PioneeerTech.WebApp.UI
{
    public partial class CompanyDetails1 : System.Web.UI.Page
    {
       // public object Contact_NumberTextBox { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompanyDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyDetailsModel companymodel = new CompanyDetailsModel()
                {
                    Employer_Name = Employer_NameTextBox.Text,
                    Contact_NO = Convert.ToInt64(Contact_NumberTextBox.Text),
                    Location_C = LocationTextBox.Text,
                    Website = WebsiteTextBox.Text,
                };
                CompanyDataAccess companydata = new CompanyDataAccess();
                companydata.SaveCompany(companymodel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values: " + ex.Message);
            }
        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDetailsModel companymodel = new CompanyDetailsModel();
            CompanyDataAccess companyaccess = new CompanyDataAccess();
           
            companymodel = companyaccess.GetCompanyDetails(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            Employer_NameTextBox.Text = companymodel.Employer_Name;
            Contact_NumberTextBox.Text = companymodel.Contact_NO.ToString();
            LocationTextBox.Text = companymodel.Location_C;
            WebsiteTextBox.Text = companymodel.Website;
        }

        protected void CompanyDetailsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyDetailsModel model = new CompanyDetailsModel()
                {

                    Employer_Name = Employer_NameTextBox.Text,
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    Contact_NO = Convert.ToInt64(Contact_NumberTextBox.Text),
                    Location_C = LocationTextBox.Text,
                    Website = WebsiteTextBox.Text,
                };
                CompanyDataAccess access = new CompanyDataAccess();
                string cmpaccess = access.EditCompany(model);
                if (cmpaccess.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void CompanyDetailsClear_Click(object sender, EventArgs e)
        {
            Employer_NameTextBox.Text = string.Empty;
            Contact_NumberTextBox.Text = string.Empty;
            LocationTextBox.Text = string.Empty;
            WebsiteTextBox.Text = string.Empty;
        }
    }

   
}