void WriteArray(string[] array, int length){
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void ShowArray(string[] array, int length) {
    for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }   
Console.WriteLine();
}

void ShowNewArray(string[] array, int length) {
    int newLength = new Random().Next(0,3);
    string[] newArray = new string[newLength];
    for (int i = 0; i < newLength; i++)
        {
            newArray[i] = array[new Random().Next(0,length)];
            Console.Write(newArray[i] + " ");
        }   
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