
namespace PowerShellSmbios.CmdLets.Results
{
    using iTin.Hardware.Specification.Dmi;

    /// <summary>
    /// Class that defines the a SMBIOS structure.
    /// </summary>
    public class StructureResult
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
    }
}
