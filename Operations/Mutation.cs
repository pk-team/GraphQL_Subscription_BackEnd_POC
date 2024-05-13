using HotChocolate.Subscriptions;

using HotChocPubSub.Domain;

namespace HotChocPubSub.Operations;

public class Mutation {
    public async Task<TimeEntry> CreateTimeEntry(
        [Service] ITopicEventSender eventSender,
        string description, 
        int hours) {
        TimeEntry timeEntry = TimeEntry.Create(description, hours);

        // Publish the event
        await eventSender.SendAsync(
            SubscriptionTopics.TimeEntryCreated, 
            timeEntry);

        return timeEntry;
    }
}
