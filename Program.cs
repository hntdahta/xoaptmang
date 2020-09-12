using System;
using System.Text;


namespace xoaptmang
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 10, 4, 6, 7, 8 };
            int k;
            NhapK(out k, arr.Length);
            Xoa(arr, k);
            Console.WriteLine("Mảng sau khi xóa: ");
            HienMang(arr, arr.Length - 1);
        }

        static bool Xoa(int[] arr, int k)
        {
            bool found = false;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (found)
                { 
                    arr[i - 1] = arr[i];
                }
                else if (arr[i] == k)
                {
                    int index = i;
                    Console.WriteLine("Vị trí của phần tử x: {0}", index);
                    found = true;
                }
            }
            return found;
        }

        static void NhapK(out int k, int n)
        {
            k = -1;
            while (k < 0 || k >= n)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập phần tử X có trong mảng");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void HienMang(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
