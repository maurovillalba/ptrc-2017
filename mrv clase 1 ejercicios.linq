<Query Kind="Program" />


//ejercicio 1:
/*void Main()
{
  Console.WriteLine("--- Convertidor De Temperatura ---");
  Console.WriteLine("    Ingrese La Temperatura En Grados Centigrados:");
  float gc = float.Parse(Console.ReadLine());
  float gf = (((9.0f/5) * gc) + 32);
  //9.0f para flotante
  //9.0 double
  Console.WriteLine("    {0} Grados Centigrados es equivalente a {1} Grados Farenheit", gc, gf);
	
}
*/

//ejercicio 2:
//version 1
/*
void Main()
{
  Console.WriteLine("--- Obtener Valor Aproximado De PI ---");
  Console.WriteLine("    Ingrese La Cantidad De Terminos Que Desea Utilizar:");
  int i = 0, n = 1, estado = 0, presicion = int.Parse(Console.ReadLine());
  float pi = 0;
  Console.WriteLine("    Cantidad De Terminos A Utilizar: {0}",presicion);
  for (;i<presicion;i++)
  {
    if (estado == 0)
	{
      pi = pi + (1.0f/n);
	  n = n + 2;
	  estado = 1;
	}
    else
	{// si estado == 1
      pi = pi - (1.0f/n);
	  n = n + 2;
	  estado = 0;
	}
  }
  float pii = pi * 4;
  Console.WriteLine("    PI aprox = {0:R}", pii);
}
*/
//version 2
/*
void Main()
{
  Console.WriteLine("--- Obtener Valor Aproximado De PI ---");
  Console.WriteLine("    Ingrese La Cantidad De Terminos Que Desea Utilizar:");
  int i = 0, n = 1, presicion = int.Parse(Console.ReadLine());
  float pi = 0;
  Console.WriteLine("    Cantidad De Terminos A Utilizar: {0}",presicion);
  for (;i<presicion;i++)
  {
    if ((i % 2) != 0)
	{
      pi = pi - (1.0f/n);
	  n = n + 2;
	}
    else
	{
	  pi = pi + (1.0f/n);
	  n = n + 2;
	}
  }
  float pii = pi * 4;
  Console.WriteLine("    PI aprox = {0:R}", pii);
}
*/
//ejercicio 3
/*
void Main()
{
  Console.WriteLine("--- AÑO BISIESTO??? ---");
  Console.WriteLine("    Ingrese El Año:    ");
  int ano = int.Parse(Console.ReadLine());
  if (((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0)){
    Console.WriteLine("El Año {0} ES BISIESTO", ano);
  }
  else
  {
    Console.WriteLine("El Año {0} NO es Bisiesto", ano);
  }
}
*/
// Define other methods and classes here
