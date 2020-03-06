using System;

namespace Examen_Mochila
{
    class Backpack
    {
        private Objeto[,] mochilaOrden;
        private int filas;
        private int columnas;
        

        //crear metodo que asigna tama;o de la matriz
        //nombre del metodo SIEMPRE se llama igual que la clase
        public Backpack(Objeto[,] mochilaOrden, int filas, int columnas)
        {
            this.mochilaOrden = mochilaOrden;
            this.filas = filas;
            this.columnas = columnas;
            
        }


        public void ShowBackpack()
        {
            //iterar filas
            for (int y = 0; y < this.filas; y++)
            {
                //iterar columnas
                for (int x = 0; x < this.columnas; x++)
                {
                    //print cada valor de la fila, columna
                    Console.Write(mochilaOrden[y, x].TomarNombre() + " . ");
                }
                //agregar salto de linea
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //verificar que los elementos ingresados no se aplasten por el peso ejercido por los objetos por encima de ellos
        //imprimir el nombre del elemento aplastado. En caso contrario, imprimir que el acomodo es correcto.
        
        public void ShowPeso()
        {
            //iterar filas
            for (int y = 0; y < this.filas; y++)
            {
                //this goes de columna izq a der, salto, y siguiente fila. Hace caso al for adentro.
                //iterar columnas
                for (int x = 0; x < this.columnas; x++)
                {
                    //print cada valor de la fila, columna
                    Console.Write(mochilaOrden[y, x].TomarPeso() + " , ");
                }
                //agregar salto de linea
                Console.WriteLine();
            }
            Console.WriteLine();
        }

//Intento de programa "freson fallido-pendiente

       /* private bool aplastado;
        public void ShowPesoModified()
        {
            //iterar filas
            for (int y = 0; y < this.filas; y++)
            {
                //this goes de columna izq a der, salto, y siguiente fila. Hace caso al for adentro.
                //iterar columnas
                for (int x = 0; x < this.columnas-1; x++)
                {
                    if(mochilaOrden[y,x].TomarPeso() > mochilaOrden[(y+1),x].TomarPeso()) {
                        bool aplastado = true;
                        
                            Console.Write("Objeto" + mochilaOrden[(y-1),x].TomarNombre() + "Aplastado" );
                    }
                    if(!aplastado) {
                        Console.WriteLine("Acomodo correcto");
                    }
                        
                        
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } */

         public void Pesar()        //verificar cada columna
        {
            //C1
            if(this.mochilaOrden[1, 0].TomarPeso() > this.mochilaOrden[2, 0].TomarPeso()) {
                Console.WriteLine("ERROR  " + this.mochilaOrden[2, 0].TomarNombre() + " aplastado");
            }
            else 
            {
                Console.WriteLine("Acomodo correcto");
            }
            //C2
            if(this.mochilaOrden[0,1].TomarPeso() == this.mochilaOrden[1,1].TomarPeso()) {
                if (this.mochilaOrden[1, 1].TomarPeso() > this.mochilaOrden[2, 1].TomarPeso())
                {
                Console.WriteLine("ERROR  " + this.mochilaOrden[2,1].TomarNombre() + " aplastado");
                }
                else {
                    Console.WriteLine("Acomodo correcto");
                }
            }
            else
            {
                if (this.mochilaOrden[1, 1].TomarPeso() == this.mochilaOrden[2, 1].TomarPeso())
                {
                    if (this.mochilaOrden[0, 1].TomarPeso() > this.mochilaOrden[1, 1].TomarPeso())
                    {
                        Console.WriteLine("ERROR  " + this.mochilaOrden[1, 1].TomarNombre() + " aplastado");
                    }
                    else
                    {
                         Console.WriteLine("Acomodo correcto");
                    }
                }
                else
                {
                    if (this.mochilaOrden[0, 1].TomarPeso() > this.mochilaOrden[1, 1].TomarPeso())
                    {
                        Console.WriteLine(this.mochilaOrden[1, 1].TomarNombre() + " aplastado");
                    }
                    else
                    {
                        if (this.mochilaOrden[0, 1].TomarPeso() + this.mochilaOrden[1, 1].TomarPeso() > this.mochilaOrden[2, 1].TomarPeso())
                        {
                            Console.WriteLine("ERROR  " + this.mochilaOrden[2, 1].TomarNombre() + " aplastado");
                        }
                        else
                        {
                             Console.WriteLine("Acomodo correcto");
                        }
                    }
                }
            }

            //C3
             if (this.mochilaOrden[0, 2].TomarPeso() == this.mochilaOrden[1, 2].TomarPeso())
            {
                if (this.mochilaOrden[1, 2].TomarPeso() > this.mochilaOrden[2, 2].TomarPeso())
                {
                    Console.WriteLine("ERROR  " + this.mochilaOrden[2, 2].TomarNombre() + " aplastado");
                }
                else
                {
                    Console.WriteLine("Acomodo correcto");
                }
            }
            else
            {
                if (this.mochilaOrden[1, 2].TomarPeso() == this.mochilaOrden[2, 2].TomarPeso())
                {
                    if (this.mochilaOrden[0, 2].TomarPeso() > this.mochilaOrden[1, 2].TomarPeso())
                    {
                        Console.WriteLine("ERROR  " + this.mochilaOrden[1, 2].TomarNombre() + " aplastado");
                    }
                    else
                    {
                        Console.WriteLine("Acomodo correcto");
                    }
                }
                else
                {
                    if (this.mochilaOrden[0, 2].TomarPeso() > this.mochilaOrden[1, 2].TomarPeso())
                    {
                        Console.WriteLine("ERROR  " + this.mochilaOrden[1, 2].TomarNombre() + " aplastado");
                    }
                    else
                    {
                        if (this.mochilaOrden[0, 2].TomarPeso() + this.mochilaOrden[1, 2].TomarPeso() > this.mochilaOrden[2, 2].TomarPeso())
                        {
                            Console.WriteLine("ERROR  " + this.mochilaOrden[2, 2].TomarNombre() + " aplastado");
                        }
                        else
                        {
                            Console.WriteLine("Acomodo correcto");
                        }

                    }
                }
            }

            //C4
            if (this.mochilaOrden[1, 3].TomarPeso() > this.mochilaOrden[2, 3].TomarPeso())
                {
                    Console.WriteLine("ERROR,  " + this.mochilaOrden[2, 3].TomarNombre() + " aplastado");
                }
                else
                {
                    Console.WriteLine("Acomodo correcto");
                }


        }
    }
}

