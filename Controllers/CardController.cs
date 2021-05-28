using System;
using CardApi.Data;
using CardApi.models;
using CardApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace CardApi.Controllers{
    [ApiController]
    [Route("cards")]
    public class CardController : Controller{
        private readonly CardContext _context;

        public CardController(CardContext context){
            _context = context;
        }

        [Route("")]
        [HttpPost]
        public Card Cadastrar([FromForm] string email){
            string numCard = GenerateCardNum.GerarNumero(); 
            Card card = new Card(email, numCard);
            _context.Cards.Add(card);
            _context.SaveChanges();
            return card;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Card> ReturnCardsByEmail([FromForm] string email){
            IEnumerable<Card> listOfCards = _context.
                    Cards.Where(s => s.Email == email);
            return listOfCards;
        }
    }
}