using System;

namespace CardApi.Services{
    public class GenerateCardNum{
        
        const int NUM_CARD_MAX = 16;

        public static string GerarNumero(){
        string NumCard = ""; 
        Random rand = new Random();
        for(int i = 0; i < NUM_CARD_MAX; i++){
            NumCard += rand.Next(0,9);
        }
        return NumCard;
        }
    }
}