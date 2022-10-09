
using iTin.Hardware.Specification;

namespace PowerShellSmbios.CmdLets.Results
{
    /// <summary>
    /// Class that defines the detail of a <see cref="SMBIOS"/> property.
    /// </summary>
    public class PropertyDetailResult
    {
        /// <summary>
        /// Gets or sets a value that contains the property name.
        /// <para type="description">Property name.</para>
        /// </summary>
        /// <value>
        /// Property name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value that contains the property value.
        /// <para type="description">Property value.</para>
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        public object Value { get; set; }

        /// <summary>
        /// Gets a value that contains the property units.
        /// <para type="description">Property units.</para>
        /// </summary>
        /// <value>
        /// Property units.
        /// </value>
        public string Units { get; set; }

        /// <summary>
        /// Gets or sets a value that contains the structure class name to which this property belongs.
        /// <para type="description">Structure class name to which this property belongs.</para>
        /// </summary>
        /// <value>
        /// Structure class name to which this property belongs.
        /// </value>
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets a value that contains the friendly property name.
        /// <para type="description">Friendly property name.</para>
        /// </summary>
        /// <value>
        /// Friendly property name.
        /// </value>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets a value that contains the property description.
        /// <para type="description">Property description.</para>
        /// </summary>
        /// <value>
        /// Property description.
        /// </value>
        public string Description { get; set; }
    }
}
