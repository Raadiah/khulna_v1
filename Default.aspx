<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Debug="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <title>Welcome</title>
        <link rel="stylesheet" type="text/css" href="homepage.css">
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" Runat="Server">
        </br></br></br></br></br></br></br></br></br></br>
    <div id="logo">
		Explore Khulna
	</div>
</br></br>
	<div id="a">
		 Your ultimate guide to the port city of Bangladesh. Sign up and be a part of the community.
	</div>
	<div>
		<button type="button" onclick="document.getElementById('Sign_Up_Form').style.display='block'; " style="width:auto;">Sign Up</button>
	</div>
</asp:Content>

