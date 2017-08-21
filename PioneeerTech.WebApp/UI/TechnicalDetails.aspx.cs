using PioneerTech.Models.models;
using PioneerTechSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PioneeerTech.WebApp.UI
{
    public partial class TechnicalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TechnicalDataAccess obj = new TechnicalDataAccess();
                List<int> EmpIDList = obj.GetEmployeeID();
                int i = 0;
                foreach (int EmpID in EmpIDList)
                {
                    EmployeeIDDropDownList.Items.Insert(i, new ListItem(EmpID.ToString()));
                    i++;
                }
            }

        }   

        protected void TechnicalDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalDetailsModel technicalmodel = new TechnicalDetailsModel()
                {
                    UI = UITextBox.Text,
                    Programming_Languages = Programming_LanguagesTextBox.Text,
                    Data_Bases = DatabasesTextBox.Text,
                };
                TechnicalDataAccess technicaldata = new TechnicalDataAccess();
                int techdata = technicaldata.SaveTechnical(technicalmodel);
                if (techdata>0)
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void TechnicalDetailsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalDetailsModel tmodels = new TechnicalDetailsModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    UI = UITextBox.Text,
                    Programming_Languages = Programming_LanguagesTextBox.Text,
                    Data_Bases = DatabasesTextBox.Text,
                };
                TechnicalDataAccess taccess = new TechnicalDataAccess();
                string tdata = taccess.EditTechnical(tmodels);
                if (tdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }

        }

        protected void TechnicalDetailsClear_Click(object sender, EventArgs e)
        {
            UITextBox.Text = string.Empty;
            Programming_LanguagesTextBox.Text = string.Empty;
            DatabasesTextBox.Text = string.Empty;
        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TechnicalDetailsModel technicalmodel = new TechnicalDetailsModel();
            TechnicalDataAccess technicaldata = new TechnicalDataAccess();
            technicalmodel = technicaldata.GetTechnicalDetails(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            UITextBox.Text = technicalmodel.UI;
            Programming_LanguagesTextBox.Text = technicalmodel.Programming_Languages;
            DatabasesTextBox.Text = technicalmodel.Data_Bases;

        }
    }
}