// Copyright 2009-2019 Josh Close and Contributors
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsvHelper.Tests.Configuration
{
	[TestClass]
	public class AwareNullStringTest
	{
		[TestMethod]
		public void POCOMapping()
		{
			var inputData = BuildTestData();

			var csv = ToCSV(inputData);

			using (var tr = new StringReader(csv))
			using (var csvr = new CsvReader(tr))
			{
				csvr.Configuration.AwareNullString = true;
				var outputData = csvr.GetRecords<TestData>().ToList();

				Assert.AreEqual(inputData.Count, outputData.Count);
				for (int i = 0; i < inputData.Count; i++)
				{
					var inputRecord = inputData[i];
					var outputRecord = outputData[i];
					Assert.AreEqual(inputRecord.IntValue, outputRecord.IntValue);
					Assert.AreEqual(inputRecord.DecimalValue, outputRecord.DecimalValue);
					Assert.AreEqual(inputRecord.DoubleValue, outputRecord.DoubleValue);
					Assert.AreEqual(inputRecord.FloatValue, outputRecord.FloatValue);
					Assert.AreEqual(inputRecord.StringValue, outputRecord.StringValue);
				}
			}
		}

		[TestMethod]
		public void Dynamic()
		{
			var inputData = BuildTestData();

			var csv = ToCSV(inputData);

			using (var tr = new StringReader(csv))
			using (var csvr = new CsvReader(tr))
			{
				csvr.Configuration.AwareNullString = true;

				var outputData = csvr.GetRecords<dynamic>().ToList();

				Assert.AreEqual(inputData.Count, outputData.Count);
				for (int i = 0; i < inputData.Count; i++)
				{
					var inputRecord = inputData[i];
					var outputRecord = outputData[i];
					Assert.AreEqual(inputRecord.IntValue?.ToString(), outputRecord.IntValue);
					Assert.AreEqual(inputRecord.DecimalValue?.ToString(), outputRecord.DecimalValue);
					Assert.AreEqual(inputRecord.DoubleValue?.ToString("G17"), outputRecord.DoubleValue);
					Assert.AreEqual(inputRecord.FloatValue?.ToString("G9"), outputRecord.FloatValue);
					Assert.AreEqual(inputRecord.StringValue, outputRecord.StringValue);
				}
			}
		}


		[TestMethod]
		public void AnonymousType()
		{
			var inputData = BuildTestData();

			var csv = ToCSV(inputData);

			using (var tr = new StringReader(csv))
			using (var csvr = new CsvReader(tr))
			{
				csvr.Configuration.AwareNullString = true;

				var anonymousTypeDefinition = new
				{
					IntValue = (int?)null,
					DecimalValue = (decimal?)null,
					DoubleValue = (double?)null,
					FloatValue = (float?)null,
					StringValue = string.Empty,
				};

				var outputData = csvr.GetRecords(anonymousTypeDefinition).ToList();

				Assert.AreEqual(inputData.Count, outputData.Count);
				for (int i = 0; i < inputData.Count; i++)
				{
					var inputRecord = inputData[i];
					var outputRecord = outputData[i];
					Assert.AreEqual(inputRecord.IntValue, outputRecord.IntValue);
					Assert.AreEqual(inputRecord.DecimalValue, outputRecord.DecimalValue);
					Assert.AreEqual(inputRecord.DoubleValue, outputRecord.DoubleValue);
					Assert.AreEqual(inputRecord.FloatValue, outputRecord.FloatValue);
					Assert.AreEqual(inputRecord.StringValue, outputRecord.StringValue);
				}
			}
		}

		private void CheckDataRow<T>( T inputValue, object outputValue)
		{
			if (inputValue == null)
			{
				Assert.IsTrue(outputValue is DBNull);
			}
			else if ( inputValue is double d )
			{
				Assert.AreEqual(d.ToString("G17"), outputValue);
			}
			else if (inputValue is float f)
			{
				Assert.AreEqual(f.ToString("G9"), outputValue);
			}
			else
			{
				Assert.AreEqual(inputValue.ToString(), outputValue);
			}
		}

		[TestMethod]
		public void DataReader()
		{
			var inputData = BuildTestData();

			var csv = ToCSV(inputData);

			using (var tr = new StringReader(csv))
			using (var csvr = new CsvReader(tr))
			{
				csvr.Configuration.AwareNullString = true;
				using (var dr = new CsvDataReader(csvr))
				{
					var dt = new System.Data.DataTable();
					dt.Load(dr);

					Assert.AreEqual(inputData.Count, dt.Rows.Count);
					for (int i = 0; i < inputData.Count; i++)
					{
						var inputRecord = inputData[i];
						var outputRecord = dt.Rows[i];
						CheckDataRow(inputRecord.IntValue, outputRecord["IntValue"]);
						CheckDataRow(inputRecord.DecimalValue, outputRecord["DecimalValue"]);
						CheckDataRow(inputRecord.DoubleValue, outputRecord["DoubleValue"]);
						CheckDataRow(inputRecord.FloatValue, outputRecord["FloatValue"]);
						CheckDataRow(inputRecord.StringValue, outputRecord["StringValue"]);
					}
				}
			}
		}

		private List<TestData> BuildTestData()
		{
			return new List<TestData>()
			{
				new TestData()
				{
					IntValue = null,
					DecimalValue = null,
					DoubleValue = null,
					FloatValue = null,
					StringValue = null,
				},
				new TestData()
				{
					IntValue = 0,
					DecimalValue = decimal.Zero,
					DoubleValue = double.NaN,
					FloatValue = float.NaN,
					StringValue = string.Empty,
				},
				new TestData()
				{
					IntValue = 1,
					DecimalValue = decimal.One,
					DoubleValue = double.PositiveInfinity,
					FloatValue = float.PositiveInfinity,
					StringValue = "null",
				},
				new TestData()
				{
					IntValue = 2,
					DecimalValue = decimal.MinusOne,
					DoubleValue = double.NegativeInfinity,
					FloatValue = float.NegativeInfinity,
					StringValue = ",",
				},
				new TestData()
				{
					IntValue = 3,
					DecimalValue = decimal.MinValue,
					DoubleValue = double.MinValue,
					FloatValue = float.MinValue,
					StringValue = "\"",
				},
				new TestData()
				{
					IntValue = 4,
					DecimalValue = decimal.MaxValue,
					DoubleValue = double.MaxValue,
					FloatValue = float.MaxValue,
					StringValue = "\",",
				},
				new TestData()
				{
					IntValue = 5,
					DecimalValue = (decimal)Math.PI,
					DoubleValue = Math.PI,
					FloatValue = MathF.PI,
					StringValue = @"


""

,""


",
				},
				new TestData()
				{
					IntValue = 6,
					DecimalValue = (decimal)double.Epsilon,
					DoubleValue = double.Epsilon,
					FloatValue = float.Epsilon,
					StringValue = "日\r本\t\b\a\n語\n\r表\r\n",
				},
			};
		}


		private string ToCSV(List<TestData> inputData)
		{
			var sb = new StringBuilder();
			using (var tw = new StringWriter(sb))
			using (var csvw = new CsvWriter(tw))
			{
				csvw.Configuration.AwareNullString = true;
				csvw.WriteRecords(inputData);
			}
			var csv = sb.ToString();
			return csv;
		}


		private class TestData
		{
			public int? IntValue { get; set; }

			public decimal? DecimalValue { get; set; }

			public double? DoubleValue { get; set; }

			public float? FloatValue { get; set; }

			public string StringValue { get; set; }


		}

	}

}
