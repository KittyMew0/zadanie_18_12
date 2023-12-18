/* Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве. */

Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int count = 0;

void CreateArray() {
    for (int i = 0; i < array.Length; i++) {  
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray() {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write(array[i] +" ");
    }
}

int SearchEven() {
    for (int i = 0; i < array.Length; i++) {  
        if (array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

CreateArray();
PrintArray();
Console.WriteLine("even numbers = " + SearchEven());