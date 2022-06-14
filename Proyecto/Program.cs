using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encomiendas = 0;
            int pesoAcumulativo;
            int sumaDePeso = 0;
            int camion = 0;
            int camionActual = 0;
            int encomiendasActual = 0;
            Console.WriteLine("Ingresar el peso de la encomienda a cargar (Ingresar numero negativo para mostrar el resultado final al momento)");
            int peso = int.Parse(Console.ReadLine());
            while (peso > 0)
            {
                encomiendas = 0;
                sumaDePeso = 0;
                camion++;
                while (peso > 0)
                {
                    pesoAcumulativo = peso += sumaDePeso;
                    sumaDePeso = pesoAcumulativo;
                    Console.WriteLine($"Peso acumulado:{sumaDePeso}");
                    
                    Console.WriteLine($"Camión transportista:{camion}");
                    if (sumaDePeso <= 200)
                    {
                        encomiendas++;
                        Console.WriteLine($"Cantidad de encomiendas:{encomiendas}");
                    }
                    else if (sumaDePeso > 200)
                    {

                        Console.WriteLine("Usted ha superado el limite de peso permitido");
                        Console.WriteLine("El programa se reiniciará");
                        peso = 0;
                        sumaDePeso = 0;
                        camion = 1;
                    }
                    if (encomiendas > encomiendasActual)
                    {
                        encomiendasActual = encomiendas;
                        camionActual = camion;
                    }
                    Console.WriteLine("\nIngresar el peso de la encomienda a cargar (Ingresar numero negativo para cambiar al proximo camión)");
                    peso = int.Parse(Console.ReadLine());
                }
                //---------------------------------------------------------------------------------------------- 

                //PUNTO A/ PESO TOTAL DE ENCOMIENDAS y CAMION. 
                Console.WriteLine($"El peso total de encomiendas del camion {camion} es: {sumaDePeso}kg\n\n");
                Console.WriteLine("\nIngresar el peso de la encomienda a cargar (Ingresar numero negativo para mostrar el resultado final al momento)");
                peso = int.Parse(Console.ReadLine());
            }
            //PUNTO B / PESO TOTAL DE ENCOMIENDAS y CAMION. 
            Console.WriteLine($"\n\nEl camion que transporta la mayor cantidad de encomiendas es el {camionActual} con un total de {encomiendasActual} encomiendas");
            //PUNTO C / PESO TOTAL DE ENCOMIENDAS y CAMION. 
            Console.WriteLine($"La cantidad de camiones cargados fue de: {camion}");

        }
    }
}
