<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Temp.aspx.cs" Inherits="Templab1_Ivan.Temp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <header class="jumbotron text-center">
            <h1>Temperature Converter:</h1>

        </header>

        
        <main>
            <form id="form1" class="form-horizontal" runat="server">
        <div class = "form-group row">
            <asp:Image ID="Image1" runat="server" Height="279px" ImageUrl="~/Images/PW-2015-06-10-Johnston-thermometer.jpg" Width="362px" />
        </div>

        <div class = "form-group row">
            
            <label class="col-sm-3">From:</label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Fahrenheit</asp:ListItem>
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
                </asp:DropDownList>
            <label class="col-sm-4">Input Temperature:</label>
            <asp:TextBox ID="txtTemperature" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="error" runat="server" ErrorMessage="Temperature Input Required" ControlToValidate="txtTemperature" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Input must be between -1000 and 1000" ControlToValidate="txtTemperature" Display="Dynamic" MaximumValue="1000" MinimumValue="-1000" Type="Double"></asp:RangeValidator>
        </div>

            <div class = "form-group row">
                
                <label class="col-sm-3">To:</label>
                <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Fahrenheit</asp:ListItem>
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
                </asp:DropDownList>
                <label class="col-sm-4">Output Temperature:</label>
               
                <asp:Label ID="lbloutTemp" runat="server"></asp:Label>

                </div>

              
                


                <div class ="form-group row">
                    <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CausesValidation="False" />
                </div>


        
        </form>
       </main>
        <footer>&copy;2020 - by Ivan</footer>
    </div>
        
      
</body>
</html>
