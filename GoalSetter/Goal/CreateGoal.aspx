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
        <br />
        <asp:Button ID="btnSaveGoal" runat="server" Text="Save Goal" />
    </asp:Panel>
</asp:Content>
