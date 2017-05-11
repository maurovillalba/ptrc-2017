<Query Kind="Program" />

//ejercicio 2
/*
void Main(){
  Console.WriteLine("--- Autosuma De Un Entero Positivo ---");
  Console.WriteLine("    Ingrese Un Entero Positivo   ");
  int ingreso = int.Parse(Console.ReadLine());
  int resultado = 0, ingre = ingreso;
  while (ingre > 0){
        resultado = resultado + (ingre % 10);
		ingre = (ingre / 10);
  }
  Console.WriteLine("    Numero Ingresado ==> {0} \n    Resultado ==> {1}", ingreso, resultado);
}
*/
// Define other methods and classes here
//ejercicio 3 
/*
void Main(){
  bool A , B, C, D;
  Console.WriteLine("--- V2 AÑO BISIESTO??? ---");
  Console.WriteLine("    Ingrese El Año:    ");
  int año = int.Parse(Console.ReadLine());
  A = (año % 4 == 0);
  B = (año % 100 != 0);
  C = (año % 400 == 0);
  D = ((A && B) || C);
  if (D)
     Console.WriteLine("El Año {0} ES BISIESTO", año);
  else
     Console.WriteLine("El Año {0} NO es Bisiesto", año);   
}
*/
//ejercicio 4
/*
void Main()
{
  DateTime fecha = new DateTime (1991, 12, 29);
  Console.WriteLine("La fecha es {0:D}",fecha);
}
*/