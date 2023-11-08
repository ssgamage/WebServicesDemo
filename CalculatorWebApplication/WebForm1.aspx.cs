using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Check the selected option from the dropdown
            string selectedOption = Request.Form["dropdown"];

            // Get the values from the input fields
            double firstNumber = Convert.ToDouble(Request.Form["txtFirstNumber"]);
            double secondNumber = Convert.ToDouble(Request.Form["txtSecondNumber"]);
            //string firstLetter = Convert.ToString(Request.Form["txtFirstLetter"]);
            //string firstLetter = Request.Form["txtFirstLetter"];


            // Call the web service based on the selected option
            double result = 0.0; // Initialize result
            //string result1 = "";

            if (selectedOption == "option1")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.CircleA(firstNumber);
                //resultImage.ImageUrl = "brailleImgC.jpg"; // Set the image source for option
            }

            if (selectedOption == "option2")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.TriangleA(firstNumber, secondNumber);
                //resultImage.ImageUrl = "brailleImgT.jpg"; // Set the image source for option
            }

            if (selectedOption == "option3")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.SquareA(firstNumber);
                //resultImage.ImageUrl = "brailleImgS.jpg"; // Set the image source for option
            }

            if (selectedOption == "option4")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.RectangleA(firstNumber, secondNumber);
                //resultImage.ImageUrl = "brailleImgR.jpg"; // Set the image source for option
            }

            /*if (selectedOption == "option5")
            {
                //string option3String = "option3";
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result1 = client.ConvertToBraille(firstLetter);
                //resultImage.ImageUrl = "brailleImgS.jpg"; // Set the image source for option
            }*/
            // Add more cases for other options...

            // Display the result
            lblResult.Text = result.ToString();
            //lblResult1.Text = result1;

            // Set the image source based on the selected option
            if (selectedOption == "option1")
            {
                resultImage.ImageUrl = "brailleImgC.jpg"; // Set the image source for option1
            }

            if (selectedOption == "option2")
            {
                resultImage.ImageUrl = "brailleImgT.jpg"; // Set the image source for option1
            }

            if (selectedOption == "option3")
            {
                resultImage.ImageUrl = "brailleImgS.jpg"; // Set the image source for option1
            }

            if (selectedOption == "option4")
            {
                resultImage.ImageUrl = "brailleImgR.jpg"; // Set the image source for option1
            }
            // Add more cases for other options...*/
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            // Call the existing WebMethod from your web service to perform the conversion
            CalculatorService.CalculatorWebServiceSoapClient proxy = new CalculatorService.CalculatorWebServiceSoapClient(); // Replace YourWebService with your actual web service reference
            string userInput = txtInput.Text;
            string brailleResult = proxy.ConvertToBraille(userInput);

            // Display the Braille result in the Label
            lblBrailleResult.Text = brailleResult;
        }
    }
}