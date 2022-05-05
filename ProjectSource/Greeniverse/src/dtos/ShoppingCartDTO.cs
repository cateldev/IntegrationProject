﻿using System.ComponentModel.DataAnnotations;
using Greeniverse.src.utils;

namespace Greeniverse.src.dtos
{

    public class NewShoppingCartDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int AmountProduct { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        public string Voucher { get; set; }

        [Required, StringLength(50)]
        public string DeliveryAdress { get; set; }

        public NewShoppingCartDTO(int id, int amountProduct, PaymentMethod paymentMethod, string voucher, string deliveryAdress)
        {
            Id = id;
            AmountProduct = amountProduct;
            PaymentMethod = paymentMethod;
            Voucher = voucher;
            DeliveryAdress = deliveryAdress;
        }
    }
    
    public class UpdateShoppingCartDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int AmountProduct { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        public string Voucher { get; set; }

        [Required, StringLength(50)]
        public string DeliveryAdress { get; set; }

        public UpdateShoppingCartDTO(int id, int amountProduct, PaymentMethod paymentMethod, string voucher, string deliveryAdress)
        {
            Id = id;
            AmountProduct = amountProduct;
            PaymentMethod = paymentMethod;
            Voucher = voucher;
            DeliveryAdress = deliveryAdress;
        }
    }
    
}
