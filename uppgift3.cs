using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Antal burar: ");
    int N = int.Parse(Console.ReadLine());
    Console.Write("Antal arter: ");
    int K = int.Parse(Console.ReadLine());
    int svar = K;
    for (int i = 0; i < N-1; i++) {
      svar *= (K-1);
    }
    Console.WriteLine("Svar: " + svar);
  }
}
