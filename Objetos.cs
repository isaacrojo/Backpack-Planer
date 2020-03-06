using System;

namespace Examen_Mochila
{
    class Objeto
    {
       public string name{get; set;}    //principio de encapsulacion get set
       public string nameSigla{get; set;}
       public int pesoGramos{get; set;}
       //public bool aplastado {get; set;}
       //public int espacios {get; set;}

        //metodo construye objetos con nombre, sigla y peso
        public Objeto(string name, string nameSigla, int pesoGramos) {
            this.name = name;
            this.pesoGramos = pesoGramos;
            this.nameSigla = nameSigla;
            //this.aplastado = aplastado;
            //this.espacios = espacios;

        }
        //metodo que devuelva el nombre
        public string TomarNombre()
        {
            return nameSigla;
        }

        public int TomarPeso()
        {
            return pesoGramos;
        }

    }
}