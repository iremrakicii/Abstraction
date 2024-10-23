namespace Abstraction
{

    public abstract class Company
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public abstract void Gorev();

    }
    public class ProjectManager : Company
    {


        public override void Gorev()
        {
            Console.WriteLine($"Merhaba ben,{Name} {LastName} Şirkette {Department} olarak çalışıyorum.");
        }
    }
    public class SoftwareDeveloper : Company
    {

        public override void Gorev()
        {
            Console.WriteLine($"Merhaba ben,{Name} {LastName} Şirkette {Department} olarak çalışıyorum.");
        }
    }
    public class SalesRepresentative : Company
    {

        public override void Gorev()
        {
            Console.WriteLine($"Merhaba ben,{Name} {LastName} Şirkette {Department} olarak çalışıyorum.");
        }
    }

}



