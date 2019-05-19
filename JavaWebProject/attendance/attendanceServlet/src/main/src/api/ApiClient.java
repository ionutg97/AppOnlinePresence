package api;

import java.net.URI;
import java.util.List;

import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.Entity;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.GenericType;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.UriBuilder;

import org.glassfish.jersey.client.ClientConfig;
import org.glassfish.jersey.client.HttpUrlConnectorProvider;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import DTO.TeacherAccountDTO;
import DTO.TimeTableDTO;
import DTO.UserDTO;

public class ApiClient {

	private static Logger log = LoggerFactory.getLogger(ApiClient.class);
	WebTarget service;
	public Client client;

	public ApiClient() {
		ClientConfig config = new ClientConfig();
		client = ClientBuilder.newClient(config);
		client.property(HttpUrlConnectorProvider.SET_METHOD_WORKAROUND, true);
		service = client.target(getBaseURI());
	}

	private static URI getBaseURI() {
		// TODO change the port to whatever is the server running on
		return UriBuilder.fromUri("http://localhost:3642").build();

	}

	private static void logResponse(String message, Response response) {
		log.info("{} - status: {} {}, body: \r\n{}", message, response.getStatus(),
				response.getStatusInfo().getReasonPhrase(), response.readEntity(String.class));
	}

	public String response() {

		Response response;

		response = service.path("api").path("values").request().accept(MediaType.APPLICATION_JSON).get(Response.class);
		// System.out.println(response.readEntity(String.class));
		return response.readEntity(String.class);
	}

	public String responseTest() {

		Response response;

		response = service.path("api").path("users").path("test").path("5").request().accept(MediaType.APPLICATION_JSON)
				.get(Response.class);

		String aux = response.readEntity(String.class);
		return aux;
	}

	public String doLogin(String str1, String str2) {
		Response response;
		String aux = null;
		if (str1 != null && str2 != null) {
			response = service.path("api").path("users").path("login").request()
					.header("Authorization", str1 + " " + str2).accept(MediaType.APPLICATION_JSON).get(Response.class);
			aux = response.readEntity(String.class);

		}
		return aux;
	}

	public boolean createNewUserAccount(UserDTO user) {
		Response response = null;
		if (user != null) {
			response = service.path("api").path("users").request(MediaType.APPLICATION_JSON)
					.post(Entity.entity(user, MediaType.APPLICATION_JSON), Response.class);

		}
		if (response != null && response.getStatus() == 201) {
			return true;
		} else
			return false;

	}

	public boolean createNewTeacherAccount(TeacherAccountDTO teacher) {
		Response response = null;
		if (teacher != null) {
			response = service.path("api").path("TeachersAccount").request(MediaType.APPLICATION_JSON)
					.post(Entity.entity(teacher, MediaType.APPLICATION_JSON), Response.class);

		}
		if (response != null && response.getStatus() == 201) {
			return true;
		} else
			return false;

	}
	
	// must return a list of timetableDTO...
	public void getAllTimetable(String username, String password) {
		Response response = null;

		response = service.path("api").path("users").path("timetable").request()
				.header("Authorization", username + " " + password).accept(MediaType.APPLICATION_JSON)
				.get(Response.class);
		// TimeTableDTO timetable= response.readEntity(TimeTableDTO.class);
		List<TimeTableDTO> list = response.readEntity(new GenericType<List<TimeTableDTO>>() {
		});
		System.out.println(list.size());

	}

}
