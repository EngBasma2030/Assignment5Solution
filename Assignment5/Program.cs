namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1-	. Write a program that prints an identity matrix using for loop, in other 
             * words takes a value n from the user and shows the identity table of size n * n.*/
            Console.Write("Enter the size of the identity matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIdentity Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }

            /*2-	Write a program in C# Sharp to find the sum of all elements of the array.*/
            Console.Write("Enter the size of the array: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] array = new int[size1];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size1; i++)
            {
                Console.Write($"Element [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < size1; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"\nThe sum of all elements in the array is: {sum}");

            /*3-	- Write a program in C# Sharp to merge two arrays of the same size sorted 
             * in ascending order.*/
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("\nEnter elements for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element [{i}]: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter elements for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element [{i}]: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int[] mergedArray = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                mergedArray[i] = array1[i];
                mergedArray[i + size] = array2[i];
            }

            Array.Sort(mergedArray);

            Console.WriteLine("\nThe merged array in ascending order:");
            foreach (int element in mergedArray)
            {
                Console.Write(element + " ");
            }

            /*Write a program in C# Sharp to count the frequency of each element of an array.
             */
            Console.Write("Enter the size of the array: ");
            int size4 = int.Parse(Console.ReadLine());

            int[] array4 = new int[size4];
            int[] frequency = new int[size4];
            bool[] visited = new bool[size4];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size4; i++)
            {
                Console.Write($"Element [{i}]: ");
                array4[i] = int.Parse(Console.ReadLine());
                visited[i] = false; 
            }

        
            for (int i = 0; i < size4; i++)
            {
                if (visited[i]) 
                    continue;

                int count = 1;
                for (int j = i + 1; j < size4; j++)
                {
                    if (array4[i] == array4[j])
                    {
                        count++;
                        visited[j] = true; 
                    }
                }
                frequency[i] = count; 
            }

            Console.WriteLine("\nFrequency of each element:");
            for (int i = 0; i < size4; i++)
            {
                if (!visited[i]) 
                {
                    Console.WriteLine($"Element {array4[i]} occurs {frequency[i]} time(s).");
                }
            }

            /*Write a program in C# Sharp to find maximum and minimum element in an array*/
            Console.Write("Enter the size of the array: ");
            int size5 = int.Parse(Console.ReadLine());

            int[] array5 = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size5; i++)
            {
                Console.Write($"Element [{i}]: ");
                array5[i] = int.Parse(Console.ReadLine());
            }

            int max = array5[0];
            int min = array5[0];

            for (int i = 1; i < size5; i++)
            {
                if (array5[i] > max)
                    max = array5[i];

                if (array5[i] < min)
                    min = array5[i];
            }

           
            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");

            /*6-	 Write a program in C# Sharp to find the second largest element in an 
             * array.*/
            Console.Write("Enter the length of the list: ");
            int length = int.Parse(Console.ReadLine());
            if (length < 2)
            {
                Console.WriteLine("The list must have at least 2 elements.");
                return;
            }

            int[] list = new int[length];

            Console.WriteLine("Enter the elements of the list:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Element [{i}]: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            int max2 = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < length; i++)
            {
                if (list[i] > max2)
                {
                    secondMax = max2;
                    max2 = list[i];
                }
                else if (list[i] > secondMax && list[i] != max2)
                {
                    secondMax = list[i];
                }
            }

            if (secondMax == int.MinValue)
            {
                Console.WriteLine("There is no second largest element (all elements are equal).");
            }
            else
            {
                Console.WriteLine($"\nThe second largest element is: {secondMax}");
            }

            /*7-	 Consider an Array of Integer values with size N, having values as    */
            Console.Write("Enter the size of the array: ");
            int size7 = int.Parse(Console.ReadLine());

            int[] array7 = new int[size7];


            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size7; i++)
            {
                Console.Write($"Element [{i}]: ");
                array7[i] = int.Parse(Console.ReadLine());
            }


            Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            int longestDistance = 0;

            for (int i = 0; i < size7; i++)
            {
                if (firstIndex.ContainsKey(array7[i]))
                {

                    int distance = i - firstIndex[array7[i]];
                    if (distance > longestDistance)
                    {
                        longestDistance = distance;
                    }
                }
                else
                {
                    firstIndex[array7[i]] = i;
                }
            }

            Console.WriteLine($"\nThe longest distance between two equal cells is: {longestDistance}");

            /*Write a program to create two multidimensional arrays of same size. Accept 
             * values from the user and store them in first array. Now copy all the elements 
             * of the first array on second array and print second array.*/
            int rows = 3;
            int columns = 3;

            int[,] arrayOne = new int[rows, columns];
            int[,] arrayTwo = new int[rows, columns];

            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter value for position [{i},{j}]: ");
                    arrayOne[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Array.Copy(arrayOne, arrayTwo, arrayOne.Length);

            Console.WriteLine("\nSecond array (after copying from the first array):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arrayTwo[i, j] + "\t");
                }
                Console.WriteLine(); 
            }

            /*11-	Write a Program to Print One Dimensional Array in Reverse Order*/
            int size11 = 5;

            int[] array11 = new int[size11];

            Console.WriteLine("Enter " + size + " elements for the array:");
            for (int i = 0; i < size11; i++)
            {
                Console.Write($"Enter value for element {i + 1}: ");
                array11[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray in reverse order:");
            for (int i = size11 - 1; i >= 0; i--)
            {
                Console.Write(array11[i] + " ");
            }
        }

    }
}
