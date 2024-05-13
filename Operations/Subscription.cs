using HotChocPubSub.Domain;

namespace HotChocPubSub.Operations;

public class Subscription {
    [Subscribe]
    [Topic(SubscriptionTopics.TimeEntryCreated)]
    public TimeEntry TimeEntryCreated([EventMessage] TimeEntry timeEntry) {
        Console.WriteLine($"TimeEntry created: {timeEntry.Description}");
        return timeEntry;
    }
}