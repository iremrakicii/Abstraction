using Abstraction;

class Program
{
    static void Main()
    {
        Company projectManager = new ProjectManager();
        projectManager.Name = "Reha";
        projectManager.LastName = "Rakıcı";
        projectManager.Department = "Proje Yöneticisi";
        projectManager.Gorev();
        Console.WriteLine("--------------------------------------------------");
        Company softwareDeveloper = new SoftwareDeveloper();
        softwareDeveloper.Name = "İrem";
        softwareDeveloper.LastName = "Rakıcı";
        softwareDeveloper.Department = "Yazılım Geliştiricisi";
        softwareDeveloper.Gorev();
        Console.WriteLine("--------------------------------------------------");
        Company salesRepresentative = new SalesRepresentative();
        salesRepresentative.Name = "Tahsin";
        salesRepresentative.LastName = "Rakıcı";
        salesRepresentative.Department = "Satış Temsilcisi";
        salesRepresentative.Gorev();
    }
}
