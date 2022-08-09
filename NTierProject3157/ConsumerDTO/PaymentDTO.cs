using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierProject3157.ConsumerDTO
{
    public class PaymentDTO
    {

        //Sanal Pos Entegrasyonu

        //Normalde bu tarz siniflar calisacagimiz bankadan aldigimiz dokumantasyon klavuzlugu ile hazirlanir.

        public int ID { get; set; }
        public string CardUserName { get; set; }
        public string SecurityNumber { get; set; }

        public string CardNumber { get; set; }

        public int CardExpiryMonth { get; set; }
        public int CardExpiryYear { get; set; }
        public decimal ShoppingPrice { get; set; }




    }
}