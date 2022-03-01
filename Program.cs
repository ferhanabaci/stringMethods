using System;

namespace hazirMetotlarString
{
    class Program
    {
        static void Main(string[] args)
        {
          // normalde birden fazla kod satırnda yapılacakları bu kütüphanede kolaylıkla ve basit yapıyoruz 
          string degisken = "Dersimiz c#, Hosgeldiniz!";
          string degisken2 = "Dersimiz Java";
          //Lenght; bu cumle icerisinde kac tane harf oldugunu ogrenmek istiyorum ?
          Console.WriteLine(degisken.Length);// bununla karakter sayısına ulasabiliriz.
          //ToUpper , ToLower 
          Console.WriteLine(degisken.ToUpper());// ya hepsini büyütür.(karakterleri)
          Console.WriteLine(degisken.ToLower());// ya hepsini kücültür.

          //Concat
          Console.WriteLine(string.Concat(degisken,"Merhaba!"));
          //Compare,CompareTo

          Console.WriteLine(degisken.CompareTo(degisken2));// birinci degisken 2. degiskene esit olrusa sıfır dondurur, 1. 2. den buyukj olursa 1 dondurur eger tam tersiyle -1 dondurur.
          Console.WriteLine(String.Compare(degisken,degisken2,true)); //0,1 , -1 iki degiskeni karsılastırırken kucuk buyuk harf duyarsız hale gelir true dersem,false dersem buyuk kucuk harf duyarlıdır 

          //Contains 
          Console.WriteLine(degisken.Contains(degisken2)); // degisken birin icinde degisken 2 var mı varsa true doncek 
          Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));//degisken ne ile bitiyor.
          Console.WriteLine(degisken.StartsWith("Merhaba!"));

          //IndexOf
          Console.WriteLine(degisken.IndexOf("Ja"));// degiskenin içinde bunu arıcaksa bulursa J nın indexini doncek

          //Insert

          Console.WriteLine(degisken.Insert(0,"Merhaba!")); // sıfırdan baslayarak stringin basına bunu ekler  
         //Last
          Console.WriteLine(degisken.LastIndexOf("i"));// 

          //Padleft PadRight;
          Console.WriteLine(degisken+degisken2.PadLeft(30));// sonuna 30 a tamamlıcak kadar bosluk ekler 
          Console.WriteLine(degisken +degisken2.PadLeft(30,'*'));
          //Remove
          Console.WriteLine(degisken.Remove(10));//10. karakterden sonra siler ucurur.
          Console.WriteLine(degisken.Remove(5,3));// 5. karakterden baslayarak sil 
          Console.WriteLine(degisken.Remove(0,1));//sıfırdan baslayrak 1 karakter silerek en bastaki karakteri silmis oluruz.


          //Replace 

            Console.WriteLine(degisken.Replace("java","C#")); // java yı degistir c# yaz  
            Console.WriteLine(degisken.Replace("","*"));
        
            // Split 

            Console.WriteLine(degisken.Split(' ')[1]);// bosluklara gore parcala ve bir diziye ata ve bana 1 indexteki veriyi getir 

            //Substring 
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            

          

        }
    }
}
