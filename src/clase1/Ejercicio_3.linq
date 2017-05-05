<Query Kind="Program" />


/*
  Perfecto, acordate que podes usar todas las letras para las variables, o sea
  que ahora podemos poner año... (antes no se podia ciertamente)
  
  Yo lo unico que trato de evitar son los acentos, que creo que no tienen sentido...
*/

//ejercicio 3

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

