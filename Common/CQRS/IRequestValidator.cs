﻿namespace MediatR;
public interface IRequestValidator<TRequest> where TRequest : IRequest
{
    Task Validate(TRequest request, CancellationToken cancellation);
}

public interface IRequestValidator<TRequest, TResult> where TRequest : IRequest<TResult>
{
    Task Validate(TRequest request,CancellationToken cancellation);
}