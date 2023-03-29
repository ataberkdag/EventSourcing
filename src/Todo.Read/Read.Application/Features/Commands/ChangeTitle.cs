﻿using MediatR;
using Read.Application.Services;

namespace Read.Application.Features.Commands
{
    public static class ChangeTitle
    {
        public class Command : IRequest
        {
            public Guid AggregateId { get; set; }
            public Guid CustomerId { get; set; }
            public string Title { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command>
        {
            private readonly ITodoItemService _todoItemService;

            public CommandHandler(ITodoItemService todoItemService)
            {
                _todoItemService = todoItemService;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var todoItem = await _todoItemService.GetByAggregateId(request.AggregateId);

                if (todoItem is null)
                    throw new Exception("Todo item is null");

                todoItem.Title = request.Title;

                await _todoItemService.Update(todoItem);
            }
        }
    }
}
