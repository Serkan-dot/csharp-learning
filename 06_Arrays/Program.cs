using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırmızı,mavi,turuncu
            //adana,ankara,istanbul,bursa

            //VeriTipi [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //dizinin eleman sayısı kaç olursa olsun eğer atama yapılmamıç dizin varsa default olarak 0 olur.

            //Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[5]);
            //Console.WriteLine(numbers[9]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] countries = { "Türkiye", "ABD", "Birleşik Krallık", "Rusya", "Almanya" };

            //for(int i = 0; i <= countries.Length - 1 ; i++)
            //{
            //    Console.WriteLine(countries[i]);
            //}

            //int[] numbers = new int[5];

            //for(int i = 0;i<= numbers.Length - 1; i++)
            //{
            //    numbers[i] = i;
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 4, 85, 75, 96, 122, 488, 522, 887, 2356, 1120 };

            //for(int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i] + " Sayısı 3'e Tam Bölünür.");
            //    }
            //}

            //char[] symbols = { 'a', 'b' , 'c' , '*' , '/' , '-'};
            //for(int i = 0; i <= symbols.Length - 1; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 23, 12, 54, 87, 3, 234, 564, 45, 324, 21, 32 };
            //int maxNumber = numbers[0];
            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metodları

            //int[] numbers = { 42, 56, 93, 67, 43, 99, 45, 13, 42 };
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length - 1]);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 34, 78, 59, 42, 4, 85, 59 };
            //Array.Sort(numbers);
            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 33, 45, 89, 41, 91, 4, 6, 87, 92 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for(int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 10, 74, 33, 25, 46 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[4];

            //for(int i= 0; i <= cities.Length - 1; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehiri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            //for(int i = 0;i<= cities.Length - 1; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 23, 65, 87, 38, 9, 17, 3, 54 };
            //int sum = 0;

            //for(int i = 0; i<= numbers.Length-1; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("Çift Sayılar: ");
            //int[] numbers = { 32, 64, 66, 98, 45, 32, 13, 57, 95 };
            //for(int i=0; i<=numbers.Length-1; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.Write(numbers[i]+ " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar: ");
            //for(int i =0; i <= numbers.Length - 1; i++)
            //{
            //    if (numbers[i]%2 != 0)
            //    {
            //        Console.Write(numbers[i] + " ");
            //    }
            //}
            #endregion

            #region Örnek

            //a dizesindekileri b dizesine tersten yazdırma
            //Console.Write("Dizi Uzunluğunu Giriniz: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[n];
            //int[] b = new int[n];
            //for(int i = 0; i <= a.Length - 1;i++)
            //{
            //    Console.Write($"{i + 1}. Sayıyı Giriniz: ");
            //    int number= Convert.ToInt32(Console.ReadLine());
            //    a[i] = number;
            //}
            //for(int i = 0; i <= a.Length - 1; i++)
            //{
            //    b[i] = a[(n - 1) - i];
            //    Console.WriteLine($"{i+1}. Sayı: " + b[i]);
            //}

            //a,b dizesindeki aynı index numarasındaki sayıların toplamları c dizisindeki aynı index numarasına eklesin

            //Console.Write("Dizilerin Uzunluğunu girin: ");
            //int n= Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[n];
            //int[] b = new int[n];
            //int[] c = new int[n];

            //for(int i = 0; i <= a.Length - 1; i++)
            //{
            //    Console.Write($"1.Dizinin {i + 1}.Sayısını Giriniz: ");
            //    int aNumber= Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"2.Dizinin {i + 1}.Sayısını Giriniz: ");
            //    int bNumber = Convert.ToInt32(Console.ReadLine());

            //    a[i] = aNumber;
            //    b[i] = bNumber;

            //    c[i] = a[i] + b[i];
            //}
            //for(int i = 0; i <= c.Length - 1; i++)
            //{
            //    Console.WriteLine($"{i+1}.Sayı: "+c[i]);
            //}
            #endregion
            Console.Read();
        }
    }
}
