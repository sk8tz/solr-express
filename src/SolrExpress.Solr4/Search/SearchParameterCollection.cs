﻿using SolrExpress.Core.Search;
using System.Collections.Generic;
using System.Linq;

namespace SolrExpress.Solr4.Search
{
    /// <summary>
    /// Parameter collection
    /// </summary>
    public class SearchParameterCollection : ISearchParameterCollection
    {
        private IEnumerable<ISearchParameter> _parameters;

        /// <summary>
        /// Add a parameter to the query
        /// </summary>
        /// <param name="parameters">The parameter to add in the query</param>
        /// <returns>Itself</returns>
        void ISearchParameterCollection.Add(IEnumerable<ISearchParameter> parameters)
        {
            this._parameters = parameters;
        }

        /// <summary>
        /// Execute parameters and get query instructions
        /// </summary>
        /// <returns>Query instructions</returns>
        string ISearchParameterCollection.Execute()
        {
            var list = new List<string>();

            foreach (var item in this._parameters?.OrderBy(q => q.GetType().ToString()))
            {
                ((ISearchParameter<List<string>>)item).Execute(list);
            }

            return string.Join("&", list);
        }
    }
}
