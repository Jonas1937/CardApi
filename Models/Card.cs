namespace CardApi.models{
    public class Card{
        public int Id { get; set; }
        public string Email { get; set; }
        public string CardNum { get; set; }
        public Card() {  }
        public Card(string email, string cardNum){   
            this.Email = email; 
            this.CardNum = cardNum;
        }
    }
}