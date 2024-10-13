using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola Mundo con C#
            Console.WriteLine("Hola, C#.");
            
            // Datos de tipo cadena
            string myString = "Esto es una cadena de texto"; 
            Console.WriteLine(myString);
            
            // Datos de tipo entero 
            int myInt = 7;
            myInt = myInt + 4; 
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            
            // Datos de tipo decimal 
            double myFloat = 6.5; 
            Console.WriteLine(myFloat);
            
            //Operaciones 
            Console.WriteLine(myFloat + myInt);
            
            //Dinamic 
            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinamico"; 
            Console.WriteLine(myDynamic);
            
            // var es un string
            var myVar = "Mi variable de tipo inferido"; 
            Console.WriteLine(myVar);
            
            //boleano
            bool myBool = false; 
            Console.WriteLine(myBool);
            
            // Interpolar tipos de datos
            Console.WriteLine($"Esta es {myBool} y {myDynamic}");
            
            // Constante
            const string myConst = "Mi constante"; 
            Console.WriteLine(myConst);
            
            // Estructuras para guardar mas de un valor 
            //Listado de componentes o arreglos
            var myArray = new string[5] {"Teresita", "Kony", "Mamita", "Messo", "Velarde"}; 
            Console.WriteLine(myArray[0]);
        }
    }
}

