




Console.WriteLine("*-*-*-*-*Start");

int number = 2012;

int newNumber = Sorting.getNumber(number);

int newNumberByBubble = Sorting.getNumberByBubbleSort(number);

Console.WriteLine("newNumber : " + newNumber);
Console.WriteLine("newNumberByBubble : " + newNumberByBubble);
Console.WriteLine("*-*-*-*-*Ready");

public class Sorting
{
    //Получить массив из числа
    private static int[] getArrFromNumber(int number)
    {
        string number_as_string = number.ToString();

        int[] arrInt = new int[number_as_string.ToString().Length];

        for (int n = 0; n < number_as_string.Length; ++n)
        {
            arrInt[n] = int.Parse(number_as_string[n] + "");
        }

        return arrInt;
    }

    public static int getNumber(int number)
    {

        int[] arrInt = getArrFromNumber(number);
        
        Array.Sort(arrInt);
        
        return int.Parse(String.Join("", arrInt));
    }

    public static int getNumberByBubbleSort(int number)
    {
        int[] arrInt = getArrFromNumber(number);

        //Сортировка пузырьком
        int temp = 0;
        for (int i = 0; i < arrInt.Length; i++)
        {
            for (int j = 0; j < arrInt.Length - 1; j++)
            {
                if (arrInt[j] > arrInt[j + 1])
                {
                    temp = arrInt[j + 1];
                    arrInt[j + 1] = arrInt[j];
                    arrInt[j] = temp;
                }
            }
        }

        return int.Parse(String.Join("", arrInt));
    }
}
