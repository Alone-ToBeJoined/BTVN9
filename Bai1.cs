using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9
{
    internal class Bai1
    {
        public static void b1 ()
        {
            List<int> maxValueArr = new List<int> ();
            List<int> minValueArr = new List<int> ();
            List<int> avgArr = new List<int>();
            Random random = new Random();
            int[] array = new int[2000];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next(1, 501); //gán giá trị ngẫu nhiên từ 1 đến 500 cho 2000 phần tử 
            }

            //tìm giá trị lớn nhất nhỏ nhất
            int maxValue = array[0];
            int minValue = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++) 
            {
                sum += array[i];
            }
            int avg = sum / 2000;

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == maxValue)
                {
                    maxValueArr.Add(i);
                }
                if (array[i] == minValue)
                {
                    minValueArr.Add(i);
                }
                if (array[i] == avg)
                {
                    avgArr.Add(i);
                }
            }

            //in cac gia tri ra man hinh
            Console.WriteLine("Gia tri lon nhat la : \n");
            foreach (int i in maxValueArr) 
            {
                
                Console.WriteLine(i + ", \n");
            }
            Console.WriteLine("Gia tri nho nhat la : \n");
            foreach (int i in minValueArr)
            {
                
                Console.WriteLine(i + ", \n");

            }
            Console.WriteLine("Gia tri trung binh la : \n");
            foreach (int i in avgArr)
            {
                Console.WriteLine(i + ", \n");
            }
        }
    }
}
