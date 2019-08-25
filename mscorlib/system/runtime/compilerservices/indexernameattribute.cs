// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
namespace System.Runtime.CompilerServices
{
    using System;

[Serializable]
[AttributeUsage(AttributeTargets.Property, Inherited = true)]
[System.Runtime.InteropServices.ComVisible(true)]
    public sealed class IndexerName2 : Attribute
    {
        public IndexerName2(String indexerName)
        {}
    }
}
