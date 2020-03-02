using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templab1_Ivan
{
    public partial class Temp : System.Web.UI.Page
    {
   


        protected void Page_Load(object sender, EventArgs e)
        {
            // turn off unobtrusive validation
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            // Default Conversion
            //DropDownList1.SelectedIndex = 1;
            //DropDownList2.SelectedIndex = 0;
            // Focus on textbox on page load
            txtTemperature.Focus();
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double inputTemp, outputTemp;
            inputTemp = double.Parse(txtTemperature.Text);

            // Combobox1 = Celsius and Combobox2 = Fahrenheit
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 0)
            {
                outputTemp = (inputTemp * (1.8) + 32);
                lbloutTemp.Text = Math.Round(outputTemp, 2).ToString();
            }
            // Combobox1 = Celsius and Combobox2 = Kelvin
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 2)
            {
                outputTemp = (inputTemp + 273.15);
                lbloutTemp.Text = Math.Round(outputTemp, 2).ToString();
            }
            // Combobox1 = Fahrenheit and Combobox2 = Celsius
            if (DropDownList1.SelectedIndex == 0 && DropDownList2.SelectedIndex == 1)
            {
                outputTemp = ((inputTemp - 32) / 1.8);
                lbloutTemp.Text = Math.Round(outputTemp, 2).ToString();
            }
            // Combobox1 = Fahrenheit and Combobox2 = Kelvin
            if (DropDownList1.SelectedIndex == 0 && DropDownList2.SelectedIndex == 2)
            {
                outputTemp = ((inputTemp + 459.67) * (5/9));
                lbloutTemp.Text = Math.Round(outputTemp, 2).ToString();
            }
            // Combobox1 = Kelvin and Combobox2 = Celsius
            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 1)
            {
                outputTemp = (inputTemp - 273.15);
                lbloutTemp.Text = Math.Round(outputTemp, 2).ToString();
            }
            // Combobox1 = Kelvin and Combobox2 = Fahrenheit
            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 0)
            {
                outputTemp = ((inputTemp - 273.15) * 9/5 + 32);
                lbloutTemp.Text = Math.Round(outputTemp, 2).ToString();
            }

        }

        // Clears selection and focuses on input textbox
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtTemperature.Text = "";
            lbloutTemp.Text = "";
            txtTemperature.Focus();
        }

        
        //ignore
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}// end namespace