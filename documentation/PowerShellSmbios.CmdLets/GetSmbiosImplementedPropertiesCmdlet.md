# GetSmbiosImplementedPropertiesCmdlet class

Returns a collection of elements where each element represents an implemented property for given strucutre class.

The elements are suitable to be used in the 'Get-SmbiosProperty' operation as an input parameter of the '-Property' parameter.

```csharp
public class GetSmbiosImplementedPropertiesCmdlet : Cmdlet
```

## Public Members

| name | description |
| --- | --- |
| [GetSmbiosImplementedPropertiesCmdlet](GetSmbiosImplementedPropertiesCmdlet/GetSmbiosImplementedPropertiesCmdlet.md)() | The default constructor. |
| [Class](GetSmbiosImplementedPropertiesCmdlet/Class.md) { get; set; } | Gets or sets a value that contains the name of the structure class. |

## Protected Members

| name | description |
| --- | --- |
| override [ProcessRecord](GetSmbiosImplementedPropertiesCmdlet/ProcessRecord.md)() | Process the command. |

## Examples

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the all implemented properties for the 'MemoryArrayMappedAddress' structure class.
The search result returns a collection of objects with the property information.
The data type of the elements of the collection is suitable to be used as an input value in the '-Property' parameter
of the Get-SmbiosProperty operation.

PS> Get-SmbiosImplementedProperties -Class MemoryArrayMappedAddress | SMBIOS-Implemented-Properties -Class MemoryArrayMappedAddress

Class              : MemoryArrayMappedAddress
ClassId            : 19
HexadecimalClassId : 13
ImplementedVersion : v21
Index              : 0
PropertyKey        : Structure = MemoryArrayMappedAddress, Property = MemoryArrayHandle, Unit = None

Class              : MemoryArrayMappedAddress
ClassId            : 19
HexadecimalClassId : 13
ImplementedVersion : v21
Index              : 0
PropertyKey        : Structure = MemoryArrayMappedAddress, Property = PartitionWidth, Unit = None

Class              : MemoryArrayMappedAddress
ClassId            : 19
HexadecimalClassId : 13
ImplementedVersion : v21
Index              : 0
PropertyKey        : Structure = MemoryArrayMappedAddress, Property = StartingAddress, Unit = Bytes

Class              : MemoryArrayMappedAddress
ClassId            : 19
HexadecimalClassId : 13
ImplementedVersion : v21
Index              : 0
PropertyKey        : Structure = MemoryArrayMappedAddress, Property = EndingAddress, Unit = Bytes

```

## See Also

* namespace [PowerShellSmbios.CmdLets](../iPowerShellSmbios.md)

<!-- DO NOT EDIT: generated by xmldocmd for iPowerShellSmbios.dll -->
