using System.Collections.Generic;

namespace CodeWars
{
    public static class Unit1
    {
        public static int DescendingOrder(int num)
        {
            List<int> numbers = DevideDigits(num);
            List<int> orderNumbers = DescendingOrderByList(numbers);

            int descendingNum = ListToNumbers(orderNumbers);

            return descendingNum;
        }

        private static List<int> DevideDigits(int num)
        {
            int digits = 10;
            List<int> numbers = new();

            while (num >= digits)
            {
                numbers.Add(num % digits);
                num /= 10;
            }

            numbers.Add(num % digits);

            return numbers;
        }

        private static List<int> DescendingOrderByList(List<int> list)
        {
            list.Sort((a, b) => b.CompareTo(a));
            return list;
        }

        private static int ListToNumbers(List<int> list)
        {
            int digits = 1;
            int num = 0;

            list.Reverse();

            foreach (int n in list)
            {
                num += n * digits;
                digits *= 10;
            }

            return num;
        }
    }
}