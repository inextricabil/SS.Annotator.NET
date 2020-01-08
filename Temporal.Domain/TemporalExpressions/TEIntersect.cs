using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Intersect checks if ALL expressions are true
    /// </summary>
    public class TEIntersect : TEList
    {
        /// <summary>
        ///     Returns true only if ALL expressions are true
        /// </summary>
        /// <param name="aDate">Date to check</param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            foreach (var te in Expressions)
                if (!te.Includes(aDate))
                    return false;
            return true;
        }
    }
}