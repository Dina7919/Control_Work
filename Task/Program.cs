void WriteArray(string[] array, int length){
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void ShowArray(string[] array, int length) {
    Console.Write("[ ");
    for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");   
Console.WriteLine();
}

void ShowNewArray(string[] array, int length) {
    Console.Write("[ "); 
    for (int i = 0; i < length; i++)
        {
            if (array[i].Length < 3)
            {
                Console.Write(array[i] + " ");
            }
        }   
        Console.Write("]"); 
Console.WriteLine();
}

Console.WriteLine("Input length: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
Console.WriteLine("Input elements of array:");
WriteArray(array, length);
Console.WriteLine("Array:");
ShowArray(array, length);
Console.WriteLine("New Array: ");
ShowNewArray(array, length);