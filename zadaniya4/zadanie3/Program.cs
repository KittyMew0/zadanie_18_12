/*Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент 
станет последним, второй – предпоследним и т.д.) */

Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void CreateArray() {
    for (int i = 0; i < array.Length; i++) {  
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray() {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write(array[i] +" ");
    }
}

void Changing() {
    int temp;
    for (int i = 0; i < (array.Length / 2); i++) {  
        temp = array[i];
        array[i] = array[num - 1 - i];
        array[num - 1 - i] = temp;
    }
}

CreateArray();
Console.WriteLine("Array:");
PrintArray();
Changing();
Console.WriteLine();
Console.WriteLine("New array:");
PrintArray();