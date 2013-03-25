<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span>
            <asp:Localize ID="Head" runat="server" meta:resourcekey="HeadResource1" 
            Text="page1"></asp:Localize>
        </span>
       <asp:Label runat="server" ID="Lable1" Text="Label1" 
            meta:resourcekey="Lable1Resource1" ></asp:Label>
    </div>
    </form>
</body>
</html>
