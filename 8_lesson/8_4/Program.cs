/*
не понятно
*/

int[] MinEl(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

int[,] WithoutRowColumn(int[,] arr, int[] m_indexes)
{
    int k = 0;
    int p = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] new_matr = new int[row - 1, column - 1];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (m_indexes[0] != i && m_indexes[1] != j)
            {
                new_matr[k, p] = arr[i, j];
                p += 1;
            }
        }
        p = 0;        
        if (m_indexes[0] != i) k += 1;        
    }
    return new_matr;
}
