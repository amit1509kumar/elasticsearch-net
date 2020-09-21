// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using System.Reflection;
using Elastic.Transport.Utf8Json;

namespace Elastic.Transport.Serialization.Formatters
{
	public sealed class ElasticsearchNetEnumResolver : IJsonFormatterResolver
	{
		internal static readonly IJsonFormatterResolver Instance = new ElasticsearchNetEnumResolver();

		private ElasticsearchNetEnumResolver() { }

		IJsonFormatter<T> IJsonFormatterResolver.GetFormatter<T>() => FormatterCache<T>.Formatter;

		private static class FormatterCache<T>
		{
			public static readonly IJsonFormatter<T> Formatter;

			static FormatterCache()
			{
				var type = typeof(T);

				if (type.IsNullable())
				{
					// build underlying type and use wrapped formatter.
					type = type.GenericTypeArguments[0];
					if (!type.IsEnum) return;

					var innerFormatter = Instance.GetFormatterDynamic(type);
					if (innerFormatter == null) return;

					Formatter = (IJsonFormatter<T>)Activator.CreateInstance(typeof(StaticNullableFormatter<>).MakeGenericType(type), innerFormatter);
				}
				else if (type.IsEnum)
				{
					var stringEnumAttribute = typeof(T).GetCustomAttribute<StringEnumAttribute>();
					Formatter = stringEnumAttribute != null
						? new EnumFormatter<T>(true)
						: new EnumFormatter<T>(false);
				}
			}
		}
	}
}