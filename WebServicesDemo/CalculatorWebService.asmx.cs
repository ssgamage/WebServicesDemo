using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        //[WebMethod]
        //public int Add(int firstNumber, int secondNumber)
        //{
            //return firstNumber + secondNumber;
        //}

        [WebMethod]
        public double CircleA(double firstNumber)
        {
            return firstNumber * firstNumber * 22 / 7;
        }

        [WebMethod]
        public double TriangleA(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber * 0.5;
        }

        [WebMethod]
        public double SquareA(double firstNumber)
        {
            return firstNumber * firstNumber;
        }

        [WebMethod]
        public double RectangleA(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        [WebMethod]
        public string ConvertToBraille(string text)
        {
            Dictionary<char, string> brailleMapping = new Dictionary<char, string>
            {
    
                { 'A', "⠈" },
                { 'B', "⠃" },
                { 'C', "⠉" },
                { 'D', "⠙" },
                { 'E', "⠑" },
                { 'F', "⠋" },
                { 'G', "⠛" },
                { 'H', "⠓" },
                { 'I', "⠊" },
                { 'J', "⠚" },
                { 'K', "⠅" },
                { 'L', "⠇" },
                { 'M', "⠍" },
                { 'N', "⠝" },
                { 'O', "⠕" },
                { 'P', "⠏" },
                { 'Q', "⠟" },
                { 'R', "⠗" },
                { 'S', "⠎" },
                { 'T', "⠞" },
                { 'U', "⠥" },
                { 'V', "⠧" },
                { 'W', "⠺" },
                { 'X', "⠭" },
                { 'Y', "⠽" },
                { 'Z', "⠵" },
                { ' ', " " }, // Space
            };

            string brailleResult = "";
            text = text.ToUpper();

            foreach (char character in text)
            {
                if (brailleMapping.ContainsKey(character))
                {
                    brailleResult += brailleMapping[character];
                }
                else
                {
                    // Handle characters not in the mapping
                    // For example, you can leave them unchanged or handle them differently
                    brailleResult += character;
                }
            }

            return brailleResult;
        }

    }
}
