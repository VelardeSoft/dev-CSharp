using System;
using System.Runtime.InteropServices;

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
            Console.WriteLine(myArray[2]);
            
            // Diccionary
            var myDictionary = new Dictionary<string, int>  // Clave - valor 
            {
                { "Velarde", 24 },
                { "Teresita", 23 },
                { "Mamita", 24 }
            }; 
            Console.WriteLine(myDictionary["Velarde"]);
            
            // Estructura Set, son estructuras desordenadas, los valores repetidos se ovbian
            var mySet = new HashSet<string> { "Teresita", "Messo", "Velarde" }; 
            Console.WriteLine(mySet);
            
            // Tuplas
            var myTuple = ("Teresita", "Messo", "Velarde");
            Console.WriteLine(myTuple);
            
            //Bucles 
            Console.WriteLine("---- BUCLES ----");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---- ForEach ----");
            int num = 1; 
            foreach (var myItem in myArray)
            {
                Console.WriteLine($"{num} : {myItem}");
                num++;
            }

            myInt = 0; 
            //Flujos
            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            } else if (myInt == 0 || myBool == false)
            {
                Console.WriteLine("El valor es CERO");
            }
            else
            {
                Console.WriteLine("El valor NO es 11");
            }
            
            // Funciones 
            MyFunction(); 
            Console.WriteLine(MyFunctionWithReturn(5));
            
            // clases
            var MyClass = new MyClass("Teresita");
            Console.WriteLine(MyClass.myName);
        }

        static void MyFunction()
        {
            Console.WriteLine("Esta es mi funcion");
        }
        static int MyFunctionWithReturn(int param)
        {
            return 10 + param; 
        }
        
        // Clases son objetos personalizados
        class MyClass
        {
            public string myName { get; set; }

            public MyClass(string myCurrentName)
            {
                myName = myCurrentName;
            }
        }
    }
}

// https://learn.microsoft.com/dotnet/csharp
// https://learn.microsoft.com




















