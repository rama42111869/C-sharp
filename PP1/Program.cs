int fila, columna;
fila = columna = 3;
int[,] matriz = new int[3,3]{ { 200, 30, 3 } , { 33, 54, 51 } , { 32, 32, 2 } };
Console.WriteLine("el maximo elemento de la matriz es: " + maxMatriz(matriz,fila,columna));
Console.WriteLine("el minimo elemento de la matriz es: " + minMatriz(matriz, fila, columna));
Console.WriteLine("el promedio de la matriz es: " + promedioMatriz(matriz, fila, columna));

int maxMatriz(int [,]matriz,int f,int c)
{
    int i, j;
    int max = 0;
    for (i = 0; i < f; i++)
    {
        for (j = 0; j < c; j++)
        {
            max = (matriz[i, j] > max) ? matriz[i, j] : max;
        }
    }
    return max;
}

int minMatriz(int[,] matriz, int f, int c)
{
    int i, j;
    int min = 9999;
    for (i = 0; i < f; i++)
    {
        for (j = 0; j < c; j++)
        {
            min = (matriz[i, j] < min) ? matriz[i, j] : min;
        }
    }
    return min;
}

double promedioMatriz(int[,] matriz, int f, int c)
{
    int i, j, acum;
    acum = 0;
    for (i = 0; i < f; i++)
    {
        for (j = 0; j < c; j++)
        {
            acum += matriz[i, j];  
        }
    }
    return (double)acum / (f*c);
}