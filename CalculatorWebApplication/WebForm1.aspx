<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="braille-alphabet.css" />
    <title>S/A Project</title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1" style="margin: auto;">
            <tr>
                <th>Shape Calculator</th>
                <th>Braille Convertor</th>
            </tr>
            <tr>
                <td>
                    <label for="dropdown">Select a shape:</label>
                    <select id="dropdown" name="dropdown">
                        <option value="option1">Circle</option>
                        <option value="option2">Triangle</option>
                        <option value="option3">Square</option>
                        <option value="option4">Rectangle</option>
                    </select>
                </td>
                <td rowspan="2">
                    <label>Type your text here:</label>
                    <asp:TextBox ID="txtInput" runat="server" placeholder="Enter text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td span="2">
                    <div id="inputFields">
                        <!-- Textboxes related to the selection will be inserted here -->
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Calculate Area" OnClick="btnAdd_Click" />
                </td>
                <td>
                    <asp:Button ID="btnConvert" runat="server" Text="Convert to Braille" OnClick="btnConvert_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Area of the shape (cm2) :
                </td>
                <td>
                    Braille Text :
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblBrailleResult" runat="server" Text="" style="font-size: 48px;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Braille dot count :
                </td>
                <td>
                    Braille dot count :
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblResult1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblBrailleResult1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Ink Cost (ml) :
                </td>
                <td>
                    Ink Cost (ml) :
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblResult2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblBrailleResult2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <img id="resultImage" src="" alt="Braille of the Shape" />
                    <!-- <asp:Image ID="resultImage" runat="server" src="" alt="Braille of the Shape" /> -->
                </td>
            </tr>
            <script src="script.js" type="text/javascript"></script>
            <script src="scriptIMG.js" type="text/javascript"></script>
        </table>
    </form>
</body>
</html>