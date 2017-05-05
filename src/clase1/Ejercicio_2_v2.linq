<Query Kind="Program" />


/*
  Mejor!
  
  Te agregue una alternativa un poco mas criptica, ya vamos a ver el operador 
  condicional ==> ? :

*/

//version 2

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

  pii = Alternativa(presicion);
  Console.WriteLine("    PI aprox = {0:R}", pii);
}

float Alternativa(int terminos) 
{
  float result = 0.0f;
  
  for (int i = 0; i < terminos ; i++)
    result += ((i % 2) == 0 ? 1 : -1) * 1.0f / (2*i+1);
    
  return result * 4;
}
