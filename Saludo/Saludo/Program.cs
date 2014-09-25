/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 23/09/2014
 * Time: 07:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Saludo
{
	class Program
	{

            string nombre ="";
                


                public void mostrarSaludo()
                {
                 	Console.WriteLine("Hola "+ nombre+ "!");
			Console.ReadKey(true);
                }


                public void pedirNombre()
                {
                 	Console.WriteLine("Ingresa tu nombre:");
			
			nombre = Console.ReadLine();
                }


		public static void Main(string[] args)
		{
			Program prueba = new Program();
                        prueba.pedirNombre();
                        prueba.mostrarSaludo();
		}
	}
}