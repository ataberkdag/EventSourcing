using Core.Domain.Abstractions;

namespace Messages.ProjectionEvents
{
    public class ContentChangedPE : IProjectionEvent
    {
        public Guid AggregateId { get; set; }
        public Guid CustomerId { get; set; }
        public string Content { get; set; }
    }
}
