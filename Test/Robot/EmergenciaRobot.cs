using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;
using Test.Exceptions;

namespace Test.Robot
{
public class EmergenciaRobot{
    


    #region Methods
       public List<Seccion> ejecutarDomo(int probabilidadTornado,RepositorioCultivo Datos,List<Seccion> Secciones){

            if((probabilidadTornado>=80) ){
                Console.WriteLine("Ejecutando Domo");

                Seccion Cereales = Secciones.FirstOrDefault(s=> s.Tipo =="Cereales") as Seccion;
                if(Cereales.enDomo == true){
                    Console.WriteLine("Los Cereales ya estan en el domo");
                }
                else{
                    Cereales.enDomo= true;
                    Console.WriteLine("Entrenado los Cereales al domo. Estado enDomo: "+ Cereales.enDomo);
                }
                
                Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
                if(Hortalizas.enDomo == true){
                    Console.WriteLine("Los Hortalizas ya estan en el domo");
                }
                else{
                    Hortalizas.enDomo= true;
                    Console.WriteLine("Entrenado los Hortalizas al domo. Estado enDomo: "+ Hortalizas.enDomo);
                }

                Seccion Frutales = Secciones.FirstOrDefault(s=> s.Tipo =="Frutales") as Seccion ;
                if(Frutales.enDomo == true){
                    Console.WriteLine("Los Frutales ya estan en el domo");
                }
                else{
                    Frutales.enDomo= true;
                    Console.WriteLine("Entrenado los Frutales al domo. Estado enDomo: "+ Frutales.enDomo);
                }

                Seccion Ornamentales = Secciones.FirstOrDefault(s=> s.Tipo =="Ornamentales") as Seccion ;
                if(Ornamentales.enDomo == true){
                    Console.WriteLine("Los Ornamentales ya estan en el domo");
                }
                else{
                    Ornamentales.enDomo= true;
                    Console.WriteLine("Entrenado los Ornamentales al domo. Estado enDomo: "+ Ornamentales.enDomo);
                }               

                 //Seccion todasSecciones = Secciones.Where(s=> s.enDomo = false) as Seccion ;
                 //todasSecciones.enDomo = true;     Intenté hacerlo de esta manera pero no pude  
                
                
            }
            else{
                Console.WriteLine("La probabilidad no es adecuada para usar el domo");
                
            }
            return Secciones;
        }
        public List<Seccion> sacarDomo(int probabilidadTornado,RepositorioCultivo Datos,List<Seccion> Secciones){
            if(probabilidadTornado < 80){
                
                
                Seccion Cereales = Secciones.FirstOrDefault(s=> s.Tipo =="Cereales") as Seccion;
                if(Cereales.enDomo==false){
                    Console.WriteLine("Los cereales no estan en el domo para ser retirados");
                }
                else{
                    Cereales.enDomo=false;
                     Console.WriteLine("Sacando Cereales. Estado enDomo: "+ Cereales.enDomo);
                }
                
                Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
                if(Hortalizas.enDomo==false){
                    Console.WriteLine("Las Hortalizas no estan en el domo para ser retirados");
                }
                else{
                    Hortalizas.enDomo=false;
                    Console.WriteLine("Sacando Hortalizas. Estado enDomo: "+ Hortalizas.enDomo);
                }

                Seccion Frutales = Secciones.FirstOrDefault(s=> s.Tipo =="Frutales") as Seccion ;
                 if(Frutales.enDomo==false){
                    Console.WriteLine("Las Frutales no estan en el domo para ser retirados");
                }
                else{
                    Frutales.enDomo=false;
                    Console.WriteLine("Sacando Frutales. Estado enDomo: "+ Frutales.enDomo);
                }

                Seccion Ornamentales = Secciones.FirstOrDefault(s=> s.Tipo =="Ornamentales") as Seccion ;
                if(Ornamentales.enDomo==false){
                    Console.WriteLine("Las Ornamentales no estan en el domo para ser retirados");
                }
                else{
                    Ornamentales.enDomo=false;
                    Console.WriteLine("Sacando Ornamentales. Estado enDomo: "+ Ornamentales.enDomo);
                }
            }

                return Secciones;    
                
            }
           
            

        }
        }
        



     #endregion Methods

