Console.Write($"Enter the number M(number of numbers): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
    for (int i = 0; i < m; i++){
        Console.Write($"Enter {i + 1} number: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] massiveNumbers){
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++){
        if (massiveNumbers[i] > 0 ) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Entered numbers greater than 0: {Comparison(massiveNumbers)} ");
