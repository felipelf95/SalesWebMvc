using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status  { get; set; }

        // associação 1 para muitos 1 vendedor possui 1 ou mais vendas...
        public Seller Seller { get; set; }


        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
