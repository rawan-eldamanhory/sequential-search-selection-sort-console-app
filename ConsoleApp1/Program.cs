using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array
    {
        private int[] _items;
        private int _size;
        private int _length;

        Array(int arrsize)
        {
            _size = arrsize;
            _length = 0;
            _items = new int[arrsize];
        }

        //fill the array
        public void Fill()
        {
            int no_of_items;
            Console.WriteLine("How many items you want to fill ? ");
            no_of_items = int.Parse(Console.ReadLine());
            if (no_of_items > _size)
            {
                Console.WriteLine("You cannot exceed the array size");
                return;
            }
            else
            {
                for (int i = 0; i < no_of_items; i++)
                {
                    Console.WriteLine("Enter item " + i);
                    _items[i] = int.Parse(Console.ReadLine());
                    _length++;
                }
            }
        }

        //traverse
        public void Display()
        {
            for (int i = 0; i < _length; i++)
                Console.WriteLine(_items[i]);
        }

        //sequential search
        public int SequentialSearch(int searchnumber)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_items[i] == searchnumber)
                {
                    return i;
                }
            }
            return -1;
        }

        //selection sort
        public void SelectionSort()
        {
            int min;

            for (int i = 0; i < _length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < _length; j++)
                {
                    if (_items[j] < _items[min])
                        min = j;
                }

                int temp = _items[min];
                _items[min] = _items[i];
                _items[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            int arraysize;
            Console.WriteLine("Enter the Array size : ");
            arraysize = int.Parse(Console.ReadLine());
            Array arr = new Array(arraysize);
            arr.Fill();
            Console.WriteLine("Array content : ");
            arr.Display();

            int Searchnumber;
            Console.WriteLine("Enter the value of the item that you want to search for : ");
            Searchnumber = int.Parse(Console.ReadLine());
            int INDEX = arr.SequentialSearch(Searchnumber);
            if (INDEX == -1)
                Console.WriteLine("This item not found ! ");
            else
                Console.WriteLine("This Item found at index : " + INDEX);

            Console.WriteLine("Array content before sorting : ");
            arr.Display();
            arr.SelectionSort();
            Console.WriteLine("Array content after selection sorting : ");
            arr.Display();

            Console.ReadKey();
        }
    }
}
