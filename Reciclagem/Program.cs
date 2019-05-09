using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;
using Reciclagem.Utils;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int respostaLixo = 0;
            Console.WriteLine("Bem-vindo a C.A enterprises,a melhor empresa de reciclagem do Brasil");   
            System.Console.WriteLine("Selecione qual lixo depositar:");
            MenuUtils.MenuPrincipal();
            respostaLixo = int.Parse(Console.ReadLine());
            switch (respostaLixo)
            {
                case 1:
                CaixaDeLeite caixaDeLeite = new CaixaDeLeite();
                caixaDeLeite.GetType().GetInterface("IPapel");
                caixaDeLeite.Papel();

                break;
                case 2:
                Latinha latinha = new Latinha();
                latinha.GetType().GetInterface("IMetal");
                latinha.Metal();
                break;
                case 3:
                GarrafaDeCachaça garrafaDeCachaça = new GarrafaDeCachaça();
                garrafaDeCachaça.GetType().GetInterface("IVidro");
                garrafaDeCachaça.Vidro();
                break;
                case 4:
                EmbalagaemSalgadinho embalagaemSalgadinho = new EmbalagaemSalgadinho();
                embalagaemSalgadinho.GetType().GetInterface("IPlastico");
                embalagaemSalgadinho.Plastico();
                break;
                case 5:
                GuardaChuva guardaChuva = new GuardaChuva();
                guardaChuva.GetType().GetInterface("IIndefinido");
                guardaChuva.Indefinido();
                break;
                case 6:
                Maçã maçã = new Maçã();
                maçã.GetType().GetInterface("IOrganico");
                maçã.Organico();
                break;
                case 0:
                System.Console.WriteLine("Saindo...");
                break;
                default:
                System.Console.WriteLine("Opção inválida,por favor inicie o programa novamente!");
                break;
            }
            
        }

        private static void CaixaDeLeite(IPapel Papel)
        {
           Papel.GetType().GetInterface("IPapel");
        }
    }
}
