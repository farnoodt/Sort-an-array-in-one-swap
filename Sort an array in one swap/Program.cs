// See https://aka.ms/new-console-template for more information
int[] arr = new int[] { 3, 8, 6, 7, 5, 9 };
sortArray(arr);
Console.WriteLine("Hello, World!");

void sortArray(int[] arr)
{
    int Sw1 = -1;
    int Sw2 = -1;
    for (int i = 0; i < arr.Length-1; i++)
    {
        if(arr[i] > arr[i + 1])
        {
            if (Sw1 == -1)
            {
                Sw1 = i;
                i++;
            }
            else
                Sw2 = i + 1;
            
        }

       
        if (Sw1 != -1 && Sw2 != -1)
        { 
            Swap(arr, Sw1, Sw2);
            Console.WriteLine(String.Join(",", arr));
            return;
        }
    }

    void Swap(int[] arr,int Sw1,int Sw2)
    {
        int tmp = arr[Sw1];
        arr[Sw1] = arr[Sw2];
        arr[Sw2] = tmp;
    }
}