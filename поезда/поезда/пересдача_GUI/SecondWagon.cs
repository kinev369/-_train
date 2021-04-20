using System;
using System.Collections.Generic;
using System.Text;

namespace пересдача_GUI
{
 public   class SecondWagon : ComonWagon
    {
      private  double allWeight;
      private  double allPrice;


        public SecondWagon() : base()
        {
        }
        public override double GetPrice()
        {
            return allWeight * allPrice;
        }
        public override double GetWeight()
        {
            return allWeight;
        }
        public SecondWagon(int id, string typeProdukt, string sohrProdukt, string name, int date, double allWeight, double allPrice) : base(id, typeProdukt, sohrProdukt, name, date)
        {
            this.allWeight = allWeight;
            this.allPrice = allPrice;

        }
        public double getAllPrice
        {
            get { return allPrice; }

        }
        public double getAllWeight
        {
            get { return allWeight; }

        }
        public override string Print()
        {

            return " id " + id + "\n" + " name " + name + "\n" + " весовой долгохранящийся " + "\n" + "дата формирования " + date + "\n" + "Вес " + allWeight + "\n" + "цена" + allPrice + "\n";
        }

    }
}
