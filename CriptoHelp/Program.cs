using System;

namespace CriptoHelp
{
    class MainClass
    {


        public static string AlfaNumerico(string x)
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
            return y.ToString();
        }
            public static int ParOuImpar(int x)
             {
                 int resultado;

                 resultado = x % 2;
           
            if (resultado == 1)
            {
                return 1; 
            }
                return 0;

                     
             }
           /*  public static string Encryption(string x ){

             }

             public static string Decryption(string x){

             }*/
        
        public static void Main(string[] args)
        {
            int option,tamanho, y;
            string text;
            Console.WriteLine("Hello From CriptoHelp!!\n HOW CAN I HELP YOU ?? (1 - encryption/ 2 - decryption)");
                option = int.Parse(Console.ReadLine());


            if (option == 1)
            {
                 
                Console.WriteLine("Type your phrase: ");
                text = Console.ReadLine();
                text = text.Replace(" ", string.Empty); // substitui os espaços 
                tamanho = ParOuImpar(text.Length);

                if (tamanho == 1){
                    text = text + "H";
                }

                y = text.Length / 2;


                string[,] matriz = new string[2,y];
                int c;
                c = 0;
                for (int iLinha = 0; iLinha < 2; iLinha++){

                    for (int z = 0; z < y ; z++)  {
                      
                        matriz[iLinha,z] = AlfaNumerico(text[c].ToString());
                        c++;
                        Console.WriteLine("matriz [{0},{1}] : {2}",iLinha +1, z+1, matriz[iLinha,z]);

                    }

                    Console.WriteLine("\n");
                }
                //numbers = AlfaNumerico(text);
                //Console.WriteLine("numbers:" + numbers.ToString());
            }
            else if (option == 2)
            {
                //run class of decryption
            }else {
                Console.WriteLine("Invalid operation... you have to choose between 1 or 2 ");
            }

        }

    }
}
