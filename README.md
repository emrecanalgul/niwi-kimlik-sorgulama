# Niwi Kimlik Sorgulama :monocle_face:


T.C. İçişleri Bakanlığı Nüfus ve Vatandaşlık İşleri Genel Müdürlüğü tarafından kullanıma sunulan web servisler üzerinden kimlik doğrulama yapılmasını sağlamaktadır.

[![NuGet version (Niwi)](https://img.shields.io/nuget/v/Niwi.svg?style=flat-square)](https://www.nuget.org/packages/Niwi/)


## Kurulum
```bash
Install-Package Niwi
# ve ya
dotnet add package Niwi
```
## Kullanım

```csharp
using NiwiLib;

Niwi.TcKimlikNoDogrula(52321242857,"Ad","Soyad",1995);
Niwi.YabanciKimlikNoDogrula(52321242857 ,"Ad","Soyad" 12, 1, 1995);

```