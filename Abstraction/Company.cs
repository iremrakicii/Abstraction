namespace Abstraction
{

    public abstract class Company
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public abstract void Gorev();


        public Company(string name, string lastName, string department)
        {
            Name = name;
            LastName = lastName;
            Department = department;
        }
    }
    public class ProjectManager : Company
    {
        public ProjectManager(string name, string lastName) : base(name, lastName, "Proje Yöneticisi")
        {

        }


        public override void Gorev()
        {
            Console.WriteLine("Şirkette Proje yöneticisi olarak çalışıyorum.");
        }
    }
    public class SoftwareDeveloper : Company
    {
        public SoftwareDeveloper(string name, string lastName) : base(name, lastName, "Yazılım Geliştiricisi")
        {

        }
        public override void Gorev()
        {
            Console.WriteLine("Şirkette Yazılım Geliştirici olarak çalışıyorum.");
        }
    }
    public class SalesRepresentative : Company
    {
        public SalesRepresentative(string name, string lastName) : base(name, lastName, "Satış Temsilcisi")
        {

        }
        public override void Gorev()
        {
            Console.WriteLine("Şirkette Satış Temsilcisi olarak çalışıyorum.");
        }
    }

}



