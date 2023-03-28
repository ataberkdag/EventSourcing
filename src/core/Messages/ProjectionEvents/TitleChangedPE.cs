using Core.Domain.Abstractions;

namespace Messages.ProjectionEvents
{
    public class TitleChangedPE : IProjectionEvent
    {
        public Guid AggregateId { get; set; }
        public Guid CustomerId { get; set; }
        public string Title { get; set; }
    }
}
