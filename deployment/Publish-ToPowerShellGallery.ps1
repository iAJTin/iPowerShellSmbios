$releasePath = Join-Path $PSScriptRoot "bin\Release"
$modulePath = Join-Path $PSScriptRoot "bin\iPowerShellSmbios"

Write-Host "Preparing module"

# Moverse a la carpeta de la versión elegida y ejecutar el comando.
# Ex. versión 1.0.0.0 -> cd ...iPowerShellSmbios\deployment\v1.0.0.0
# Cuando solicite ApiKey introducir clave
Publish-Module -Path .\iPowerShellSmbios -Repository PSGallery -NuGetApiKey (Read-Host "NuGetApiKey (from https://powershellgallery.com/account)") -verbose
Publish-Module -Path .\iPowerShellSmbios -Repository PSGallery -NuGetApiKey oy2ktth5hdjvl62z4sxqz5cmd2yblr5e3lrpsoys5utyv4