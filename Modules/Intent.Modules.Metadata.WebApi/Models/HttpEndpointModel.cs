﻿#nullable enable
using System.Collections.Generic;
using Intent.Metadata.Models;

namespace Intent.Modules.Metadata.WebApi.Models;

internal class HttpEndpointModel : IHttpEndpointModel
{
    public HttpEndpointModel(
        string? name,
        HttpVerb verb,
        string? baseRoute,
        string? subRoute,
        HttpMediaType? mediaType,
        bool requiresAuthorization,
        bool allowAnonymous,
        IElement internalElement,
        IReadOnlyCollection<IHttpEndpointInputModel> inputs)
    {
        Name = name;
        Verb = verb;
        BaseRoute = baseRoute;
        SubRoute = subRoute;
        MediaType = mediaType;
        RequiresAuthorization = requiresAuthorization;
        AllowAnonymous = allowAnonymous;
        InternalElement = internalElement;
        Inputs = inputs;
    }

    public string Id => InternalElement.Id;
    public string? Name { get; }
    public ITypeReference? TypeReference => InternalElement.TypeReference;
    public HttpVerb Verb { get; }
    public string? BaseRoute { get; }
    public string? SubRoute { get; }
    public HttpMediaType? MediaType { get; }
    public bool RequiresAuthorization { get; }
    public bool AllowAnonymous { get; }
    public IElement InternalElement { get; }
    public IReadOnlyCollection<IHttpEndpointInputModel> Inputs { get; }
}