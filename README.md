# Hotchocolate Graphql Publish Subscrib POC

Configuration

```cs
Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions();
```

Publish event

```cs
public async Task<string> MyMutation(
  [Service] ITopicEventSender eventSender
  string param1,
  string param2) {

  await eventSender.SendAsync(
      "Topic_Name_1", 
      "Payload");

  return "Payload";
}
```

subscription

```cs
[Subscribe]
[Topic("Topic_Name_1")]
public string TimeEntryCreated([EventMessage] string payload) {
    Console.WriteLine(payload);
    return payload;
}
```