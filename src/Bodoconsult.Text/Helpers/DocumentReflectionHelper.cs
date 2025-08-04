// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Reflection;
using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Helper for getting type properties for document related types
/// </summary>
public static class DocumentReflectionHelper
{

    private static readonly Dictionary<Type, PropertyInfo[]> TypeInfo = new();

    /// <summary>
    /// Get the relevante properties of a document related type
    /// </summary>
    /// <param name="type">Document related type like Document, Paragraph etc.</param>
    /// <returns>Array with property infos</returns>
    public static PropertyInfo[] GetProperties(Type type)
    {

        if (TypeInfo.TryGetValue(type, out var properties))
        {
            return properties;
        }

        var props = type.GetProperties();

        var pi = new List<PropertyInfo>();

        foreach (var propInfo in props)
        {
            if (!propInfo.PropertyType.IsPrimitive && propInfo.PropertyType != typeof(string) && !propInfo.PropertyType.IsEnum)
            {
                continue;
            }

            var attr = propInfo.GetCustomAttributes(typeof(DoNotSerializeAttribute), true);
            if (attr.Length != 0)
            {
                continue;
            }

            pi.Add(propInfo);
        }

        var pia = pi.ToArray();

        TypeInfo.Add(type, pia);

        return pia;
    }

}


