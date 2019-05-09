using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CaixaDeLeite : IPapel
    {
        public bool Papel(){
            Console.WriteLine("Bom,este lixo será depositado na lixeira :");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("AZUL");
            Console.ResetColor();
            return true;
        }
    }
}