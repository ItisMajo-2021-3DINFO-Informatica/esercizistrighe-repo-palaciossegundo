using System;

namespace eserciziostringhe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio sulle stringhe 3");
            string parola = "";
            int contaparole = 0;
            while (parola != "fine")
            {
                Console.WriteLine("Inserisci una parola");
                parola = Console.ReadLine();
                char prima = parola[0];
                int lunghezza = parola.Length;
                char ultima = parola[lunghezza - 1];
                if (prima == ultima)
                {
                    contaparole++;
                }
                Console.WriteLine("Ci sono "+ contaparole + " che iniziano e finiscono per la stessa lettera");
            }
        }
    }
}
