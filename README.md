# Şirket Personel Görevleri

Bu proje, **Company** sınıfı üzerinden türetilmiş olan personel sınıflarını kullanarak, farklı departmanlarda çalışan şirket çalışanlarını modellemektedir. Her bir çalışan, kendine özgü bir göreve ve departmana sahiptir.

## Sınıflar

### 1. Company (Soyut Sınıf)

Bu sınıf şirket çalışanlarının genel özelliklerini tanımlar. Her çalışanın bir **isim**, **soyisim** ve **departmanı** bulunur. Ayrıca, her alt sınıfın kendi görev tanımını yapmasını zorunlu kılan soyut bir **Gorev** metodu vardır.

- **Properties**:
  - `string Name`: Çalışanın adı.
  - `string LastName`: Çalışanın soyadı.
  - `string Department`: Çalışanın çalıştığı departman.
  
- **Methods**:
  - `abstract void Gorev()`: Alt sınıflarda uygulanması zorunlu olan görev metodu.

### 2. ProjectManager (Proje Yöneticisi)

Bu sınıf, **Company** sınıfından türetilmiştir ve bir proje yöneticisini temsil eder. Bu sınıfın görev metodu, proje yöneticisinin şirkette ne iş yaptığını açıklar.

- **Constructor**:
  - `ProjectManager(string name, string lastName)`: İsim ve soyadını alarak, departman ismini "Proje Yöneticisi" olarak atar.

- **Gorev()**:
  - Şirkette proje yöneticisi olarak çalıştığını bildirir.

### 3. SoftwareDeveloper (Yazılım Geliştiricisi)

Bu sınıf, **Company** sınıfından türetilmiştir ve bir yazılım geliştiricisini temsil eder. Görev metodu yazılım geliştiricisinin şirketteki rolünü açıklar.

- **Constructor**:
  - `SoftwareDeveloper(string name, string lastName)`: İsim ve soyadını alarak, departman ismini "Yazılım Geliştiricisi" olarak atar.

- **Gorev()**:
  - Şirkette yazılım geliştirici olarak çalıştığını bildirir.

### 4. SalesRepresentative (Satış Temsilcisi)

Bu sınıf, **Company** sınıfından türetilmiştir ve bir satış temsilcisini temsil eder. Görev metodu satış temsilcisinin şirketteki rolünü açıklar.

- **Constructor**:
  - `SalesRepresentative(string name, string lastName)`: İsim ve soyadını alarak, departman ismini "Satış Temsilcisi" olarak atar.

- **Gorev()**:
  - Şirkette satış temsilcisi olarak çalıştığını bildirir.

## Kullanım

Aşağıdaki örnek kod, üç farklı departmandan çalışanlar oluşturur ve her bir çalışanın görevini ekrana yazdırır:

```csharp
Company projectManager = new ProjectManager("Reha", "Rakıcı");
Console.WriteLine($"{projectManager.Name} {projectManager.LastName}, şirketin {projectManager.Department}");
projectManager.Gorev();

Company softwareDeveloper = new SoftwareDeveloper("İrem", "Rakıcı");
Console.WriteLine($"{softwareDeveloper.Name} {softwareDeveloper.LastName}, şirketin {softwareDeveloper.Department}");
softwareDeveloper.Gorev();

Company salesRepresentative = new SalesRepresentative("Tahsin", "Rakıcı");
Console.WriteLine($"{salesRepresentative.Name} {salesRepresentative.LastName}, şirketin {salesRepresentative.Department}");
salesRepresentative.Gorev();
```
## Kullanılan Araç Ve Teknolojiler
Programlama Dili: C# IDE: Visual Studio
