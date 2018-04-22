<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="selected_search_item.aspx.cs" Inherits="selected_search_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
                <title>Selected Searched Item</title>
    <link rel="stylesheet" type="text/css" href="selected_search_item.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" Runat="Server">
    <div class="content_body" style="margin: 3% 60px;">
        <div id="div_left">
            <div style="background-color: white; width: 450px; height: 350px;">
                <img />
            </div>
            <div style="margin: 30px 0% ; background-color: white; width: 450px; height:140px; text-align: center";>
                Information
            </div>
        </div>
        <div id="div_right"style="margin-left: 50px";>
            <div style="background-color: white; width: 650px; height:  70px; padding: 5px;">Title</div>
            <div style="margin: 30px 0%; background-color: white; width: 650px; height: 420px;  padding: 5px;">Description</div>
        </div>    
        </div>
</asp:Content>

