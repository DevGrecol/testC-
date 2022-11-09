using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////// INVERTIR NÚMERO DE DOS CIFRAS //////////////////////////////////               
            /*
                int NUM, AUX, DEC, UNI;
                string linea;
                Console.WriteLine("Ingrese numero de dos cifras");
                linea = Console.ReadLine();
                NUM = int.Parse(linea);
                DEC = NUM / 10;
                UNI = NUM % 10;
                AUX = (UNI * 10) + DEC;

                Console.WriteLine("Numero invertido es: "+ AUX);
                Console.WriteLine("Salir [Enter]");
                Console.ReadLine();
            */

            /////////////////////// INVERTIR NÚMERO DE TRES CIFRAS //////////////////////////////////
            /*
            int NUM, AUX, DEC, UNI, CEN;
            String linea;
            Console.WriteLine("Ingrese numero de tres cifras: ");
            linea = Console.ReadLine();
            //conviente cadena de texto a numero entero
            NUM = int.Parse(linea);
            CEN = NUM / 100;
            NUM = NUM % 100;
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;

            Console.WriteLine("Numero inventido es: " + AUX);
            Console.WriteLine("Salir [Enter]");
            Console.ReadLine();
            */
            /////////////////////// OPERACIONES BASICAS //////////////////////////////////
            /*
            int NUM1, NUM2, RESUL;
            //salto de linea
            string linea;
            Console.Write("PRIMER NÚMERO :");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);

            Console.Write("SEGUNDO NÚMERO :");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);

            Console.WriteLine();

            RESUL = NUM1 + NUM2;
            Console.WriteLine("LA SUMA ES {0}: ", RESUL);

            RESUL = NUM1 - NUM2;
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", NUM1, NUM2, RESUL);

            RESUL = NUM1 * NUM2;
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + RESUL);

            RESUL = NUM1 / NUM2;
            Console.WriteLine("LA DIVISIÓN ES: " + RESUL);

            RESUL = NUM1 % NUM2;
            Console.WriteLine("EL RESIDUO ES: " + RESUL);

            Console.ReadLine(); 
            */
            /////////////////////// COMPRA EN RESTAURANTE //////////////////////////////////
            /*
            byte CAMB, CANH, CANP;
            double APAGAR;
            string linea;

            const double PRECIOB = 0.8;
            const double PRECIOH = 2;
            const double PRECIOP = 1.2;

            Console.WriteLine("Cantidad de Hamburguesas: ");
            linea = Console.ReadLine();
            CANH = byte.Parse(linea);

            Console.WriteLine("Cantidad de Papas: ");
            linea = Console.ReadLine();
            CANP = byte.Parse(linea);

            Console.WriteLine("Cantidad de Bebidas: ");
            linea = Console.ReadLine();
            CAMB = byte.Parse(linea);

            Console.WriteLine();

            APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CAMB * PRECIOB);
            Console.WriteLine("VALOR A PAGAR: "+ APAGAR);
            Console.ReadLine();
            */

            /////////////////////// COMPRA EN RESTAURANTE //////////////////////////////////
            /*
            int NUM1;
            string linea;
            long RESUL;

            Console.WriteLine("DIGITE UN NUMERO: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = Math.Abs(NUM1);
            Console.WriteLine("VALOR ABSOLUTO: " + RESUL);
            Console.WriteLine("POTENCIA: " + Math.Pow(NUM1, 3));
            Console.WriteLine("RAIZ CUADRADA: " + Math.Sqrt(NUM1));
            Console.WriteLine("SENO: " + Math.Sin(NUM1 * Math.PI / 180));
            Console.WriteLine("COSENO: " + Math.Cos(NUM1 * Math.PI / 180));
            Console.WriteLine("NUMERO MAXIMO: " + Math.Max(NUM1, 50));
            Console.WriteLine("NUMERO MINIMO: " + Math.Min(NUM1, 50));
            Console.WriteLine("PARTE ENTERA: " + Math.Truncate(18.78));
            Console.WriteLine("REDONDEO: " + Math.Round(18.78));


            Console.ReadLine();
            */

            /////////////////////// COMPRA EN RESTAURANTE //////////////////////////////////
            /*
            double BASE, ALTURA, RESUL;
            string linea;

            Console.WriteLine("Ingrese la base: ");
            linea = Console.ReadLine();
            BASE = double.Parse(linea);

            Console.WriteLine("Ingrese la Linea: ");
            linea = Console.ReadLine();
            ALTURA = double.Parse(linea);

            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO: " + String.Format("{0:####.00}", RESUL));

            Console.ReadLine();
            */
            /////////////////////// RECORRER ARRAY //////////////////////////////////

            //ARRAY UNIDIMENCIONAL

            //int[] arrayInt = new int[10];
            string linea;
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("array de interos");
            for (int i = 0; i < array1.Length; i++) {
                Console.WriteLine(array1[i] = i);
            }

            linea = Console.ReadLine();
            //string[] arrayStrings = new string[10];
            string[] weekDays = new string[] {"Sun", "Mon","Tue", "Wed", "Thu","Fri", "Sat"};

            Console.WriteLine("array por posicionamineto");
            Console.WriteLine(weekDays[0]);          
            Console.WriteLine(weekDays[6]);

            linea = Console.ReadLine();
            Console.WriteLine("array de strings");
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
            
            Console.ReadLine();
            /*
            string NOMBRE;

            string linea;
            Console.WriteLine("Ingrese nombre: ");
            linea = Console.ReadLine();
            NOMBRE = linea;
            
            foreach (char letra in NOMBRE)
            {
                Console.WriteLine("{0}",letra);
            }

            Console.ReadLine();
            */


            /*
            int[] diasMes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in diasMes)
            {
                Console.WriteLine("dias del mes: {0} ",i);
            }

            string[] nombres = { "Andres", "Ducuara", "Poloche" };
            foreach (string s in nombres)
            {
                Console.WriteLine("Nombres {0}: ",s);
            }

            string saludo = "Hola";
            foreach(char letra in saludo) {
            Console.Write("{0}-", letra);   
            }

            Console.ReadLine();
            */



        }
    }
}
