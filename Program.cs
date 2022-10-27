

using ejercbilletera; 

var Billetera1 = new Billetera();
Console.WriteLine("Billetera 1 ");
Console.WriteLine("Ingrese la cantidad de billetes de 10");
int billete10Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe10 = billete10Ingresado;

Console.WriteLine("Ingrese la cantidad de billetes de 20");
int billete20Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe20 = billete20Ingresado;

Console.WriteLine("Ingrese la cantidad de billetes de 50");
int billete50Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe50 = billete50Ingresado;

Console.WriteLine("Ingrese la cantidad de billetes de 100");
int billete100Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe100 = billete100Ingresado;

Console.WriteLine("Ingrese la cantidad de billetes de 200");
int billete200Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe200 = billete200Ingresado;

Console.WriteLine("Ingrese la cantidad de billetes de 500");
int billete500Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe500 = billete500Ingresado;

Console.WriteLine("Ingrese la cantidad de billetes de 1000");
int billete1000Ingresado = int.Parse(Console.ReadLine());
    Billetera1.BilletesDe1000 = billete1000Ingresado;
Console.Clear();
Console.WriteLine($"El total de plata de billetera 1 es { Billetera1.Total()}");
Console.WriteLine();


var Billetera2 = new Billetera();
Console.WriteLine("Billetera 2 ");
Console.WriteLine("Ingrese la cantidad de billetes de 10");
int billete10Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe10 = billete10Ingresado2;

Console.WriteLine("Ingrese la cantidad de billetes de 20");
int billete20Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe20 = billete20Ingresado2;

Console.WriteLine("Ingrese la cantidad de billetes de 50");
int billete50Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe50 = billete50Ingresado2;

Console.WriteLine("Ingrese la cantidad de billetes de 100");
int billete100Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe100 = billete100Ingresado2;

Console.WriteLine("Ingrese la cantidad de billetes de 200");
int billete200Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe200 = billete200Ingresado2;

Console.WriteLine("Ingrese la cantidad de billetes de 500");
int billete500Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe500 = billete500Ingresado2;

Console.WriteLine("Ingrese la cantidad de billetes de 1000");
int billete1000Ingresado2 = int.Parse(Console.ReadLine());
    Billetera2.BilletesDe1000 = billete1000Ingresado2;

Console.WriteLine(Billetera2.Total());

Console.Clear();
Console.WriteLine($"El total de plata de billetera 1 es {Billetera1.Total()}");
Console.WriteLine();
Console.WriteLine($"El total de plata de billetera 2 es {Billetera2.Total()}");
Console.WriteLine();



Billetera Billetera3 = Billetera1.Combinar(Billetera2);

Console.WriteLine($"Combinamos las dos billeteras, el total de la billetera 3 es { Billetera3.Total()}");

Console.WriteLine($"El total de la billetera 1 es {Billetera1.Total()}" );
Console.WriteLine($"El total de la billetera 2 es {Billetera2.Total()}") ;