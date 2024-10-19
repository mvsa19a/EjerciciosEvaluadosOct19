using System;
using System.Collections.Generic;

namespace CuentaBancaria
{
    internal class Cuenta
    {
        public static void Main(string[] args)
        {
            List<decimal> cuenta = new List<decimal> { 0 }; // Inicializar con saldo 0
            int opcion;

            do
            {
                Console.WriteLine("\n--- Menu de opciones ---");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConsultarSaldo(cuenta);
                        break;
                    case 2:
                        DepositarDinero(cuenta);
                        break;
                    case 3:
                        RetirarDinero(cuenta);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida, intente nuevamente.");
                        break;
                }
            } while (opcion != 4);
        }

        public static void ConsultarSaldo(List<decimal> cuenta)
        {
            Console.WriteLine($"El saldo actual es: {cuenta[0]}");
        }

        public static void DepositarDinero(List<decimal> cuenta)
        {
            Console.Write("Introduzca la cantidad a depositar: ");
            decimal deposito = decimal.Parse(Console.ReadLine());
            cuenta[0] += deposito;
            Console.WriteLine("Deposito realizado exitosamente.");
        }

        public static void RetirarDinero(List<decimal> cuenta)
        {
            Console.Write("Introduzca la cantidad a retirar: ");
            decimal retiro = decimal.Parse(Console.ReadLine());

            if (retiro <= cuenta[0])
            {
                cuenta[0] -= retiro;
                Console.WriteLine("Retiro realizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
