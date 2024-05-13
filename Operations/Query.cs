using HotChocPubSub.Domain;

namespace HotChocPubSub.Operations;

public class Query
{
    public string Greet => "Hello World!";


    public IEnumerable<TimeEntry> GetTimeEntries()
    {
        return new List<TimeEntry>
        {
            TimeEntry.Create("Configure Subscriptions with dotnet Graphql Hotchocolate", 2),
            TimeEntry.Create("Configure Grapqhl subscriptions on svelte client", 3),
            TimeEntry.Create("Dotnet background service POC", 2)
        };
    }   
}