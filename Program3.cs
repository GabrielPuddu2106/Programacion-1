{
    Console.Title = " Cambio Dolar $ ";

    Int32 dolar;

    Double cambioeuro;

    Console.WriteLine("Ingrese la cantidad de dolares que desea cambiar");
    dolar = Int32.Parse(Console.ReadLine());

    cambioeuro = (dolar * 1.33250);

    // Conversion 

    Console.WriteLine("Su cambio de moneda a euro es :" + cambioeuro);
}