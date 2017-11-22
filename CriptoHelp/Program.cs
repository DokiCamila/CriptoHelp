using System;

namespace CriptoHelp
{
    class MainClass
    {
        public static string NumericoAlfa(int x)
        {
            string y;
            y = "";
            switch (x)
            {
                case 0:
                    y = "A";
                    break;

                case 1:
                    y = "B";
                    break;

                case 2:
                    y = "C";
                    break;

                case 3:
                    y = "D";
                    break;

                case 4:
                    y = "E";
                    break;

                case 5:
                    y = "F";
                    break;

                case 6:
                    y = "G";
                    break;

                case 7:
                    y = "H";
                    break;

                case 8:
                    y = "I";
                    break;

                case 9:
                    y = "J";
                    break;

                case 10:
                    y = "K";
                    break;

                case 11:
                    y = "L";
                    break;

                case 12:
                    y = "M";
                    break;

                case 13:
                    y = "N";
                    break;

                case 14:
                    y = "O";
                    break;

                case 15:
                    y = "P";
                    break;

                case 16:
                    y = "Q";
                    break;

                case 17:
                    y = "R";
                    break;

                case 18:
                    y = "S";
                    break;

                case 19:
                    y = "T";
                    break;

                case 20:
                    y = "U";
                    break;

                case 21:
                    y = "V";
                    break;

                case 22:
                    y = "W";
                    break;

                case 23:
                    y = "X";
                    break;

                case 24:
                    y = "Y";
                    break;

                case 25:
                    y = "Z";
                    break;

                default:
                    Console.WriteLine("Numero Inválido!!");
                    break;
            }

            return y;
        }
        
        public static int AlfaNumerico(string x)
        {
            int y;
            x = x.ToUpper();

            y = -1;

            switch (x)
            {
                case "A":
                    y = 0;
                    break;
                case "B":
                    y = 1;
                    break;
                case "C":
                    y = 2;
                    break;
                case "D":
                    y = 3;
                    break;
                case "E":
                    y = 4;
                    break;
                case "F":
                    y = 5;
                    break;
                case "G":
                    y = 6;
                    break;
                case "H":
                    y = 7;
                    break;
                case "I":
                    y = 8;
                    break;
                case "J":
                    y = 9;
                    break;
                case "K":
                    y = 10;
                    break;
                case "L":
                    y = 11;
                    break;
                case "M":
                    y = 12;
                    break;
                case "N":
                    y = 13;
                    break;
                case "O":
                    y = 14;
                    break;
                case "P":
                    y = 15;
                    break;

                case "Q":
                    y = 16;
                    break;

                case "R":
                    y = 17;
                    break;
                case "S":
                    y = 18;
                    break;
                case "T":
                    y = 19;
                    break;

                case "U":
                    y = 20;
                    break;

                case "V":
                    y = 21;
                    break;

                case "W":
                    y = 22;
                    break;

                case "X":
                    y = 23;
                    break;
                case "Y":
                    y = 24;
                    break;

                case "Z":
                    y = 25;
                    break;

                default:
                    Console.WriteLine("Caractere Inválido!!");
                    break;
            }
            return y;
        }
            public static int ParOuImpar(int x)
             {
            //Verifica se a frase contem numeros pares 
                 int resultado;

                 resultado = x % 2;
           
            if (resultado == 1)
            {
                return 1; 
            }
                return 0;

                     
             }


        public static void Main(string[] args)
        {

            int[,] chave = new int[2, 2];
            int[,] resultado;
            int tamanho, y ;
            int i, j;
            string option, text;
            string[] cifrada;
            Console.WriteLine("Hello From CriptoHelp!!\n HOW CAN I HELP YOU ?? (1 - encryption/ 2 - decryption)");
                option = Console.ReadLine();


            if (option == "1")
            {
                Console.WriteLine("Type your phrase: ");
                text = Console.ReadLine();
                text = text.Replace(" ", string.Empty); // substitui os espaços 
                tamanho = ParOuImpar(text.Length);
                Console.WriteLine("Seu texto contem {0} letras :" , text.Length);
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Type your key[{0},{1}]: ", i + 1, j + 1);
                        chave[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                //Adiciona mais uma letra
                if (tamanho == 1){
                    text = text + "H";
                }

                //Numero de colunas na matriz
                y = text.Length / 2;

                // Transformando em numeros
                int[,] texto = new int[2,y];

                int l;
                l = 0;
                for (i = 0; i < 2; i++){

                    for ( j = 0;j < y ; j++)  {
                      
                        texto[i,j] = AlfaNumerico(text[l].ToString());
                        l++;
                        Console.WriteLine("matriz [{0},{1}] : {2}",i +1, j+1, texto[i,j]);

                    }

                    Console.WriteLine("\n");
                }
                Console.ReadLine();
                resultado = new int[2, y];
                int res=0;
                /// MATRIZ GERADA///

                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < y; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            res += ( chave[i, k] * texto[k, j] );
                        } 

                        resultado[i, j] = res;
                        res = 0;
                    }
                }

               /* Console.WriteLine("\n Matriz gerada");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("{0}", resultado[i, j]);
                    }
                }*/

                Console.WriteLine("\n Matriz com modulo 26");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < y; j++)
                    {
                        resultado[i, j] = (resultado[i, j] % 26);
                        Console.WriteLine("{0}", resultado[i, j]);

                    }
                }
                cifrada = new string[text.Length];
                for (int k = 0; k < text.Length;k++){
                    for (i = 0; i < 2; i++)
                    {
                        int h;
                        h = 0;
                        for (j = 0; j < y; j++)
                        {

                            cifrada[k] += NumericoAlfa(resultado[i, j]);
                            h++;
                        }
                    }

                }

                Console.Write("The cipher phrase: " + cifrada[i]);

            }

            else if (option == "2")
            {
                Console.WriteLine("Type your phrase: ");
                text = Console.ReadLine();
                text = text.Replace(" ", string.Empty); // substitui os espaços 
                Console.WriteLine("Seu texto contem {0} letras :" , text.Length);
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Type your key[{0},{1}]: ", i + 1, j + 1);
                        chave[i, j] = int.Parse(Console.ReadLine());
                    }
                }



                //Numero de colunas na matriz
                y = text.Length / 2;

                // Transformando em numeros
                int[,] texto = new int[2,y];

                int l;
                l = 0;
                for (i = 0; i < 2; i++){

                    for ( j = 0;j < y ; j++)  {
                      
                        texto[i,j] = AlfaNumerico(text[l].ToString());
                        l++;
                        Console.WriteLine("matriz [{0},{1}] : {2}",i +1, j+1, texto[i,j]);

                    }

                    Console.WriteLine("\n");
                }


                //Começo dos calculos de chave 
                int[,] chaveInversa = new int[2, 2];
                int  det, a, b, c, d;



                det = 0;
                det = (chave[0, 0] * chave[1, 1]) - (chave[0, 1] * chave[1, 0]);
                //Console.WriteLine("Seu determinante é de :" + det);

                if (det == 1)

                {
                    det = 1;
                }
                else if (det == 3)
                {
                    det = 9;
                }
                else if (det == 5)
                {
                    det = 21;
                }
                else if (det == 7)
                {
                    det = 15;
                }
                else if (det == 9)
                {
                    det = 3;
                }
                else if (det == 11)
                {
                    det = 19;
                }
                else if (det == 15)
                {
                    det = 7;
                }
                else if (det == 17)
                {
                    det = 23;
                }
                else if (det == 19)
                {
                    det = 11;
                }
                else if (det == 21)
                {
                    det = 5;
                }
                else if (det == 23)
                {
                    det = 17;
                }
                else if (det == 25)
                {
                    det = 25;
                }
                else
                {
                    Console.WriteLine("Error...");
                }

                a = chave[0, 0];
                b = chave[0, 1];
                c = chave[1, 0];
                d = chave[1, 1];

               

                chaveInversa[0, 0] = d;
                chaveInversa[0, 1] = b *(-1);
                chaveInversa[1, 0] = c*(-1);
                chaveInversa[1, 1] = a;
                do
                {
                    chaveInversa[0, 1] = chaveInversa[0, 1] + 26; 

                } while (chaveInversa[0, 1] < 0);
                 
                do
                {
                    chaveInversa[1, 0] = chaveInversa[1, 0] + 26;

                } while (chaveInversa[1, 0] < 0);

                //Console.WriteLine("\nSeu det é de: " + det);


                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("chaveInversa[{0},{1}]: {2}", i + 1, j + 1, chaveInversa[i, j]);
                        chaveInversa[i, j] = (det * chaveInversa[i, j]) % 26;


                    }
                }
               /* chaveInversa[0, 1] = ( chaveInversa[0, 1]* (-1));
                chaveInversa[1, 0] = (chaveInversa[0, 1]*(-1));*/

                Console.WriteLine("\n");

              /*  for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("chaveInversa[{0},{1}]: {2}", i + 1, j + 1, chaveInversa[i, j]);



                    }
                }*/
                resultado = new int[2, y];
                int res = 0;
                /// MATRIZ GERADA///

                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < y; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            res += (chaveInversa[i, k] * texto[k, j]);
                        }

                        resultado[i, j] = res;
                        res = 0;
                    }
                }

               /* Console.WriteLine("\n Matriz gerada");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("{0}", resultado[i, j]);
                    }
                }*/

                Console.WriteLine("\n Matriz com modulo 26");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < y; j++)
                    {
                        resultado[i, j] = (resultado[i, j] % 26);


                    }
                }
                cifrada = new string[text.Length];
                for (int k = 0; k < text.Length; k++)
                {
                    for (i = 0; i < 2; i++)
                    {
                        int h;
                        h = 0;
                        for (j = 0; j < y; j++)
                        {

                            cifrada[k] += NumericoAlfa(resultado[i, j]);
                            h++;
                        }
                    }

                }

                Console.Write("The original phrase: " + cifrada[i]);






            }else {
                Console.WriteLine("Invalid operation... you must have to choose between 1 or 2 ");
            }

        }

    }
}
