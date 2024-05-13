using HotChocPubSub.Operations;
using HotChocPubSub.RequestPipeline;

var builder = WebApplication.CreateBuilder(args);
{
    // configure cors for any origin
    builder.Services.AddCors(options => 
        options.AddDefaultPolicy(builder => 
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()));

    builder.Services.AddGraphQLServer()
        .AddQueryType<Query>()
        .AddMutationType<Mutation>()
        .AddSubscriptionType<Subscription>()
        .AddInMemorySubscriptions();
}
WebApplication app = builder.Build(); {

    app.UseCors();
    app.UseWebSockets();
    app.MapGraphQLWebSocket();
    app.MapMInimapApiEndpoints();
    app.MapGraphQL("/yo");
    app.Run();
}
