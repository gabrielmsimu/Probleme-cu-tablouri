using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            //Problema_1();
            //Problema_2();
            //Problema_3();
            //Problema_4();
            //Problema_5();
            //Problema_6();
            Problema_7();
        }


        /// <summary>
        /// Reverse. Se da un vector nu n elemente. 
        /// Se cere sa se inverseze ordinea elementelor din vector. 
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        private static void Problema_7()
        {
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("before:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

            int aux;

            for (int i = 0; i < n/2; i++)
            {
                aux = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = aux;
            }

            Console.WriteLine("after:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }


        }



        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. 
        /// Se cere sa se stearga din vector elementul de pe pozitia k. 
        /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
        /// </summary>
        private static void Problema_6()
        {
            Console.WriteLine("Cate elemente doriti sa aiba vectorul?");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("De pe care pozitie doriti sa stergeti elementul?");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Before ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }


            for (int i = k; i < n-1; i++)
            {
                v[i] = v[i + 1];
            }

            Console.WriteLine("After:");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write($"{v[i]} ");
            }




        }


        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
        /// Se cere sa se insereze valoarea e in vector pe pozitia k. 
        /// Primul element al vectorului se considera pe pozitia zero.
        /// </summary>
        private static void Problema_5()
        {
            Console.WriteLine("Introduceti numarul initial de elemente al vectorului");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n+1];
            

            
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("Before: ");
            for (int i = 0; i < v.Length-1; i++)
            {
                Console.Write($"{v[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Introduceti valoarea e");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti valoarea pozitiei k (k trebuie sa fie mai mic decat {n})");
            int k = int.Parse(Console.ReadLine());

            for (int i = v.Length-1; i > k ; i--)
            {
                v[i] = v[i-1];
            }

            v[k] = e;


            Console.WriteLine("After: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }


            
        }



        /// <summary>
        /// Deteminati printr-o singura parcurgere, 
        /// cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
        /// </summary>
        private static void Problema_4()
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            int poz_max = 0, poz_min = 0;
            int count_max = 0, count_min = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti valoarea elementului {i}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (v[poz_max] < v[i])
                {
                    poz_max = i;
                    count_max = 1;
                }
                else if (v[poz_max] == v[i])
                {
                    count_max++;
                }

                if (v[poz_min] > v[i])
                {
                    poz_min = i;
                    count_min = 1;
                }
                else if (v[poz_min] == v[i])
                {
                    count_min++;
                }                
            }

            Console.WriteLine($"Maximul este {v[poz_max]} si apare de {count_max} ori, iar minimul este {v[poz_min]} si apare de {count_min} ori.");




        }


        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
        /// </summary>
        private static void Problema_3()
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            int poz_min = 0, poz_max = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti valoarea elementului {i}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] < v[poz_min])
                {
                    poz_min = i;
                }
                if (v[i] > v[poz_max])
                {
                    poz_max = i;
                }
            }

            Console.WriteLine($"Pozitiile din vector pe care apar cea mai mare si cea mai mica valoare din vector sunt {poz_max} pentru maxim si {poz_min} pentru minim.");
        }


        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. 
        /// Se cere sa se determine prima pozitie din vector pe care apare k. 
        /// Daca k nu apare in vector rezultatul va fi -1. 
        /// </summary>
        private static void Problema_2()
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti valoarea lui k");
            int k = int.Parse(Console.ReadLine());
            bool aparut = false;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti valoarea numarului {i}:");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"Pozitia pe care apare {k} este pozitia {i}.");
                    aparut = true;
                    break;
                }
            }

            if (aparut == false)
            {
                Console.WriteLine("-1");
            }
        }


        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. 
        /// Rezultatul se va afisa pe ecran.
        /// </summary>
        private static void Problema_1()
        {
            Console.WriteLine("Introduceti numarul (n) de elemente ale vectorului:" );
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            int sum = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"Introduceti valoarea numarului {i+1}");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < v.Length; i++)
            {
                sum = sum + v[i];
            }

            Console.WriteLine($"Suma elementelor vectorului este {sum}");

        }
    }
}
