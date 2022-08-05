using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    public class Program
    {
        public static EfFisDal fisDal;
        public static FisManager fisManager;
        public static MakbuzManager makbuzManager;
        public static EfMakbuzDal makbuzDal;
        static void Main(string[] args)
        {
            fisDal = new EfFisDal();
            fisManager = new FisManager(fisDal);
            makbuzDal = new EfMakbuzDal();
            makbuzManager = new MakbuzManager(makbuzDal);


            Console.WriteLine("Hello World!");
            Console.WriteLine(makbuzManager.GetById(1).Data.Description);
        }
    }
}
 