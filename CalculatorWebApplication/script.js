document.getElementById("dropdown").addEventListener("change", function () {
    var selectedOption = this.value;
    var inputFields = document.getElementById("inputFields");
    //var resultImage = document.getElementById("resultImage"); // Add this line

    while (inputFields.firstChild) {
        inputFields.removeChild(inputFields.firstChild);
    }

    if (selectedOption === "option1") {
        //resultImage.src = "brailleImgC.jpg"; // Set the image source for option1
        var textbox1 = document.createElement("input");
        textbox1.type = "text";
        textbox1.name = "txtFirstNumber"; // ASP.NET TextBox ID
        textbox1.placeholder = "Enter the radius";
        inputFields.appendChild(textbox1);
    } else if (selectedOption === "option2") {
        //resultImage.src = "brailleImgT.jpg"; // Set the image source for option1
        var textbox2 = document.createElement("input");
        textbox2.type = "text";
        textbox2.name = "txtFirstNumber"; // ASP.NET TextBox ID
        textbox2.placeholder = "Enter the base";
        inputFields.appendChild(textbox2);
        var textbox3 = document.createElement("input");
        textbox3.type = "text";
        textbox3.name = "txtSecondNumber"; // ASP.NET TextBox ID
        textbox3.placeholder = "Enter the perpendicular height";
        inputFields.appendChild(textbox3);
    } else if (selectedOption === "option3") {
        //resultImage.src = "brailleImgS.jpg"; // Set the image source for option1
        var textbox4 = document.createElement("input");
        textbox4.type = "text";
        textbox4.name = "txtFirstNumber"; // ASP.NET TextBox ID
        textbox4.placeholder = "Enter the size";
        inputFields.appendChild(textbox4);
    } else if (selectedOption === "option4") {
        //resultImage.src = "brailleImgR.jpg"; // Set the image source for option1
        var textbox5 = document.createElement("input");
        textbox5.type = "text";
        textbox5.name = "txtFirstNumber"; // ASP.NET TextBox ID
        textbox5.placeholder = "Enter the width";
        inputFields.appendChild(textbox5);
        var textbox6 = document.createElement("input");
        textbox6.type = "text";
        textbox6.name = "txtSecondNumber"; // ASP.NET TextBox ID
        textbox6.placeholder = "Enter the length";
        inputFields.appendChild(textbox6);
    } /*else if (selectedOption === "option5") {
        //resultImage.src = "brailleImgS.jpg"; // Set the image source for option1
        var textbox7 = document.createElement("input");
        textbox7.type = "text";
        textbox7.name = "txtFirstLetter"; // ASP.NET TextBox ID
        textbox7.placeholder = "Enter your text";
        inputFields.appendChild(textbox7);
    }*/
});