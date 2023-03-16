using System;

class Program {
    static void Main(string[] args) {
        int num;
        int sum = 0;
        
        Console.WriteLine("Enter a list of integers (terminate with 0):");
        do {
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        } while (num != 0);
        
        Console.WriteLine("The sum of the entered integers is: {0}", sum);
    }
}
