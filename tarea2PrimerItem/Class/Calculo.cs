
namespace tarea2PrimerItem.Class
{
    public class Calculo
    {
        public void Condicional()
        {
            int PrimerNumero = 0;
            int SegundoNumero = 0;
            int suma = 0;
            decimal division = 0;


            try
            {
               

                Console.WriteLine("Inserte el primer numero:");
                PrimerNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserte el segundo numero:");
                SegundoNumero = Convert.ToInt32(Console.ReadLine());


                if (PrimerNumero > SegundoNumero)
                {

                    suma = PrimerNumero + SegundoNumero;

                    Console.WriteLine($"El pimer numero es mayor que el primero, La suma de los dos valores da un resultado de:{suma} ");

                }

                else {
                    division = SegundoNumero / PrimerNumero;

                    Console.WriteLine($"El segundo valor es mayor que el primero, la divicion de los dos valores da un resultado de:{division}");


                }
                    
                
                

            
            }
            catch ( Exception ex )
            {
                Console.WriteLine ($"Ocurrio un error al determinar cual es el numero mayor {ex}");
            }





        }


    }
    }
