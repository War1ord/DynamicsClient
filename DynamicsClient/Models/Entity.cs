// <copyright file="Entity.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Models
{
    using DynamicsClients.Contracts;

    public class Entity<T>
        where T : IDynamicsEntityModel, new()
    {
    }
}