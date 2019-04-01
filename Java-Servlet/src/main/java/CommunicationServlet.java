
import java.net.URI;

import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.Entity;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.UriBuilder;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.glassfish.jersey.client.ClientConfig;
import org.glassfish.jersey.client.HttpUrlConnectorProvider;

public class CommunicationServlet {

	private static Logger log = LoggerFactory.getLogger(CommunicationServlet.class);

	private static URI getBaseURI() {
		// TODO change the port to whatever is the server running on
		return UriBuilder.fromUri("http://localhost:3642").build();

	}

	private static void logResponse(String message, Response response) {
        log.info("{} - status: {} {}, body: \r\n{}", message, response.getStatus(), response.getStatusInfo().getReasonPhrase(),
                response.readEntity(String.class));
    }
	
	 public static void main(String[] args) {
	        ClientConfig config = new ClientConfig();
	        //config.register(Custom);
	        Client client = ClientBuilder.newClient(config);
	        // Next line of code is a workaround for using PATCH
	        // A value of true declares that the client will try to set unsupported HTTP method to java.net.HttpURLConnection via reflection.
	        // PATCH workaround:
	        //    - alternative to client.property(HttpUrlConnectorProvider.SET_METHOD_WORKAROUND, true);
	        //    - also allow PATCH to have a response body
	        //    - see user1648865 response from https://stackoverflow.com/questions/17897171/how-to-have-a-patch-annotation-for-jax-rs 
	        client.property(HttpUrlConnectorProvider.SET_METHOD_WORKAROUND, true);
	        //
	        WebTarget service = client.target(getBaseURI());
	        Response response;
	       

	        response = service.path("api").path("values").request().accept(MediaType.APPLICATION_JSON).get(Response.class);
	  
	        System.out.println(response.readEntity(String.class));
	       // logResponse("Book collection", response);
	 }
}
