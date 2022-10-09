
using System.Management.Automation;

using iTin.Core.Hardware.Common;

using PowerShellSmbios.CmdLets.Results;

namespace PowerShellSmbios.CmdLets
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the property is expressed,
    /// description and structure class to which it belongs.
    /// </para>
    /// <para type="description">
    /// The value of the property <b>Property</b> must be obtained by calling the <b>Get-SmbiosProperty</b>, for more information see the help
    /// for the <b>Get-SmbiosProperty</b> and the sample examples below.
    /// </para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     How to get the value of the 'BiosVersion' property of the 'Bios' class ?.
    ///     To do this, first by calling 'Get-SmbiosLocateProperty', we search among all the available properties of our system for those that call 'BiosVersion'
    ///     and then with the result obtained, the 'Get-SmbiosProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
    ///     Finally we call 'Get-SmbiosPropertyDetail' to obtain all the available information about the 'Manufacturer' property.
    /// 
    ///     PS> Get-SmbiosPropertyDetail -Property (Get-SmbiosProperty -Property (Get-SmbiosLocateProperty -Name BiosVersion)) | SMBIOS-Property-Detail -Property (SMBIOS-Property -Property (SMBIOS-Locate-Property -Name BiosVersion))
    ///
    ///     Name         : BiosVersion
    ///     Value        : 16.0.1 (48919)
    ///     Units        : None
    ///     Class        : Bios
    ///     FriendlyName : BIOS Version
    ///     Description  : String number of the BIOS Version
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     How to get the value of the 'Manufacturer' property of the 'System' class ?.
    ///     To do this, first by calling 'Get-SmbiosLocateProperty', we search among all the available properties of our system for those that call 'Manufacturer' and belongs to 'System' structure class
    ///     and then with the result obtained, the 'Get-SmbiosProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
    ///     Finally we call 'Get-SmbiosPropertyDetail' to obtain all the available information about the 'Manufacturer' property.
    /// 
    ///     PS> Get-SmbiosPropertyDetail -Property (Get-SmbiosProperty -Property (Get-SmbiosLocateProperty -Name Manufacturer -Class System)) | SMBIOS-Property-Detail -Property (SMBIOS-Property -Property (SMBIOS-Locate-Property -Name Manufacturer -Class System))
    ///
    ///     Name         : Manufacturer
    ///     Value        : Parallels Software International Inc.
    ///     Units        : None
    ///     Class        : BasicInformation
    ///     FriendlyName : System Manufacturer
    ///     Description  : System Manufacturer
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     How to get the value of the 'AssetTag' property, but only element 4 of the 'MemoryDevice' structure class ?.
    /// 
    ///     PS> Get-SmbiosPropertyDetail -Property (Get-SmbiosProperty -Property (Get-SmbiosLocateProperty -Name AssetTag -Class MemoryDevice -Index 4)) | SMBIOS-Property-Detail -Property (SMBIOS-Property -Property (SMBIOS-Locate-Property -Name AssetTag -Class MemoryDevice -Index 4))
    ///
    ///     Name         : AssetTag
    ///     Value        : 
    ///     Units        : None
    ///     Class        : MemoryDevice
    ///     FriendlyName : AssetTag
    ///     Description  : 
    /// 
    ///   </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "SmbiosPropertyDetail")]
    [OutputType(typeof(PropertyDetailResult))]
    [Alias("SMBIOS-Property-Detail")]
    public class GetSmbiosPropertyDetailCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (PropertyItem) Property: Gets or sets a value that contains the property item data
        /// <summary>
        /// Gets or sets a value that contains the property information.
        /// <para type="description">A <see cref="PropertyItem"/> instance.</para>
        /// </summary>
        /// <value>
        /// A <see cref="PropertyItem"/> reference that contains the property information.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter a PropertyItem instance, use SmbiosProperty for get one")]
        public PropertyItem Property { get; set; }
        #endregion

        #endregion

        #region protected override methdos

        #region [protected] {override} (void) ProcessRecord: Process the command
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            WriteObject(
                new PropertyDetailResult
                {
                    Name = Property.Key.PropertyId.ToString(),
                    Value = Property.Value,
                    Units = Property.Key.PropertyUnit.ToString(),
                    Class = Property.Key.StructureId.ToString(),
                    FriendlyName = Property.Key.GetPropertyName(),
                    Description = Property.Key.GetPropertyDescription()
                });
        }
        #endregion

        #endregion
    }
}
