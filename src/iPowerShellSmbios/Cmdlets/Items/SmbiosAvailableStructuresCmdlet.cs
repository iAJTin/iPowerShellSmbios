
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;

using iTin.Hardware.Specification;

using PowerShellSmbios.CmdLets.Results;

namespace PowerShellSmbios.CmdLets
{
    /// <summary>
    /// <para type="synopsis">Returns a collection of elements where each element represents an available SMBIOS structure.</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     PS> Get-SmbiosAvailableStructures | SMBIOS-Available-Structures
    /// 
    ///                        Class ClassId HexadecimalClassId
    ///                        ----- ------- ------------------
    ///                         Bios       0 00
    ///                       System       1 01
    ///                    BaseBoard       2 02
    ///              SystemEnclosure       3 03
    ///                    Processor       4 04
    ///                  SystemSlots       9 09
    ///               OnBoardDevices      10 0A
    ///          PhysicalMemoryArray      16 10
    ///                 MemoryDevice      17 11
    ///     MemoryArrayMappedAddress      19 13
    ///                   SystemBoot      32 20
    ///                   EndOfTable     127 7F
    /// 
    /// </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "SmbiosAvailableStructures")]
    [OutputType(typeof(StructureResult[]))]
    [Alias("SMBIOS-Available-Structures")]
    public class GetSmbiosAvailableStructuresCmdlet : Cmdlet
    {
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            var result = new Collection<StructureResult>();
            var structures = DMI.CreateInstance().Structures;
            foreach (var structure in structures)
            {
                result.Add(
                    new StructureResult
                    {
                        Class = structure.Class,
                        ClassId = (int)structure.Class,
                        HexadecimalClassId = $"{(int)structure.Class:X2}"
                    });
            }

            WriteObject((StructureResult[])result.ToArray().Clone(), true);
        }
    }
}
