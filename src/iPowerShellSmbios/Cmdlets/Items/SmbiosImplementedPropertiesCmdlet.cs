
using System.Collections.Generic;
using System.Management.Automation;

using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification;
using iTin.Hardware.Specification.Dmi;

using PowerShellSmbios.CmdLets.Results;

namespace PowerShellSmbios.CmdLets
{
    /// <summary>
    /// <para type="synopsis">Returns a collection of elements where each element represents an implemented property for given strucutre class.</para>
    /// <para type="description">The elements are suitable to be used in the 'Get-SmbiosProperty' operation as an input parameter of the '-Property' parameter.</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the all implemented properties for the 'MemoryArrayMappedAddress' structure class.
    ///     The search result returns a collection of objects with the property information.
    ///     The data type of the elements of the collection is suitable to be used as an input value in the '-Property' parameter
    ///     of the Get-SmbiosProperty operation.
    /// 
    ///     PS> Get-SmbiosImplementedProperties -Class MemoryArrayMappedAddress | SMBIOS-Implemented-Properties -Class MemoryArrayMappedAddress
    /// 
    ///     Class              : MemoryArrayMappedAddress
    ///     ClassId            : 19
    ///     HexadecimalClassId : 13
    ///     ImplementedVersion : v21
    ///     Index              : 0
    ///     PropertyKey        : Structure = MemoryArrayMappedAddress, Property = MemoryArrayHandle, Unit = None
    ///
    ///     Class              : MemoryArrayMappedAddress
    ///     ClassId            : 19
    ///     HexadecimalClassId : 13
    ///     ImplementedVersion : v21
    ///     Index              : 0
    ///     PropertyKey        : Structure = MemoryArrayMappedAddress, Property = PartitionWidth, Unit = None
    ///
    ///     Class              : MemoryArrayMappedAddress
    ///     ClassId            : 19
    ///     HexadecimalClassId : 13
    ///     ImplementedVersion : v21
    ///     Index              : 0
    ///     PropertyKey        : Structure = MemoryArrayMappedAddress, Property = StartingAddress, Unit = Bytes
    ///
    ///     Class              : MemoryArrayMappedAddress
    ///     ClassId            : 19
    ///     HexadecimalClassId : 13
    ///     ImplementedVersion : v21
    ///     Index              : 0
    ///     PropertyKey        : Structure = MemoryArrayMappedAddress, Property = EndingAddress, Unit = Bytes
    /// 
    ///   </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "SmbiosImplementedProperties")]
    [OutputType(typeof(PropertyDefinitionResult[]), typeof(string))]
    [Alias("SMBIOS-Implemented-Properties")]
    public class GetSmbiosImplementedPropertiesCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (DmiStructureClass?) Class: Gets or sets a value that contains the name of the structure class
        /// <summary>
        /// Gets or sets a value that contains the name of the structure class.
        /// <para type="description">Structure class name</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="DmiStructureClass"/> enumeration.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter the structure class name, e.g. BaseBoard, Processor, MemoryDevice")]
        public DmiStructureClass Class { get; set; }
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
            DmiStructureCollection structures = dmi.Structures;
            DmiStructure structure = structures[Class];
            DmiClass @class = structure.Elements[0];
            IEnumerable<IPropertyKey> properties = @class.ImplementedProperties;

            var result = new List<PropertyDefinitionResult>();
            foreach (var property in properties)
            {
                result.Add(
                    new PropertyDefinitionResult
                    {
                        Class = Class,
                        ClassId = (int)Class,
                        HexadecimalClassId = $"{(int)Class:X2}",
                        ImplementedVersion = $"{(@class.ImplementedVersion == DmiStructureVersion.Latest ? "Latest" : @class.ImplementedVersion.ToString())}",
                        PropertyKey = property
                    });
            }
            
            WriteObject((PropertyDefinitionResult[])result.ToArray().Clone(), true);
        }
        #endregion

        #endregion
    }
}
