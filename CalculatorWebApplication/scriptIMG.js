document.getElementById("btnAdd").addEventListener("click", function (event) {
    event.preventDefault(); // Prevent the default behavior
    var selectedOption = document.getElementById("dropdown").value;

    // Call the function to set the image source based on the selected option
    setResultImage(selectedOption);
});

function setResultImage(selectedOption) {
    var resultImage = document.getElementById("resultImage");

    switch (selectedOption) {
        case "option1":
            resultImage.src = "Images/image1.jpg"; // Set the image source for option1
            break;
        case "option2":
            resultImage.src = "Images/image2.jpg"; // Set the image source for option2
            break;
        case "option3":
            resultImage.src = "Images/image3.jpg"; // Set the image source for option3
            break;
        case "option4":
            resultImage.src = "brailleImgR.jpg"; // Set the image source for option4
            break;
        default:
            resultImage.src = ""; // No image if no option matches
            break;
    }
}