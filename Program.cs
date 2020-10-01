using System;



namespace bai2
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;


            Console.WriteLine("Please select an option");

            Console.WriteLine("1. tao mang:");
            Console.WriteLine("2. kiem tra mang doi xung:");
            Console.WriteLine("3. sap xep mang:");
            Console.WriteLine("4.tim kiem mang:");
            Console.WriteLine("5.thoat:");
            do
            {
                Console.WriteLine("Option:");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.CreateArray();
                        break;
                    case 2:
                   
                        break;
                    case 3:

                        break;
                    case 4:
                        program.binsearch();
                        break;
                    case 5: return;


                }


            }
            while (choice != 5);





        }

        public void CreateArray()
        {

            int[] array;
            int n;
            Console.WriteLine("1. nhap kich thuoc mang:");
            n = Int32.Parse(Console.ReadLine());
            array = new int[n];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine($"nhap phan tu {i}:");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
        }

        public void IsSysmmetryArray()
        {
       
        }

       public static void bubblesort(int[] array, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
        }


        static int binsearch(int[] dataset, int target, int l, int u)
        {
            insertsort(dataset, dataset.Length);//Chắc chắn danh sách đẵ sắp xếp
            while (u >= l)
            {
                int mid = (l + u) / 2;
                if (target == dataset[mid]) return mid;
                else if (target > dataset[mid])
                    l = mid + 1;
                else if (target = 0 && inserted != 1; )
            {
                    if (pick_item < dataset[j])
                    {
                        dataset[j + 1] = dataset[j];
                        j--;
                        dataset[j + 1] = pick_item;
                    }
                    else
                        inserted = 1;
                }
            }
        }

       
    }
    }
