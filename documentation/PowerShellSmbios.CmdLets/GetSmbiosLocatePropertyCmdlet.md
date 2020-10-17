# GetSmbiosLocatePropertyCmdlet class

Returns a value that contains the location or locations of the SMBIOS property by its name.

If you get multiple results you can filter the result indicating the specific structure class and index into collection. For more information, please see the examples below.

```csharp
public class GetSmbiosLocatePropertyCmdlet : Cmdlet
```

## Public Members

| name | description |
| --- | --- |
| [GetSmbiosLocatePropertyCmdlet](GetSmbiosLocatePropertyCmdlet/GetSmbiosLocatePropertyCmdlet.md)() | The default constructor. |
| [Class](GetSmbiosLocatePropertyCmdlet/Class.md) { get; set; } | Gets or sets a value that contains the name of the structure class to which this property belongs. This value is optional. |
| [Index](GetSmbiosLocatePropertyCmdlet/Index.md) { get; set; } | Gets or sets a value that contains the index of element in the collection. This value is optional. |
| [Name](GetSmbiosLocatePropertyCmdlet/Name.md) { get; set; } | Gets or sets a value that contains the name of the property to locate. |

## Protected Members

| name | description |
| --- | --- |
| override [ProcessRecord](GetSmbiosLocatePropertyCmdlet/ProcessRecord.md)() | Process the command. |

## Examples

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'BiosVersion' property.
The result of the search tells us that it belongs to the 'Bios' structure class and the implemented structure version in this system is v24,
additionally the 'Structure' property stores the key that identifies this property.

Notice, as it only returns one element.

PS> Get-SmbiosLocateProperty -Name BiosVersion | SMBIOS-Locate-Property -Name BiosVersion

Class              : Bios
ClassId            : 0
HexadecimalClassId : 00
ImplementedVersion : v24
Index              : 0
PropertyKey        : Structure = Bios, Property = BiosVersion, Unit = None

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'AssetTag' property.
The search result tells us that it belongs to 'BaseBoard', 'Processor' and a collection of 'Memory Device'.

Notice, as it now returns an array containing the matches

PS> Get-SmbiosLocateProperty -Name AssetTag | SMBIOS-Locate-Property -Name AssetTag

Class              : BaseBoard
ClassId            : 2
HexadecimalClassId : 02
ImplementedVersion : Latest
Index              : 0
PropertyKey        : Structure = BaseBoard, Property = AssetTag, Unit = None

Class              : Processor
ClassId            : 4
HexadecimalClassId : 04
ImplementedVersion : v23
Index              : 0
PropertyKey        : Structure = Processor, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 0
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 1
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 2
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 3
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 4
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 5
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

 Class              : MemoryDevice
 ClassId            : 17
 HexadecimalClassId : 11
 ImplementedVersion : v27
 Index              : 6
 PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

 Class              : MemoryDevice
 ClassId            : 17
 HexadecimalClassId : 11
 ImplementedVersion : v27
 Index              : 7
 PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the property 'AssetTag' but only that of structure class 'Processor'.

Notice, as it only returns one element.

PS>  Get-SmbiosLocateProperty -Name AssetTag -Class Processor | SMBIOS-Locate-Property -Name AssetTag -Class Processor

Class              : Processor
ClassId            : 4
HexadecimalClassId : 04
ImplementedVersion : v23
Index              : 0
PropertyKey        : Structure = Processor, Property = AssetTag, Unit = None

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'AssetTag' property but only those whose index is '0' (the first element).

Notice, as it now returns an array containing the matches

PS> Get-SmbiosLocateProperty -Name AssetTag -Index 0 | SMBIOS-Locate-Property -Name AssetTag -Index 0

Class              : BaseBoard
ClassId            : 2
HexadecimalClassId : 02
ImplementedVersion : Latest
Index              : 0
PropertyKey        : Structure = BaseBoard, Property = AssetTag, Unit = None

Class              : Processor
ClassId            : 4
HexadecimalClassId : 04
ImplementedVersion : v23
Index              : 0
PropertyKey        : Structure = Processor, Property = AssetTag, Unit = None

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 0
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'AssetTag' property, but only element 4 of the 'MemoryDevice' structure class.

Notice, as it only returns one element.

PS> Get-SmbiosLocateProperty -Name AssetTag -Class MemoryDevice -Index 4 | SMBIOS-Locate-Property -Name AssetTag -Class MemoryDevice -Index 4

Class              : MemoryDevice
ClassId            : 17
HexadecimalClassId : 11
ImplementedVersion : v27
Index              : 4
PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None

```

## See Also

* namespace [PowerShellSmbios.CmdLets](../iPowerShellSmbios.md)

<!-- DO NOT EDIT: generated by xmldocmd for iPowerShellSmbios.dll -->
