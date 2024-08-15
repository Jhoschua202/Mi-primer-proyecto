
string Nombre;
Console.WriteLine("Bienvenidos a nuestro primer sistema creado en C#");
Console.WriteLine("Ingrese tu nombre para continuar");
Nombre = Console.ReadLine();//para recibir Valores de caracter
Console.WriteLine("Ingrese su edad");
int Edad = Convert.ToInt32(Console.ReadLine);// convertir a dato tipo double 
 double EdadMeses = Edad * 12; // Calculos Matematicos
Console.WriteLine("La edad en meses es: " + EdadMeses + "Meses");//Contatenacion
