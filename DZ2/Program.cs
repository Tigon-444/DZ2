using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            ArrayList list2 = new ArrayList();
            LinkedList<int> list3 = new LinkedList<int>();

            List<int> allStatistic = new List<int>();


            CreateList(ref list1, ref allStatistic);

            CreateArrayList(ref list2, ref allStatistic);

            CreateLinkedList(ref list3, ref allStatistic);

            FindElementList(ref list1, ref allStatistic);

            FindElementArrayList(ref list2, ref allStatistic);

            FindElementLinkedList(ref list3, ref allStatistic);

            ResultDivision777List(ref list1, ref allStatistic);

            ResultDivision777ArrayList(ref list2, ref allStatistic);

            ResultDivision777LinkedList(ref list3, ref allStatistic);

            AllStatistic(allStatistic);

            

            void CreateList(ref List<int> List1, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    list1.Add(i + 1);
                }
                sw.Stop();

                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds)); // запись статистики

            }

            void CreateArrayList(ref ArrayList List2, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    list2.Add(i + 1);
                }
                sw.Stop();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds)); // запись статистики

            }

            void CreateLinkedList(ref LinkedList<int> List3, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start(); // создание и заполнение Linkedlist
                for (int i = 0; i < 1000000; i++)
                {
                    list3.AddLast(i + 1);
                }
                sw.Stop();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds)); // запись статистики
            }

            void FindElementList(ref List<int> List1, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine($"Элемент №496753 для List= {list1[496753]}");
                sw.Stop();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds));
            }

            void FindElementArrayList(ref ArrayList List2, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine($"Элемент №496753 для ArrayList= {List2[496753]}");
                sw.Stop();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds));
            }

            void FindElementLinkedList(ref LinkedList<int> List3, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                LinkedListNode<int> node;
                node = list3.First;
                for (int i = 0; i < 496753; i++)
                {
                    node = node.Next;
                }
                Console.WriteLine($"Элемент №496753 для LinkedList= {node.Value}");
                sw.Stop();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds));

            }

            void ResultDivision777List(ref List<int> List1, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start(); ;
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i] % 777 == 0)
                    {
                        Console.Write(" " + list1[i]);
                    }
                }
                sw.Stop();
                Console.WriteLine();
                Console.WriteLine();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds));
            }

            void ResultDivision777ArrayList(ref ArrayList List2, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (int chislo in list2)
                {
                    if (chislo % 777 == 0) Console.Write(" " + chislo);
                }
                sw.Stop();
                Console.WriteLine();
                Console.WriteLine();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds));
            }

            void ResultDivision777LinkedList(ref LinkedList<int> List3, ref List<int> allStatistic)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start(); 
                LinkedListNode<int> node;
                node = list3.First;
                while (node != null)
                {
                    if (node.Value % 777 == 0)
                    {
                        Console.Write(node.Value + " ");
                    }
                    node = node.Next;
                }
                sw.Stop();
                Console.WriteLine();
                Console.WriteLine();
                allStatistic.Add(Convert.ToInt32(sw.ElapsedMilliseconds));
            }

            static void AllStatistic (List<int> allStatistic) 
            {
                string parameter1;
                for (int i = 1; i < 10; i++)
                {
                    if (i % 3 == 0)
                    {
                        parameter1 = "LinkedList ";
                    }
                    else if (i % 2 == 0)
                    {
                        parameter1 = "ArrayList ";
                    }
                    else
                    {
                        parameter1 = "List ";
                    }
                    if (i > 0 & i <= 3)
                    {
                        Console.WriteLine("Время создания {0}= {1}", parameter1, allStatistic[i-1]);
                    }
                    if (i > 3 & i <= 6)
                    {
                        Console.WriteLine("Время нахождение элемента {0}= {1}", parameter1, allStatistic[i - 1]);
                    }
                    if (i > 6 & i <= 10)
                    {
                        Console.WriteLine("Время поиска чисел делящихся на 777 {0}= {1}", parameter1, allStatistic[i - 1]);
                    }

                }
            }

        }
    }
}