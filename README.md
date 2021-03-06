<p align="center">
  <img src="https://github.com/iAJTin/iPowerShellSmbios/blob/main/powershellgallery/iPowerShellSmbios.png" height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iPowerShellSmbios">
    <img src="https://img.shields.io/badge/iTin-iPowerShellSmbios-green.svg?style=flat"/>
  </a>
</p>

***

# What is iPowerShellSmbios?

iPowerShellSmbios contains a collection of **PowerShell Cmdlets** that allow us to obtain the [SMBIOS] information.

**Currently only works on windows**

# Install 

#### PowerShellGallery

 - Currently in progress...

#### Manually

|Step|Description|
|:------|:------|
|1|Create the ```iPowerShellSmbios``` folder in ```%programfiles%\WindowsPowerShell\Modules```|
|2|Copy the contents of the output folder ```Release``` or ```Debug``` into the folder created in the previous step. ```%programfiles%\WindowsPowerShell\Modules\iPowerShellSmbios```.|
|3|Run Windows PowerShell|
|4|For import **iPowerShellSmbios** module, please enter the following command: ```PS> Import-Module iPowerShellSmbios```|
|5|Now to check that everything is correct, let's check the [SMBIOS] version, please enter the following command: ```PS> Get-SmbiosVersion``` or if you prefer, use its alias ```SMBIOS-Version```|
|6|In both cases, in both cases we must obtain a response value, if this is so, perfect is already installed!!|
|7|Enjoy ;)| 

# Usage

## Examples

| Cmdlet | Alias | Description | Example(s) |
|:------|:------|:----------|:----------|
| Get-SmbiosVersion | SMBIOS-Version | Returns a value that contains the [SMBIOS] version of the system | [Get-SmbiosVersion](./documentation/PowerShellSmbios.CmdLets/GetSmbiosVersionCmdlet.md) |
| Get-SmbiosAvailableStructures | SMBIOS-Available-Structures | Returns a collection of elements where each element represents an available [SMBIOS] structure | [GetSmbiosAvailableStructures](./documentation/PowerShellSmbios.CmdLets/GetSmbiosAvailableStructuresCmdlet.md) |
| Get-SmbiosImplementedProperties | SMBIOS-Implemented-Properties | Returns a collection of elements where each element represents an implemented property for given structure class | [GetSmbiosImplementedProperties](./documentation/PowerShellSmbios.CmdLets/GetSmbiosImplementedPropertiesCmdlet.md)|
| Get-SmbiosLocateProperty | SMBIOS-Locate-Property | Returns a value that contains the location or locations of the [SMBIOS] property by its name | [GetSmbiosLocateProperty](./documentation/PowerShellSmbios.CmdLets/GetSmbiosLocatePropertyCmdlet.md)|
| Get-SmbiosProperty | SMBIOS-Property | Returns a reference that contains the information associated with the given property such as the key that identifies the property and its value | [GetSmbiosProperty](./documentation/PowerShellSmbios.CmdLets/GetSmbiosPropertyCmdlet.md) |
| Get-SmbiosPropertyDetail| SMBIOS-Property-Detail | Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the property is expressed, description and structure class to which it belongs | [GetSmbiosPropertyDetail](./documentation/PowerShellSmbios.CmdLets/GetSmbiosPropertyDetailCmdlet.md) |

# Documentation

 - For full code documentation, please see next link [documentation].

# How can I send feedback!!!

If you have found **iPowerShellSmbios** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iPowerShellSmbios**, please send me and email stating why this is so. I will use this feedback to improve **iPowerShellSmbios** in future releases.

My email address is 

![email.png][email] 

[email]: ./assets/email.png "email"
[SMBIOS]: https://github.com/iAJTin/iSMBIOS
[documentation]: ./documentation/iPowerShellSmbios.md

