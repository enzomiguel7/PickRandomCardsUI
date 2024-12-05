using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    // Classe CardPicker
     class CardPicker

    {

        static Random random = new Random(); // Cria um objeto random

        public static string[] PickSomeCards(int numberOfCards) // Cria o método PickSomeCards, com um parâmetro de valor inteiro
        {
            string[] pickedCards = new string[numberOfCards];   // Cria um array de strings com o tamanho baseado no número de cartas solicitadas
            
            for (int i = 0; i < numberOfCards; i++) // Loop for para criar as cartas no array e mostrar cada uma no console
            { 
                pickedCards[i] = RandomValue() + " of " + RandomSuit(); // Cria uma carta dentro do array (ex: "5 of Queen")
            }
            return pickedCards; // Retorna o valor do array pickedCards para a chamada do método no Main
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5); // Váriavel com um valor aleatório entre 1 a 4

            if (value == 1) return "Spades"; // Caso o valor aleatório seja 1
            if (value == 2) return "Hearts";// Caso o valor aleatório seja 2
            if (value == 3) return "Clubs";// Caso o valor aleatório seja 3

            return "Diamonds"; //  Caso o valor aleatório seja 4


        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);  // Váriavel com um valor aleatório entre 1 a 13

            if (value == 1)   return "Ace";// Caso o valor aleatório seja 1
            if (value == 11) return "Jack";// Caso o valor aleatório seja 11
            if (value == 12) return "Queen";// Caso o valor aleatório seja 12
            if (value == 13) return "King";// Caso o valor aleatório seja 13

            return value.ToString(); // Caso o valor aleatório nao seja nenhum dos acima
        }
    }
}
