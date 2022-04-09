using System;

namespace Massiv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minimumValue = 0;
            int maximumValue = 30;
            int maximumArrayLength = 30;

            int[] array = new int[maximumArrayLength];
            int lastElement = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minimumValue, maximumValue);
            }

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.Write("\n");

            int numberRepeat = 0;
            int numberRepeatCount = 1;
            bool isRepeatTask = false;
            int startingPosition = 1;
            int numberRepeatTemp = 0;
            int numberRepeatCountTemp = startingPosition;


            for (int i = 0; i < array.Length; i++)
            {
                if(i==array.Length-1)
                {
                    if (numberRepeatCountTemp > numberRepeatCount)
                    {
                        numberRepeat = array[i];
                        numberRepeatCount = numberRepeatCountTemp;
                    }
                }
                else if(array[i]==array[i+1])
                {
                    numberRepeatTemp = array[i];
                    numberRepeatCountTemp++;
                    isRepeatTask = true;
                }
                else
                {
                    if (numberRepeatCountTemp > numberRepeatCount)
                    {
                        numberRepeat = array[i];
                        numberRepeatCount = numberRepeatCountTemp;
                    }

                    numberRepeatCountTemp = startingPosition;
                }
            }

            if(isRepeatTask==true)
            {
                Console.Write("Число с наибольшей серией повторений = " + numberRepeat + " повторений в серии - " + numberRepeatCount);
            }
            else
            {
                Console.Write("Повторений в данном масиве нет");
            }
            
            Console.ReadLine();
        }
    }
}
