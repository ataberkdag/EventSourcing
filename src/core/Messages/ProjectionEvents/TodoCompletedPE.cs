using Core.Domain.Abstractions;

namespace Messages.ProjectionEvents
{
    public class TodoCompletedPE : IProjectionEvent
    {
        public Guid AggregateId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
