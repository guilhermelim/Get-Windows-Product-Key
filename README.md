# Get-Windows-Product-Key
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://raw.githubusercontent.com/guilhermelim/Get-Windows-Product-Key/master/LICENSE)

### Presentation
Obtenha a chave do produto Windows. Este aplicativo é escrito em C# e destina-se a todos que precisam obter o número da chave do produto Windows ou 
para aqueles que desejam decodificar `DigitalProductId` exportado do registro.

Registry Address: `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId`

![Print UI](README/print.png)
Observação: Eu não sou responsável por nada que você faça com isso. Isso é apenas para propósitos educacionais.

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
- Foi utilizada a Class `KeyDecoder` do projeto – [WinProdKeyFinder](https://github.com/mrpeardotnet/WinProdKeyFinder)

## Author
[Guilherme Lima](https://github.com/guilhermelim)

## License
[MIT License](https://raw.githubusercontent.com/guilhermelim/Get-Windows-Product-Key/master/LICENSE)