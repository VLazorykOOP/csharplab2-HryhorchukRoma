using System;

class Program
{
    public static void Main(string[] args)
    {
        task4();
    }
    static void task1()
    {
        Console.WriteLine("Ente dimensions of array:");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ente k:");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0 && arr[i] % k != 0)
                {
                    arr[i] *= -1;
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine("Element: " + i);
            }
        }
        else if (n == 2)
        {
            Console.WriteLine("Enter size1 of array:");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size2 of array:");
            int size2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ente k:");
            int k = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[size1, size2];
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.WriteLine("Enter element:");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (arr[i, j] < 0 && arr[i, j] % k != 0)
                    {
                        arr[i, j] *= -1;
                    }
                }
            }
            for (int i = 0; i < size1; i++)
            {

                for (int j = 0; j < size2; j++)
                {
                    Console.WriteLine("Element " + "[ " + i + " , " + j + " ]: " + arr[i, j]);
                }
            }
        }
    }
    static int min(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    static int max(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    static void task2()
    {
        Console.WriteLine("Enter size of array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int minimum = min(arr);
        int maximum = max(arr);
        for (int i = 0; i < size; i++)
        {
            if (arr[i] == minimum)
            {
                Console.WriteLine("-");
                arr[i] = maximum;
            }
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Element " + "[ " + i + " ]: " + arr[i]);
        }
    }
    static void task3()
    {
        Console.WriteLine("Enter size of array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine("Enter element:");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int acc = 0;
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i+1; j<size; j++)
        {
            if (arr[i, j] != 0)
            {
                acc++;
              Console.WriteLine(arr[i , j]);
                sum += arr[i, j];
            }
        }
    }
    float rez = (float)Math.Round((sum / (float)acc), 3);
    Console.WriteLine("Result: " + rez);
  }
  static void task4(){
    Console.WriteLine("Enter size1 of array:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter size2 of array:");
    int size2 = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[size1, size2];
    int[] rezarr=new int[size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            Console.WriteLine("Enter element:");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
for(int i=0; i<size2; i++){
      int acc = 0;
      for(int j=0; j<size1; j++){
        if(arr[j,i]<0){
          acc += arr[j,i];
        }
      }
      rezarr[i] = acc;
}
for(int i=0; i<size2; i++){
  Console.WriteLine("Element " + "[ " + i + " ]: " + rezarr[i]);
}
}
  }
