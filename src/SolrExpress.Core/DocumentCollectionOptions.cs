﻿using SolrExpress.Core.Search;
using System.Collections.Generic;

namespace SolrExpress.Core
{
    /// <summary>
    /// Options to control SOLR Query behavior
    /// </summary>
    public class DocumentCollectionOptions
    {
        public DocumentCollectionOptions()
        {
            this.FailFast = true;
            this.CheckAnyParameter = true;
            this.GlobalParameters = new List<ISearchParameter>();
            this.GlobalQueryInterceptors = new List<ISearchInterceptor>();
            this.GlobalResultInterceptors = new List<IResultInterceptor>();
        }

        /// <summary>
        /// If true, check for possibles fails in the use of the Solr Queriable (using SolrFieldAttribute), otherwise false. Default is true
        /// </summary>
        public bool FailFast { get; set; }

        /// <summary>
        /// If true, check for possibles misstakes in use of IANyParameter
        /// </summary>
        public bool CheckAnyParameter { get; set; }

        /// <summary>
        /// Global parameter used in all queryable intance
        /// </summary>
        public List<ISearchParameter> GlobalParameters { get; private set; }

        /// <summary>
        /// Global query interceptor used in all queryable intance
        /// </summary>
        public List<ISearchInterceptor> GlobalQueryInterceptors { get; private set; }

        /// <summary>
        /// Global result interceptor used in all queryable intance
        /// </summary>
        public List<IResultInterceptor> GlobalResultInterceptors { get; private set; }
    }

    /// <summary>
    /// Options to control SOLR Query behavior
    /// </summary>
    public class DocumentCollectionOptions<TDocument> : DocumentCollectionOptions
        where TDocument : IDocument
    {
        /// <summary>
        /// SOLR host address
        /// </summary>
        public string HostAddress { get; set; }
    }
}
