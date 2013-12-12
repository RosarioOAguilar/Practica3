using System;
using System.Collections; // es necesaria por la hashtable

namespace Practica3
{
	public class Proceso
	{
		public Hashtable tabla;// nombre de la hashtable
		public Proceso()
		{
			this.tabla = new Hashtable();//se crea la tabla
		}
		//se muestran los procesos de cada metodo
		public void capturar()
		{
			for(int i=0;  i<4;  i++)// se piden los datos 4 veces 
			{// lo que se pedira al usuario para almacenarlo en la hashtable
				Persona persona = new Persona(); //
			    Console.WriteLine("\n¿Cual es tu Nombre? \n\r");
				persona.nombre = Console.ReadLine();
			    Console.WriteLine("\n¿Cual es tu Codigo? \n\r");
			    persona.codigo = int.Parse(Console.ReadLine());
			    Console.WriteLine("\n¿Cual es tu Telefono? \n\r");
			    persona.tel =  int.Parse(Console.ReadLine());
			    Console.WriteLine("\n¿Cual es tu Facebook? \n\r");
			    persona.face =  Console.ReadLine();
			    this.tabla.Add(persona.codigo, persona);// los datos se agregan en las tabla
                Console.Clear();//limpiamos pantalla y seguir con los demas metodos
			}
		}
		
		public void editar()
		{
			for(int id=0; id<2; id++){// esta accion se va a hacer dos veces
				Console.WriteLine("\r\r\r¿Cual es el Codigo que se editaran los Datos?");
				int codigo = int.Parse(Console.ReadLine());
				if(this.tabla.ContainsKey(codigo)){
				Persona edita= new Persona();
				edita = (Persona)(this.tabla[codigo]);
				
				Console.WriteLine("\n\r*Nombre\n");
				Console.WriteLine(edita.nombre);
				
				Console.WriteLine("\n\r\r*Codigo\n");
				Console.WriteLine(edita.codigo);
				
				Console.WriteLine("\n\r\r\r*Telefono\n");
				Console.WriteLine(edita.tel);
				
				Console.WriteLine("\n\r\r\r\r*Facebook\n");
				Console.WriteLine(edita.face);
				Console.WriteLine("\n Asi se Guardaran \n");
				
				// esto atributos son los que se va a editar
                Console.WriteLine("*Nombre:\n");
                edita.nombre= Console.ReadLine();
                
				Console.WriteLine("*Telefono:\n");
				edita.tel= int.Parse(Console.ReadLine());
				
				Console.WriteLine("*Facebook:\n");
				edita.face=Console.ReadLine();
				System.Console.Clear();	
				
			
				        Console.WriteLine("Presiona cualquier tecla para continuar...");
				        Console.ReadKey();
                        System.Console.Clear();
				}else{
					Console.WriteLine("No existe el codigo");
				        Console.ReadKey();
                        System.Console.Clear();
				}
				
			}				
				
			}
		
		
		public void eliminar()
		{
			for( int el=0; el<2; el++ ){// este proceso se ejecutara dos veces  
				 Persona elimina= new Persona();//busca el codigo y elimina la imaformacion total
				 Console.WriteLine("\n\n\r\r++Codigo de la persona a Eliminar++");
				 elimina.codigo= int.Parse(Console.ReadLine());
				 
				 if(!tabla.ContainsKey(elimina.codigo)){
				Console.WriteLine("Este codigo no existe, favor de Rectificarlo");
				Console.ReadLine();
				System.Console.Clear();
				}
				else{
				 	System.Console.Clear();
					elimina = (Persona)(this.tabla[elimina.codigo]);
				
				Console.WriteLine("-Nombre");
				Console.WriteLine(elimina.nombre);
				
				Console.WriteLine("-telefono");
				Console.WriteLine(elimina.tel);
				
				Console.WriteLine("-facebook");
				Console.WriteLine(elimina.face);
				
				Console.WriteLine("¿Esta seguro de eliminar este Usuario?  presiona \n si  \n  no");
				string res= Console.ReadLine();
				if(res == "si"){
				        this.tabla.Remove(elimina.codigo);
                        Console.WriteLine("Los Datos fueron eliminados Exitosamente");				        
				}
				else{
					   Console.WriteLine("Los Datos estan a salvo");
				}
				Console.WriteLine("Presiona cualquier tecla para continuar...");
				Console.ReadKey();	
			}	 
		    }
			}
		
		public void imprimir()
		{
			Console.Clear();
			
			Console.WriteLine(" Datos Almacenados ");
			
			  IDictionaryEnumerator comparacion = tabla.GetEnumerator();//para generar una comparacion y buscar el dato que se solicita
			     while(comparacion.MoveNext() ){// se compara cada uno de los datos hasta encontrar el que usuario indico
				Persona mostrar=(Persona)(tabla[comparacion.Key]);// la clave se a buscar por medio del enmutador (key)
				
				Console.WriteLine("+Nombre");
				Console.WriteLine(mostrar.nombre);
				
				Console.WriteLine("+Codigo");
				Console.WriteLine(mostrar.codigo);
				
				Console.WriteLine("+telefono");
				Console.WriteLine(mostrar.tel);
					
				Console.WriteLine("+facebook");
				Console.WriteLine(mostrar.face);	
                				
		}
			  Console.ReadLine();
	}
	}
		
}