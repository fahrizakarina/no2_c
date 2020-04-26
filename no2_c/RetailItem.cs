using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no2_c
{
    class RetailItem
    {
        private String description;
        private int unitsOnHand;
        private Double price;

        public void setDescription(String userDescription) 
        {
            description = userDescription;
        }
        public void setUnitsOnHand(int userUnitsOnHand)
        {
            unitsOnHand = userUnitsOnHand;
        }
        public void setPice(Double userPrice)
        {
            price = userPrice;
        }

        public String getDescription()
        {
            return description;
        }
        public int getUnitsOnHand()
        {
            return unitsOnHand;
        }
        public Double getPrice()
        {
            return price;
        }

        public RetailItem(String descriptionGiven, int unitsOnHanGiven, Double priceGiven) 
        {
            description = descriptionGiven;
            unitsOnHand = unitsOnHanGiven;
            price = priceGiven;
        }
    }
}
