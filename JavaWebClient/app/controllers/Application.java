package controllers;

import play.libs.F.Promise;
import play.libs.ws.WS;
import play.mvc.Controller;
import play.mvc.Http.RequestBody;
import play.mvc.Result;
import utilities.LogTool;
import views.html.index;
import views.html.dashboard;

public class Application extends Controller {
	
    public static Result index() {
        return ok(index.render("Your new application is ready."));
    }
    
    public static Promise<Result> auth() {
    	LogTool.log("Authenticating");
    	RequestBody body = request().body();
		Promise<Result> result = WS.url("https://euw.api.pvp.net/api/lol/euw/v1.2/champion?api_key=e511e298-0729-48e1-9f2c-20639de4741a").get().map(response -> {
			return ok(body.toString());
		});
		return result;
    }
    
    public static Result login() {
    	return ok(dashboard.render("Login")); 
    }

}
