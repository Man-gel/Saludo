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
                public void mostrarSaludo()
                {
                 	Console.WriteLine("Hello!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
                }


		public static void Main(string[] args)
		{
			Program prueba = new Program();
                        prueba.mostrarSaludo();
		}
	}
}