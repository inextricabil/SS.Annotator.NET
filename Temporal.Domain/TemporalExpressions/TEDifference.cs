using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Difference checks if first expression is true and second
    ///     expression is false
    /// </summary>
    public class TEDifference : TemporalExpression
    {
        public TEDifference(TemporalExpression exprA, TemporalExpression exprB)
        {
            ExpressionA = exprA;
            ExpressionB = exprB;
        }

        public TemporalExpression ExpressionA { get; set; }
        public TemporalExpression ExpressionB { get; set; }

        /// <summary>
        ///     Returns true if the first expression is true and
        ///     the second expression is false
        /// </summary>
        /// <param name="aDate">Date to check</param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            return ExpressionA.Includes(aDate) && !ExpressionB.Includes(aDate);
        }
    }
}