using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_Frameworks
{
    public static class StringActions
    {
        public static int CountUnequalSymbols(string line)
        {
            char[] array = new char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = line[i];
            }
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var list = new List<char>();

                for (int j = i; j < array.Length; j++)
                {
                    if (IsListNotContainElement(list, array[j]))
                    {
                        list.Add(array[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (count < list.Count)
                {
                    count = list.Count;
                }
            }
            if (count == 1) return 0;
            return count;
        }

        public static int CountEqualLatinLetters(string line)
        {
            char[] array = new char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = line[i];
            }
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var list = new List<char>();

                for (int j = i; j < array.Length; j++)
                {
                    if (IsListContainLatinLetter(list, array[j]))
                    {
                        list.Add(array[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (count < list.Count)
                {
                    count = list.Count;
                }
            }
            if (count == 1) return 0;
            return count;
        }

        public static int CountEqualFigures(string line)
        {
            char[] array = new char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = line[i];
            }
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var list = new List<char>();

                for (int j = i; j < array.Length; j++)
                {
                    if (IsListContainNumber(list, array[j]))
                    {
                        list.Add(array[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (count < list.Count)
                {
                    count = list.Count;
                }
            }
            if (count == 1) return 0;
            return count;
        }

        private static bool IsListNotContainElement(List<char> list, char element)
        {
            foreach (char item in list)
            {
                if (item == element) return false;
            }
            return true;
        }

        private static bool IsListContainLatinLetter(List<char> list, char element)
        {
            foreach (char item in list)
            {
                if (item != element || !((element >= 'A' && element <= 'Z') || (element >= 'a' && element <= 'z'))) return false;
            }
            return true;
        }

        private static bool IsListContainNumber(List<char> list, char element)
        {
            foreach (char item in list)
            {
                if (item != element || !char.IsNumber(element)) return false;
            }
            return true;
        }
    }
}

