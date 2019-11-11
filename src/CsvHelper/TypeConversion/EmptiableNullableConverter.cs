using System;
using CsvHelper.Configuration;

namespace CsvHelper.TypeConversion
{
	public class EmptiableNullableConverter : ITypeConverter
	{
		private class EmptiableNullableStringConverter : StringConverter
		{
			public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
			{
				if (text == null)
				{
					return null;
				}
				return base.ConvertFromString(text, row, memberMapData);
			}

			public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
			{
				if (value == null)
				{
					return null;
				}
				return base.ConvertToString(value, row, memberMapData);
			}
		}

		private ITypeConverter BaseConverter { get; set; }

		private EmptiableNullableConverter(ITypeConverter baseConverter)
		{
			this.BaseConverter = baseConverter;
		}

		object ITypeConverter.ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
		{
			return this.BaseConverter.ConvertFromString(text, row, memberMapData);
		}

		string ITypeConverter.ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
		{
			if (value == null)
			{
				return null;
			}
			return this.BaseConverter.ConvertToString(value, row, memberMapData);
		}

		public static ITypeConverter Create<T>(bool emptiableNullable)
			where T : ITypeConverter, new()
		{
			if (typeof(T) == typeof(StringConverter) && emptiableNullable)
			{
				return new EmptiableNullableStringConverter();
			}
			var baseConverter = new T();
			if (emptiableNullable)
			{
				return new EmptiableNullableConverter(baseConverter);
			}
			return baseConverter;
		}

	}
}
