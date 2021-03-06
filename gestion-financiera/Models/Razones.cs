using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestion_financiera.Models
{
    
    public class Razones{

       
        public int ID { get; set; }
        //razon corriente
        public double acorriente1 {get;set;}
        public double pcorriente1 {get;set;}
        public double Mensaje1 {get;set;}



        public double acorriente2 {get;set;}
        public double pcorriente2 {get;set;}
        public double Mensaje2 {get;set;}



        public double acorriente3 {get;set;}
        public double pcorriente3 {get;set;}
        public double Mensaje3 {get;set;}


        public double acorriente10 {get;set;}
        public double pcorriente13 {get;set;}
        public double Mensaje13 {get;set;}

        //prueba acida
        public double acorriente4 {get;set;}
        public double pcorriente4 {get;set;}
        public double inventario4 {get;set;}
        public double Mensaje4 {get;set;}



        public double acorriente5 {get;set;}
        public double pcorriente5 {get;set;}
        public double inventario5 {get;set;}
        public double Mensaje5 {get;set;}



        public double acorriente6 {get;set;}
        public double pcorriente6 {get;set;}
        public double inventario6 {get;set;}
        public double Mensaje6 {get;set;}


        public double acorriente11 {get;set;}
        public double pcorriente14 {get;set;}
        public double inventario7 {get;set;}
        public double Mensaje14 {get;set;}

        //indice de liquidez
        public double adisponible1 {get;set;}
        public double pcorriente7 {get;set;}
        public double Mensaje7 {get;set;}



        public double adisponible2 {get;set;}
        public double pcorriente8 {get;set;}
        public double Mensaje8 {get;set;}



        public double adisponible3 {get;set;}
        public double pcorriente9 {get;set;}
        public double Mensaje9 {get;set;}


        public double adisponible4 {get;set;}
        public double pcorriente15 {get;set;}
        public double Mensaje15 {get;set;}

        //capital de trabajo
        public double acorriente7 {get;set;}
        public double pcorriente10 {get;set;}
        public double Mensaje10 {get;set;}



        public double acorriente8 {get;set;}
        public double pcorriente11 {get;set;}
        public double Mensaje11 {get;set;}



        public double acorriente9 {get;set;}
        public double pcorriente12 {get;set;}
        public double Mensaje12 {get;set;}



        public double acorriente12 {get;set;}
        public double pcorriente16 {get;set;}
        public double Mensaje16 {get;set;}

    }


}
