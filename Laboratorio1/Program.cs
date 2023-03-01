using Laboratorio1.Entidades;
using Laboratorio1.Negocios;

Persona per = new Persona();
ClsPersona clsPersona = new ClsPersona();

Console.Write(@"Bienvenido 
Ingrese su Nombre por favor -> ");
per.Nombre = Console.ReadLine();

Console.Write("\nIngrese su edad actual -> ");
per.Edad = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIngrese su sexo -> ");
per.Sexo = Console.ReadLine();

Console.Write("\nIngrese su peso en Kg. (kilogramos) -> ");
per.Peso = Convert.ToDouble(Console.ReadLine());

Console.Write("\nIngrese su altura en metros -> ");
per.Altura = Convert.ToDouble(Console.ReadLine());

Console.Write($@"
Nombre: {per.Nombre} edad: {per.Edad} sexo: {per.Sexo}
Peso: {per.Peso}
Altura: {per.Altura}
Usted {clsPersona.CalcularIMC(per)}
Usted {clsPersona.MayorDeEdad(per)}");
