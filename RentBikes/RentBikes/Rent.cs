using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentBike.Models
{
    public class Rent
    {
        public TypeRent typeRent { get; set; }
        public double amountTime { get; set; }

        //Se calcula el precio del alquiler por el tiempo solicitado
        public double totalPriceRent
        {
            get
            {
                return amountTime * this.typeRent.price;
            }
        }

        public Rent(TypeRent typeRent, double amountTime)
        {
            this.typeRent = typeRent;
            this.amountTime = amountTime;
        }
    }
}
