<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_18112023_WebFormElementleri.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h1> Form Elementleri</h1>
        <h2>Textbox</h2>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server"  Text="Tıkla" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <%-- Checkbox --%>
        <div>
            <hr />
            <h2>Checkbox</h2>
            <hr />
            <p>Kullandığınız programlama dillerini seçiniz</p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C#"/>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Pyhton"/>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Java"/>
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Kotlin"/>
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Javascript"/>
            <br />
            <asp:Button ID="btnCheckbox" runat="server" Text="Oku" OnClick="btnCheckbox_Click" />
            <br />
            <asp:Label ID="lblCheckbox" runat="server" ></asp:Label>
        </div>
        <%-- RadioButton --%>
        <div>
            <h2>RadioButton</h2>
            <hr />
            <p>Cinsiyetinizi Seçiniz</p>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Erkek"/>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Kadın" GroupName="gender" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Belirtmek İstemiyorum" GroupName="gender" />
            <br />
            <asp:Button ID="btnRadioButton" runat="server" Text="Oku" OnClick="btnRadioButton_Click" />
            <br />
            <asp:Label ID="lblRadioButton" runat="server" ></asp:Label>
        </div>
        <%-- DropdownList --%>

        <div>
            <h2>DropdownList</h2>
            <hr />
            <asp:DropDownList ID="ddlSehirler" runat="server">
            <asp:ListItem value="34">İstanbul</asp:ListItem>
            <asp:ListItem value="06">Ankara</asp:ListItem>
            <asp:ListItem value="35">İzmir</asp:ListItem>
            <asp:ListItem value="54">Sakarya</asp:ListItem>
            <asp:ListItem value="01">Adana</asp:ListItem>

            </asp:DropDownList>
            <hr />
            <asp:Button ID="btnSehirOku" runat="server" Text="Oku" OnClick="btnSehirOku_Click" />
            <asp:Button ID="btnYeniDeger" runat="server" Text="Şehirleri Değiştir" OnClick="btnYeniDeger_Click" />
            <br />
            <asp:Label ID="lblSehir" runat="server" ></asp:Label>
        </div>
        <%-- Image --%>
        <div>
            <h2>Image</h2>
            <hr />
            <asp:Image ID="Image1" runat="server" Width="300px" ImageUrl="~/images/armut.jpg" />
            <br />
            <asp:Button ID="btnImage" runat="server" Text="Değiştir" OnClick="btnImage_Click" />
        </div>
        <%-- FileUpload --%>
        <div>
            <h2>FileUpload</h2>
            <hr />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="btnUpload" runat="server" Text="Dosya Yükle" OnClick="btnUpload_Click" />
            <asp:Label ID="lblUpload" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
