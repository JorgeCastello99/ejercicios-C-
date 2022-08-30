using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           int menu=1;
            while(menu !=0){
            Console.WriteLine("Elije uno de estos ejercicios o salir: \n");
            Console.WriteLine("0- Salir \n1- Resta Positiva \n2- EsRea\n3- ConversMonetaria \n4- CifrasNum\n5- ParImpar\n6- SumaInterv\n7- Primo\n8- Potencia \n9- SumCifras\n10- Descuento\n11- Quiniela\n12- Piramide\n13- Vector\n14- Agenda\n");

            menu = int.Parse(Console.ReadLine());
            
                switch (menu){
                    case 0:
                       
                        break;
                    case 1:
                        Ejer1();
                    break;
                case 2:
                    Ejer2();
                    break;
                case 3:
                    Ejer3();
                    break;
                case 4:
                        Ejer4();
                    break;
                case 5:
                        Ejer5();
                    break;
                case 6:
                        Ejer6();
                    break;
                case 7:
                        Ejer7();
                    break;
                case 8:
                        Ejer8();
                    break;
                case 9:
                        Ejer9();
                    break;
                case 10:
                        Ejer10();
                    break;
                case 11:
                        Ejer11();
                    break;
                case 12:
                        Ejer12();

                    break;
                case 13:
                        Ejer13();
                    break;
                case 14:

                    break;
            }
             
        }
        }
    
                //Ejercicio 1
                static void Ejer1(){
                    bool num, num2;
                int total,x,y;
                do{
                    Console.WriteLine("dame primer numero");
                    num =int.TryParse(Console.ReadLine(), out x);
                    
                    Console.WriteLine("dame primer numero");
                    num2 = int.TryParse(Console.ReadLine(), out y);
                   }while(!num && !num2);
                    
                       

                    total = Math.Abs(x - y);
                    Console.WriteLine("El total es:" + total+"\n");
                     
                }


                //Ejercicio 2
                static void Ejer2(){
                     int num;
                    Console.WriteLine("dame numero para saber si tiene parte fraccionaria o no");
                    num = int.Parse(Console.ReadLine());
                    

                }

                //Ejercicio 3
                static void Ejer3(){
                     double num;
                      String num2;
                     double totalpe;
                     double totaleu;
                      
                    Console.WriteLine("dame un numero real");
                     num =double.Parse(Console.ReadLine());

                 do{
                             Console.WriteLine("¬øQuieres convertirlo de peseta a euros o de euro a pesetas? 1/2");
                                 num2 = Console.ReadLine();
                            if(num2.Equals("1")){
                                
                                Console.WriteLine("Has elegido convertir peseta a euros\n");
                                totaleu=num/166.386;
                                 Console.WriteLine(Math.Round(totaleu,2)+" euros\n");
                        
                            }
                            if(num2.Equals("2")){
                                Console.WriteLine("Has elegido convertir euro a pesetas\n");
                                   Console.WriteLine("Has elegido convertir euro a peseta\n");
                                totalpe=num * 166.386;
                                 Console.WriteLine(Math.Round(totalpe,2)+" pesetas\n");
                        
                            }
                            else{
                            Console.WriteLine("No has seleccionado la opcion correctamente");
                            }
                    }
                    while(!num2.Equals("1") && !num2.Equals("2"));

                }


                 //Ejercicio 4
                static void Ejer4(){
                     int num;
                    Console.WriteLine("dame numero entero de no mas de 5 cifras para calcular las cifras que tiene dicho numero.");
                    num = int.Parse(Console.ReadLine());
                       int contador =1;
                       int control =10;
	
                    if(num<99999){
                       while(control <= num){
                            contador = contador +1;
                            control =control * 10;
                        }
                         Console.WriteLine("La cantidad de cifras de "+num+" son: "+contador);
                    }
                    else{
                         Console.WriteLine("has dado mas de 5 cifras \n");
                    }

                }
                


                  //Ejercicio 5
                static void Ejer5(){
                     int num,num2;
                       String eleccion;
                    Console.WriteLine("dame numero ");
                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("dame numero ");
                    num2 = int.Parse(Console.ReadLine());

                do{

                    Console.WriteLine("Que numero quieres, pares o impares: par/impar");
                    eleccion=Console.ReadLine();
                        if(eleccion.Equals("par")){
                                if(num <num2){
                                    num=num+1;
                                    for(int i=num;i<num2;i++){
                                        if(i%2==0){
                                            Console.WriteLine(i);
                                        }                                                
                                  
                                    }

                                }
                                else{
                                      num2=num2+1;
                                    for(int i=num2;i<num;i++){
                                        if(i%2==0){
                                            Console.WriteLine(i);
                                        }                                                
                                     
                                    }
                                }


                        }
                         else if(eleccion.Equals("impar")){
                                  if(num <num2){
                                    num=num+1;
                                    for(int i=num;i<num2;i++){
                                        if(i%2!=0){
                                            Console.WriteLine(i);
                                        }                                                
                                      
                                    }

                                }
                                else{
                                      num2=num2+1;
                                    for(int i=num2;i<num;i++){
                                        if(i%2!=0){
                                            Console.WriteLine(i);
                                        }                                                
                                        
                                    }
                                }



                        }
                        else{
                           Console.WriteLine("Seleccion erronea");
                        }

                }while(!eleccion.Equals("par") && !eleccion.Equals("impar"));
                    Console.WriteLine("\n");
                }




                 //Ejercicio 6
                static void Ejer6(){
                     int x,y,total=0;
                    Console.WriteLine("dame numero x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame numero y");
                    y = int.Parse(Console.ReadLine());
                    
                  for(int i=x;i<=y;i++){
                    total=total+i;
                  }
                   Console.WriteLine("El total de la suma de los numeros comprendidos entre"+x+" e "+y+" son: "+total+"\n");

                }
                    

                    //Ejercicio 7
                static void Ejer7(){
           
                     int num;
                    Console.WriteLine("dame numero para saber si es primo o no");
                    num = int.Parse(Console.ReadLine());
                       
                     int bucle=0;  
                    for(int i=1;i<=num;i++){
                      
                      if(num%i==0){
                        bucle++;
                      }
                        

                    }
                    if(bucle==2){
                         Console.WriteLine("Es primo\n");
                    }
                    else{
                         Console.WriteLine("No es primo\n");
                     }
                     
                }
                

                 //Ejercicio 8
                static void Ejer8(){
                     int basex, exponentey;
                    Console.WriteLine("dame la base de la potencia");
                    basex = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame el exponente depotencia");
                    exponentey = int.Parse(Console.ReadLine());

                      int total=1;  
            
                    for(int i=1;i<=exponentey;i++){

                        total= total *basex;
                    }
                    Console.WriteLine("El total de la potencia es: "+ total+"\n");
                   

                }


                  //Ejercicio 9
                static void Ejer9(){
                    
                    bool vale;

                    int numero,total,totalto=0;
                    string numeros;
                      do{
                        Console.WriteLine("dame numero de no mas de 5 cifras");
                          vale = int.TryParse(Console.ReadLine(), out numero);
                          
                      }while(!vale || numero>99999);
                      
                  numeros=numero.ToString();
                      for(int i=0; i<numeros.Length;i++){
                            total=numero%10;
                              numero=numero/10;
                             totalto=totalto+total;
                       }
                       Console.WriteLine(totalto+"\n");


                }
                  


                   //Ejercicio 10
                static void Ejer10(){
                    
                    int compra;
                    int total,total2;
                        Console.WriteLine("Importe de compra");
                        compra=int.Parse(Console.ReadLine());

                          if(compra<200){
                                 Console.WriteLine("No se aplica descuento\n El precio total es "+compra);
                          } 
                          if(compra>=200 && compra<500){
                                total=(compra*5)/100;
                                total2=compra-total;
                                 Console.WriteLine(" se aplica descuento de 10%\n El precio total es "+ total2);
                          }
                          if(compra>500 && compra <1000){
                                total=(compra*10)/100;
                                     total2=compra-total;
                                 Console.WriteLine(" se aplica descuento de 10%\n El precio total es "+ total2);
                          }
                          if(compra>1000){
                                 total=(compra*15)/100;
                                 total2=compra-total;
                                 Console.WriteLine(" se aplica descuento de 10%\n El precio total es "+ total2);
                          }
                      


                }
                
                  //Ejercicio 11
                static void Ejer11(){
                    int azar;
                    Random random=new Random();
                    string[] partidos=new string []{"Real madrid vs Toledo","Barcelona vs Betis","Sevilla vs Albacete","Cuenca vs Granada","Ciudad real vs Lugo","Espa√±a vs Brasil","Alemania vs Francia"};
                   Console.WriteLine("\n");
                        for(int i=0;i<partidos.Length;i++){
                             azar=random.Next(1,4);
                         
                            if(azar==3){
                            Console.WriteLine(partidos[i]+": x ");
                       
                            }
                            else{Console.WriteLine(partidos[i]+": "+azar);
                        
                             }
                            
                        
                    } Console.WriteLine("\n");

                      


                }
        
                 //Ejercicio 12
                static void Ejer12(){
                int numero;
                
                Console.WriteLine("Dame numero");
                 numero=int.Parse(Console.ReadLine());
                
                for(int i=1;i<=numero;i++){
                    
                    Console.Write(1+"\n");
                    if(i=a){
                        
                    }
                }    

                   Console.WriteLine("\n");
                    
                    

                }
                

        
                 //Ejercicio 13
                static void Ejer13(){
                int numero;
                
                Console.WriteLine("Dame numero");
                 numero=int.Parse(Console.ReadLine());
                    switch(numero){
                        case 1:
                                int[] ar=new int[6];
                      Random random=new Random();
                            for(int i=0;i<ar.Length;i++){
                                ar[i]=random.Next();
                            }
                                
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;

                    }

                   Console.WriteLine("\n");
                    
                      


                }

                  //Ejercicio 14
                static void Ejer14(){
                int numero;
                
                Console.WriteLine("Dame numero");
                 numero=int.Parse(Console.ReadLine());
                    switch(numero){
                        case 1:
                                int[] ar=new int[6];
                      Random random=new Random();
                            for(int i=0;i<ar.Length;i++){
                                ar[i]=random.Next();
                            }
                                
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
           ãÒI±Å>î§∂d‡jD·ÚˆîÃ[ÉÍKJª@íÓù't˚1:tõH∫@á&Ì‰´nfègoÚ¶<	(=ª&S(†4;≥⁄{[ÃéÒ 
+ìÔÉ≥´ô§·6bâ§Ã}‡ôäπP˝94ú)è‘ß∆ŸÀ˛ıjÙ·√+ÂòÚé”Ü¡˜”32Y⁄â÷µ	Õ≈3‹)ÊXınª⁄hLz‡œò^b+≥Ù'"∞A≈«“!bå¡ﬁw¯— rÊ¨Ÿ–Óº21 £õ‚
sê∆û_˘3Úµ≈ï√/€™a_æ@(´Ä˛Å∂bè‰†û&±)J~≠ê.1Mä2ã·ç…8Pâk≠È|©PÍıº◊lÇ[