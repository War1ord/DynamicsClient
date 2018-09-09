// <copyright file="DynamicsQuery.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Models
{
    /// <summary>
    /// The class that holds data for the dynamics query string
    /// </summary>
    public class DynamicsQuery
    {
        public int? Top { get; set; }

        public string[] Select { get; set; }

        public DynamicsFilterExpression[] Filter { get; set; }
    }
}