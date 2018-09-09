// <copyright file="IDynamicsClientFactory.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClient.Contracts
{
    /// <summary>
    /// The factory class for Dynamics Client
    /// </summary>
    public interface IDynamicsClientFactory
    {
        /// <summary>
        /// Gets a dynamics web client.
        /// </summary>
        /// <returns>
        /// Dynamics Web Client
        /// </returns>
        DynamicsWebClientAsync GetDynamicsWebClient();

        /// <summary>
        /// Gets the dynamics metadata client.
        /// </summary>
        /// <returns>
        /// Dynamics Metadata Client
        /// </returns>
        DynamicsMetadataClientAsync GetDynamicsMetadataClient();
    }
}