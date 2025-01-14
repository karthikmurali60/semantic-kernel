﻿// Copyright (c) Microsoft. All rights reserved.

using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace Microsoft.SemanticKernel.Reliability;

public class DefaultHttpRetryHandlerFactory : IDelegatingHandlerFactory
{
    public DefaultHttpRetryHandlerFactory(HttpRetryConfig? config = null)
    {
        this.Config = config;
    }

    public DelegatingHandler Create(ILogger? logger)
    {
        return new DefaultHttpRetryHandler(this.Config, logger);
    }

    public HttpRetryConfig? Config { get; }
}
