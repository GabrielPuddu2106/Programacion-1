{
    Console.Title = " La Fecha de una persona";

    Int32 Ndia;
    Int32 Nmes;
    Int32 Dda = 0;

    Console.WriteLine("Ingrese el numero de dia");
    Ndia = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el numero de mes");
    Nmes = Int32.Parse(Console.ReadLine());

    switch (Nmes)
    {
        case 1:
            Dda = Ndia;
            break;

        case 2:
            Dda = Ndia +31;
            break;

        case 3:
            Dda = Ndia + 59;

            break;

        case 4:
            Dda = Ndia + 90;
            break;

        case 5:
            Dda = Ndia + 120;
            break;

        case 6:
            Dda = Ndia + 151;
            break;

        case 7:
            Dda = Ndia + 181;

            break;

        case 8:
            Dda = Ndia + 212;
            break;

        case 9:
            Dda = Ndia + 243;
            break;

        case 10:
            Dda = Ndia + 273;
            break;

        case 11:
            Dda = Ndia + 304;
            break;

        case 12:
            Dda = Ndia + 334;
            break;

        default: Console.WriteLine("Datos incorrectos");

            
            return;
    
    }

    Console.WriteLine("El dia " + Ndia + "Corresponde al numero de dia " + Dda);
}
