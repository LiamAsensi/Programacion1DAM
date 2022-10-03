/* 
Alejo Asensi, Liam
Práctica Evaluable Tema 2
Ejercicio 1     si
*/

using System;

class PracT2_E1
{
	public static void Main()
	{
        string nombre = "";
        bool esCorrecto;
        int mesNac = 0, anyoNac = 0, contPers = 1, jovenes = 0, maduros = 0, mayores = 0, edad, anyo = 0, mes = 0;
        
        do
        {
            esCorrecto = false;
            
            try
            {
                Console.Write("Introduce el mes actual: ");
                mes = Convert.ToInt32(Console.ReadLine());
                if (mes < 1 || mes > 12) throw new Exception("Se ha introducido un mes inexistente (Debe ser entre 1 y 12).");
                Console.Write("Introduce el año actual: ");
                anyo = Convert.ToInt32(Console.ReadLine());
                if (anyo < 0) throw new Exception("Se ha introducido un año negativo.");
                
                esCorrecto = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}\n", e.Message);
            }
        } while (!esCorrecto);
        
        Console.WriteLine();
        
        do
        {
            do
            {
                esCorrecto = false;
                
                try
                {
                    Console.Write("Introduce el nombre de la persona {0}: ", contPers);
                    nombre = Console.ReadLine();
                    Console.Write("Introduce el mes de nacimiento de {0}: ", nombre);
                    mesNac = Convert.ToInt32(Console.ReadLine());
                    if (mesNac < 1 || mesNac > 12) throw new Exception("Se ha introducido un mes inexistente (Debe ser entre 1 y 12).");
                    Console.Write("Introduce el año de nacimiento de {0}: ", nombre);
                    anyoNac = Convert.ToInt32(Console.ReadLine());
                    if (anyoNac < 0 || anyoNac > anyo) throw new Exception("Se ha introducido un año incorrecto.");
                    
                    esCorrecto = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}\n", e.Message);
                }
            } while (!esCorrecto);
            
            if (anyoNac != 0)
            {
                Console.Write("{0} nació en ", nombre);
            
                switch (mesNac)
                {
                    case 1:
                        Console.Write("Enero");
                        break;
                    case 2:
                        Console.Write("Febrero");
                        break;
                    case 3:
                        Console.Write("Marzo");
                        break;
                    case 4:
                        Console.Write("Abril");
                        break;
                    case 5:
                        Console.Write("Mayo");
                        break;
                    case 6:
                        Console.Write("Junio");
                        break;
                    case 7:
                        Console.Write("Julio");
                        break;
                    case 8:
                        Console.Write("Agosto");
                        break;
                    case 9:
                        Console.Write("Septiembre");
                        break;
                    case 10:
                        Console.Write("Octubre");
                        break;
                    case 11:
                        Console.Write("Noviembre");
                        break;
                    case 12:
                        Console.Write("Diciembre");
                        break;
                    default:
                        Console.Write("Error");
                        break;
                }
                
                edad = anyo - anyoNac;
                if (mes < mesNac)edad--;  
                
                Console.WriteLine(" del año {0}. Tiene {1} años.", anyoNac, edad);
                
                if (edad <= 25) jovenes++;
                else if (edad > 25 && edad < 50) maduros++;
                else mayores++;
            }
            
            Console.WriteLine();
            
            contPers++;
        } while (anyoNac != 0);
        
        Console.WriteLine("Hay {0} jóvenes, {1} maduros y {2} mayores", jovenes, maduros, mayores);
        
        if (jovenes == 0 && maduros == 0 && mayores > 0) Console.WriteLine("Todos tienen 50 años o más"); 
        else if (mayores > 0 && (jovenes > 0 || maduros > 0)) Console.WriteLine("Hay algunos menores de 50 y otros mayores");
        else Console.WriteLine("Ninguno ha llegado a los 50.");
	}
}

