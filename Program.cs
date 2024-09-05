using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[] { "oculos", "torre", "mesa", "cadeira", "balança" };
            
            Random rand = new Random();
            int indexWord = rand.Next(0, 3);

            string wordChoice = palavras[indexWord];
            char[] word = new char[wordChoice.Length];
            char[] correctArray = wordChoice.ToCharArray();

            char[] errLetters = new char[26];

            int err = 0;

            Console.WriteLine("Bem vindo ao jogo da forca!");
            Console.Write("A palavra é: ");
            for (int i = 0; i < word.Length; i++)
            {
                
                word[i] = '_';
                Console.Write("_");
            }

            Console.WriteLine("\n");

            bool acertou = false;



            while (!acertou)
            {

                Console.Write("Escolha uma letra: ");
                char letter = Char.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                bool error = true;
                bool finish = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (correctArray[i] == letter) {
                        word[i] = letter;
                        error = false;
                    }
                    if ( word[i] == '_')
                    {
                        finish = false;
                    }
                }

                if (error) {
                    errLetters[err] = letter;
                    err++;
                }

                Console.Clear();

                Console.Write("erros: " + err + " | ");
                for(int i = 0; i < errLetters.Length; i++)
                {
                    Console.Write(errLetters[i] + " "); 
                }
                Console.WriteLine("\n================================");
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                }
                Console.WriteLine("\n");

                if(err > 6)
                {
                    Console.WriteLine("Você não conseguiu adivinhar a porra da palavra seu merda! o bagulho era: " + wordChoice);
                    break;
                }
                if(finish)
                {
                    Console.WriteLine("Parabéns você acertou a palavra!");
                    break;
                }

            }
        }
    }
}
