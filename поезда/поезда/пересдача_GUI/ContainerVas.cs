using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace пересдача_GUI
{
   public class ContainerVas
    {
        public List<Conteyner> cont;

        public ContainerVas()
        {
            
            cont = new List<Conteyner>();
        }
        public void GetPriceAndWeightAll()
        {
            for(int i = 0; i < cont.Count; i++)
            {
                Console.WriteLine( "вес всего "+cont[i].GetAllWeight());
                Console.WriteLine("цена всего "+cont[i].GetAllPrice());

            }
        }
       
        public void fromFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line = "";
            while ((line) != null) 
            {
                Conteyner conteyner = new Conteyner();
                conteyner.LoadFromFile(ref sr,ref line);
                cont.Add(conteyner);
            
            } // считываем пока не конец



        }

    }
}
