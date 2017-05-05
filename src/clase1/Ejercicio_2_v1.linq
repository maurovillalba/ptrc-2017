<Query Kind="Program" />

/*

  Bien, ojo con la indentacion. Deberia notarse que el if esta anidado en el for 

*/

//ejercicio 2:
//version 1

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

