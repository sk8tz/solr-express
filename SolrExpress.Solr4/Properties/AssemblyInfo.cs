﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SolrExpress.Solr4")]
[assembly: AssemblyDescription("A simple and lightweight query .NET library for Solr 4.x")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("https://github.com/solr-express/solr-express")]
[assembly: AssemblyProduct("SolrExpress.Solr4")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("6900d200-26dc-400b-a3ac-359cd75b69bb")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]

#if STRONGNAME
[assembly: AssemblyKeyFile("SolrExpress.Solr4.snk")]
[assembly: InternalsVisibleTo("SolrExpress.Solr4.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001002bc6c1a3bbdef7c2ac7826a383c62c7fb175fb5913cd5b0be201e066889f371585a7114412a1713cbfdd491a7fcec139376c09e85fddbfef18fd18b7a0bb2ba46a6cbd1f4eb30b8998e8386626c527e2b2267f8d69cf6dd13e06f913dbed986fdabd9aab922b746a3f3380f8a4379781959743ba5176f9373618a2fd93b809ac")]
[assembly: InternalsVisibleTo("SolrExpress.Solr4.IntegrationTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001008d0094d78f0146a1097de01d358fed6b12d79e3656aca8ec32014535e9368e2e958c378bdae2cd9ca73c2d9798c400b82f73ca98cfe7b966949dce40ccd307f5d2269cca4afa91c56477111d183a148f3f8c4142a4b418a94d904227cc7b77663584e06de89b949984eab65149fa2deae65dd14ebc49c216ba6747131ef2b9b7")]
#else
[assembly: InternalsVisibleTo("SolrExpress.Solr4.Tests")]
[assembly: InternalsVisibleTo("SolrExpress.Solr4.IntegrationTests")]
#endif