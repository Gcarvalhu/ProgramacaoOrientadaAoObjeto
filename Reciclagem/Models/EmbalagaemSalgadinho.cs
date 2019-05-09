using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class EmbalagaemSalgadinho : IPlastico
    {
        public bool Plastico(){
            Console.WriteLine("Bom,este lixo será depositado na lixeira :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("VERMELHA");
            Console.ResetColor();
            return true;
        }
    }
}