using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models {
    public class Latinha : IMetal {
        public bool Metal () {
            Console.WriteLine("Bom,este lixo será depositado na lixeira :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("AMARELA");
            Console.ResetColor();
            return true;
        }
    }
}