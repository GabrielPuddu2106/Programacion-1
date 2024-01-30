{
    Console.Title = "Sexo del individuo";

    Int32 edad;

    String name, sexo;

    Console.WriteLine("Ingrese su name");
    name = Console.ReadLine();  

    Console.WriteLine("Ingrese la edad");
    edad = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su sexo (Hombre=M y Mujer=F)");
    sexo = Console.ReadLine();  

    if(sexo == "M"|| sexo == "m") // logica
    {
        Console.WriteLine("\nEl Sr {0} ha sido registrado", name); // v
    }
    else
    {
        Console.WriteLine("nLa Sra {0} ha sido registrada", name); // f
    }

    Console.WriteLine("\n\n");
    Console.WriteLine("\n---->Fin del programa");
    Console.ReadKey();
}