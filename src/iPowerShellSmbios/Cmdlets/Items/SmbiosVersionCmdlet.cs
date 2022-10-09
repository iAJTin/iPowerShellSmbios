
using System.Management.Automation;

using iTin.Hardware.Specification;

namespace PowerShellSmbios.CmdLets
{
    /// <summary>
    /// <para type="synopsis">Returns a value that contains the SMBIOS version of the system.</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     PS> Get-SmbiosVersion | SMBIOS-Version
    ///     207
    /// 
    ///   </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "SmbiosVersion")]
    [OutputType(typeof(string))]
    [Alias("SMBIOS-Version")]
    public class GetSmbiosVersionCmdlet : Cmdlet
    {
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            WriteObject(DMI.CreateInstance().SmbiosVersion);
        }
    }
}
