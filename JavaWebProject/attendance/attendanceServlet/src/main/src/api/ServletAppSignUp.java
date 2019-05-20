package api;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import DTO.TeacherAccountDTO;
import DTO.UserDTO;

/**
 * Servlet implementation class ServletApp
 */
@WebServlet("/ServletAppSignUp")
public class ServletAppSignUp extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */

	public ServletAppSignUp() {
		super();

		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		ApiClient a = new ApiClient();

		boolean req = false;
		PrintWriter out = response.getWriter();
		String name = request.getParameter("name");
		String pass = request.getParameter("pass");
		String confirmPass = request.getParameter("confirmPass");

		if (validareDate(name, pass, confirmPass) == true) {
			if (request.getParameter("typeAccount").equals("User Account")) {
				UserDTO user = new UserDTO(name, pass, confirmPass);
				req = a.createNewUserAccount(user);

			} else if (request.getParameter("typeAccount").equals("Teacher Account")) {
				// numele profesorului trebuie luat din interfata...
				TeacherAccountDTO teacher = new TeacherAccountDTO(name, pass, confirmPass, "Zaharia");
				req = a.createNewTeacherAccount(teacher);

			}
		}
		if (req == true) {
			// mesaj pus in interfata
			System.out.println("Cont creat cu succes");
			out.close();

		} else {

			// mesaj in interfata
			System.out.println("Nu s-a creat contul!");
		}
	}

	boolean validareDate(String name, String password, String confirmPassword) {
		if (name != null && password != null && confirmPassword != null)
			return true;
		else
			return false;

	}

}
