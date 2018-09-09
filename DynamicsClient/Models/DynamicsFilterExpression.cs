// <copyright file="DynamicsFilterExpression.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Models
{
    /// <summary>
    /// Dynamics Filter Expression
    /// </summary>
    public class DynamicsFilterExpression
    {
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>
        /// The name of the field.
        /// </value>
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or sets the type of the operator.
        /// </summary>
        /// <value>
        /// The type of the operator.
        /// </value>
        public OperatorType OperatorType { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include quotes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include quotes]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeQuotes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is grouping.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is grouping; otherwise, <c>false</c>.
        /// </value>
        public bool IsGrouping { get; set; }

        /// <summary>
        /// Gets or sets the expressions.
        /// </summary>
        /// <value>
        /// The expressions.
        /// </value>
        public DynamicsFilterExpression[] Expressions { get; set; }

        /// <summary>
        /// Gets or sets the apend operator.
        /// </summary>
        /// <value>
        /// The apend operator.
        /// </value>
        public ApendOperator ApendOperator { get; set; }
    }
}