using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal static class Helper
    {
        #region EX01:Swap
        ///wirte static method to do swap betwwen two int numbers
        #region NonGenerics
        //public static void Swap(ref int x , ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref object x, ref object y)
        //{
        //    object temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #region Generics
        public static void Swap<hamada>(ref hamada x, ref hamada y)
        {
            hamada temp = x;
            x = y;
            y = temp;
        }
        #endregion
        #endregion
        #region EX:02 Search
        ///write method take int[] array and int value 
        ///and return the first index of that value 
        ///and if not exists return -1
        #region NonGenerics
        //public static int SearchArray(int[] arr, int value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        //public static int SearchArray(Point[] arr, Point value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            //if (arr[i] == value) //address == address
        //            if (arr[i].X == value.X && arr[i].Y == value.Y)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion
        #region Generics
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    //if (arr[i] == value)
                    if (arr[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #endregion
    }
}
