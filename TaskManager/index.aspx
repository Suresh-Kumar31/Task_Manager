<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TaskManager.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 256px;
        }
        .auto-style2 {
            height: 500px;
        }
        </style>
</head>
<body>
    <h1>Task Manager</h1>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <h2>View Task</h2>
            
        </div>
        <div class="auto-style2">
        <h2>Add Task</h2>
            <asp:Label ID="Label1" runat="server" Text="Due Date:"></asp:Label><asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Due Time:"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            HH&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
            </asp:DropDownList>
            MM<br />
            <asp:Label ID="Label3" runat="server" Text="Task Subject:"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Task Completion Status:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Task" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
