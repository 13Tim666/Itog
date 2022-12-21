
string [] stringArray = {"12345", "-3", "hello", "MMM", "a1b2", "r6"};

int LengthArray(string [] stringArray){
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++){
        if (stringArray[i].Length <= 3) count++;
    }
    return count;
}

void FillArray(string [] stringNewArray, string [] stringArray){
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++){
        if (stringArray[i].Length <= 3) {
            stringNewArray[j] = stringArray[i];
            j++;
        }
    }
}

void Printarray(string [] array){
        Console.Write("[ ");
    for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]}, ");
    }
        Console.WriteLine("\b\b ]");
}

string [] stringNewArray = new string[LengthArray(stringArray)];
FillArray(stringNewArray, stringArray);
Printarray(stringNewArray);
