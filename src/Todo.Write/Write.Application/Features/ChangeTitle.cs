﻿using Core.Application.Common;
using MediatR;
using Write.Application.Services;

namespace Write.Application.Features
{
    public static class ChangeTitle
    {
        public class Command : IRequest<BaseResult>
        {
            public Guid TodoId { get; set; }
            public string Title { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, BaseResult>
        {
            private readonly IEventRecordManager _eventRecordManager;
            private readonly IDbContextHandler _dbContextHandler;

            public CommandHandler(IEventRecordManager eventRecordManager,
                IDbContextHandler dbContextHandler)
            {
                _eventRecordManager = eventRecordManager;
                _dbContextHandler = dbContextHandler;
            }

            public async Task<BaseResult> Handle(Command request, CancellationToken cancellationToken)
            {
                var todo = _eventRecordManager.ProduceAggregate(request.TodoId);

                todo.ChangeTitle(request.Title);

                await _eventRecordManager.SaveEvent(todo);

                await _dbContextHandler.Commit();

                return BaseResult.Success();
            }
        }
    }
}
