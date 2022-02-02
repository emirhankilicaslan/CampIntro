using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            int age = 36;

            Kurs kurs1 = new Kurs();
            kurs1.CourseName = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.CourseName = "Java";
            kurs2.Egitmen = "Emirhan Kılıçaslan";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.CourseName = "Python";
            kurs3.Egitmen = "Buse Nur Balkanlı";
            kurs3.IzlenmeOrani = 64;

            Kurs kurs4 = new Kurs();
            kurs4.CourseName = "C++";
            kurs4.Egitmen = "Selçuk Levent Görgeç";
            kurs4.IzlenmeOrani = 75;

            //Console.WriteLine(kurs1.CourseName + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs [] { kurs1, kurs2, kurs3, kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.CourseName + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string CourseName { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOrani { get; set; }
    }
}
