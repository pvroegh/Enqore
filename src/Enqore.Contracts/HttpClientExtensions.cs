﻿using Enqore.Contracts.Validation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Enqore.Contracts;
public static class HttpClientExtensions
{
    public static async Task<TResponse> SendRequest<TRequest, TResponse>(this HttpClient httpClient, TRequest request, CancellationToken cancellationToken = default)
        where TRequest : IRequest<TResponse>
    {
        var response = await httpClient.PostAsJsonAsync($"/{typeof(TRequest).Name}", request, cancellationToken);
        if (response.IsSuccessStatusCode)
        {
            var value = await response.Content.ReadFromJsonAsync<TResponse>(cancellationToken: cancellationToken);
            return value!;
        }
        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
        {
            var value = await response.Content.ReadFromJsonAsync<ValidationDetails>();
            throw new ValidationException("bla");
        }
        
        throw new InvalidOperationException();
    }
}