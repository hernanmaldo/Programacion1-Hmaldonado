using System;
using System.Net;
using System.Timers;

public static class Actividades
{
    public static void Main()
    {
        
        //Ejercicio 1
        string nombre;
        int edad;
        DateTime fechaNacimiento;
        double gasto;
        bool estudiante;

        //Ejercicio 2
        nombre = "Hernan";
        edad = 22;
        fechaNacimiento = new DateTime(2001, 01, 30);
        gasto = 300000.0;
        estudiante = true;

        //Ejercicio 3
        double costo1;
        double costo2;
        int cantidad1;
        int cantidad2;

        Console.WriteLine("Ingrese un costo");
        costo1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese una cantidad para dicho costo");
        cantidad1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ingrese otro costo");
        costo2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese una cantidad para dicho costo");
        cantidad2 = Convert.ToInt16(Console.ReadLine());
        //Ejercicio 4
        double total1 = costo1 * cantidad1;
        double total2 = costo2 * cantidad2;
        double costototal = total1 + total2;
        double totalMayor;
        double totalMenor;

        //Ejercicio 8
        double costo3;
        if (costo1 > costo2)
        {
            costo3 = costo1 + 20;
        }
        else
        {
            costo3 = costo2 + 20;
        }

        if (total1 > total2)
        {
            Console.WriteLine("El mayor tottal es: " + total1);
            totalMayor = total1;
            totalMenor = total2;
        }else
        {
            
            Console.WriteLine("El mayor tottal es: " + total2);
            totalMayor = total2;
            totalMenor = total1;
        }
        Console.WriteLine("Su costo Total es: $" + Convert.ToString(costototal));

        //Ejercicio 10
        Console.WriteLine("Ingrese un total");
        int total3 =Convert.ToInt16(Console.ReadLine());
        if (total3 > totalMayor)
        {
            Console.WriteLine("El valor ingresado es mayor que los totales anteriores: "+totalMenor+" y "+ totalMayor);
        }else
        {if (total3 > totalMenor)
            {
                Console.WriteLine("El valor ingresado es mayor que el total: "+ totalMenor);
            }else { Console.WriteLine("EL valor ingresado es menor que los totales anteriores"); }
            
        }
       

        //Ejercicio 5 y 7
        Console.WriteLine("Ingrese la base de su triangulo en cm");
        int Base = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ingrese la Altura de su triangulo en cm");
        int Altura = Convert.ToInt16(Console.ReadLine());

        double areaTriangulo = (Base * Altura) / 2;
        double Hipotenusa = Math.Sqrt((Base ^ 2) + (Altura ^ 2));

        Console.WriteLine("El Area de su triángulo es: " + areaTriangulo + " cm");
        Console.WriteLine("De tratarse de un Triangulo Rectangulo su Hipotenusa seria: "+ Hipotenusa+ "cm" );
        
        //Ejercicio 6

        Console.WriteLine("Ingrese el radio de su círculo en cm");
        int radio = Convert.ToInt16(Console.ReadLine());
        double perimetro = radio * 2 * 3.1415;
        Console.WriteLine("El perímetro de su circulo es: "+ Convert.ToString(perimetro) + " cm");

        //Ejercicio 11 

        int edadEj11;
        Console.WriteLine("Ingrese una edad: ");
        edadEj11 = Convert.ToInt16(Console.ReadLine());

        if (edadEj11 >= 18)
        {
            Console.WriteLine("Mayor");
        }
        //Ejercicio 12
        double monto;

        Console.WriteLine("Ingrese un monto");
        monto = Convert.ToDouble(Console.ReadLine());

        if (monto < 100 && monto > 50)
        {
            Console.WriteLine("El costo es moderado");
        }


        //Ejercicio 13

        int valorUsuario;

        Console.WriteLine("Ingrese un valor entero: ");
        valorUsuario = Convert.ToInt16(Console.ReadLine());
        
        if (valorUsuario % 2 == 0) {
            Console.WriteLine("El valor es par");
        }
        else
        {
            Console.WriteLine("El valor es impar");
        }

        //Ejercicio 14

        double precio;
        int cantidaD;
        double totaL;
        bool condicion1;
        bool condicion2;
        Console.WriteLine("Ingrese un precio: ");
        precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese una cantidad: ");
        cantidaD = Convert.ToInt16(Console.ReadLine());
        totaL = cantidaD * precio;
        condicion1 = (cantidaD > 10) && (precio > 10);
        condicion2 = (cantidaD < 100) && (precio > 0);


        if (condicion1 || condicion2)
        {
            Console.WriteLine("El total es: "+ totaL);

        }else
        {
            Console.WriteLine("EL precio es: "+ precio);
        }
        

        //Ejercicio 15

        int entrada;
        string salida;
        double altura;
        double ancho;
        double largo;
        double radio2;
        double areaBase;
        double volumen;
        double pi;
        pi = 3.14;

        salida = "no";
        while (salida == "no")
        {
            Console.WriteLine(@"Indique el objeto al cual desea medir su volumen:
1. Cilindro
2. Esfera
3. Ortoedro
4. Prisma
5. Salir");
            entrada = Convert.ToInt16(Console.ReadLine());
            switch (entrada)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio de la base de su cilintro:");
                    radio2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de su cilindro: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    volumen = pi * radio * radio * altura;
                    Console.WriteLine("El volumen de su cilindo es: " + volumen);
                    Console.WriteLine("Salir? [si/no]");
                    salida = Console.ReadLine() ?? "si" ;
                    break;
                case 2:
                    Console.WriteLine("Ingrese el radio de su esfera:");
                    radio2 = Convert.ToDouble(Console.ReadLine());
                    

                    volumen = 1.333 * pi * radio * radio * radio;
                    Console.WriteLine("El volumen de su esfera es: " + volumen);
                    Console.WriteLine("Salir? [si/no]");
                    salida = Console.ReadLine() ?? "si";
                    break;
                case 3:
                    Console.WriteLine("Ingrese el largo de su ortoedro:");
                    largo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de su ortoedro: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el ancho de su ortoedro: ");
                    ancho = Convert.ToDouble(Console.ReadLine());

                    volumen = largo * altura * ancho;
                    Console.WriteLine("El volumen de su ortoedro es: " + volumen);
                    Console.WriteLine("Salir? [si/no]");
                    salida = Console.ReadLine() ?? "si";
                    break;
                 case 4:
                    Console.WriteLine("Ingrese el area de la base de su prisma:");
                    areaBase = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de su prisma: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    volumen = areaBase * altura;
                    Console.WriteLine("El volumen de su cilindo es: " + volumen);
                    Console.WriteLine("Salir? [si/no]");
                    salida = Console.ReadLine() ?? "si";
                    break;
                  case 5:

                    salida = "si";
                    break;
            }


        }
      
    }
}











    



