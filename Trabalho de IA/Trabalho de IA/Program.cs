using System;
using System.Collections.Generic;
using System.Linq;

namespace Trabalho_de_IA {
    class Program {
        static void Main(string[] args) {
            OrderList orderList = new OrderList();
            Console.WriteLine("Digite a quantidade de discos");
            int quntityDiscs = int.Parse(Console.ReadLine());
            int lastMoved = 0;
            List<int> discsA = new List<int>();
            List<int> discsB = new List<int>();
            List<int> discsC = new List<int>();
            for (int i = 1; i <= quntityDiscs; i++) {
                discsA.Add(i);
            }
            while (true) {
                if (discsA.Count == 0 && discsB.Count == 0 && discsC.Count != 0) {
                    Console.WriteLine($"TODAS AS PEÇAS FORAM MOVIDAS PARA O DISCO C!\nRESULTADO:");
                    foreach (int i in discsC) {
                        Console.WriteLine(i);
                    }
                    break;
                }
                if (discsA.Count == 0 && discsB.Count != 0 && discsC.Count == 0) {
                    Console.WriteLine($"TODAS AS PEÇAS FORAM MOVIDAS PARA O DISCO B!\nRESULTADO:");
                    foreach (int i in discsB) {
                        Console.WriteLine(i);
                    }
                    break;
                }
                if (discsA.Count != 0 && discsA.ElementAt(0) != lastMoved) {
                    if(discsB.Count != 0 && discsC.Count != 0  && discsA.ElementAt(0) < discsB.ElementAt(0) && discsA.ElementAt(0) < discsC.ElementAt(0)) {
                        if (discsB.ElementAt(0) < discsC.ElementAt(0)) {
                            discsB.Add(discsA.ElementAt(0));
                            discsB = orderList.doOrder(discsB);
                            Console.WriteLine($"Movendo disco {discsA.ElementAt(0)} de A para B");
                            lastMoved = discsA.ElementAt(0);
                            discsA.Remove(discsA.ElementAt(0));
                            continue;
                        }
                        else {
                            discsC.Add(discsA.ElementAt(0));
                            discsC = orderList.doOrder(discsC);
                            Console.WriteLine($"Movendo disco {discsA.ElementAt(0)} de A para C");
                            lastMoved = discsA.ElementAt(0);
                            discsA.Remove(discsA.ElementAt(0));
                            continue;
                        }
                    }
                    else if (discsB.Count != 0 && discsA.ElementAt(0) < discsB.ElementAt(0)) {
                        discsB.Add(discsA.ElementAt(0));
                        discsB = orderList.doOrder(discsB);
                        Console.WriteLine($"Movendo disco {discsA.ElementAt(0)} de A para B");
                        lastMoved = discsA.ElementAt(0);
                        discsA.Remove(discsA.ElementAt(0));
                        continue;
                    }
                    else if (discsB.Count == 0) {
                        discsB.Add(discsA.ElementAt(0));
                        discsB = orderList.doOrder(discsB);
                        Console.WriteLine($"Movendo disco {discsA.ElementAt(0)} de A para B");
                        lastMoved = discsA.ElementAt(0);
                        discsA.Remove(discsA.ElementAt(0));
                        continue;
                    }
                    else if (discsC.Count != 0 && discsA.ElementAt(0) < discsC.ElementAt(0)) {
                        discsC.Add(discsA.ElementAt(0));
                        discsC = orderList.doOrder(discsC);
                        Console.WriteLine($"Movendo disco {discsA.ElementAt(0)} de A para C");
                        lastMoved = discsA.ElementAt(0);
                        discsA.Remove(discsA.ElementAt(0));
                        continue;
                    }
                    else if (discsC.Count == 0) {
                        discsC.Add(discsA.ElementAt(0));
                        discsC = orderList.doOrder(discsC);
                        Console.WriteLine($"Movendo disco {discsA.ElementAt(0)} de A para C");
                        lastMoved = discsA.ElementAt(0);
                        discsA.Remove(discsA.ElementAt(0));
                        continue;
                    }
                }
                if (discsB.Count != 0 && discsB.ElementAt(0) != lastMoved) {
                    if (discsA.Count != 0 && discsC.Count != 0 && discsB.ElementAt(0) < discsA.ElementAt(0) && discsB.ElementAt(0) < discsC.ElementAt(0)) {
                        if (discsA.ElementAt(0) < discsC.ElementAt(0)) {
                            discsA.Add(discsB.ElementAt(0));
                            discsA = orderList.doOrder(discsA);
                            Console.WriteLine($"Movendo disco {discsB.ElementAt(0)} de B para A");
                            lastMoved = discsB.ElementAt(0);
                            discsB.Remove(discsB.ElementAt(0));
                            continue;
                        }
                        else {
                            discsC.Add(discsB.ElementAt(0));
                            discsC = orderList.doOrder(discsC);
                            Console.WriteLine($"Movendo disco {discsB.ElementAt(0)} de B para C");
                            lastMoved = discsB.ElementAt(0);
                            discsB.Remove(discsB.ElementAt(0));
                            continue;
                        }
                    }
                    else if (discsA.Count != 0 && discsB.ElementAt(0) < discsA.ElementAt(0)) {
                        discsA.Add(discsB.ElementAt(0));
                        discsA = orderList.doOrder(discsA);
                        Console.WriteLine($"Movendo disco {discsB.ElementAt(0)} de B para A");
                        lastMoved = discsB.ElementAt(0);
                        discsB.Remove(discsB.ElementAt(0));
                        continue;
                    }
                    else if (discsA.Count == 0) {
                        discsA.Add(discsB.ElementAt(0));
                        discsA = orderList.doOrder(discsA);
                        Console.WriteLine($"Movendo disco {discsB.ElementAt(0)} de B para A");
                        lastMoved = discsB.ElementAt(0);
                        discsB.Remove(discsB.ElementAt(0));
                        continue;
                    }
                    else if (discsC.Count != 0 && discsB.ElementAt(0) < discsC.ElementAt(0)) {
                        discsC.Add(discsB.ElementAt(0));
                        discsC = orderList.doOrder(discsC);
                        Console.WriteLine($"Movendo disco {discsB.ElementAt(0)} de B para C");
                        lastMoved = discsB.ElementAt(0);
                        discsB.Remove(discsB.ElementAt(0));
                        continue;
                    }
                    else if (discsC.Count == 0) {
                        discsC.Add(discsB.ElementAt(0));
                        discsC = orderList.doOrder(discsC);
                        Console.WriteLine($"Movendo disco {discsB.ElementAt(0)} de B para C");
                        lastMoved = discsB.ElementAt(0);
                        discsB.Remove(discsB.ElementAt(0));
                        continue;
                    }
                }
                if (discsC.Count != 0 && discsC.ElementAt(0) != lastMoved) {
                    if (discsA.Count != 0 && discsB.Count != 0 && discsC.ElementAt(0) < discsA.ElementAt(0) && discsC.ElementAt(0) < discsB.ElementAt(0)) {
                        if (discsA.ElementAt(0) < discsB.ElementAt(0)) {
                            discsA.Add(discsC.ElementAt(0));
                            discsA = orderList.doOrder(discsA);
                            Console.WriteLine($"Movendo disco {discsC.ElementAt(0)} de C para A");
                            lastMoved = discsC.ElementAt(0);
                            discsC.Remove(discsC.ElementAt(0));
                            continue;
                        }
                        else {
                            discsB.Add(discsC.ElementAt(0));
                            discsB = orderList.doOrder(discsB);
                            Console.WriteLine($"Movendo disco {discsC.ElementAt(0)} de C para B");
                            lastMoved = discsC.ElementAt(0);
                            discsC.Remove(discsC.ElementAt(0));
                            continue;
                        }
                    }
                    else if (discsA.Count != 0 && discsC.ElementAt(0) < discsA.ElementAt(0)) {
                        discsA.Add(discsC.ElementAt(0));
                        discsA = orderList.doOrder(discsA);
                        Console.WriteLine($"Movendo disco {discsC.ElementAt(0)} de C para A");
                        lastMoved = discsC.ElementAt(0);
                        discsC.Remove(discsC.ElementAt(0));
                        continue;
                    }
                    else if (discsA.Count == 0) {
                        discsA.Add(discsC.ElementAt(0));
                        discsA = orderList.doOrder(discsA);
                        Console.WriteLine($"Movendo disco {discsC.ElementAt(0)} de C para A");
                        lastMoved = discsC.ElementAt(0);
                        discsC.Remove(discsC.ElementAt(0));
                        continue;
                    }
                    else if (discsB.Count != 0 && discsC.ElementAt(0) < discsB.ElementAt(0)) {
                        discsB.Add(discsC.ElementAt(0));
                        discsB = orderList.doOrder(discsB);
                        Console.WriteLine($"Movendo disco {discsC.ElementAt(0)} de C para B");
                        lastMoved = discsC.ElementAt(0);
                        discsC.Remove(discsC.ElementAt(0));
                        continue;
                    }
                    else if (discsB.Count == 0) {
                        discsB.Add(discsC.ElementAt(0));
                        discsB = orderList.doOrder(discsB);
                        Console.WriteLine($"Movendo disco {discsC.ElementAt(0)} de C para B");
                        lastMoved = discsC.ElementAt(0);
                        discsC.Remove(discsC.ElementAt(0));
                        continue;
                    }
                }
            }
        }
    }
}
