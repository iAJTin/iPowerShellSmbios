
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification;
using iTin.Hardware.Specification.Dmi;

using PowerShellSmbios.CmdLets.Results;

namespace PowerShellSmbios.CmdLets
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns a value that contains the location or locations of the SMBIOS property by its name.
    /// </para>
    /// <para type="description"> 
    /// If you get multiple results you can filter the result indicating the specific structure class and index into collection. For more information, please see the examples below.
    /// </para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'BiosVersion' property.
    ///     The result of the search tells us that it belongs to the 'Bios' structure class and the implemented structure version in this system is v24,
    ///     additionally the 'Structure' property stores the key that identifies this property.
    /// 
    ///     Notice, as it only returns one element.
    /// 
    ///     PS> Get-SmbiosLocateProperty -Name BiosVersion | SMBIOS-Locate-Property -Name BiosVersion
    ///
    ///     Class              : Bios
    ///     ClassId            : 0
    ///     HexadecimalClassId : 00
    ///     ImplementedVersion : v24
    ///     Index              : 0
    ///     PropertyKey        : Structure = Bios, Property = BiosVersion, Unit = None
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'AssetTag' property.
    ///     The search result tells us that it belongs to 'BaseBoard', 'Processor' and a collection of 'Memory Device'.
    /// 
    ///     Notice, as it now returns an array containing the matches
    /// 
    ///     PS> Get-SmbiosLocateProperty -Name AssetTag | SMBIOS-Locate-Property -Name AssetTag
    ///
    ///     Class              : BaseBoard
    ///     ClassId            : 2
    ///     HexadecimalClassId : 02
    ///     ImplementedVersion : Latest
    ///     Index              : 0
    ///     PropertyKey        : Structure = BaseBoard, Property = AssetTag, Unit = None
    ///
    ///     Class              : Processor
    ///     ClassId            : 4
    ///     HexadecimalClassId : 04
    ///     ImplementedVersion : v23
    ///     Index              : 0
    ///     PropertyKey        : Structure = Processor, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 0
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 1
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 2
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 3
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 4
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 5
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///      Class              : MemoryDevice
    ///      ClassId            : 17
    ///      HexadecimalClassId : 11
    ///      ImplementedVersion : v27
    ///      Index              : 6
    ///      PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    ///
    ///      Class              : MemoryDevice
    ///      ClassId            : 17
    ///      HexadecimalClassId : 11
    ///      ImplementedVersion : v27
    ///      Index              : 7
    ///      PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the property 'AssetTag' but only that of structure class 'Processor'.
    ///
    ///     Notice, as it only returns one element.
    /// 
    ///     PS>  Get-SmbiosLocateProperty -Name AssetTag -Class Processor | SMBIOS-Locate-Property -Name AssetTag -Class Processor
    ///
    ///     Class              : Processor
    ///     ClassId            : 4
    ///     HexadecimalClassId : 04
    ///     ImplementedVersion : v23
    ///     Index              : 0
    ///     PropertyKey        : Structure = Processor, Property = AssetTag, Unit = None
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'AssetTag' property but only those whose index is '0' (the first element).
    /// 
    ///     Notice, as it now returns an array containing the matches
    /// 
    ///     PS> Get-SmbiosLocateProperty -Name AssetTag -Index 0 | SMBIOS-Locate-Property -Name AssetTag -Index 0
    ///
    ///     Class              : BaseBoard
    ///     ClassId            : 2
    ///     HexadecimalClassId : 02
    ///     ImplementedVersion : Latest
    ///     Index              : 0
    ///     PropertyKey        : Structure = BaseBoard, Property = AssetTag, Unit = None
    ///
    ///     Class              : Processor
    ///     ClassId            : 4
    ///     HexadecimalClassId : 04
    ///     ImplementedVersion : v23
    ///     Index              : 0
    ///     PropertyKey        : Structure = Processor, Property = AssetTag, Unit = None
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 0
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'AssetTag' property, but only element 4 of the 'MemoryDevice' structure class.
    /// 
    ///     Notice, as it only returns one element.
    /// 
    ///     PS> Get-SmbiosLocateProperty -Name AssetTag -Class MemoryDevice -Index 4 | SMBIOS-Locate-Property -Name AssetTag -Class MemoryDevice -Index 4
    ///
    ///     Class              : MemoryDevice
    ///     ClassId            : 17
    ///     HexadecimalClassId : 11
    ///     ImplementedVersion : v27
    ///     Index              : 4
    ///     PropertyKey        : Structure = MemoryDevice, Property = AssetTag, Unit = None
    /// 
    ///   </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "SmbiosLocateProperty")]
    [OutputType(typeof(PropertyDefinitionResult), typeof(PropertyDefinitionResult[]))]
    [Alias("SMBIOS-Locate-Property")]
    public class GetSmbiosLocatePropertyCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (string) Name: Gets or sets a value that contains the name of the property to locate
        /// <summary>
        /// Gets or sets a value that contains the name of the property to locate.
        /// <para type="description">The property name to locate.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the name of the property to locate.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter the property name to locate, e.g. Manufacturer, AVX2, CacheSize, DigitalTemperatureSensor")]
        public string Name { get; set; }
        #endregion

        #region [public] (DmiStructureClass?) Class: Gets or sets a value that contains the name of the structure class to which this property belongs
        /// <summary>
        /// Gets or sets a value that contains the name of the structure class to which this property belongs. This value is optional.
        /// <para type="description">Optional structure class name</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="DmiStructureClass"/> enumeration.
        /// </value>
        [Parameter(Mandatory = false, ValueFromPipeline = true, HelpMessage = "Enter the structure class name, e.g. BaseBoard, Processor, MemoryDevice")]
        public DmiStructureClass? Class { get; set; }
        #endregion

        #region [public] (int?) Index: Gets or sets a value that contains the index of element in the collection
        /// <summary>
        /// Gets or sets a value that contains the index of element in the collection. This value is optional.
        /// <para type="description">Optional index of element in the collection</para>
        /// </summary>
        /// <value>
        /// Element index collection
        /// </value>
        [Parameter(Mandatory = false, ValueFromPipeline = true, HelpMessage = "Enter the element index collection, e.g. 0, 1, 2, 3")]
        public int? Index { get; set; }
        #endregion

        #endregion

        #region protected override methdos

        #region [protected] {override} (void) ProcessRecord: Process the command
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            DMI dmi = DMI.CreateInstance();

            var result = new List<PropertyDefinitionResult>();
            var structures = dmi.Structures;
            foreach (var structure in structures)
            {
                int index = 0;
                DmiClassCollection elements = structure.Elements;
                foreach (DmiClass element in elements)
                {
                    IEnumerable<IPropertyKey> properties = element.ImplementedProperties;
                    foreach (IPropertyKey propertyKey in properties)
                    {
                        if (!propertyKey.PropertyId.ToString().Equals(Name, StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }

                        result.Add(
                            new PropertyDefinitionResult
                            {
                                Index = index,
                                Class = structure.Class,
                                ClassId = (int)structure.Class,
                                HexadecimalClassId = $"{(int)structure.Class:X2}",
                                ImplementedVersion = $"{(element.ImplementedVersion == DmiStructureVersion.Latest ? "Latest" : element.ImplementedVersion.ToString())}",
                                PropertyKey = propertyKey
                            });
                    }
             
                    index++;
                }
            }

            IEnumerable<PropertyDefinitionResult> classFiltered =
                Class.HasValue
                    ? result.Where(property => property.Class == Class).ToList()
                    : (result as IEnumerable<PropertyDefinitionResult>).ToList();

            IEnumerable<PropertyDefinitionResult> indexfFiltered;
            if (Index.HasValue)
            {
                indexfFiltered =
                    classFiltered.Any()
                        ? classFiltered.Where(property => property.Index == Index).ToList()
                        : result.Where(property => property.Index == Index).ToList();
            }
            else
            {
                indexfFiltered = (classFiltered as IEnumerable<PropertyDefinitionResult>).ToList();
            }

            if (indexfFiltered.Count() == 1)
            {
                WriteObject(indexfFiltered.FirstOrDefault());
            }
            else
            {
                WriteObject((PropertyDefinitionResult[])indexfFiltered.ToArray().Clone(), true);
            }
        }
        #endregion

        #endregion
    }
}
