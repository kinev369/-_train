using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace пересдача_GUI
{
  public  class Conteyner
    {
        const double saz = 10;
        const int raz = 8;

        public List<ComonWagon> Wagons;
        int date;
        int dateSort;
        int dateReturn;
        public Conteyner()
        {
            date = 13;
            dateReturn = date + 10;
            dateSort = 0;
            Wagons = new List<ComonWagon>();
        }
        public void Print()
        {
            string line = "";
            for (int i = 0;i< Wagons.Count;i++)
            {
               Console.WriteLine( Wagons[i].Print());
            }
        
        }
        public string Print2()
        {
            string line = "";
            for (int i = 0; i < Wagons.Count; i++)
            {
                line += Wagons[i].Print()+ "\n";
            }
            return line;
        }
        public double GetAllPrice()
        {
            double AllPrice = 0;
            for(int i= 0; i < Wagons.Count; i++)
            {
                if(Wagons[i].getSohrProdukt == "Скоропортящийся")
                AllPrice = AllPrice+ Wagons[i].GetPrice();
            }
            return AllPrice;
        }
        /*public void takeFrost(ref int s2)
        {
            int countPer = -1;
            List<ComonWagon> ls = new List<ComonWagon>();
          
            ls = Wagons;
            for (int i = 0; i < Wagons.Count; i++)
            {
                for (int j = i + 1; j < Wagons.Count; j++)
                {
                    ComonWagon s = new ComonWagon();
                    if (Wagons[i].getComonPrice < Wagons[j].getComonPrice)
                    {
                        s = Wagons[i];
                        Wagons[i] = Wagons[j];
                        Wagons[j] = s;
                    };
                }
            }
            
            for (int i = 0; i < Wagons.Count; i++)
            {
               if(Wagons[i].getId== ls[i].getId)
                {
                    countPer++;
                }
            }
            double s4 = countPer / s;
            s2 = Convert.ToInt32(Math.Ceiling(s4));
            
        }*/
        public string takeFrost()
        {
            Permutations s = new Permutations();
            List<ComonWagon> Wagons2 = new List<ComonWagon>();
            List<ComonWagon> Wagons3 = new List<ComonWagon>();
            string z = "";
            for (int i = 0;i < Wagons.Count; i++)
                if(Wagons[i].getSohrProdukt == "Скоропортящийся")
                    Wagons2.Add(Wagons[i]);
            
            s.RecPermutation(Wagons2, Wagons2.Count,false);
         
            double min = 10000000000000000;
            int ind = 0;
            double[] s2 = new double[s._permutationsList.Count];
            for(int i = 0;i < s._permutationsList.Count; i++)
                s2[i]= findUbt(s._permutationsList[i].Wagons);
            for (int i = 0; i <s2.Length ; i++)
                if (min > s2[i])
                {
                    min = s2[i];
                    i = ind;
                }
            for(int i = 0; i < Wagons2.Count; i++)
                Wagons3.Add(s._permutationsList[ind].Wagons[i]);
            for (int i = Wagons3.Count-1; i < Wagons.Count; i++)
                Wagons3.Add(Wagons[i]);
            for (int i = 0; i < Wagons3.Count; i++)
                z += Wagons3[i].Print() + "\n";
            return z;
            dateSort = Convert.ToInt32(Math.Floor(Wagons2.Count / saz));
            Wagons = Wagons2;
            
            /*int countPer = -1;
            List<ComonWagon> ls = new List<ComonWagon>();
            ls = Wagons;
            for (int i = 0; i < Wagons.Count; i++)
            {
                for (int j = i + 1; j < Wagons.Count; j++)
                {
                    ComonWagon s = new ComonWagon();
                    if (Wagons[i].getComonPrice < Wagons[j].getComonPrice)
                    {
                        s = Wagons[i];
                        Wagons[i] = Wagons[j];
                        Wagons[j] = s;
                    };
                }
            }
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].getId == ls[i].getId)
                {
                    countPer++;
                }
            }
            string ls2 = "";
            for (int i = 0; i < Wagons.Count; i++)
            {
                ls2 = ls2 + " вагон " + i + " id вагона" + Wagons[i].getId + "\n";
            }
            return ls2;
                */
            return "";
        }
        public double findUbt(List<ComonWagon> Wagons)
        {
            int countSort = 0;
            double UbtOt = 0;
            double UbtPri = 0;
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].getSohrProdukt == "Скоропортящийся")
                {
                    if (Wagons[i].getSrokGode() < dateReturn)
                        UbtOt += Wagons[i].GetPrice() * 1.26;//UbtOt = UbtOt + Wagons[i].getComonPrice;
                    if (Wagons[i].getSrokGode() - 35 < dateReturn + dateSort + (decimal.Floor(countSort / raz)))
                        UbtPri += UbtPri + Wagons[i].GetPrice() * 0.64;
                }

                countSort++;
            }
            countSort = 0;
            return UbtPri+UbtOt;
        }
        
        public string findUbt()
        {
            int countSort = 0;
            double UbtOt = 0;
            double UbtPri = 0;
           for(int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].getSohrProdukt == "Скоропортящийся")
                {
                    if (Wagons[i].getSrokGode() < dateReturn)
                        UbtOt += Wagons[i].GetPrice() * 1.26;//UbtOt = UbtOt + Wagons[i].getComonPrice;
                   else  if (Wagons[i].getSrokGode() - 35 < dateReturn + dateSort + (decimal.Floor(countSort / raz)))
                        UbtPri += UbtPri + Wagons[i].GetPrice() * 0.64;
                }

                countSort++;
            }
            countSort = 0;
            return "убытки отправителя:" + UbtOt + " " + "\n"+"убытки приемщика "+ UbtPri;
        }
        public double GetAllWeight()
        {
            double AllWeight= 0;
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].getSohrProdukt == "Скоропортящийся")
                    AllWeight = AllWeight + Wagons[i].GetWeight();
            }
            return AllWeight;
        } 
        public void LoadFromFile(ref StreamReader sr, ref string line)
        {
            int id, data, count, srokGod;
            double weight, price;
            string name = "";
            while ((line = sr.ReadLine()) != "-------------------------" && line != null) // считываем пока не конец
            {
                string[] arr = line.Split(' ');      // разбиваем на массив 
               
                    if (arr[0] == "DolgH")
                    {
                    id = Convert.ToInt32((arr[1]));
                    name = arr[2];
                    data = Convert.ToInt32((arr[3]));
                    weight = Convert.ToDouble(arr[4]);
                    count = Convert.ToInt32((arr[5]));
                    price = Convert.ToDouble(arr[6]);
                    OneWagon oneWagon = new OneWagon(id, "Штучный", "Долгохронящийся", name, data, count, weight, price);
                    Wagons.Add(oneWagon);
                }

                if (arr[0] == "SkorH")
                    {
                    id = Convert.ToInt32((arr[1]));
                    name = arr[2];
                    data = Convert.ToInt32((arr[3]));
                    weight = Convert.ToDouble(arr[4]);
                    count = Convert.ToInt32((arr[5]));
                    price = Convert.ToDouble(arr[6]);
                    srokGod = Convert.ToInt32((arr[7]));

                    OneWagonSkor oneWagon = new OneWagonSkor(id, "Штучный", "Скоропортящийся", name, data, count, weight, price, srokGod);
                    Wagons.Add(oneWagon);
                    }

                    if (arr[0] == "DolgV")
                    {
                    id = Convert.ToInt32((arr[1]));
                    name = arr[2];
                    data = Convert.ToInt32((arr[3]));
                    weight = Convert.ToDouble(arr[4]);
                    price = Convert.ToDouble(arr[5]);

                    SecondWagon oneWagon = new SecondWagon(id, "Весовой", "Долгохронящийся", name, data, weight, price);
                    Wagons.Add(oneWagon);
                    }

                    if (arr[0] == "SkorV")
                    {
                    
                        id = Convert.ToInt32((arr[1]));
                        name = arr[2];
                        data = Convert.ToInt32((arr[3]));
                        weight = Convert.ToDouble(arr[4]);
                        price = Convert.ToDouble(arr[5]);
                        srokGod = Convert.ToInt32((arr[6]));

                    SecondWagonSkor oneWagon = new SecondWagonSkor(id, "Весовой", "Скоропортящийся", name, data, weight, price, srokGod);
                    Wagons.Add(oneWagon);
                    }

            }   
        }
    }
}
