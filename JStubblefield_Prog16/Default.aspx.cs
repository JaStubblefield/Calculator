/*Jason Stubblefield
 * Program 16, Due 5/8/18
 * Partner names: None
 * Description: This program validates the user's input and does calculations on it
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JStubblefield_Prog16
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                form1.Visible = false;
                double num1;
                double num2;
                double result = 0;
                char symbol = 'N';
                if (double.TryParse(X.Text, out num1) && double.TryParse(Y.Text, out num2))
                {
                    switch (Operation.Text.ToUpper())
                    {
                        case "ADDITION":
                            symbol = '+';
                            result = num1 + num2;
                            break;
                        case "SUBTRACTION":
                            symbol = '-';
                            result = num1 - num2;
                            break;
                        case "MULTIPLICATION":
                            symbol = '*';
                            result = num1 * num2;
                            break;
                        case "DIVISION":
                            if (Math.Abs(num2) < 0.0000001)
                            {
                                Response.Write("Cannot divide by zero. Hit the back button and try again.");
                            }
                            else
                            {
                                symbol = '/';
                                result = num1 / num2;
                            }
                            break;
                        default:
                            Response.Output.Write("Sorry, {0}, I am unable to determine the operation you desire. Hit the back button and try again.", Name.Text);
                            break;
                    }
                    if (symbol != 'N')
                    {
                        Response.Output.Write("{0}, here is your result: {1} {2} {3} = {4}<br /><br />", Name.Text, num1, symbol, num2, result);
                        Response.Write("If you have another calculation, please hit the Back button and enter your new information.");
                    }
                }
                else
                {
                    Response.Output.Write("Sorry, {0}, your numbers are invalid. Hit the Back button and try again.", Name.Text);
                }
            }
        }
    }
}