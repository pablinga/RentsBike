using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBike.Models
{
    public class Client
    {
        public int dni { get; set; }
        public string name { get; set; }
        public List<Rent> rents { get; set; }

        public Client(int dni, string name){
            this.dni = dni;
            this.name = name;
            rents = new List<Rent>();
        }

        public double TotalPrice()
        {
            double TotalPrice = 0;
            foreach (Rent r in rents)
            {
                TotalPrice += TotalPrice + r.totalPriceRent;
            }
            if (rents.Count >= 3 && rents.Count <= 5) {
                return TotalPrice * 0.7;
            }
            return TotalPrice;
        }

        public void ReturnsBike()
        {
            rents = new List<Rent>();
        }

        
    }
}