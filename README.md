# Get-Windows-Product-Key
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

### Presentation
Obtain the Windows product key. This application is written in C # and is intended for everyone who needs to obtain the Windows product key number or
for those who wish to decode `DigitalProductId` exported from the registry.

Registry Address: `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId`

![Print UI](README/print.png)
Note: I have no responsibility for anything you do with this. This is for educational purposes only.

## Requirements
* .NET Framework 4.0 Client Profile ([Download](https://www.microsoft.com/en-us/download/details.aspx?id=24872))
* Supported Operating Systems (32- and 64-bit)
  * Windows XP SP3
  * Windows Server 2003
  * Windows Vista
  * Windows Server 2008
  * Windows 7
  * Windows Server 2012
  * Windows 8/8.1
  * Windows 10

## References :notebook:
- The class `KeyDecoder` was used from the project – [WinProdKeyFinder](https://github.com/mrpeardotnet/WinProdKeyFinder)


## Author
[Guilherme Lima](https://github.com/guilhermelim)

## License
[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://raw.githubusercontent.com/guilhermelim/Get-Windows-Product-Key/master/LICENSE)
[MIT License](https://raw.githubusercontent.com/guilhermelim/Get-Windows-Product-Key/master/LICENSE)
