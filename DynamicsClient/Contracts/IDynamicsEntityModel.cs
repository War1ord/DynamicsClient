// <copyright file="IDynamicsEntityModel.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Contracts
{
    /// <summary>
    /// The Entity Model to be used with the Dynamics Client
    /// </summary>
    public interface IDynamicsEntityModel
    {
        /// <summary>
        /// Gets or sets the name of the entity collection.
        /// </summary>
        /// <value>
        /// The name of the entity collection.
        /// </value>
        string EntityCollectionName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        string Id { get; set; }
    }
}