﻿using Newtonsoft.Json.Linq;
using SolrExpress.Query;
using System.Collections.Generic;

namespace SolrExpress.Solr5.Builder
{
    /// <summary>
    /// Documents data builder
    /// </summary>
    /// <typeparam name="TDocument">Type of the document returned in the search</typeparam>
    public class DocsResultBuilder<TDocument> : IResultBuilder
        where TDocument : IDocument
    {
        /// <summary>
        /// Execute the parse of the JSON object in the list of informed document
        /// </summary>
        /// <param name="jsonObject">JSON object used in the parse</param>
        public void Execute(JObject jsonObject)
        {
            if ((jsonObject["response"] != null) && (jsonObject["response"]["docs"] != null))
            {
                this.Data = jsonObject["response"]["docs"].ToObject<List<TDocument>>();

                return;
            }

            throw new Exception.UnexpectedJsonFormatException(jsonObject.ToString());
        }

        /// <summary>
        /// Documents of the search
        /// </summary>
        public List<TDocument> Data { get; private set; }
    }
}