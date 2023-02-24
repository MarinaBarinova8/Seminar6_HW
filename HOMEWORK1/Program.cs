// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь


int [] CreateNewArray (int number)
{
    int [] array = new int [number];
    Console.WriteLine("Input your number: ");
    for(int i = 0; i <array.Length; i++)
    {
        int num_user = Convert.ToInt32(Console.ReadLine());
        array[i] = num_user;
    }
    
    return array;
}

int  Nums (int  [] array)
{
    
    int count = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array [i] > 0)
        {
            count++;
        }
    
    }
    return count;
    
}
void ShowArray ( int [] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}


int [] newArray = CreateNewArray(10);

ShowArray(newArray);

Console.WriteLine($"There are {Nums(newArray)} numbers greater than zero");

