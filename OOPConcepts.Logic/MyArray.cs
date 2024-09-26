using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
   public class MyArray
    {
        private int _top;
        private int[] _array;

        public MyArray(int n)
        {
            N = n;
            _array = new int[N];
            _top = 0;
        }

        public int N { get; }
        /// <summary>
        /// Indicates if the array is full
        /// </summary>
        public bool IsFull => _top == N;

        /// <summary>
        /// Indicates if the array is empty
        /// </summary>
        public bool IsEmpty => _top == 0;

        public void Add(int number)
        {
           
            if(IsFull)
            {
                throw new Exception("The array is full.");
            }
            _array[_top] = number;
            _top++;
        }
        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Array is empty";
            }
            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
                count++;
                if(count > 9)
                {
                    count = 0;
                    output += "\n";
                }
            }
            return output;
        }

        public void Fill (int minimuim, int maximuim)
        {
            var random= new Random();
            for (int i = 0; i <N; i++)
            {
                _array[i] = random.Next(minimuim, maximuim);
            }
            _top = N;
        }
        public void Sort()
        {
            Sort(true);
        }
        private void Sort(bool descending)
        {
            for (int i = 0;i < _top-1;i++)
            {
                for (int j = i+1; j < _top; j++)
                {
                    if(descending)
                    {
                        if (_array[i] < _array[j])
                        {
                            Change(ref _array[i],ref _array[j]);
                        }
                    }
                    else
                    {
                        if(_array[i] > _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                }
            }
        }

        private void Change(ref int a ,ref int b)
        {
            //a=10 ,b=5
            
            a = a + b; //a=15
            b = a - b; //b=10
            a = a - b; //a=5
        }
    }
}
