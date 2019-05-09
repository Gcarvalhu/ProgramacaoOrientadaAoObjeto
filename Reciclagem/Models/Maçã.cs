using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models {
    public class Maçã: IOrganico {
        public bool Organico () {
            Console.WriteLine ("Bom,este lixo será depositado na lixeira :");
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine ("PRETA");
            Console.ResetColor ();
            return true;
        }
    }
}