<%@page import="java.util.Date"%>
<%@page import="java.text.DecimalFormat"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<title>Online Attendance</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>
html,body,h1,h2,h3,h4,h5 {font-family: "Raleway", sans-serif}
</style>
<body class="w3-light-grey">

<!-- Top container -->
<div class="w3-bar w3-top w3-green w3-large" style="z-index:4">
  <button class="w3-bar-item w3-button w3-hide-large w3-hover-none w3-hover-text-light-grey" onclick="w3_open();"><i class="fa fa-bars"></i>  Menu</button>
  <span class="w3-bar-item w3-right">Online Attendance</span>
</div>

<!-- Sidebar/menu -->
<nav class="w3-sidebar w3-collapse w3-white w3-animate-left" style="z-index:3;width:300px;" id="mySidebar"><br>
  <div class="w3-container w3-row">
    <div class="w3-col s4">
      <img src="images/avatar2.png" class="w3-circle w3-margin-right" style="width:46px">
    </div>
    <div class="w3-col s8 w3-bar">
      <span>Welcome, <strong>nume</strong></span><br>
      <a href="#" class="w3-bar-item w3-button"><i class="fa fa-envelope"></i></a>
      <a href="#" class="w3-bar-item w3-button"><i class="fa fa-user"></i></a>
      <a href="#" class="w3-bar-item w3-button"><i class="fa fa-cog"></i></a>
    </div>
  </div>
  <hr>
  <div class="w3-container">
    <h5>Dashboard</h5>
  </div>
  <div class="w3-bar-block">
    <a href="#" class="w3-bar-item w3-button w3-padding-16 w3-hide-large w3-dark-grey w3-hover-black" onclick="w3_close()" title="close menu"><i class="fa fa-remove fa-fw"></i>  Close Menu</a>
    <a href="#" class="w3-bar-item w3-button w3-padding"><i class="fa fa-users fa-fw"></i> Overview</a>
    <button onclick="myFunction('Demo1')"class="w3-bar-item w3-button w3-padding"><i class="fa fa-bank fa-fw"></i> My courses <i class="fa fa-caret-down"></i></button>
    <div id="Demo1" class="w3-hide">
    	<a class="w3-button w3-block w3-left-align" href="#tehnologiiinternet" onclick="schimbarecontent(event)">Tehnologii internet - proiect</button>
  		<a class="w3-button w3-block w3-left-align" href="#">Rețele de calculatoare</a>
  		<a class="w3-button w3-block w3-left-align" href="#">Baze de date</a>
  		<a class="w3-button w3-block w3-left-align" href="#">Sisteme multimedia</a>
  		<a class="w3-button w3-block w3-left-align" href="#">Sisteme multimedia - proiect</a>
  		<a class="w3-button w3-block w3-left-align" href="#">Sisteme de prelucrare grafică</a>
	</div>
    <a href="#" class="w3-bar-item w3-button w3-padding"><i class="fa fa-history fa-fw"></i> History</a>
    <a href="#" class="w3-bar-item w3-button w3-padding"><i class="fa fa-cog fa-fw"></i> Settings</a><br><br>

  </div>
</nav>


<!-- Overlay effect when opening sidebar on small screens -->
<div class="w3-overlay w3-hide-large w3-animate-opacity" onclick="w3_close()" style="cursor:pointer" title="close side menu" id="myOverlay"></div>

<!-- !PAGE CONTENT! -->
<div id= "continut" class="w3-main" style="margin-left:300px;margin-top:43px;">

  <!-- Header -->
  <header class="w3-container" style="padding-top:22px">
    <h5><b><i class="fa fa-dashboard"></i> My Dashboard</b></h5>
  </header>

  <div class="w3-row-padding w3-margin-bottom">
    <div class="w3-quarter">
      <div class="w3-container w3-red w3-padding-16">
        <div class="w3-left"><i class="fa fa-comment w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>9</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>Messages</h4>
      </div>
    </div>
    <div class="w3-quarter">
      <div class="w3-container w3-orange w3-text-white w3-padding-16">
        <div class="w3-left"><i class="fa fa-bell w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>5</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>News</h4>
      </div>
    </div>
    <div class="w3-quarter">
      <div class="w3-container w3-blue w3-padding-16">
        <div class="w3-left"><i class="fa fa-eye w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>22</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>Views</h4>
      </div>
    </div>
    <div class="w3-quarter">
      <div class="w3-container w3-teal w3-padding-16">
        <div class="w3-left"><i class="fa fa-share-alt w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>3</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>Shares</h4>
      </div>
    </div>
    
    <div class="w3-twothird">
        <h5><strong>Feeds</strong></h5>
        <table class="w3-table w3-striped w3-white">
          <tr>
            <td><i class="fa fa-calendar w3-text-blue w3-large"></i></td>
            <td>Calendar</td>
            <td><i>2018-2019</i></td>
          </tr>
          <tr>
            <td><i class="fa fa-file w3-text-red w3-large"></i></td>
            <td>Education plan-bachelor</td>
            <td><i>2018-2019</i></td>
          </tr>
          <tr>
            <td><i class="fa fa-users w3-text-yellow w3-large"></i></td>
            <td>Groups</td>
            <td><i>2018-2019</i></td>
          </tr>
          <tr>
            <td><i class="fa fa-laptop w3-text-red w3-large"></i></td>
            <td>Schedule</td>
            <td><i>2018-2019</i></td>
          </tr>
          <tr>
            <td><i class="fa fa-file w3-text-blue w3-large"></i></td>
            <td>Education plan-master</td>
            <td><i>2018-2019</i></td>
          </tr>
        </table>
      </div>
    

  <!-- End page content -->
</div>

<script>
// Get the Sidebar
var mySidebar = document.getElementById("mySidebar");

// Get the DIV with overlay effect
var overlayBg = document.getElementById("myOverlay");

var targetDiv = document.getElementById("continut");
var htmlContent = '';

// Toggle between showing and hiding the sidebar, and add overlay effect
function w3_open() {
  if (mySidebar.style.display === 'block') {
    mySidebar.style.display = 'none';
    overlayBg.style.display = "none";
  } else {
    mySidebar.style.display = 'block';
    overlayBg.style.display = "block";
  }
}

// Close the sidebar with the close button
function w3_close() {
  mySidebar.style.display = "none";
  overlayBg.style.display = "none";
}
function myFunction(id) {
	  var x = document.getElementById(id);
	  if (x.className.indexOf("w3-show") == -1) {
	    x.className += " w3-show";
	  } else { 
	    x.className = x.className.replace(" w3-show", "");
	  }
	}
function schimbarecontent(event){
	htmlContent = '<form class="w3-container"><p><label class="w3-text-green"><b>First Name</b></label><input class="w3-input w3-border w3-sand" name="first" type="text"></p><p><label class="w3-text-green"><b>Last Name</b></label><input class="w3-input w3-border w3-sand" name="last" type="text"></p><p><label class="w3-text-green"><b>Group</b></label><input class="w3-input w3-border w3-sand" name="group" type="text"></p><p><label class="w3-text-green"><b>Hour</b></label><input class="w3-input w3-border w3-sand" name="hour" type="text"></p><p><label class="w3-text-green"><b>Date</b></label><input class="w3-input w3-border w3-sand" name="date" type="text"></p><p><label class="w3-text-green"><b>Laboratory</b></label><input class="w3-input w3-border w3-sand" name="laboratory" type="text"></p><p><button class="w3-btn w3-green">Register</button></p></form></div>';
	targetDiv.innerHTML = htmlContent;	
}

</script>

</body>
</html>
