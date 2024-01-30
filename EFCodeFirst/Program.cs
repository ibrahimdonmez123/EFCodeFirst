using EFCodeFirst.Context;
using EFCodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Program
    {

        static void Main(string[] args)
        {
            //InsertIslemleri();
            //UpdateIslemleri();
            //DeleteIslemleri();


            EFCodeFirstContext db = new EFCodeFirstContext();

            // ESKİ YÖNTEM      var ogrenciler = from ogr in db.Ogrenciler select ogr;
            var ogrenciler = db.Ogrenciler.ToList();

            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine($"Öğrencinin ismi :  {ogr.Isim}");
                Console.WriteLine($"Öğrencinin Yaşı :  {ogr.Yas}");
                Console.WriteLine($"Öğrencinin Cinsiyeti :  {ogr.Cinsiyet}");
                Console.WriteLine(  " ---------------------------------------------");
                Console.ReadLine();


            }

           


        }




        public static void DeleteIslemleri()
        {
            EFCodeFirstContext db = new EFCodeFirstContext();
            Console.WriteLine("Silinecek olan id giriniz : ");
            var secilenogrenci = db.Ogrenciler.Find(Convert.ToInt32(Console.ReadLine()));

            if (secilenogrenci == null)
            {
                Console.WriteLine("Öğrenci bulunamadı");
                Console.ReadLine();
            }
            else
            {
                db.Ogrenciler.Remove(secilenogrenci);
                db.SaveChanges();

                Console.WriteLine($"{secilenogrenci.Isim} Silinci");
                Console.ReadLine();

            }
        }
        public static void UpdateIslemleri()
        {

            
            EFCodeFirstContext db = new EFCodeFirstContext();

            // var ogrenci = db.Ogrenciler.Find(1);

            // ogrenci.Cinsiyet = "erkek";
            // ogrenci.Isim = "ibo";
            // ogrenci.Yas = 22;
            Console.WriteLine("Güncellenecek olan id giriniz : ");
            var secilenogrenci = db.Ogrenciler.Find(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Yeni cinsiyet : ");

            secilenogrenci.Cinsiyet = Console.ReadLine();

            Console.WriteLine("Yeni ism : ");

            secilenogrenci.Isim = Console.ReadLine();

            Console.WriteLine("Yeni yas : ");

            secilenogrenci.Yas = Convert.ToInt32(Console.ReadLine());

            db.SaveChanges();

            Console.WriteLine($"{secilenogrenci.Isim} isimli öğrencinin bilgileri güncellendi ");
            Console.ReadLine();
        }


        public static void InsertIslemleri()
        {
            EFCodeFirstContext db = new EFCodeFirstContext();

            Console.WriteLine("Sırayla öğrencinin Cinsiyet , Id , İsim ve Yaş bilgilerini giriniz");
            Ogrenci ogrenci = new Ogrenci
            {
                Cinsiyet = Console.ReadLine(),
                Id = Convert.ToInt32(Console.ReadLine()),
                Isim = Console.ReadLine(),
                Yas = Convert.ToInt32(Console.ReadLine())
            };


            db.Ogrenciler.Add(ogrenci);
            db.SaveChanges();

            Console.WriteLine($"{ogrenci.Isim} eklendi");
            Console.ReadLine();

        }



    }
}
