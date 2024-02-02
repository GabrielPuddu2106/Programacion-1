static void Main(string[] args)
{
    Console.Title = "Ejemplol de una matriz 3x4";

    int[,] Matrix;
    Matrix = new int[3, 4];
    //Cargar y visualizar una matriz
    for (int filas = 0; filas < 3; filas++)
    {// for externo para filas
        for (int columnas = 0; columnas < 4; columnas++)
        {// for interno para columnas
            Console.Write("Ingrese el valor de la posición [" + filas + +columnas + "]: ");
            Matrix[filas, columnas] = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.Write("Ahora visualizamos la matrix digitada....");
            Imprimir(Matrix);
            Console.ReadKey();

            static void Imprimir(int[,] Matrix)
            {
                for (int filas = 0; filas < 3; filas++)
                {
                    Console.Write("\n");
                    for (int columnas = 0; columnas < 4; columnas++)
                    {
                        Console.Write("\t" + Matrix[filas, columnas] + "\t");
                    }
                }
            }
        }
    }
}