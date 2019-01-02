# CsvHelper.Configuration Namespace

## Classes
&nbsp; | &nbsp;
- | -
[ClassMap](/api/CsvHelper.Configuration/ClassMap) | Maps class members to CSV fields.
[ClassMap`1](/api/CsvHelper.Configuration/ClassMap`1) | Maps class members to CSV fields.
[ClassMapCollection](/api/CsvHelper.Configuration/ClassMapCollection) | Collection that holds CsvClassMaps for record types.
[Configuration](/api/CsvHelper.Configuration/Configuration) | Configuration used for reading and writing CSV data.
[ConfigurationException](/api/CsvHelper.Configuration/ConfigurationException) | Represents configuration errors that occur.
[ConfigurationFunctions](/api/CsvHelper.Configuration/ConfigurationFunctions) | Holds the default callback methods for delegate members of ``CsvHelper.Configuration.Configuration`` .
[DefaultClassMap`1](/api/CsvHelper.Configuration/DefaultClassMap`1) | A default ``CsvHelper.Configuration.ClassMap`1`` that can be used to create a class map dynamically.
[MapTypeConverterOption](/api/CsvHelper.Configuration/MapTypeConverterOption) | Sets type converter options on a member map.
[MemberMap](/api/CsvHelper.Configuration/MemberMap) | Mapping info for a member to a CSV field.
[MemberMap`2](/api/CsvHelper.Configuration/MemberMap`2) | Mapping info for a member to a CSV field.
[MemberMapCollection](/api/CsvHelper.Configuration/MemberMapCollection) | A collection that holds ``CsvHelper.Configuration.MemberMap`` 's.
[MemberMapData](/api/CsvHelper.Configuration/MemberMapData) | The configured data for the member map.
[MemberNameCollection](/api/CsvHelper.Configuration/MemberNameCollection) | A collection that holds member names.
[MemberReferenceMap](/api/CsvHelper.Configuration/MemberReferenceMap) | Mapping info for a reference member mapping to a class.
[MemberReferenceMapCollection](/api/CsvHelper.Configuration/MemberReferenceMapCollection) | A collection that holds ``CsvHelper.Configuration.MemberReferenceMap`` 's.
[MemberReferenceMapData](/api/CsvHelper.Configuration/MemberReferenceMapData) | The configuration data for the reference map.
[ParameterMap](/api/CsvHelper.Configuration/ParameterMap) | Mapping for a constructor parameter. This may contain value type data, a constructor type map, or a reference map, depending on the type of the parameter.
[ParameterMapData](/api/CsvHelper.Configuration/ParameterMapData) | The constructor paramter data for the map.
[ParameterReferenceMap](/api/CsvHelper.Configuration/ParameterReferenceMap) | Mapping info for a reference parameter mapping to a class.
[ParameterReferenceMapData](/api/CsvHelper.Configuration/ParameterReferenceMapData) | The configuration data for the reference map.

## Interfaces
&nbsp; | &nbsp;
- | -
[IBuildableClass`1](/api/CsvHelper.Configuration/IBuildableClass`1) | Has build capabilities.
[IHasConstant`2](/api/CsvHelper.Configuration/IHasConstant`2) | Has constant capabilities.
[IHasConvertUsing`2](/api/CsvHelper.Configuration/IHasConvertUsing`2) | Has convert using capabilities.
[IHasDefault`2](/api/CsvHelper.Configuration/IHasDefault`2) | Has default capabilities.
[IHasDefaultOptions`2](/api/CsvHelper.Configuration/IHasDefaultOptions`2) | Options after a default call.
[IHasIndex`2](/api/CsvHelper.Configuration/IHasIndex`2) | Has index capabilities.
[IHasIndexOptions`2](/api/CsvHelper.Configuration/IHasIndexOptions`2) | Options after an index call.
[IHasMap`1](/api/CsvHelper.Configuration/IHasMap`1) | Has mapping capabilities.
[IHasMapOptions`2](/api/CsvHelper.Configuration/IHasMapOptions`2) | Options after a mapping call.
[IHasName`2](/api/CsvHelper.Configuration/IHasName`2) | Has name capabilities.
[IHasNameIndex`2](/api/CsvHelper.Configuration/IHasNameIndex`2) | Has name index capabilities.
[IHasNameIndexOptions`2](/api/CsvHelper.Configuration/IHasNameIndexOptions`2) | Options after a name index call.
[IHasNameOptions`2](/api/CsvHelper.Configuration/IHasNameOptions`2) | Options after a name call.
[IHasOptional`2](/api/CsvHelper.Configuration/IHasOptional`2) | Has optional capabilities.
[IHasOptionalOptions`2](/api/CsvHelper.Configuration/IHasOptionalOptions`2) | Options after an optional call.
[IHasTypeConverter`2](/api/CsvHelper.Configuration/IHasTypeConverter`2) | Has type converter capabilities.
[IHasTypeConverterOptions`2](/api/CsvHelper.Configuration/IHasTypeConverterOptions`2) | Options after a type converter call.
[IHasValidate`2](/api/CsvHelper.Configuration/IHasValidate`2) | Has validate capabilities.
[IParserConfiguration](/api/CsvHelper.Configuration/IParserConfiguration) | Configuration used for the ``CsvHelper.IParser`` .
[IReaderConfiguration](/api/CsvHelper.Configuration/IReaderConfiguration) | Configuration used for the ``CsvHelper.IReader`` .
[ISerializerConfiguration](/api/CsvHelper.Configuration/ISerializerConfiguration) | Configuration used for the ``CsvHelper.ISerializer`` .
[IWriterConfiguration](/api/CsvHelper.Configuration/IWriterConfiguration) | Configuration used for the ``CsvHelper.IWriter`` .

## Enums
&nbsp; | &nbsp;
- | -
[MemberTypes](/api/CsvHelper.Configuration/MemberTypes) | Flags for the type of members that can be used for auto mapping.
[TrimOptions](/api/CsvHelper.Configuration/TrimOptions) | Options for trimming of fields.
