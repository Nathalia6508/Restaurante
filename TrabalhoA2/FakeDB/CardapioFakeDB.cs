using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace FakeDB
{
    internal class CardapioFakeDB
    {
        private static List<Cardapio> cardapios;

        public static List<Cardapio> Cardapios
        {
            get
            {
                if (Cardapios == null)
                {
                    cardapios = new List<Cardapio>();
                }
                return cardapios;
            }
        }

        public static void Preencher()
        {
            cardapios.Add(new Cardapio("Filé a Parmeggiana", "Bife com molho e queijo", 37.90, "jpg", 1));
            cardapios.Add(new Cardapio("Peixe Grelhado", "Filé de peixe grelhado", 40.67, "jpg", 2));
            cardapios.Add(new Cardapio("Porção de batata", "Batata frita com molho", 12.20, "jpg", 3));
            cardapios.Add(new Cardapio("Filé a Bechamel", "Bife com molho branco e queijo", 37.50, "jpg", 4));
            cardapios.Add(new Cardapio("Filé a Parmeggiana", "Bife com molho e queijo", 37.90, "jpg", 5));
            cardapios.Add(new Cardapio("Purê de Batata", "Batata amassada com leite", 27.80, "jpg", 6));
            cardapios.Add(new Cardapio("Pasteizinhos", "Entrada de pasteis de frango", 16.30, "jpg", 7));
            cardapios.Add(new Cardapio("Espetinho de camarão", "Espeto com camarão", 15.40, "jpg", 8));
            cardapios.Add(new Cardapio("Espetinho de carne", "Espeto com carne", 10.40, "jpg", 9));
            cardapios.Add(new Cardapio("Espetinho de frango", "Espeto com frango", 10.40, "jpg", 10));
        }
    }
}
