<%@page import="api.ApiClient"%>
<%@page import="java.util.Map"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<form action="Adaugare" method="post">
		<input type="text" name="user" />
		<input type="text" name="pass" /> 
		<input type="submit" name="Adauga" />
	</form>
	
	<ol>
		<%
	ApiClient a = new ApiClient();
	String raspuns = a.response();
	out.print(raspuns);
	%>
		<%= raspuns %>


	</ol>


</body>
</html>