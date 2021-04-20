using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пересдача_GUI
{
    public class Permutations
    {
        //Список перестановок
        public List<Conteyner> _permutationsList;
        private String _str;

        /// <summary>
        /// Добавляет новую перестановку в список
        /// </summary>
        /// <param name="a">Массив символов
        /// <param name="repeat">Содержать повторы
        /// 
        public  Permutations()
        {
            _permutationsList = new List<Conteyner>();

        }
        private void AddToList(List<ComonWagon> a, bool repeat = true)
        {
            Conteyner buffer = new Conteyner();
            for (int i = 0; i < a.Count; i++)
            {
                buffer.Wagons.Add(a[i]);
            }
            if (repeat || !_permutationsList.Contains(buffer))
            {
                _permutationsList.Add(buffer);
            }

        }
      
        /// <summary>
        /// Рекурсивный поиск всех перестановок
        /// </summary>
        /// <param name="a">
        /// <param name="n">
        /// <param name="repeat">Содержать повторы
        public void RecPermutation(List<ComonWagon> a, int n, bool repeat = true)
        {
            if (n == 1 && repeat == false)
            {
                AddToList(a, repeat);
            }
            for (var i = 0; i < n; i++)
            {
                repeat = true;
                var temp = a[n - 1];
                for (var j = n - 1; j > 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[0] = temp;
                if (i < n - 1) AddToList(a, repeat);
                if (n > 0) RecPermutation(a, n - 1, repeat);
            }
            Console.WriteLine("");
        }

        /*
        public Permutations()
        {
            _str = "";
        }

        public Permutations(String str)
        {
            _str = str;
        }
        /// <summary>
        /// Строка, на основе которой строятся перестановки
        /// </summary>
        public String PermutationStr
        {
            get
            {
                return _str;
            }
            set
            {
                _str = value;
            }
        }*/
        /// <summary>
        /// Получает список всех перестановок
        /// </summary>
        /// <param name="repeat">Содержать повторения
        /// <returns></returns>
        /// <summary>
        /// Получает отсортированный список всех перестановок
        /// </summary>
        /// <param name="repeat">Содержать повторения
        /// <returns></returns>

    }
}