using System;
 
class MainClass {
 public static void Main (string[] args) {
   Console.Write("Antal personer: ");
   int N = int.Parse(Console.ReadLine());
   Console.Write("Antal påsar: ");
   int K = int.Parse(Console.ReadLine());
   int[] påsar = new int[K];
   for (int i = 0; i < K; i++) {
     Console.Write("Påse " + (i+1) + ": ");
     påsar[i] = int.Parse(Console.ReadLine());
   }
   int bryggare = 0;
   int total = 0;
   Array.Sort(påsar);
   for (int i = 0; total < N; i++) {
     if(påsar[påsar.Length - 1] >= 10) {
       påsar[påsar.Length - 1] -= 10;
       total += 10;
     }
     else {
       påsar[påsar.Length - 1] -= påsar[påsar.Length - 1];
       total += påsar[påsar.Length - 1];
     }
     Array.Sort(påsar);
     bryggare = i;
   }
   Console.WriteLine("Svar :" + bryggare);
 }
}
