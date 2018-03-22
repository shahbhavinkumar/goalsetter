<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateGoal.aspx.cs" Inherits="GoalSetter.Goal.CreateGoal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="289px" Width="376px">
        <asp:Label ID="Label1" runat="server" Text="Goal Name"></asp:Label>
        &nbsp;
        <asp:TextBox ID="tbGoalName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Goal Type"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Personal</asp:ListItem>
            <asp:ListItem>Money</asp:ListItem>
            <asp:ListItem>Family</asp:ListItem>
            <asp:ListItem>Professional</asp:ListItem>
            <asp:ListItem>Spiritual</asp:ListItem>
            <asp:ListItem>Recreational</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Goal Duration"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>5 Yr</asp:ListItem>
            <asp:ListItem>1 Yr</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem Value="3">3 Month</asp:ListItem>
            <asp:ListItem Value="1">1 Month</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnSaveGoal" runat="server" Text="Save Goal" />
        <br />
        <br />
    </asp:Panel>
</asp:Content>
