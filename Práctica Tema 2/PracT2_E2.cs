/* 
Alejo Asensi, Liam
Práctica Evaluable Tema 2
Ejercicio 2     si
*/

using System;

class PracT2_E2
{
	public static void Main()
	{
        int num = 1, mayor = 0, menor = 0, numAnterior = 0, contNum = 0, numRepetido = 0, contNumRepetido = 0, iteracion = 1;
        bool esCorrecto;
        
        do
        {
            do
            {
                esCorrecto = false;
                try
                {
                    Console.Write("Introduce un número: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    
                    esCorrecto = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}\n", e.Message);
                }
            } while (!esCorrecto);
            
            
            if (num != 0)
            {
                if (num == numAnterior) 
                {
                    contNum++;
                    if(contNum > contNumRepetido)
                    {
                        contNumRepetido = contNum;
                        numRepetido = num;
                    }
                }
                else
                {
                    contNum = 0;
                    if (iteracion == 1)
                    {
                        mayor = num;
                        menor = num;
                    }
                    else
                    {
                        if (num > mayor) mayor = num;
                        else if (num < menor) menor = num;
                    }
                }
                               
                numAnterior = num;
            }
            
            iteracion++;
            
        } while (num != 0);
        
        Console.WriteLine("El número más repetido es {0}. El mayor es {1}, y el menor es {2}", numRepetido, mayor, menor);
        
	}
}


