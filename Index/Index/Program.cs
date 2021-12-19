using System;

namespace Index
{

    class SampleCollection<T>
    {
        // Объявление массива для хранения элементов данных
        private T[] arr = new T[100];

        // Определение индексатора,
        // чтобы клиентский код мог использовать нотацию []
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            Console.WriteLine(stringCollection[0]);
        }
    }
}
