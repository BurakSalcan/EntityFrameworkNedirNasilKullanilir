using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkNedirNasilKullanilir.Model;

namespace EntityFrameworkNedirNasilKullanilir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();

            #region Kategorilerin Sayısı 

            //int sayi = db.Categories.Count();
            //Console.WriteLine("Kategori sayısı: " + sayi);

            #endregion

            #region Kategori Listesi

            //List<Categories> kategoriler = db.Categories.ToList();

            //foreach (Categories item in kategoriler)
            //{
            //    Console.WriteLine(item.CategoryID + " )" + item.CategoryName + " - " + item.Description);
            //}

            #endregion

            #region Ürün Listesi

            //List<Products> urunler = db.Products.ToList();
            //foreach (Products item in urunler)
            //{
            //    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            //    Console.WriteLine("Ürün ID: " + item.ProductID);
            //    Console.WriteLine("Ürün Adı: " + item.ProductName);
            //    Console.WriteLine("Kategori Adı: " + item.Categories.CategoryName);
            //    Console.WriteLine("Tedarikçi: " + item.Suppliers.CompanyName);
            //    Console.WriteLine("Fiyat: " + item.UnitPrice);
            //}

            #endregion

            #region LinqToSQL Kullanımı

            //List<Products> urunler = db.Products.Where(p => p.CategoryID == 3).ToList();

            //foreach (Products item in urunler)
            //{
            //    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            //    Console.WriteLine("Ürün ID: " + item.ProductID);
            //    Console.WriteLine("Ürün Adı: " + item.ProductName);
            //    Console.WriteLine("Kategori ID: " + item.CategoryID);
            //    Console.WriteLine("Kategori Adı: " + item.Categories.CategoryName);
            //    Console.WriteLine("Tedarikçi: " + item.Suppliers.CompanyName);
            //    Console.WriteLine("Fiyat: " + item.UnitPrice);
            //}

            //Products urun = db.Products.Find(3000);
            //if (urun != null)
            //{
            //    Console.WriteLine(urun.ProductName);
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir id'ye sahip ürün bulunamamıştır.");
            //}

            #endregion

            #region Ekle

            //Categories c = new Categories();
            //c.CategoryName = "Entity ile eklendim.";
            //c.Description = "Ciddiyim.";

            //db.Categories.Add(c);
            //db.SaveChanges();

            #endregion

            #region Sil

            //Categories c = db.Categories.Find(5017);
            //db.Categories.Remove(c);
            //db.SaveChanges();

            #endregion

            #region Güncelle

            Categories c = db.Categories.Find(4019);
            c.CategoryID = 4019;
            c.CategoryName = "Güncelledik.";
            c.Description = "Valla güncellendi abey entity ileeeee";
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();

            #endregion

        }
    }
}
