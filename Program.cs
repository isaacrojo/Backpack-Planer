using System;

namespace Examen_Mochila
{
    class Program
    {
       static void Main (string[] args)
       {
        
        Objeto _ = new Objeto(" (vacio) ", "_",  0); 
        Objeto CU = new Objeto("Cuerda", "CU", 1000);
        Objeto BA = new Objeto("Botella de Agua", "BA", 1100);
        Objeto M = new Objeto("Manzana", "M", 250);
        Objeto P = new Objeto("Pan", "P", 70);
        Objeto B = new Objeto ("Brujula", "B", 250);
        Objeto PB = new Objeto("Papel", "PB", 320);
        Objeto PL = new Objeto("Platano", "PL", 80);

        Backpack mochila = new Backpack(
            new Objeto [3,4] {             //nuevo arreglo bidimensinal de objetos
                { _ , M, P, _ },            // "acomodo correcto" 
                {PL, CU, BA, PB},
                {PL, CU, BA, B}
            },
             3,4
        );

       Console.WriteLine("Objetos de la mochila");
        mochila.ShowBackpack();

       Console.WriteLine("Peso de los bjetos de la mochila");
        mochila.ShowPeso();
        //mochila.ShowPesoModified();

        Console.WriteLine("Verificacion por columnas del acomodo de la mochila (1-4)");
        mochila.Pesar();



           
       } 
        

    }
}
