using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_29112021_55_OOP_EncapsulationOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Daire isimli bir class'a aşağıdaki şekilde nesne oluşturma kuralları uygulayınız.
         Pi sayııs olarak bir özellikk tutunuz bu özelliğin değerini 3 olarak atayınız
            Pi sayısı değerini dışarıdan gönderiniz.
            bu dairenin çevresini ve alanını hesaplayınız
         */
            Daire d1 = new Daire();
            Console.WriteLine("Yarıcap değerini giriniz");
            int yaricap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pi değerini giriniz");
            double pi = Convert.ToDouble(Console.ReadLine());
            d1.Yaricap = yaricap;
            d1.PiSayisi = pi;
            Console.WriteLine("Dairenin Alanı: "+d1.AlanHesapla());
            Console.WriteLine("Dairenin Çevresi: "+d1.CevreHesapla());
            Console.WriteLine("Dairenin capı: "+d1.Cap);
            Console.ReadLine();
        }
    }
}
