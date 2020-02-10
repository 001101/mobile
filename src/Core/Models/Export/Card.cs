﻿using Bit.Core.Models.View;

namespace Bit.Core.Models.Export
{
    public class Card
    {
        public Card() { }

        public Card(CardView obj)
        {
            if(obj == null)
            {
                return;
            }

            CardholderName = obj.CardholderName;
            Brand = obj.Brand;
            Number = obj.Number;
            ExpMonth = obj.ExpMonth;
            ExpYear = obj.ExpYear;
            Code = obj.Code;
        }

        public string CardholderName { get; set; }
        public string Brand { get; set; }
        public string Number { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Code { get; set; }

        public static CardView ToView(Card req, CardView view = null)
        {
            if(view == null)
            {
                view = new CardView();
            }

            view.CardholderName = req.CardholderName;
            view.Brand = req.Brand;
            view.Number = req.Number;
            view.ExpMonth = req.ExpMonth;
            view.ExpYear = req.ExpYear;
            view.Code = req.Code;
            return view;
        }
    }
}
