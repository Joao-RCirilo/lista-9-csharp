
using System;
using System.Collections;

class HelloWorld
{
    static void Main()
    {
        Hashtable listaCPFTel = new Hashtable(); 
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o CPF da pessoa {i}: ");
            string cpf = Console.ReadLine();

            Console.Write($"Digite o número de telefone da pessoa {i}: ");
            string telefone = Console.ReadLine();

            listaCPFTel[cpf] = telefone;

            Console.WriteLine();
        }
        foreach (DictionaryEntry entry in listaCPFTel)
        {
            string cpf = (string)entry.Key;
            string telefone = (string)entry.Value;

            Console.WriteLine($"CPF: {cpf}, Telefone: {telefone}");
        }
        Console.ReadLine();
    }
}
