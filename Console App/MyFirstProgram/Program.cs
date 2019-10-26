using System;

namespace MyFirstProgram {
    class Program {
        static void Main(string[] args) {
            string name = "Tony";

            // int age = new int()
            //     age = 40
            int age = 40;

            Console.WriteLine("Hello World!");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine("Happy {0}th birthday, {1}", age, name);

            SavingsAccount a1 = new SavingsAccount();
            Console.WriteLine(a1.Balance);
        }
    }
}
