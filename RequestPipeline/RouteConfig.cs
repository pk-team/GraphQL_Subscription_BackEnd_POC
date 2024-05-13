namespace HotChocPubSub.RequestPipeline;

// EndpointMiddleware is a middleware that processes incoming HTTP requests.
public static  class MapEndpoints{
    public static void MapMInimapApiEndpoints(this WebApplication  app) {
        app.MapGet("/", context => context.Response.WriteAsync("Hello World!"));
    }
}
    
