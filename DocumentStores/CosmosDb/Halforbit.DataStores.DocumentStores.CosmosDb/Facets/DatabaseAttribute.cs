﻿using Halforbit.DataStores.DocumentStores.CosmosDb.Implementation;
using Halforbit.Facets.Attributes;
using System;

namespace Halforbit.DataStores.DocumentStores.CosmosDb.Facets
{
    public class DatabaseAttribute : FacetParameterAttribute
    {
        public DatabaseAttribute(string value = null, string configKey = null) : base(value, configKey) { }

        public override Type TargetType => typeof(CosmosDbDataStore<,>);

        public override string ParameterName => "databaseId";
    }
}
