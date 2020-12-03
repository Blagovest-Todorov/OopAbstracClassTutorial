using System;

namespace _27.OopAbstractClassTutorial
{
    
    abstract class M1 //defining the Parent abstract class -M1
    {
        public int Add(int a, int b) 
        {
            return a + b;
        }
    }          // Definnign the Child class -M2
    class M2 : M1  //M2 is child class of M1 //M2 Inherits the class M1 ; M1 is the Parent Class /
    {
        public int Mul(int a, int b) 
        {
            return a * b;
        }
    }
    class test 
    {
        static void Main(string[] args )
        {
            M2 ob = new M2(); //Creating a instance of class M2 , the object "ob"
            int result = ob.Add(10, 20);  //into a variable result we call on the Object "ob" the method Add -this method is inhereted by the class M1
            Console.WriteLine("the result is {0}", result ); //Printing out the result ! 
            Console.ReadLine();
        }
    }
}
