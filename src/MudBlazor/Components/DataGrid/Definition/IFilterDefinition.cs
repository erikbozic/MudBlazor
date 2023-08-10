// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace MudBlazor
{
#nullable enable
    
    /// <summary>
    /// This is meant to be transmitted on the wire (probably json), so it can be used on the server
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFilterDefinitionForBuilder<T>
    {
        Guid Id { get; set; }

        string? PropertyName { get; }

        string? Title { get; set; }

        string? Operator { get; set; }

        object? Value { get; set; }

        FieldType FieldType { get; }
    }
    
    public interface IFilterDefinition<T> : IFilterDefinitionForBuilder<T>
    {
        Column<T>? Column { get; set; }

        string? IFilterDefinitionForBuilder<T>.PropertyName => Column?.PropertyName;

        FieldType IFilterDefinitionForBuilder<T>.FieldType => FieldType.Identify(Column?.PropertyType);

        Func<T, bool> GenerateFilterFunction(FilterOptions? filterOptions = null);

        IFilterDefinition<T> Clone();
    }
}
