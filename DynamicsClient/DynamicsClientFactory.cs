// <copyright file="DynamicsClientFactory.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClient
{
    using DynamicsClient.Contracts;

    /// <summary>
    /// The factory class for Dynamics Client
    /// </summary>
    /// <seealso cref="IDynamicsClientFactory" />
    public class DynamicsClientFactory : IDynamicsClientFactory
    {
        /// <summary>
        /// Gets a dynamics web client.
        /// </summary>
        /// <returns>
        /// dynamics web client
        /// </returns>
        public DynamicsWebClientAsync GetDynamicsWebClient()
        {
            return new DynamicsWebClientAsync();
        }
    }
}