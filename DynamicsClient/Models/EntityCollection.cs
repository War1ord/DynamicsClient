// <copyright file="EntityCollection.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Models
{
    using DynamicsClients.Contracts;

    public class EntityCollection<T>
        where T : IDynamicsEntityModel, new()
    {
    }
}