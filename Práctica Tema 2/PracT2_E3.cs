/* 
Alejo Asensi, Liam
Práctica Evaluable Tema 2
Ejercicio 3
*/

using System;

class PracT2_E3
{
	public static void Main()
	{
        bool esCorrecto;
        int tam = 0;
        
        // Código para la toma de datos
        
        do
        {
            esCorrecto = false;
            
            try
            {
                Console.Write("Introduce el tamaño del cuadrado: ");
                tam = Convert.ToInt32(Console.ReadLine());
                
                if (tam % 2 == 0) throw new Exception("El tamaño tiene que ser impar.");
                else if (tam < 9 || tam >= 26) throw new Exception("Tamaño incorrecto. Tiene que ser entre 9 y 25.");
                
                esCorrecto = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}\n", e.Message);
            }
        } while (!esCorrecto);
        
        
        // Código para dibujar el cuadrado
        
        for (int filaActual = 1; filaActual <= tam; filaActual++)
        {
            if (filaActual == 1 || filaActual == tam)
            {
                for (int colActual = 1; colActual <= tam; colActual++) Console.Write("*");
                Console.WriteLine();
            }
            else
            {
                Console.Write("*");
                for (int colActual = 1; colActual <= tam - 2; colActual++)
                {
                    if (colActual == filaActual - 1 || colActual == tam - filaActual) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
	}
}



