﻿#if NET40 || NET45
using SolrExpress.Core.DependencyInjection;
using SolrExpress.Core.Search;
using SolrExpress.Core.Utility;

namespace SolrExpress.Core.Extension
{
    public static class DocumentCollectionBuilderExtensions
    {
        /// <summary>
        /// Add SolrExpress framework services in DI container
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="builder">Options builder action</param>
        /// <returns>Configured DocumentCollectionOptionsBuilder</returns>
        public static DocumentCollectionBuilder<TDocument> AddSolrExpress<TDocument>(this DocumentCollectionBuilder<TDocument> builder)
            where TDocument : IDocument
        {
            Checker.IsNull(builder);

            var builderObj = new DocumentCollectionBuilder<TDocument>();
            var documentCollection = builderObj.Create();

            builderObj
                .Engine
                .AddSingleton<ISearchParameterBuilder<TDocument>, SearchParameterBuilder<TDocument>>(new SearchParameterBuilder<TDocument>(documentCollection.Engine))
                .AddTransient<IDocumentCollection<TDocument>, DocumentCollection<TDocument>>(documentCollection);

            return builderObj;
        }
    }
}
#endif