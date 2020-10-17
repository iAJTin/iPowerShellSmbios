
namespace PowerShellSmbios.CmdLets.Results
{
    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Dmi;

    /// <summary>
    /// Class that defines the location of a <see cref="SMBIOS"/> property.
    /// </summary>
    public class PropertyDefinitionResult
    {
        /// <summary>
        /// Gets or sets a value that represents a structure class.
        /// <para type="description">Name of the structure class.</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="DmiStructureClass"/> enumeration.
        /// </value>
        public DmiStructureClass Class { get; set; }

        /// <summary>
        /// Gets a value that contains the numeric representation of the structure class.
        /// <para type="description">Numeric representation of the structure class.</para>
        /// </summary>
        /// <value>
        /// A <see cref="int"/> that contains the numeric representation of the structure class.
        /// </value>
        public int ClassId { get; set; }

        /// <summary>
        /// Gets a value that contains the hexadecimal representation of the structure class.
        /// <para type="description">Hexadecimal representation of the structure class.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the hexadecimal representation of the structure class.
        /// </value>
        public string HexadecimalClassId { get; set; }

        /// <summary>
        /// Gets a value that contains the hexadecimal representation of the structure class to which this property belongs.
        /// <para type="description">Hexadecimal representation of the structure class to which this property belongs.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the hexadecimal representation of the structure class.
        /// </value>
        public string ImplementedVersion { get; set; }

        /// <summary>
        /// Gets a value that contains the hexadecimal representation of the structure class to which this property belongs.
        /// <para type="description">Hexadecimal representation of the structure class to which this property belongs.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the hexadecimal representation of the structure class.
        /// </value>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets a value containing key that represents the property.
        /// <para type="description">Key that represents the property.</para>
        /// </summary>
        /// <value>
        /// An instance that implements the <see cref="IPropertyKey"/> interface that represents the key of the property.
        /// </value>
        public IPropertyKey PropertyKey { get; set; }
    }
}
