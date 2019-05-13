package api;
import java.io.*;
import java.io.IOException;
import javax.servlet.ServletException;
import api.ApiClient;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.jasper.tagplugins.jstl.core.Out;

/**
 * Servlet implementation class ServletApp
 */
@WebServlet("/ServletApp")
public class ServletApp extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
	
 	
    public ServletApp() {
        super();

    	
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		
		 //HttpSession session = request.getSession();
	      //response.setContentType("text/html");
        ApiClient a = new ApiClient();
		
		HttpSession session = request.getSession(true); 
		PrintWriter out = response.getWriter();
		String uname=request.getParameter("username");
		String upass=request.getParameter("pass");
		String raspuns = a.DoLogin(uname, upass);
		if(raspuns.equals("\"Theona\""))
		{
			response.sendRedirect("first-page-student.jsp");
			//response.getOutputStream().print(raspuns);
			
			out.close();
		
		}
		else
		{
			response.sendRedirect("error.jsp");
		}
	}

}
