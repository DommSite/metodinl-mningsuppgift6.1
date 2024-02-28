using System;
namespace metodinlämningsuppgift6_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Välj ett av alternativen");
            Console.WriteLine("1.Addera tre tal");
            Console.WriteLine("2.Största talet av två tal");
            Console.WriteLine("3.Avsluta programmet");
            int val = int.Parse(Console.ReadLine());
            if(val==1)
            {
                adderamenyval();
            }
            else if(val==2)
            {
                störstamenyval();
            }
        }

        static void adderamenyval()
        {
            int[] tal = new int[3];
            
            Console.WriteLine("Skriv in de 3 tal du vill addera");
            for(int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Skriv tal #" + (i+1));
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dina 3 tal adderade ihop blir " + addera(tal));
            Main();
        }

        static void störstamenyval()
        {
            int[] tal = new int[2];
            Console.WriteLine("Skriv in de 2 tal du vill jämföra");
            for (int i = 0;i < 2; i++)
            {
                Console.WriteLine("Skriv in tal #" + (i + 1));
                tal[i] = int.Parse(Console.ReadLine()) ;
            }
            störst(tal);
            Main();
        }
        static int addera(int[] tal)
        {
            int svar = 0;
            for(var i = 0; i < tal.Length; i++)
            {
                svar = svar + tal[i];
            }
            return svar;
        }



        static void störst(int[] tal)
        {
            if(tal[0] < tal[1])
            {
                Console.WriteLine("Det största talet var " + tal[1]);
            }
            else if(tal[0] > tal[1]) 
            {
                Console.WriteLine("Det största talet var " + tal[0]);
            }
            else
            {

                Console.WriteLine(tal[0] + " och " + tal[1] + " är lika stora");
            }
            
        }
    }
}