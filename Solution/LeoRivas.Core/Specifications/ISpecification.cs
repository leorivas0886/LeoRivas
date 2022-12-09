using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeoRivas.Core.Specifications
{
    public interface ISpecification<T>
    {
        /// <summary>
        /// What's the criteria of the Entity that I'm going to get. 
        /// It could be where the document' area has a subject of Architecture;
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }
        /// <summary>
        /// What other aggregates will include the entity
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }

        #region Properties for Pagination
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnable { get; }
        #endregion
    }
}
