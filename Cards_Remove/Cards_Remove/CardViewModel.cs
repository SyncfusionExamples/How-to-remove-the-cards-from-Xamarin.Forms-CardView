using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cards_Remove
{
    public class CardViewModel
    {
        public ObservableCollection<CardModel> Items { get; set; }
        public CardViewModel()
        {
            Items = new ObservableCollection<CardModel>()
            {
                new CardModel(){ Title = "FaceBook" , Image = "FacebookFill.png"},
                new CardModel(){ Title = "Gmail" , Image = "GmailFill.png"},
                new CardModel(){ Title = "Instagram" , Image = "InstagramFill.png"},
                new CardModel(){ Title = "Whatsapp" , Image = "WhatsappFill.png"},
            };
        }
    }
}
