﻿using System;

namespace VctoonClient.Navigations;

/// <summary>To be added.</summary>
/// <remarks>To be added.</remarks>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class QueryPropertyAttribute : Attribute
{
    public string Name { get; }

    public string QueryId { get; }


    public QueryPropertyAttribute(string name, string queryId)
    {
        Name = name;
    }
}