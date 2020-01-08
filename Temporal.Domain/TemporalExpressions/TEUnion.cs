using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Union checks if ANY expressions are true
    /// </summary>
    public class TEUnion : TEList
    {
        /// <summary>
        ///     Returns true if ANY expressions are true
        /// </summary>
        /// <param name="aDate">Date to test</param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            foreach (var te in Expressions)
                if (te.Includes(aDate))
                    return true;
            return false;
        }
    }
}