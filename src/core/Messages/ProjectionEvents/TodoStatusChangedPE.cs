using Core.Domain.Abstractions;

namespace Messages.ProjectionEvents
{
    public class TodoStatusChangedPE : IProjectionEvent
    {
        public Guid AggregateId { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
    }
}
