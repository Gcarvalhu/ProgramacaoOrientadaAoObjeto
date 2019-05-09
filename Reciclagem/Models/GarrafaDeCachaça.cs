using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaDeCachaça : IVidro
    {
        public bool Vidro(){
            Console.WriteLine("Bom,este lixo será depositado na lixeira :");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("VERDE");
            Console.ResetColor();
            return true;
        }
    }
}