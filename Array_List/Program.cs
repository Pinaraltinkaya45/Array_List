using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList nedir...

            //string[] isimler = { "Enes", "Pınar", "Yusuf", "Ercan" };  // ilkel dizi

            //foreach (string a in isimler)
            //{
            //    Console.WriteLine(a);
            //}


            ArrayList koleksiyon = new ArrayList();  // bu bir classtır, içindeki methodları kullanabiliriz


            // add : eleman eklemeye yarar
            koleksiyon.Add("Enes");  // arrayliste eleman eklemek için kullandık
            koleksiyon.Add("Ali");
            koleksiyon.Add("Yusuf");
            koleksiyon.Add("Mehmet");



            // remove: almış olduğu objeyi kaldırır
            koleksiyon.Remove("Mehmet");  // mehmet değeri kalktı



            // count: dizinin eleman  sayısını alır
            int elemanSayisi = koleksiyon.Count;
            Console.WriteLine("Dizinin eleman sayısı : " + elemanSayisi);


            //clear : diiznin içindeki tüm elemanları siler
           // koleksiyon.Clear();




            // Contains: obje veri türünde değer alıyor geriye boolean dönüyor yani veriğin değer var mı yok mu kontrol ediyor
            bool kontrol = koleksiyon.Contains("Pınar");
            Console.WriteLine("Pınar var mı dizinin içinde : " + kontrol);




            // IndexOf : girmiş olduğun değerin index numarasını veriyor sana
            int index = koleksiyon.IndexOf("Yusuf");
            Console.WriteLine("Yusufun index numarası kaç: " + index);





            // insert : bir değer ve o değeri nereyew eklemek istiyorsak onun index numarasını giricez
            koleksiyon.Insert(3, "Sercan");




            // reverse: diziyi ters cevirir
            koleksiyon.Reverse();





            // sort : sıralamak için kullanılır
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(1);
            rakamlar.Add(100);
            rakamlar.Add(2);

            rakamlar.Sort(); // diziyi küçükten  büyüğe sıralar


            foreach (int i in rakamlar)
            {
                Console.WriteLine(i);
            }





            // toString : elimizdeki dataları string türüne dönüştürür

            int a = 10;
           string b =  a.ToString();
            Console.WriteLine(b);


            Console.ReadLine();
        }
    }
}
