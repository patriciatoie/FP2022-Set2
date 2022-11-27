using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Set2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr;
            Console.WriteLine("Introduceti un numar cuprins intre 1 si 21 corespunzator problemei:");
            nr = int.Parse(Console.ReadLine());

            switch (nr)
            {
                case 1: P1(); break;
                case 2: P2(); break;
                case 3: P3(); break;
                case 4: P4(); break;
                case 5: P5(); break;
                case 6: P6(); break;
                case 7: P7(); break;
                case 8: P8(); break;
                case 9: P9(); break;
                case 10: P10(); break;
                case 11: P11(); break;
                case 12: P12(); break;
                case 13: P13(); break;
                case 14: P14(); break;
                case 15: P15(); break;
                case 16: P16(); break;
                case 17: P17(); break;
                default:
                Console.WriteLine("Numarul introdus nu este corect, numarul trebuie sa fie cuprins intre 1 si 17, conform problemei.");
                 break;
            }
        }

        private static void P1()
        {
            // Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
            Console.WriteLine("Problema numarul 1");

            int n, i, x, contor;
            contor = 0;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei", i); // introduc de la tastatura elementele secventei, unde i este pozitia
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) // caut elementele pare ale secventei
                    contor++;
            }
            Console.WriteLine($"Am gasit numere pare in secventa, acestea sunt in numar de: {contor}");
        }

        private static void P2()
        {
            //Se da o secventa de n numere. Sa se determina cate
            //sunt negative, cate sunt zero si cate sunt pozitive. 
            Console.WriteLine("Problema numarul 2");

            int n, i, x, neg, poz, zero;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            neg = 0;
            poz = 0;
            zero = 0;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei:", i); // introducem de la tastatura cele n numere din secventa
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    neg++;
                if (x > 0)
                    poz++;
                if (x == 0)
                    zero++;
            }
            Console.WriteLine($"Secventa are {neg} numere negative, {poz} numere pozitive, {zero} numere egale cu 0.");
        }

        private static void P3()
        {
            //Calculati suma si produsul numerelor de la 1 la n. 
            Console.WriteLine("Problema numarul 3");

            int n, s, p, i;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            s = 0;
            p = 1;
            for (i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {s} iar produsul este: {p}");
        }

        private static void P4()
        {
            //Se da o secventa de n numere.Determinati pe ce pozitie
            //se afla in secventa un numara a. Se considera ca primul
            //element din secventa este pe pozitia zero.Daca numarul
            //nu se afla in secventa raspunsul va fi -1.
            Console.WriteLine("Problema numarul 4");

            int n, x, i, a;
            bool c = false;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul a pe care il cautam in secventa");
            a = int.Parse(Console.ReadLine());
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    Console.WriteLine($"Pozitia pe care apare numarul {a} este {i}");
                    c = true;
                    break;
                }
            }
            if (c == false)
            {
                Console.WriteLine("-1");
            }
        }

        private static void P5()
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu
            //pozitia pe care apar in secventa? Se considera ca primul
            //element din secventa este pe pozitia 0. 
            Console.WriteLine("Problema numarul 5");

            int n, i, x, contor;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            contor = 0;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea element al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (x == i)
                    contor++;
            }
            Console.WriteLine($"{contor} elemente din secventa sunt egale cu pozitia lor.");
        }

        private static void P6()
        {
            //Se da o secventa de n numere. Sa se determine
            //daca numerele din secventa sunt in ordine crescatoare. 
            Console.WriteLine("Problema numarul 6");

            int n, i, x, nr, y;
            bool crescatoare = false;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            y = 0;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea element al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (y <= x)
                    crescatoare = true;
                else
                    crescatoare = false;
                x = y;
            }
            if (crescatoare = true)
                Console.WriteLine("Elementele sunt in ordine crescatoare");
            else
                Console.WriteLine("Elementele NU sunt in ordine crescatoare");
        }
    

        private static void P7()
        {
            //Se da o secventa de n numere. Sa se determine
            //cea mai mare si cea mai mica valoare din secventa.
            Console.WriteLine("Problema numarul 7");

            int n, i, x, max, min;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            max = -int.MaxValue;
            min = int.MaxValue;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }
            Console.WriteLine($"Cea mai mare valoare din secventa este {max} iar cea mai mica valoare este {min}");
        }

        private static void P8()
        {
            // Determianti al n-lea numar din sirul lui Fibonacci.
            // Sirul lui Fibonacci se construieste astfel:
            // f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
            // Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
            Console.WriteLine("Problema numarul 8");

            int n, x1, x2, x3, i;
            Console.WriteLine("Cate numere are sirul Fibonacci?");
            n = int.Parse(Console.ReadLine());
            x1 = 0;
            x2 = 1;
            x3 = x1 + x2;
            for (i = 2; i <= n - 1; i++)
            {
                x3 = x1 + x2;
                x1 = x2;
                x2 = x3;
            }
            Console.WriteLine($"Al {n}- lea numar din sirul lui Fibonacci este {x3}");
        }

        private static void P9()  
        {
            //Sa se determine daca o secventa de n numere este monotona.
            //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
            Console.WriteLine("Problema numarul 9");

            int n, i, x, y;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            bool cresc = true;
            bool descresc = true;
            y = 0;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea element al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (y <= x)
                {
                    cresc = true;
                    descresc = false;
                }
                else
                {
                    cresc = false;
                    descresc = true;
                }
                y = x;
            }
            if (cresc = true)
                Console.WriteLine("Secventa este monoton crescatoare");
            else if (descresc = true)
                Console.WriteLine("Secventa este monoton descrescatoare");
            else
                Console.WriteLine("Secventa nu este monotona");
        }

        private static void P10()
        {
            //Se da o secventa de n numere. Care este numarul
            //maxim de numere consecutive egale din secventa?
            Console.WriteLine("Problema numarul 10");

            int n, i, x, anterior, maxim, contor;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            contor = 1;
            Console.WriteLine("Introduceti numarul anterior cu care vor fi comparate numerele secventei");
            anterior = int.Parse(Console.ReadLine());
            maxim = 0;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea element al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (anterior == x)
                    contor++;
                else
                    contor = 1;
                if (contor >= maxim)
                    maxim = contor;
            }
            Console.WriteLine($"Numarul maxim de numere egale consecutive din secventa este {maxim}");
        }

        private static void P11()
        {
            // Se da o secventa de n numere.Se cere sa
            // se caculeze suma inverselor acestor numere.
            Console.WriteLine("Problema numarul 11");

            int n, i, x, sum, inv;
            sum = 0;
            inv = 0;
            Console.WriteLine("Cate elemente are secventa?");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {0}-lea element al secventei", i);
                x = int.Parse(Console.ReadLine());

                while (x != 0)
                {
                    inv = inv * 10 + x % 10;
                    x = x / 10;
                }
                sum = sum + inv;
                inv = 0;
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa este: {sum}");
        }

        private static void P12()
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere?
            //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.//
            Console.WriteLine("Problema numarul 12");

            string sir = Console.ReadLine();
            string[] split = sir.Split('0');
            int i, grup, anterior, cresc, nr;
            grup = 0;
            anterior = 0;
            cresc = 0;
            nr = 0;
            for (i = 0; i < split.Length; i++)
            {
                cresc = 0;
                nr = 0;
                foreach (char c in split[i])
                {
                    if (Char.IsDigit(c))
                    {
                        if (c != '0')
                        {
                            if ((int)c > anterior)
                            {
                                cresc++;
                            }
                            nr++;
                            anterior = (int)c;
                        }
                    }
                }
                if (cresc == nr && cresc != 0 && nr != 0)
                    grup++;
            }
            Console.WriteLine("In secventa se gasesc {0} grupuri de numere consecutive, delimitate de 0", grup);
        }
    

        private static void P13()
        {
            // O < secventa crescatoare rotita> este o secventa de numere
            // care este in ordine crescatoare sau poate fi transformata
            // intr - o secventa in ordine crescatoare prin rotiri succesive
            // (rotire cu o pozitie spre stanga = toate elementele se muta
            // cu o pozitie spre stanga si primul element devine ultimul).
            // Determinati daca o secventa de n numere este o secventa
            // crescatoare rotita.// 
            Console.WriteLine("Problema numarul 13");

            int n, a, minim;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar care va fi mai apoi comparat cu numerele din secventa:");
            a = int.Parse(Console.ReadLine());
            minim = a;
            bool crescatoare = true;
            int cadere = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei:", i);
                int x = int.Parse(Console.ReadLine());
                if (x < a) // daca primul meu numar x e mai mic ca minimul, primul numar devine ultimul prin rotire cu o pozitie la stanga si secventa nu mai e crescatoare rotita
                {
                    crescatoare = false;
                }
                if (a > x && minim > x)
                {
                    cadere++;
                }
                a = x;
            }
            if (crescatoare == true || cadere == 1)
                Console.WriteLine("Este crescatoare rotita");
            else
                Console.WriteLine("Nu este crescatoare rotita");
        }

        private static void P14()
        {
            //O <secventa monotona rotita> este o secventa de numere monotona
            //sau poate fi transformata intr-o secventa montona prin rotiri succesive.
            //Determinati daca o secventa de n numere este o secventa monotona rotita. 
            Console.WriteLine("Problema numarul 14");

            int n, i, a, min, max, x, cadereCresc, cadereDescresc;
            bool crescatoare = true;
            bool descrescatoare = true;
            Console.WriteLine("Cate numere are secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar a cu care vor fi mai apoi comparate numerele din secventa:");
            a = int.Parse(Console.ReadLine());
            min = max = a;
            cadereCresc = 0;
            cadereDescresc = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei", i);
                x = int.Parse(Console.ReadLine());
                if (x < a)
                    crescatoare = false;
                else // daca x > a
                    descrescatoare = false;
                if (x < a && x < min)
                    cadereCresc++;
                if (x > a && x > max)
                    cadereDescresc++;
                a = x;
            }
            if (crescatoare == true || cadereCresc == 1)
                Console.WriteLine("Secventa este crescatoare (monoton) rotita.");
            else if (descrescatoare == true || cadereDescresc == 1)
                Console.WriteLine("Secventa este descarescatoare (monoton) rotita.");
            else
                Console.WriteLine("Secventa nu este monotona.");
        }

        private static void P15()

        {  //O secventa bitonica este o secventa de numere care
           //incepe monoton crescator si continua monoton descrecator.
           //De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.
           //Se da o secventa de n numere. Sa se determine daca este bitonica.
           Console.WriteLine("Problema numarul 15");

            Console.WriteLine("Cate numere are secventa?");
           int n = int.Parse(Console.ReadLine());
           int cr = 0;
           int des = 0;
           bool crescatoare = false;
           bool descrescatoare = false;
           int a = 0;
           for (int i = 0; i < n - 1; i++)
           {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei:", i);
                int x = int.Parse(Console.ReadLine());
                if (x >= a && descrescatoare == false)
                {
                    crescatoare = true;
                    cr++;
                }
                else if (x <= a && crescatoare == true)
                {
                    descrescatoare = true;
                    des++;
                }
                a = x;
            }
            if (cr + des == n - 1)
                Console.WriteLine("Secventa Bitonica");
            else
                Console.WriteLine("Secventa nu este bitonica");
        }

        private static void P16()
        {
            //O <secventa bitonica rotita> este o secventa bitonica sau
            //una ca poate fi transformata intr-o secventa bitonica prin
            //rotiri succesive (rotire = primul element devine ultimul).
            //Se da o secventa de n numere. Se cere sa se determine daca
            //este o secventa bitonica rotita. 
            Console.WriteLine("Problema numarul 16");

            Console.WriteLine("Ctae numere are secventa?");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int comparatorDesc = a;
            int comparatorCresc = a;
            bool crescatoare = false;
            bool descrescatoare = false;
            bool bitonica = false;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea numar al secventei", i);
                int x = int.Parse(Console.ReadLine());
                if (x <= a && crescatoare == false)
                {
                    descrescatoare = true;
                }
                else if (x >= comparatorCresc && crescatoare == false && descrescatoare == false)
                {
                    crescatoare = true;
                    descrescatoare = true;
                }
                else if (x >= a && crescatoare == false)
                {
                    crescatoare = true;
                }
                else if (x <= a && crescatoare == true)
                {
                    descrescatoare = true;
                }
                else if (x <= a && descrescatoare == true)
                {
                    crescatoare = true;
                }
                else if (x >= a && descrescatoare == true && crescatoare == true)
                {
                    if (x >= comparatorDesc || x >= comparatorCresc)
                    {
                        bitonica = true;
                    }
                    else
                    {
                        bitonica = false;
                    }
                }
                a = x;
            }
            if (bitonica == true)
                Console.WriteLine("Este bitonica rotita");
            else
                Console.WriteLine("Nu este bitonica rotita");
        }

        private static void P17()
        {
            //Se da o secventa de 0 si 1, unde 0 inseamna paranteza
            //deschisa si 1 inseamna paranteza inchisa. Determinati
            //daca secventa reprezinta o secventa de paranteze corecta
            //si,  daca este, determinati nivelul maxim de incuibare
            //a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta
            //si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0
            //este incorecta. 
            Console.WriteLine("Problema numarul 17");

            Console.WriteLine("Scrieti un sir de caractere formate din 0 si 1");
            string sir = Console.ReadLine();
            int contor = 0;
            int nrIncuibari = 0;
            int maxIncuibare = -1;
            foreach (char c in sir)
            {
                if (c == '0')
                    contor++;
                else if (c == '1' && contor > 0)
                    contor--;
            }
            if (contor == 0)
            {
                Console.WriteLine("Parantezele sunt situate corect");
                foreach (char c in sir)
                {
                    if (c == '0')
                        nrIncuibari++;
                    if (c == '1')
                        nrIncuibari--;
                    if (nrIncuibari > maxIncuibare)
                        maxIncuibare = nrIncuibari;
                }
                Console.WriteLine($"Incuibarea maxima este {maxIncuibare}");
            }
            else
                Console.WriteLine("Parantezele nu sunt situate corect");
        }
    }
}
