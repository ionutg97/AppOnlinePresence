<%@page import="java.util.Date"%>
<%@page import="java.text.DecimalFormat"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Online Attendance</title>
<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
</head>
<body>
	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-t-85 p-b-20">
				<form class="login100-form validate-form" action="ServletAppSignUP" method="post">
					<span class="login100-form-title p-b-70">
						Sign-up
					</span>
					<div style="text-align: center">
						<input type="checkbox" name="accountType" value="User Account" id="chbxuser" onchange="checkbox_changeduser()"> User Account
						<input type="checkbox" name="accountType" value="Teacher Account" id="chbxteacher" onchange="checkbox_changedteacher()"> Teacher Account
					</div>
					<div class="wrap-input100 validate-input m-t-85 m-b-35" data-validate = "Enter username">
						<input class="input100" type="text" name="username">
						<span class="focus-input100" data-placeholder="Username"></span>
					</div>
					<div class="wrap-input100 validate-input m-b-50" data-validate="Enter password">
						<input class="input100" type="password" name="pass">
						<span class="focus-input100" data-placeholder="Password"></span>
					</div>
					<div id="useraccount"></div>
					<div id="teacheraccount"></div>
					<div class="container-login100-form-btn">
						<button class="login100-form-btn">
							Sign-up
						</button>
					</div>
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
	<script>
	var checkbox = document.getElementById("chbxuser");
	function checkbox_changeduser() {
        if (checkbox.checked == true) {
        	htmlContent='<div class="wrap-input100 validate-input m-b-50" data-validate="Confirm password"><input class="input100" type="password" name="confirmPass"><span class="focus-input100" data-placeholder="Confirm Password"></span></div>'
        	useraccount.innerHTML = htmlContent;	
        }
        else{
        	htmlContent='';
        	useraccount.innerHTML = htmlContent;
        }
    }
	
	
	var checkbox2 = document.getElementById("chbxteacher");
	function checkbox_changedteacher() {
        if (checkbox2.checked == true) {
        	htmlContent='<div class="wrap-input100 validate-input m-b-50" data-validate="Confirm password"><input class="input100" type="password" name="confirmPass"><span class="focus-input100" data-placeholder="Confirm Password"></span></div><div class="wrap-input100 validate-input m-b-50" data-validate="Enter Full Name"><input class="input100" type="text" name="fullName"><span class="focus-input100" data-placeholder="Full Name"></span></div>';
        	teacheraccount.innerHTML = htmlContent;	
        }
        else{
        	htmlContent='';
        	teacheraccount.innerHTML = htmlContent;
        }
    }
	</script>
</body>
</html>