<Query Kind="Program" />

/*

  Bien, faltaria la operacion inversa
  
  Una idea: podria ser por ejemplo que si el usuario ingresa
    32F
  el programa sabe que tiene que convertir F -> C
  
  Si el usuario ingresa
  
    32C
    
  convertiria C -> F
  
  Si no pone unidad el default seria uno de los dos, a eleccion

*/

//ejercicio 1:
void Main()
{
  Console.WriteLine("--- Convertidor De Temperatura ---");
  Console.WriteLine("    Ingrese La Temperatura En Grados Centigrados:");
  float gc = float.Parse(Console.ReadLine());
  float gf = (((9.0f/5) * gc) + 32);
  //9.0f para flotante
  //9.0 double
  Console.WriteLine("    {0} Grados Centigrados es equivalente a {1} Grados Farenheit", gc, gf);
	
}


