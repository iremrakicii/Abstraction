using Abstraction;

class Program
{
    static void Main()
    {
        Company projectManager = new ProjectManager("Reha", "Rakıcı");
        Console.WriteLine($"{projectManager.Name} {projectManager.LastName}, şirketin {projectManager.Department}");
        projectManager.Gorev();
        Console.WriteLine("--------------------------------------------------");
        Company softwareDeveloper = new SoftwareDeveloper("İrem", "Rakıcı");
        Console.WriteLine($"{softwareDeveloper.Name} {softwareDeveloper.LastName}, şirketin {softwareDeveloper.Department}");
        softwareDeveloper.Gorev();
        Console.WriteLine("--------------------------------------------------");
        Company salesRepresentative = new SalesRepresentative("Tahsin", "Rakıcı");
        Console.WriteLine($"{salesRepresentative.Name} {salesRepresentative.LastName}, şirketin {salesRepresentative.Department}");
        salesRepresentative.Gorev();
    }
}
