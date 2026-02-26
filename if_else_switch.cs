using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        TAREA IF ELSE Y SWITCH
            //YENCY ELADIO ARIAS MARCELINO 2025-0193


            //1. NUMERO POSITIVO, NEGATIVO O CERO
            
            Console.WriteLine("Ingresa un numero... ");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num > 0)
            {
                Console.WriteLine("El numero es positivo");
                            }
            else if (num < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es cero");            
            }




            //2. PAR O IMPAR
            /*
            Console.WriteLine("Ingresa un numero... ");
            int nump = Convert.ToInt32(Console.ReadLine());

            if (nump % 2 == 0)
            {
                Console.WriteLine("El numero es par");

            }

            else
            {
                Console.WriteLine("El numero es impar");
            }
            */



            //3. MAYOR DE EDAD
            /*
            Console.WriteLine("Ingresa tu edad ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)

            {
                Console.WriteLine($"Eres mayor, tienes {edad} años");
            }

            else

            {
                Console.WriteLine($"Eres menor, tienes {edad} años");
            }
            */



            //4. Multiplo de 5
            /*
            Console.WriteLine("Ingresa un numero... ");
            int mult5 = Convert.ToInt32(Console.ReadLine());

            if (mult5 % 5 == 0)
            {
                Console.WriteLine($"El numero {mult5} SI es multiplo de 5");
            }

            else
            {
                Console.WriteLine($"El numero {mult5} NO es multiplo de 5");
            }
            */



            //5. DESCUENTO POR EDAD
            /*
            Console.WriteLine("Ingresa tu edad para el descuento... ");
            int edad2 = Convert.ToInt32(Console.ReadLine());

            if (edad2 >= 60)

            {
                Console.WriteLine($"Entonces tienes {edad2} años... te aplicaremos el 50% de descuento!");
            }

            else

            {
                Console.WriteLine($"No aplicas para el descuento, tienes {edad2} años...");
            }
            */

            //6. CALIFICACION APROBATORIA
            /*
            Console.WriteLine("Ingresa la calificacion (0-100): ");
            int calificacion = Convert.ToInt32(Console.ReadLine());

            if (calificacion >= 60)
            {
                Console.WriteLine($"Aprobaste con {calificacion}");
            }
            else
            {
                Console.WriteLine($"Reprobaste con {calificacion}");
            }
            */



            //7. DIA DE LA SEMANA
            /*
            Console.WriteLine("Ingresa un numero del 1 al 7: ");
            int dia = Convert.ToInt32(Console.ReadLine());


            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;

                case 6:
                    Console.WriteLine("Sabado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
            */



            //8. NUMERO MAYOR ENTRE DOS
            /*
            Console.WriteLine("Ingresa el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine($"El numero mayor es {num1}");
            }

            else if (num2 > num1)
            {
                Console.WriteLine($"El numero mayor es {num2}");
            }

            else
            {
                Console.WriteLine("Ambos numeros son iguales");
            }
            */



            //9. MAYOR ENTRE TRES NUMEROS
            /*
            Console.WriteLine("Ingresa el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"El numero mayor es {num1}");
            }

            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"El numero mayor es {num2}");
            }

            else
            {
                Console.WriteLine($"El numero mayor es {num3}");
            }
            */



            //10. CLASIFICACION DE ANGULOS
            /*
            Console.WriteLine("Ingresa el valor del angulo en grados: ");
            int angulo = Convert.ToInt32(Console.ReadLine());

            if (angulo < 90)
            {
                Console.WriteLine("Es un angulo agudo");
            }

            else if (angulo == 90)
            {
                Console.WriteLine("Es un angulo recto");
            }

            else if (angulo > 90 && angulo < 180)
            {
                Console.WriteLine("Es un angulo obtuso");
            }

            else if (angulo == 180)
            {
                Console.WriteLine("Es un angulo llano");
            }

            else
            {
                Console.WriteLine("Angulo fuera de clasificacion");
            }
            */



            //11. CALCULO DE IMPUESTOS
            /*
            Console.WriteLine("Ingresa tu salario mensual: ");
            double salario = Convert.ToDouble(Console.ReadLine());


            if (salario < 10000)
            {
                Console.WriteLine("Pagas 0% de impuestos");
            }

            else if (salario <= 30000)
            {
                Console.WriteLine("Pagas 10% de impuestos");
            }

            else
            {
                Console.WriteLine("Pagas 20% de impuestos");
            }
            */



            //12. CLASIFICACION DE NUMEROS
            /*
            Console.WriteLine("Ingresa el primer numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer numero: ");
            int n3 = Convert.ToInt32(Console.ReadLine());


            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("Hay al menos un cero");
            }

            else if (n1 > 0 && n2 > 0 && n3 > 0)
            {
                Console.WriteLine("Todos son positivos");
            }

            else if (n1 < 0 && n2 < 0 && n3 < 0)
            {
                Console.WriteLine("Todos son negativos");
            }

            else
            {
                Console.WriteLine("Son numeros mixtos");
            }
            */


            //13. AÑO BISIESTO
            /*
            Console.WriteLine("Ingresa un año: ");
            int anio = Convert.ToInt32(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                Console.WriteLine("Es un año bisiesto");
            }

            else
            {
                Console.WriteLine("No es un año bisiesto");
            }
            */



            //14. CONVERSION DE CALIFICACIONES
            /*
            Console.WriteLine("Ingresa la calificacion (0-100): ");
            int nota = Convert.ToInt32(Console.ReadLine());


            if (nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Calificacion: A");
            }

            else if (nota >= 80 && nota <= 89)
            {
                Console.WriteLine("Calificacion: B");
            }

            else if (nota >= 70 && nota <= 79)
            {
                Console.WriteLine("Calificacion: C");
            }

            else if (nota >= 60 && nota <= 69)
            {
                Console.WriteLine("Calificacion: D");
            }

            else if (nota >= 0 && nota < 60)
            {
                Console.WriteLine("Calificacion: F");
            }

            else
            {
                Console.WriteLine("Nota invalida");
            }
            */



            //15. FORMACION DE TRIANGULO
            /*
            Console.WriteLine("Ingresa el primer lado: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo lado: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer lado: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 + lado2 > lado3 &&
                lado1 + lado3 > lado2 &&
                lado2 + lado3 > lado1)
            {
                Console.WriteLine("Si se puede formar un triangulo");
            }
            else
            {
                Console.WriteLine("No se puede formar un triangulo");
            }
            */



            //16. CALCULADORA DE DESCUENTOS
            /*
            Console.WriteLine("Ingresa el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            if (precio < 50)
            {
                Console.WriteLine("No aplica descuento");
            }
            else if (precio <= 100)
            {
                Console.WriteLine("Aplica 5% de descuento");
            }
            else
            {
                Console.WriteLine("Aplica 10% de descuento");
            }
            */



            //17. TIPO DE TRIANGULO
            /*
            Console.WriteLine("Ingresa el primer lado: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo lado: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer lado: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());


            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }

            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triangulo isosceles");
            }

            else
            {
                Console.WriteLine("Es un triangulo escaleno");
            }
            */



            //18. EVALUACION DE TEMPERATURA
            /*
            Console.WriteLine("Ingresa la temperatura en grados Celsius: ");
            int temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("Hace mucho frio");
            }
            else if (temperatura <= 20)
            {
                Console.WriteLine("Clima fresco");
            }
            else if (temperatura <= 30)
            {
                Console.WriteLine("Clima agradable");
            }
            else
            {
                Console.WriteLine("Hace mucho calor");
            }
            */



            //19. CONVERSION DE HORAS A TURNOS
            /*
            Console.WriteLine("Ingresa la hora (0-23): ");
            int hora = Convert.ToInt32(Console.ReadLine());


            if (hora >= 6 && hora <= 11)
            {
                Console.WriteLine("Mañana");
            }

            else if (hora >= 12 && hora <= 17)
            {
                Console.WriteLine("Tarde");
            }

            else if (hora >= 18 && hora <= 23)
            {
                Console.WriteLine("Noche");
            }

            else if (hora >= 0 && hora <= 5)
            {
                Console.WriteLine("Madrugada");
            }

            else
            {
                Console.WriteLine("Hora invalida");
            }
            */



            //20. CLASIFICACION DE IMC
            /*
            Console.WriteLine("Ingresa tu peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa tu altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"Tu IMC es: {imc}");


            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }

            else if (imc < 25)
            {
                Console.WriteLine("Normal");
            }

            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }

            else
            {
                Console.WriteLine("Obesidad");
            }
            */

        }

    }
}