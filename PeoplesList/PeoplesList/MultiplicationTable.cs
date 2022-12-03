using System;

namespace PeoplesList
{
    public class MultiplicationTable
    {
        private int _tableNumber;

        public MultiplicationTable(int tableNumber)
        {
            _tableNumber = tableNumber;
        }

        public void showTable()
        {
            Console.WriteLine($"Table of {2}");
            Console.WriteLine($"");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {_tableNumber} = {i * _tableNumber}");
            }
            Console.WriteLine($"");
        }
    }
}