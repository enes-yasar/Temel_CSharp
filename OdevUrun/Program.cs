using System;

namespace OdevUrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = new string[] { "Elektronik", "Moda","Bahçe","Kitap" };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);
            }
            Console.WriteLine("----------------------");
            string[] Elektronik = new string[] { "Bilgisayar", "Telefon", "Tablet", "Televizyon", "Yazıcı" };
            foreach (var i in Elektronik)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            string[] Moda = new string[]  {"Tişört","Kazak","Mont","Ayakkabı","Gömlek"};
            foreach (var i in Moda)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------");
            string[] Bahce = new string[] { "Mangal","Barbekü","Aydınlatma" };
            foreach (var i in Bahce)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------");
            string[] Kitap = new string[] {"Edebiyat","Dergi","Roman","Çocuk" };
            foreach (var i in Kitap)
            {
                Console.WriteLine(i);
            }
                
            
        
        
        
        
        }   
    }
}
