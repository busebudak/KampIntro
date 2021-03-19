using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //interfacelerde başına I konulur.
    interface IPersonManager
    {
        //implemented operatin(tamamlanmış operasyon)

        //public  void Add()
        // {
        //    Console.WriteLine("Eklendi");
        // }

        //interfacelerde implemented değil unimplemented olarak yazmam gerekir.
        //interface üyeleri dışarıdan erişebilir olmalıdır.Bu yüzden default olan publici yazamam.

        void Add();

    }
    //inherits(classlarda) interfacelerde buna implements denir.
    class CustomerManager : IPersonManager
    {
        //yukarıda IPersonManager hatalı gözüktüğü sırada soldaki ampulden implement interface'e tıklarım.
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }
    }

}
