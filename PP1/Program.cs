int fila, columna;
fila = columna = 3;
int[,] matriz = new int[3,3]{ { 200, 30, 3 } , { 33, 54, 51 } , { 32, 32, 2 } };
Console.WriteLine("el maximo elemento de la matriz es: " + maxMatriz(matriz,fila,columna));

int maxMatriz(int [,]matriz,int f,int c)
{
    int i, j;
    int max = 0;
    for (i=0;i<f;i++)
    {
        for (j=0;j<c;j++)
        {
            max = (matriz[i, j] > max) ? matriz[i, j] : max;
        }
    }
    return max;
}