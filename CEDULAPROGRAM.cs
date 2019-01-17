using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACEDULA
{
    class Program
    {

        public void digitar()
        {

            long numero, numero2, numero3, numero4;

            String dato, dato2, dato3, dato4;
            Console.Write("Buenas, Bienvenido");
            Console.Write("\n\nEn este programa solo podra comparar dos cedulas a la vez");
            Console.Write("\n\nPor favor seguir este patron al digitar la cedula: 000-0000000-0");

            Console.Write("\n\nDigite el numero de cedula : ");
            dato = Console.ReadLine();


            Console.Write("\n\nDigite el numero de cedula : ");
            dato2 = Console.ReadLine();

            dato3 = dato.Replace("-", "");
            dato4 = dato2.Replace("-", "");
            numero = Convert.ToInt64(dato3);
            numero2 = Convert.ToInt64(dato4);

            if (numero==numero2)
            {
                Console.Write("\n\nLas cedulas introducidas son iguales");
            }else if (numero != numero2)
            {
                numero3 = (((numero % 1000) % 100) % 10);
            //Console.Write("\n\nEl ultimo digito del numero es: " + numero3);

            numero4 = (((numero2 % 1000) % 100) % 10);
            // Console.Write("\n\nEl ultimo digito del numero es: " + numero4);

            if (numero3 != numero4)
            {
                if (numero3 > numero4)
                {
                    Console.Write("\n\nLa Cedula mayor es: " + dato);
                    Console.Write("\n\nLa Cedula menor es: " + dato2);
                }
                else if (numero3 < numero4)
                {
                    Console.Write("\n\nLa Cedula mayor es: " + dato2);
                    Console.Write("\n\nLa Cedula menor es: " + dato);
                }
            }
            else if (numero3 == numero4)
            {

                string cadena = dato3;
                char dato5;
                dato5 = cadena[9];
                int numero5 = Convert.ToInt32(dato5);
                // Console.WriteLine("{0}", cadena[9]);
                string cadena2 = dato4;
                char dato6;

                dato6 = cadena2[9];
                int numero6 = Convert.ToInt32(dato6);
                //Console.WriteLine("{0}", cadena2[9]);

                if (numero5 > numero6)
                {
                    Console.Write("\n\nLa Cedula mayor es: " + dato);
                    Console.Write("\n\nLa Cedula menor es: " + dato2);
                }
                else if (numero5 < numero6)
                {
                    Console.Write("\n\nLa Cedula mayor es: " + dato2);
                    Console.Write("\n\nLa Cedula menor es: " + dato);
                }
                else if (numero5 == numero6)
                {
                    string cadena3 = dato3;
                    char dato7;
                    dato7 = cadena3[8];
                    int numero7 = Convert.ToInt32(dato7);
                    //Console.WriteLine("{0}", cadena3[8]);

                    string cadena4 = dato4;
                    char dato8;
                    dato8 = cadena4[8];
                    int numero8 = Convert.ToInt32(dato8);
                    //Console.WriteLine("{0}", cadena4[8]);

                    if (numero7 > numero8)
                    {
                        Console.Write("\n\nLa Cedula mayor es: " + dato);
                        Console.Write("\n\nLa Cedula menor es: " + dato2);
                    }
                    else if (numero7 < numero8)
                    {
                        Console.Write("\n\nLa Cedula mayor es: " + dato2);
                        Console.Write("\n\nLa Cedula menor es: " + dato);
                    }
                    else if (numero7 == numero8)
                    {
                        string cadena5 = dato3;
                        char dato9;
                        dato9 = cadena3[8];
                        int numero9 = Convert.ToInt32(dato9);
                       // Console.WriteLine("{0}", cadena5[7]);

                        string cadena6 = dato4;
                        char dato10;
                        dato10 = cadena6[7];
                        int numero10 = Convert.ToInt32(dato10);
                        // Console.WriteLine("{0}", cadena6[7]);

                        if (numero9 > numero10)
                        {
                            Console.Write("\n\nLa Cedula mayor es: " + dato);
                            Console.Write("\n\nLa Cedula menor es: " + dato2);
                        }
                        else if (numero9 < numero10)
                        {
                            Console.Write("\n\nLa Cedula mayor es: " + dato2);
                            Console.Write("\n\nLa Cedula menor es: " + dato);
                        }
                        else if (numero9 == numero10)
                        {
                            string cadena7 = dato3;
                            char dato11;
                            dato11 = cadena7[6];
                            int numero11 = Convert.ToInt32(dato11);
                            // Console.WriteLine("{0}", cadena5[6]);

                            string cadena8 = dato4;
                            char dato12;
                            dato12 = cadena8[6];
                            int numero12 = Convert.ToInt32(dato12);
                            // Console.WriteLine("{0}", cadena6[6]);

                            if (numero11 > numero12)
                            {
                                Console.Write("\n\nLa Cedula mayor es: " + dato);
                                Console.Write("\n\nLa Cedula menor es: " + dato2);
                            }
                            else if (numero11 < numero12)
                            {
                                Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                Console.Write("\n\nLa Cedula menor es: " + dato);
                            }
                            else if (numero11 == numero12)
                            {
                                string cadena9 = dato3;
                                char dato13;
                                dato13 = cadena9[5];
                                int numero13 = Convert.ToInt32(dato13);
                                // Console.WriteLine("{0}", cadena5[5]);

                                string cadena10 = dato4;
                                char dato14;
                                dato14 = cadena10[5];
                                int numero14 = Convert.ToInt32(dato14);
                                // Console.WriteLine("{0}", cadena6[5]);

                                if (numero13 > numero14)
                                {
                                    Console.Write("\n\nLa Cedula mayor es: " + dato);
                                    Console.Write("\n\nLa Cedula menor es: " + dato2);
                                }
                                else if (numero13 < numero14)
                                {
                                    Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                    Console.Write("\n\nLa Cedula menor es: " + dato);
                                }
                                else if (numero13 == numero14)
                                {
                                    string cadena11 = dato3;
                                    char dato15;
                                    dato15 = cadena11[4];
                                    int numero15 = Convert.ToInt32(dato15);
                                    // Console.WriteLine("{0}", cadena5[4]);

                                    string cadena12 = dato4;
                                    char dato16;
                                    dato16 = cadena12[4];
                                    int numero16 = Convert.ToInt32(dato16);
                                    // Console.WriteLine("{0}", cadena6[4]);

                                    if (numero15 > numero16)
                                    {
                                        Console.Write("\n\nLa Cedula mayor es: " + dato);
                                        Console.Write("\n\nLa Cedula menor es: " + dato2);
                                    }
                                    else if (numero15 < numero16)
                                    {
                                        Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                        Console.Write("\n\nLa Cedula menor es: " + dato);
                                    }
                                    else if (numero15 == numero16)
                                    {
                                        string cadena13 = dato3;
                                        char dato17;
                                        dato17 = cadena13[3];
                                        int numero17 = Convert.ToInt32(dato17);
                                        // Console.WriteLine("{0}", cadena5[3]);

                                        string cadena14 = dato4;
                                        char dato18;
                                        dato18 = cadena14[4];
                                        int numero18 = Convert.ToInt32(dato18);
                                        // Console.WriteLine("{0}", cadena6[3]);

                                        if (numero17 > numero18)
                                        {
                                            Console.Write("\n\nLa Cedula mayor es: " + dato);
                                            Console.Write("\n\nLa Cedula menor es: " + dato2);
                                        }
                                        else if (numero17 < numero18)
                                        {
                                            Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                            Console.Write("\n\nLa Cedula menor es: " + dato);
                                        }
                                        else if (numero17 == numero18)
                                        {
                                            string cadena15 = dato3;
                                            char dato19;
                                            dato19 = cadena15[2];
                                            int numero19 = Convert.ToInt32(dato19);
                                            // Console.WriteLine("{0}", cadena5[2]);

                                            string cadena16 = dato4;
                                            char dato20;
                                            dato20 = cadena16[2];
                                            int numero20 = Convert.ToInt32(dato20);
                                            // Console.WriteLine("{0}", cadena6[2]);

                                            if (numero19 > numero20)
                                            {
                                                Console.Write("\n\nLa Cedula mayor es: " + dato);
                                                Console.Write("\n\nLa Cedula menor es: " + dato2);
                                            }
                                            else if (numero19 < numero20)
                                            {
                                                Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                                Console.Write("\n\nLa Cedula menor es: " + dato);
                                            }
                                            else if (numero19 == numero20)
                                            {
                                                string cadena17 = dato3;
                                                char dato21;
                                                dato21 = cadena17[1];
                                                int numero21 = Convert.ToInt32(dato21);
                                                // Console.WriteLine("{0}", cadena5[1]);

                                                string cadena18 = dato4;
                                                char dato22;
                                                dato22 = cadena18[4];
                                                int numero22 = Convert.ToInt32(dato22);
                                                // Console.WriteLine("{0}", cadena6[1]);

                                                if (numero21 > numero22)
                                                {
                                                    Console.Write("\n\nLa Cedula mayor es: " + dato);
                                                    Console.Write("\n\nLa Cedula menor es: " + dato2);
                                                }
                                                else if (numero21 < numero22)
                                                {
                                                    Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                                    Console.Write("\n\nLa Cedula menor es: " + dato);
                                                }
                                                else if (numero21 == numero22)
                                                {
                                                    string cadena19 = dato3;
                                                    char dato23;
                                                    dato23 = cadena19[0];
                                                    int numero23 = Convert.ToInt32(dato23);
                                                    // Console.WriteLine("{0}", cadena5[0]);

                                                    string cadena20 = dato4;
                                                    char dato24;
                                                    dato24 = cadena12[0];
                                                    int numero24 = Convert.ToInt32(dato24);
                                                    // Console.WriteLine("{0}", cadena6[0]);

                                                    if (numero23 > numero24)
                                                    {
                                                        Console.Write("\n\nLa Cedula mayor es: " + dato);
                                                        Console.Write("\n\nLa Cedula menor es: " + dato2);
                                                    }
                                                    else if (numero23 < numero24)
                                                    {
                                                        Console.Write("\n\nLa Cedula mayor es: " + dato2);
                                                        Console.Write("\n\nLa Cedula menor es: " + dato);
                                                    }
                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program MT = new Program();

            MT.digitar();



        }
    }
}