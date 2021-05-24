<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="calculator.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        

        </p>
    <p>
        
        Istoricul valorilor:
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" >
            <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="a" HeaderText="a" HeaderStyle-HorizontalAlign="Center" />
        <asp:BoundField ItemStyle-Width="150px" DataField="b" HeaderText="b" HeaderStyle-HorizontalAlign="Center"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="c" HeaderText="c"  HeaderStyle-HorizontalAlign="Center"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="delta" HeaderText="delta" HeaderStyle-HorizontalAlign="Center"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="x1" HeaderText="x1" HeaderStyle-HorizontalAlign="Center"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="x2" HeaderText="x2" HeaderStyle-HorizontalAlign="Center"/>
    </Columns>
            
        </asp:GridView>
        
        </p>
</asp:Content>
