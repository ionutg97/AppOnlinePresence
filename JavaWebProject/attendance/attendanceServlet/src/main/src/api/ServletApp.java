package api;
import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import DTO.UserDTO;

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
		
		//String raspuns = a.doLogin(uname, upass);
		UserDTO user =new UserDTO("ionut","123456","123456");
		boolean req=a.createNewUserAccount(user);
		//a.getAllTimetable(request.getParameter("username"), request.getParameter("pass"));
		//if(raspuns.equals("\"Logare cu succes!\""))
		if(req==true)
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
