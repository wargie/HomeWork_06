//Задача 46.Написать программу масштабирования фигуры

int ScalingFactor = 2;                                                          
int[] pointA = { 1, 1 };
int[] pointB = { 2, 3 };
int[] pointC = { 5, 3 };
char[] pointName = { 'A', 'B', 'C' };

//Console.WriteLine($"Задан коэффициант масшатирования, равный {ScalingFactor}");

int[,] GotNewCoords(int[] a, int[] b, int[] c, int ScalingFactor)

    {
        int[,] coor = new int[3, 2];                                   
        for (int ii = 0; ii < 2; ii++)                                  
            {
                for (int j = 0; j < 2; j++)                                 
                    {
                        if (ii == j)                                            
                            {
                                coor[0, j] = a[ii];                                 
                                coor[1, j] = (b[ii] - a[ii]) * ScalingFactor + a[ii];
                                coor[2, j] = (c[ii] - a[ii]) * ScalingFactor + a[ii];
                            }
                    }
            }
            return coor;
    }

void PrintCords(int[,] arr, char[] point)

    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{point[i]} ");
                for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j == 0) Console.Write($"({arr[i, j]}, ");
                        else Console.WriteLine($"{arr[i, j]})");
                    }
            }
    }

Console.WriteLine();
int[,] newCords = GotNewCoords(pointA, pointB, pointC, ScalingFactor);
PrintCords(newCords, pointName);