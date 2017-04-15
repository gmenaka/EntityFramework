// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Benchmarks.EFCore.Models.AdventureWorks
{
    public class AdventureWorksFixture
    {
        // This method is called from timed code, be careful when changing it
        public static AdventureWorksContext CreateContext() 
            => new AdventureWorksContext(ConnectionString);

        public static string ConnectionString { get; } = $@"Data Source=AdventureWorks2014.sdf;";
    }
}
