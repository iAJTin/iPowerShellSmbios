
What is iPowerShellSmbios?
==========================

iPowerShellSmbios contains a collection of PowerShell Cmdlets that allow us to obtain the SMBIOS information.

Changes in this version (v1.0.1)
================================

· Changed
  -------

 - iSMBIOS library

    •———————————————————————————————•
    | Library   Version Description |
    •———————————————————————————————•
    | iSMBIOS   1.1.8   iSMBIOS     |
    •———————————————————————————————•

v1.0.0
======

· Added
  -----

 - iSMBIOS library

    •———————————————————————————————•
    | Library   Version Description |
    •———————————————————————————————•
    | iSMBIOS   1.1.7   iSMBIOS     |
    •———————————————————————————————•

 - Library versions for this version

    •—————————————————————————————————————————————————————————————————————————•
    | Library               Version     Description                           |
    •—————————————————————————————————————————————————————————————————————————•
    | iPowerShellSmbios     1.0.0.0     SMBIOS PowerShell Cmdlets library     |
    •—————————————————————————————————————————————————————————————————————————•

- Solution structure, prepare solution structure to add future new specifications.

      \ root
        \ documentation       [Code documentation (md files)]
        \ references          [External references]
        \ src
          \ iPowerShellSmbios [SMBIOS PowerShell Cmdlets library] 
        \ tools               [Build documentation script]


Install via PowerShellGallery
=============================

For more information, please see https://www.powershellgallery.com/packages/iPowerShellSmbios/1.0.0.0

Usage
=====

Examples
--------

- Below are a series of tabs with shortcuts and information on all available cmdlets.

----------------------------------------------------------------------------------------------------------------------------------------------------------
| Get-SmbiosVersion                                                                                                                                      |
----------------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-SmbiosVersion                                                                                                                    |
| Alias             SMBIOS-Version                                                                                                                       |
| Description       Returns a value that contains the SMBIOS version of the system.                                                                      |
| Example(s) link   https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/PowerShellSmbios.CmdLets/GetSmbiosVersionCmdlet.md               |
----------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------------
| Get-SmbiosAvailableStructures                                                                                                                          |
----------------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-SmbiosAvailableStructures                                                                                                        |
| Alias             SMBIOS-Available-Structures                                                                                                          |
| Description       Returns a collection of elements where each element represents an available SMBIOS structure.                                        |
| Example(s) link   https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/PowerShellSmbios.CmdLets/GetSmbiosAvailableStructuresCmdlet.md   |
----------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------------
| Get-SmbiosImplementedProperties                                                                                                                        |
----------------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-SmbiosImplementedProperties                                                                                                      |
| Alias             SMBIOS-Implemented-Properties                                                                                                        |
| Description       Returns a collection of elements where each element represents an implemented property for given structure class.                    |
| Example(s) link   https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/PowerShellSmbios.CmdLets/GetSmbiosImplementedPropertiesCmdlet.md |
----------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetSmbiosLocateProperty                                                                                                                            |
----------------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-GetSmbiosLocateProperty                                                                                                          |
| Alias             SMBIOS-Locate-Property                                                                                                               |
| Description       Returns a value that contains the location or locations of the SMBIOS property by its name.                                          |
| Example(s) link   https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/PowerShellSmbios.CmdLets/GetSmbiosLocatePropertyCmdlet.md        |
----------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetSmbiosProperty                                                                                                                                  |
----------------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-GetSmbiosProperty                                                                                                                |
| Alias             SMBIOS-Property                                                                                                                      |
| Description       Returns a reference that contains the information associated with the given property such as the key that identifies the property    |
|                   and its value.                                                                                                                       |
| Example(s) link   https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/PowerShellSmbios.CmdLets/GetSmbiosPropertyCmdlet.md              |
----------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetSmbiosPropertyDetail                                                                                                                            |
----------------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-GetSmbiosPropertyDetail                                                                                                          |
| Alias             SMBIOS-Property-Detail                                                                                                               |
| Description       Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the property is   |
|                   expressed, description and structure class to which it belongs.                                                                      |
| Example(s) link   https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/PowerShellSmbios.CmdLets/GetSmbiosPropertyCmdlet.md              |
----------------------------------------------------------------------------------------------------------------------------------------------------------


Library Documentation
---------------------

For full code documentation, please see https://github.com/iAJTin/iPowerShellSmbios/blob/main/documentation/iPowerShellSmbios.md
