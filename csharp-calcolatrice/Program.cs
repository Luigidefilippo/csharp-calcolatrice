namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            int num1 = 2;
            int num2 = 6;

            double numd1 = 2.7654;
            double numd2 = 6.39;


            //SOMMA
            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.SommaDueNumeri(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.WriteLine(CalcoliHelper.SommaDueNumeri(numd1, numd2));


            //DIFFERENZA 
            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.DifferenzaDueNumeri(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.DifferenzaDueNumeri(numd1, numd2));

            //OPERAZIONE MOLTIPLICAZIONE
            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.MoltiplicaDueNumeri(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.MoltiplicaDueNumeri(numd1, numd2));

            //VALORE ASSOLUTO

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.ValoreAssoluto(num1));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.ValoreAssoluto(numd1));

            Console.WriteLine();

            //VALORE MINIMO 

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Minimo(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Minimo(numd1, numd2));

            //VALORE MASSIMO 

            Console.WriteLine();

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Massimo(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Massimo(numd1, numd2));
        }

    }
}
    
