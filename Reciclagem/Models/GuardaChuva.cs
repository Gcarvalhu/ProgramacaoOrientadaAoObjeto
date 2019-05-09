using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : IIndefinido
    {
        public bool Indefinido(){
            Console.WriteLine("Bom,este lixo será depositado na lixeira :");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("CINZA");
            Console.ResetColor();
            return true;
        }
    }
}