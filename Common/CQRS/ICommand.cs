﻿namespace MediatR;
public interface ICommand : IRequest;
public interface ICommand<out TResult> : IRequest<TResult>, ICommand;

public interface ICommandHandler<TCommand>: IRequestHandler<TCommand> where TCommand : ICommand;
public interface ICommandHandler<TCommand, TResult>: IRequestHandler<TCommand, TResult> where TCommand : ICommand<TResult>;

public record CreateCommandResult(long Id);
