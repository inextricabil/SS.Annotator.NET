using System.Collections.Generic;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Class for list of temporal expressions
    ///     required by the composite pattern.
    /// </summary>
    public abstract class TEList : TemporalExpression
    {
        protected List<TemporalExpression> Expressions;

        public TEList()
        {
            Expressions = new List<TemporalExpression>();
        }

        /// <summary>
        ///     Adds a temporal expression to the list
        /// </summary>
        /// <param name="expr">Temporal expression to add.</param>
        public void Add(TemporalExpression expr)
        {
            Expressions.Add(expr);
        }
    }
}