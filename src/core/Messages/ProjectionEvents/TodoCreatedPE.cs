using Core.Domain.Abstractions;

namespace Messages.ProjectionEvents
{
    public class TodoCreatedPE : IProjectionEvent
    {
        public Guid AggregateId { get; set; }
        public Guid CustomerId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
