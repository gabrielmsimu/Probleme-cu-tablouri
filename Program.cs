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
            //Problema_7();
            //Problema_8();
            //Problema_9();
            //Problema_10(); //Binary Search -> de intrebat
            //Problema_11(); //Ciurul lui Erastostene -> de intrebat
            //Problema_12(); //Selection Sort
            //Problema_13(); //Insertion Sort
        }

        


        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
        /// </summary>
        private static void Problema_13()
        {
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 100);
            }

            Console.WriteLine("Before: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

            int aux;
            for (int i = 1; i < v.Length; i++)
            {
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--) 
                {
                    aux = v[k];
                    v[k] = v[k - 1];
                    v[k - 1] = aux;
                }
            }

            Console.WriteLine();
            Console.WriteLine("After:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }


        }

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        private static void Problema_12()
        {
            Console.WriteLine("Cate elemente doriti sa aiba vectorul?");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 100);
            }

            Console.WriteLine("Before:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

            int aux;
            for (int i = 0; i < n; i++)
            {
                int k = i;
                for (int j = i+1; j < n; j++)
                {
                    if (v[j] < v[k]) 
                    {
                        k = j;
                    }
                }
                aux = v[i];
                v[i] = v[k];
                v[k] = aux;
            }


            Console.WriteLine("After:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }



        }

        /// <summary>
        /// Se da un numar natural n. 
        /// Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
        /// </summary>
        private static void Problema_11()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        /// Se cere sa se determine pozitia unui element dat k. 
        /// Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        private static void Problema_10()
        {
            Console.WriteLine("cate elemente doriti sa aiba vectorul?");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = i + 2000;
            }

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Introduceti valoarea a carei pozitie doriti sa o gasiti:");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"Pozitia elementului este {i}");
                }
            }

        }


        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
        /// </summary>
        private static void Problema_9()
        {
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("Cu cate pozitii spre stanga doriti sa rotiti vectorul?");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Before: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

            int aux;

            for (int i = 1; i <= k; i++)
            {
                aux = v[0];
                for (int j = 0; j < n-1; j++)
                {
                    v[j] = v[j + 1];
                }
                v[n - 1] = aux;

            }

            Console.WriteLine("After: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

        }


        /// <summary>
        /// Rotire. Se da un vector cu n elemente. 
        /// Rotiti elementele vectorului cu o pozitie spre stanga. 
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        private static void Problema_8()
        {
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("Before: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

            int aux = v[0];
            for (int i = 0; i < n-1; i++)
            {
                
                v[i] = v[i + 1];
            }
            v[n-1] = aux;

            Console.WriteLine("After: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }


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
