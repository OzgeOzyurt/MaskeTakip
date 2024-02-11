using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen1 = new Citizen();
            citizen1.FirstName = "Ozge";
            citizen1.LastName = "Ozyurt";
            citizen1.DateOfBirthYear = 1995;
            citizen1.NationalIdentity = 12345678910;

            Citizen citizen2 = new Citizen();
            citizen2.FirstName = "Cem";

            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(citizen1);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
