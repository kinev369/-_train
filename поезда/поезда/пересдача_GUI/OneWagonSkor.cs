using System;
using System.Collections.Generic;
using System.Text;

namespace пересдача_GUI
{
  public  class OneWagonSkor : ComonWagon
    {
        private int count;
        private double weight;
        private double onePrice;
        private int srokGod;
        public OneWagonSkor() : base()
        {
        }
        public override double GetPrice()
        {
            return count * onePrice;
        }
        public override double GetWeight()
        {
            return count * weight;
        }
        public OneWagonSkor(int id, string typeProdukt, string sohrProdukt, string name, int date, int count, double weight, double onePrice, int srokGod) : base(id, typeProdukt, sohrProdukt, name, date)
        {
            this.count = count;
            this.weight = weight;
            this.onePrice = onePrice;
            this.srokGod = srokGod;
        }


        public int geCount
        {
            get { return count; }

        }
        public double getWeight
        {
            get { return weight; }

        }
        public double getOnePrice
        {
            get { return onePrice; }

        }
        public override int getSrokGode()
        {
            return   srokGod; 

        }
        public override string Print()
        {

            return " id " + id + "\n" + " name " + name + "\n" + " штучный скоропортящийся " + "\n" + "дата формирования " + date + "\n" + "Вес " + weight + "\n" + "цена" + onePrice + "\n" + "количество" + count + "\n"+"срок годности" + srokGod +"\n";
        }


    }

}

