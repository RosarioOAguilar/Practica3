using System;

namespace Practica3
{
	class Program
	{
		  
		public static void Main(string[] args)
		{
			Console.WriteLine("PROGRAMACION III ... PRACTICA NUMERO 3");
			
			Proceso proceso = new Proceso(); //Instancia de la clase proceso
			
			//llamamos a nuestro metodos de la clase proceso
			proceso.capturar();
			proceso.editar();
			proceso.eliminar();
			proceso.imprimir();
		}
	}
}

