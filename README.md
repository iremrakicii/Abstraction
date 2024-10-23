# Şirket Personel Görevleri

Bu proje, **Company** sınıfı üzerinden türetilmiş olan personel sınıflarını kullanarak, farklı departmanlarda çalışan şirket çalışanlarını modellemektedir. Her bir çalışan, kendine özgü bir göreve ve departmana sahiptir.

# Şirket Görev Yönetimi Projesi

Bu proje, bir şirketteki farklı rollerde çalışanların görevlerini tanımlayan ve görevlerini konsola yazdıran basit bir **C# Abstraction (Soyutlama)** örneğidir.

## Proje Hakkında

Projede, soyut bir sınıf olan `Company` sınıfı yer almaktadır ve bu sınıf, çalışanların ad, soyad ve departman bilgilerini tutmakta ve her çalışan için `Gorev()` adında soyut bir metot içermektedir.

Bu soyut sınıfı miras alan 3 farklı sınıf bulunmaktadır:

1. **ProjectManager** - Proje yöneticilerini temsil eder.
2. **SoftwareDeveloper** - Yazılım geliştiricilerini temsil eder.
3. **SalesRepresentative** - Satış temsilcilerini temsil eder.

Her bir sınıf, kendi içinde `Gorev()` metodunu implement ederek çalışanların görev tanımını konsola yazdırmaktadır.

## Kullanılan Sınıflar ve Metotlar

- `Company`: Çalışanların temel özelliklerini tutan soyut sınıf.
  - Özellikler: `Name`, `LastName`, `Department`
  - Metot: `Gorev()`
  
- `ProjectManager`: Şirkette proje yöneticisi rolünü temsil eden sınıf. `Gorev()` metodunu override eder.
  
- `SoftwareDeveloper`: Şirkette yazılım geliştirici rolünü temsil eden sınıf. `Gorev()` metodunu override eder.
  
- `SalesRepresentative`: Şirkette satış temsilcisi rolünü temsil eden sınıf. `Gorev()` metodunu override eder.

## Programın Çalıştırılması

`Main` metodunda üç farklı nesne oluşturulmaktadır:

1. **ProjectManager** nesnesi
2. **SoftwareDeveloper** nesnesi
3. **SalesRepresentative** nesnesi

Her bir nesne için çalışan bilgileri set edilir ve `Gorev()` metodu çağrılarak görev tanımları konsola yazdırılır.

## Kullanılan Araç Ve Teknolojiler
Programlama Dili: C# IDE: Visual Studio
