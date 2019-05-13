package api;

import java.net.URI;
import java.net.URI;

import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.Entity;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.MediaType
import javax.ws.rs.core.Response;
import javax.ws.rs.core.UriBuilder;

import org.glassfish.jersey.client.ClientConfig;
import org.glassfish.jersey.client.HttpUrlConnectorProvider;
import org.glassfish.jersey.client.authentication.HttpAuthenticationFeature;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.glassfish.jersey.client.ClientConfig;
import org.glassfish.jersey.client.HttpUrlConnectorProvider;

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

	public String DoLogin(String str1, String str2) {
		Response response;
		String aux = null;
		if (str1 != null && str2 != null) {
			response = service.path("api").path("users").path("test").path("5").request()
					.header("Authorization", str1 + " " + str2).accept(MediaType.APPLICATION_JSON).get(Response.class);
			aux = response.readEntity(String.class);

		}
		return aux;
	}

}
