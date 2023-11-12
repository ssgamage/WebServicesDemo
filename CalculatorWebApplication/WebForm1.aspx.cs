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
            double result1 = 0.0;
            double result2 = 0.0;
            //string result1 = "";

            if (selectedOption == "option1")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.CircleA(firstNumber);
                result1 = result / 0.18095573684677;
                result2 = result1 * 0.0002617994;
                //resultImage.ImageUrl = "brailleImgC.jpg"; // Set the image source for option
            }

            if (selectedOption == "option2")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.TriangleA(firstNumber, secondNumber);
                result1 = result / 0.18095573684677;
                result2 = result1 * 0.0002617994;
                //resultImage.ImageUrl = "brailleImgT.jpg"; // Set the image source for option
            }

            if (selectedOption == "option3")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.SquareA(firstNumber);
                result1 = result / 0.18095573684677;
                result2 = result1 * 0.0002617994;
                //resultImage.ImageUrl = "brailleImgS.jpg"; // Set the image source for option
            }

            if (selectedOption == "option4")
            {
                CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
                result = client.RectangleA(firstNumber, secondNumber);
                result1 = result / 0.18095573684677;
                result2 = result1 * 0.0002617994;
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

            // Round the double to the nearest integer
            double roundedNumber = Math.Round(result1);

            // Format the rounded number without decimals
            string formattedNumber = roundedNumber.ToString("0");

            // Display the result
            lblResult.Text = result.ToString();
            lblResult1.Text = formattedNumber.ToString();
            lblResult2.Text = result2.ToString();
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
            //double valueCount1 = 0.0;
            // Call the existing WebMethod from your web service to perform the conversion
            CalculatorService.CalculatorWebServiceSoapClient proxy = new CalculatorService.CalculatorWebServiceSoapClient();

            string userInput = txtInput.Text;

            // Call the ConvertToBraille method
            string brailleResult = proxy.ConvertToBraille(userInput);

            // Get the value count from the response
            int valueCount = GetValueCount(proxy, userInput);

            // Display the Braille result in the Label
            lblBrailleResult.Text = brailleResult;
            lblBrailleResult1.Text = valueCount.ToString();
            lblBrailleResult2.Text = (valueCount* 0.0002617994).ToString();
        }

        // Helper method to get the value count from the web service
        private int GetValueCount(CalculatorService.CalculatorWebServiceSoapClient proxy, string userInput)
        {
            // Call the web service method to get the value count
            int valueCount = proxy.GetValueCount(userInput);

            return valueCount;
        }
    }
}
