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
            Dictionary<char, Tuple<string, int>> brailleMapping = new Dictionary<char, Tuple<string, int>>
    {
        { 'A', Tuple.Create("⠈", 1) },
        { 'B', Tuple.Create("⠃", 2) },
        { 'C', Tuple.Create("⠉", 2) },
        { 'D', Tuple.Create("⠙", 3) },
        { 'E', Tuple.Create("⠑", 2) },
        { 'F', Tuple.Create("⠋", 3) },
        { 'G', Tuple.Create("⠛", 4) },
        { 'H', Tuple.Create("⠓", 3) },
        { 'I', Tuple.Create("⠊", 2) },
        { 'J', Tuple.Create("⠚", 3) },
        { 'K', Tuple.Create("⠅", 2) },
        { 'L', Tuple.Create("⠇", 3) },
        { 'M', Tuple.Create("⠍", 3) },
        { 'N', Tuple.Create("⠝", 4) },
        { 'O', Tuple.Create("⠕", 3) },
        { 'P', Tuple.Create("⠏", 4) },
        { 'Q', Tuple.Create("⠟", 5) },
        { 'R', Tuple.Create("⠗", 4) },
        { 'S', Tuple.Create("⠎", 3) },
        { 'T', Tuple.Create("⠞", 4) },
        { 'U', Tuple.Create("⠥", 3) },
        { 'V', Tuple.Create("⠧", 4) },
        { 'W', Tuple.Create("⠺", 4) },
        { 'X', Tuple.Create("⠭", 4) },
        { 'Y', Tuple.Create("⠽", 5) },
        { 'Z', Tuple.Create("⠵", 4) },
        // Add more letters with their braille representation and numeric values
        { ' ', Tuple.Create(" ", 0) }, // Space
    };

            int valueCount = 0; // Variable to keep track of the total value count

            string brailleResult = "";
            text = text.ToUpper();

            foreach (char character in text)
            {
                if (brailleMapping.ContainsKey(character))
                {
                    var mapping = brailleMapping[character];
                    brailleResult += mapping.Item1; // Add braille representation
                    valueCount += mapping.Item2; // Add numeric value
                }
                else
                {
                    // Handle characters not in the mapping
                    // For example, you can leave them unchanged or handle them differently
                    brailleResult += character;
                }
            }

            return $"{brailleResult}";
        }

        [WebMethod]
        public int GetValueCount(string text)
        {
            // Implement the logic to calculate the value count based on the input text
            int valueCount = 0;

            foreach (char character in text)
            {
                // Assume you have a mapping of characters to values
                // You need to adjust this based on your actual logic
                valueCount += GetCharacterValue(character);
            }

            return valueCount;
        }

        // Helper method to get the value of a character
        private int GetCharacterValue(char character)
        {
            // Replace this with your actual logic to map characters to values
            Dictionary<char, int> characterValueMapping = new Dictionary<char, int>
    {
        { 'A', 1 },
        { 'B', 2 },
        { 'C', 2 },
        { 'D', 3 },
        { 'E', 2 },
        { 'F', 3 },
        { 'G', 4 },
        { 'H', 3 },
        { 'I', 2 },
        { 'J', 3 },
        { 'K', 2 },
        { 'L', 3 },
        { 'M', 3 },
        { 'N', 4 },
        { 'O', 3 },
        { 'P', 4 },
        { 'Q', 5 },
        { 'R', 4 },
        { 'S', 3 },
        { 'T', 4 },
        { 'U', 3 },
        { 'V', 4 },
        { 'W', 4 },
        { 'X', 4 },
        { 'Y', 5 },
        { 'Z', 4 },
        { ' ', 0 },

        // Add more mappings as needed
    };

            // Return the mapped value or 0 if not found
            return characterValueMapping.TryGetValue(character, out int value) ? value : 0;
        }


    }
}