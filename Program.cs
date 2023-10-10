using System.Data;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {
        // 1- Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme durumunu kontrol ediniz. Ehliyet alma koşulu en az 18 ve eğitim durumu lise ya da üniversite olmalıdır.

/*             Console.Write("ad: ");
            string ad = Console.ReadLine();

            Console.Write("yaş: ");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("eğitim: ");
            string egitim = Console.ReadLine();

            if(yas>=18)
            {
                //eğitim bilgisini kontrol et
                if(egitim=="lise" || egitim=="üniversite")
                {
                    Console.WriteLine($"{ad} ehliyet alabilirsiniz.");
                }else
                {
                    Console.WriteLine($"{ad} eğitim durumunuz lise ya da üniversite olmalıdır.");
                }
            }else
            {
                Console.WriteLine($"{ad} ehliyet almak için en az 18 olmalısınız.");
            } */

        // 2- Girilen 3 sayıdan en büyüğünü bulunuz.

/*             Console.Write("a sayısı: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b sayısı: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("b sayısı: ");
            int c = int.Parse(Console.ReadLine());

            if(a>b && a>c)
                Console.WriteLine("a en büyük");
                else if (b>c && b>a)
                System.Console.WriteLine("b en büyük");
                else if (c>a && c>a)
                System.Console.WriteLine("c en büyük");
                else
                    System.Console.WriteLine("yanlış bilgi");
 */


        // 3- Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortama göre not aralığına karşılık gelen not bilgisini yazdırınız.
        // 0 - 24 = 0
        // 25 - 44 = 1
        // 45 - 54 = 2
        // 55 - 69 = 3
        // 70 - 84 = 4
        // 85 - 100 = 5

/*         System.Console.Write("1. yazılı: ");
        int not1 = int.Parse(Console.ReadLine());

        System.Console.Write("2. yazılı: ");
        int not2 = int.Parse(Console.ReadLine());
        
        System.Console.Write("sözlü: ");
        int sozlu = int.Parse(Console.ReadLine());

        var ortalama = (not1+not2+sozlu)/3;

        if (ortalama>=0 && ortalama<25)
            System.Console.WriteLine("notunuz 0");
        else if (ortalama>=25 && ortalama<45)
            System.Console.WriteLine("notunuz 1");
        else if (ortalama>=45 && ortalama<55)
            System.Console.WriteLine("notunuz 2");
        else if (ortalama>=55 && ortalama<70)
            System.Console.WriteLine("notunuz 3");
        else if (ortalama>=70 && ortalama<85)
            System.Console.WriteLine("notunuz 4");
        else if (ortalama>=85 && ortalama<100)
            System.Console.WriteLine("notunuz 5");
        else
            System.Console.WriteLine("yanlış bilgi");
 */


        // 4- Trafiğe çıkış tarihi alınan bir aracın servis zamanının aşağıdaki bilgilere göre hesaplayınız.
        // 1. bakım = 1. yıl
        // 2. bakım = 2. yıl
        // 3. bakım = 3. yıl
        // Süre hesabını gün, ay, yıl bilgisine göre gün bazlı hesaplayın.

/*         System.Console.Write("yıl: ");
        int yil = int.Parse(Console.ReadLine());

        System.Console.Write("ay: ");
        int ay = int.Parse(Console.ReadLine());

        System.Console.Write("gün: ");
        int gun = int.Parse(Console.ReadLine());

        int toplamGun = (DateTime.Now - new DateTime(yil,ay,gun)).Days;

        if (toplamGun<=365)
            System.Console.WriteLine("1. servis");
        else if (toplamGun>365 && toplamGun<365*2)
            System.Console.WriteLine("2. servis");
        else if (toplamGun>365*2 && toplamGun<365*3)
            System.Console.WriteLine("3. servis");
        else 
            System.Console.WriteLine("yanlış bilgi");
 */
    }
}