using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            int opcionElegida = 0;

            opcionElegida = int.Parse(Console.ReadLine());
            while(opcionElegida != 5){
                Console.WriteLine("Ingrese primer numero:");
                double Numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero:");
                double Numero2 = double.Parse(Console.ReadLine());
                double resultado;

                switch(opcionElegida){
                    case 1: 
                        resultado = Numero1 + Numero2;
                        break;
                    case 2:
                        resultado = Numero1 - Numero2;
                        break;
                    case 3: 
                        resultado = Numero1 * Numero2;
                        break;
                    case 4:
                        if (Numero2 == 0){
                            resultado = 0;
                        }
                        else{
                            resultado = Numero1 / Numero2;
                        }
                        break;
                    default:
                        resultado = 0;
                        break;
                }
                Console.WriteLine("El resultado de tu operacion es {0}", resultado);
                Console.WriteLine("Calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                opcionElegida = int.Parse(Console.ReadLine());
            }

        }
    }
}
