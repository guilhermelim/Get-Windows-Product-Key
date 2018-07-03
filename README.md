# Get-Windows-Product-Key
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://raw.githubusercontent.com/guilhermelim/Get-Windows-Product-Key/master/LICENSE)

### Apresenta��o
Obtenha a chave do produto Windows. Este aplicativo � escrito em C# e destina-se a todos que precisam obter o n�mero da chave do produto Windows ou 
para aqueles que desejam decodificar `DigitalProductId` exportado do registro.

Registry Address: `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId`

![Print UI](README/print.png)
Observa��o: Eu n�o sou respons�vel por nada que voc� fa�a com isso. Isso � apenas para prop�sitos educacionais.

## Refer�ncias :notebook:
- Foi utilizada a Class `KeyDecoder` do projeto. [WinProdKeyFinder](https://github.com/mrpeardotnet/WinProdKeyFinder)

## Author
[Guilherme Lima](https://github.com/guilhermelim)

## License
[MIT License](https://raw.githubusercontent.com/guilhermelim/Get-Windows-Product-Key/master/LICENSE)