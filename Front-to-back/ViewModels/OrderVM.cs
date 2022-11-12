﻿using Front_to_back.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.ViewModels
{
    public class OrderVM
    {
        [Required]
        [StringLength(maximumLength: 150)]
        public string CompanyName { get; set; }
        [StringLength(maximumLength: 40)]
        public string Region { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string City { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Apartment { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string PostCode { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Phone { get; set; }
        public bool BankTransfer { get; set; }
        public bool CheckPayments { get; set; }
        public bool Paypal { get; set; }
        public bool CashOnDelivery { get; set; }
        



        [StringLength(maximumLength: 25)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Address { get; set; }

        public string Country { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
