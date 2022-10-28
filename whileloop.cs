using System;

class Program {
  public static void Main (string[] args) {
  int i=0; //initialization
    while (i<10){ //condition
    Console.WriteLine ("Hello World");
    
    Console.WriteLine("Before i++ {0}",i);
      i++; 
      Console.WriteLine("After i++ {0} ",i);
    }
    
  }
}
