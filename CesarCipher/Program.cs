// See https://aka.ms/new-console-template for more information
using System;

namespace CesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la frase:");
            string input = Console.ReadLine();

            Console.WriteLine("Ingrese el desplazamiento:");
            if (int.TryParse(Console.ReadLine(), out int shift))
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Cifrar");
                Console.WriteLine("2. Descifrar");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    string encrypted = Cipher.Encrypt(input, shift);
                    Console.WriteLine($"Frase cifrada: {encrypted}");
                }
                else if (option == "2")
                {
                    string decrypted = Cipher.Decrypt(input, shift);
                    Console.WriteLine($"Frase descifrada: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Por favor, seleccione 1 para cifrar o 2 para descifrar.");
                }
            }
            else
            {
                Console.WriteLine("El desplazamiento debe ser un número entero.");
            }
        }
    }
}

