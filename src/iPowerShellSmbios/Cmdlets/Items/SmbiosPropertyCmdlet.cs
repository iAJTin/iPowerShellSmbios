
namespace PowerShellSmbios.CmdLets
{
    using System.Management.Automation;

    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Dmi;

    using Results;

    /// <summary>
    /// <para type="synopsis">
    /// Returns a reference that contains the information associated with the given property such as the key that identifies the property and its value.
    /// </para>
    /// <para type="description">
    /// The value of the property <b>Property</b> must be obtained by calling the <b>Get-SmbiosLocateProperty</b>, for more information see the help
    /// for the <b>Get-SmbiosLocateProperty</b> and the sample examples below.
    /// </para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     How to get the value of the Vendor property?
    ///     First we make a call to 'Get-SmbiosLocateProperty', to search among all the available properties of our system those that call 'Vendor' and
    ///     then with the result obtained, we call 'Get-SmbiosProperty' to obtain the property information, remember that a property is made up of its key and its value.
    /// 
    ///     PS> Get-SmbiosProperty -Property (Get-SmbiosLocateProperty -Name Vendor -Class Bios) | SMBIOS-Property -Property (SMBIOS-Locate-Property -Name Vendor -Class Bios)
    ///
    ///     Key                                               Value
    ///     ---                                               -----
    ///      Structure = Bios, Property = Vendor, Unit = None Parallels Software International Inc.
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     How to get the value of the AssetTag property of Memory device (4) ?
    ///     First we make a call to 'Get-SmbiosLocateProperty', to search among all the available properties of our system those that call 'AssetTag' filtered to obtain
    ///     the 5th element of the array (remember zero index in arrays) and then with the result obtained, we call 'Get-SmbiosProperty' to obtain the property information,
    ///     remember that a property is made up of its key and its value.
    /// 
    ///     PS> Get-SmbiosProperty -Property (Get-SmbiosLocateProperty -Name AssetTag -Class MemoryDevice -Index 4) | SMBIOS-Property -Property (SMBIOS-Locate-Property -Name AssetTag -Class MemoryDevice -Index 4)
    ///
    ///     Name         : AssetTag
    ///     Value        :
    ///     Units        : None
    ///     Class        : MemoryDevice
    ///     FriendlyName : AssetTag
    ///     Desctiption  :
    /// 
    ///   </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "SmbiosProperty")]
    [OutputType(typeof(PropertyDefinitionResult))]
    [Alias("SMBIOS-Property")]
    public class GetSmbiosPropertyCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (PropertyDefinitionResult) Property: Gets or sets a value that contains location property data
        /// <summary>
        /// Gets or sets a value that contains the location property data.
        /// <para type="description">A <see cref="PropertyDefinitionResult"/> instance.</para>
        /// </summary>
        /// <value>
        /// A <see cref="PropertyDefinitionResult"/> reference that contains the location property data.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter an instance of PropertyDefinitionResult, use SmbiosLocateProperty for get one")]
        public PropertyDefinitionResult Property { get; set; }
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
            DmiStructure structure = structures[Property.Class];
            DmiClass element = structure.Elements[Property.Index];
            QueryPropertyResult propertyResult = element.GetProperty(Property.PropertyKey);

            WriteObject(propertyResult.Value);
        }
        #endregion

        #endregion
    }
}
