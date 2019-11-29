using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    List<int> ö = new List<int>();
    ö.Add(1);
    ö.Add(1);
    Random rnd = new Random();

    int deltagare = rnd.Next(1,10001);
    int i = 2;
    Console.WriteLine("Deltagare: " + deltagare);
    if (deltagare == 1) {
      i = 1;
    }
    else {
      while (Total(ö)<deltagare) {
        ö.Add(ö[i-1] + ö[i-2]);
        i++;
       }
    }
    Console.WriteLine("Ö: " + i);
  }
  public static int Total(List<int> a) {
    int total = 0;
    foreach(int element in a) {
      total+=element;
    }
    return total;
  }
}
