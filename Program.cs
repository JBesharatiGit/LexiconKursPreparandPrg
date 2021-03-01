using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrgPreparandKurs
{
    class Program
    {
        //Den här programmet består av ett MenySystem med 16 MenyAlternativ som hänvisas till  16 olika funktioner.Användaren 
        //Kan läsa MenuSystemmet och skriver in Nummret av varje MenyAlternativ + trycker på Enter Sedan motsvarande funktionalitet käras.
        //Programmet köras igång tills man väljer MenyAlternativt noll.
        //Det finns också kontroller för att användaren skriver rät tal
        //Man förökte att visar sista MenuAlternativ som har valt i linje 2 för att användaren veta vilken Funktion har körs.
        //På MenyAlternativ 15 det spelar ingen roll man slutar strängen med komm eller ej
        //På MenuAlternativ 16 om intervallet mellan två tal vara stor och behöver mer plats än en sida programmet visar information sidan efter sidan
        //För att funktioner nummer 7 och 8 funkar rät ska man kontrollerar fil adress på göobal varjabler och göra den lämpligt

        
        //global varjabler
        static bool ColorFlag = false;
        static byte IsStop = 1;
        static int menuItem = -1;
        static string fileAddress = @"c:\preparandkurs\Textfile.txt";

        static void Main(string[] args)
        {
            //Sätter Console fönstret stårlik på början
            Console.SetWindowSize(100, 50);
            Console.SetWindowPosition(Console.WindowTop, Console.WindowLeft);

            PrintMenu();// Skriver MenySystemet i console fönster

            while (IsStop != 0)//Programmet hållas igång  tills användaren bestämmer att stänga ner och inmatar talet noll när väljer MenyAlternativ
            {
                PrintRequesMenuItem();//Ber användaren väljer en av de MenyAlternativa
                menuItem = Convert.ToInt32(ChekVaildInput());//Tar användaren MenuAlternativ nummer och Kontrollerar att användaren inmatade ett tal

                switch (menuItem)//Baserde på användarens inmatnings tal,bestämmer vilket funktionalitet  ska köras.
                {
                    case 0:
                        SelectedMenuItem(menuItem);
                        EndingProgram();//Stänger Program
                        break;
                    case 1:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        HellowWorld(); //Den här funktion skriver ut ”Hello World”
                        break;
                    case 2:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        PersonalInfo(); //Den här funktion Tar Förnamn, Efternamn, Ålder från användare och skriver ut dessa i konsole fönster
                        break;
                    case 3:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        ChangTextColor(); //Den här funktion ändrar textensFärg på Blåa och ändrar tillbcaka om Köras igen
                        break;
                    case 4:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        PrintDate(); //Den här funktion skriver ut dagens datum.
                        break;
                    case 5:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        
                        Console.WriteLine("Skriv in första tal!");
                        int FirstNumber = Convert.ToInt32(ChekVaildInput());//Tar användaren Första tal och Kontrollerar att användaren inmatade digital typ                      
                        Console.WriteLine("Skriv in andra tal!");
                        int SecundNumber = Convert.ToInt32(ChekVaildInput());//Tar användaren Andrar tal och Kontrollerar att användaren inmatade digital typ                     
                        
                        Console.WriteLine("Det större tal är : " + GetGreaterNum(FirstNumber, SecundNumber));
                        break;
                    case 6:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        GuessRandomNumber();
                        break;

                    case 7:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        SaveToFile();//Den här funktionen tar en godtikligt text från användaren och sparar i en text fil
                        break;
                    case 8:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        //Console.WriteLine();
                        ReadFromFile(); //Den här funktionen läser texten från filen och skriver ut i Console fönstret
                        break;
                    case 9:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        
                        double InputNumber = double.NaN;//lokal varjabel
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        Console.WriteLine("Skriv in ett decimal tal, får tillbaka \n" +
                                          "Talet roten ur upphöjt till 2,upphöjt till 10)!");
                        InputNumber = ChekVaildInput();//Tar användaren Andrar tal och Kontrollerar att användaren inmatade digital typ                     

                        Console.WriteLine(GetRootPower(InputNumber));
                        break;
                    case 10:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        MultiplyToTen();
                        break;
                    case 11:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        ArrayOrdering();
                        break;
                    case 12:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        Ispalindrom();
                        break;
                    case 13:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        WritingIntervalNo();
                        break;

                    case 14:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        OrderOddEvenNumber();
                        break;
                    case 15:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line
                        AddStringNumbers();
                        break;

                    case 16:
                        PrintMenu();//Den här funktion skriver ut MenySystem på console fönster
                        SelectedMenuItem(menuItem);//Den här funktion sparar och visar MenyAlternativ som har valts på andra line

                        Person MyPerson = new Person();
                        
                        Console.WriteLine("Ange namnet på din karaktär.");
                        MyPerson.YourName = Console.ReadLine();
                        Console.WriteLine("Ange ditt motståndare");
                        MyPerson.Opponent = Console.ReadLine();
                        Random random = new Random();
                        MyPerson.Helsa = random.Next(1, 100);
                        MyPerson.Styrka = random.Next(1, 100);
                        MyPerson.Lucky = random.Next(1, 100);
                        MyPerson.HelsaOpponent = random.Next(1, 100);
                        MyPerson.StyrkaOpponent = random.Next(1, 100);
                        MyPerson.LuckyOpponent = random.Next(1, 100);
                        MyPerson.PrintInfo();
                        break;
                    default:
                        Console.WriteLine("Du valde Meny Item Number  Out of range!");
                        break;
                }
            }
        }

        //0-Den här funktion stänger ner programet och väntar på användaren trycka på knapen på tangenbordet.
        public static void EndingProgram()
        {
            IsStop = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***Programmet är slut.***");
            Console.ResetColor();
            Console.ReadKey();
        }


        //1-Den här funktion skriver ut ”Hello World”
        public static void HellowWorld()
        {
            Console.WriteLine("Hellow World!");
        }

        //2-Den här funktion Tar Förnamn, Efternamn, Ålder från användare och skriver ut dessa i konsole fönster
        public static void PersonalInfo()
        {
            //Lokala varjabler
            string FirstName, LastName;
            int Age=-1;

            //Tar information från användaren
            Console.WriteLine("Skriv in Namn! :");
            FirstName = Console.ReadLine();
            Console.WriteLine("Skriv in EfterNamn! :");
            LastName = Console.ReadLine();
            Console.WriteLine("Skriv in Ålder! :");
            Age = (int)ChekVaildInput();//Tar användaren Andrar tal och Kontrollerar att användaren inmatade digital typ
            //Skriver ut information
            Console.WriteLine("Du är " + FirstName + " " + LastName + " " + " och du är " + Age + " år gammal.");
        }

        //3- Den här funktion ändrar textensFärg på Blåa och ändrar tillbcaka om Köras igen
        public static void ChangTextColor()
        {
            //Kontrollerar om nuvarande färgen är förinställt eller nej
            //Om det var förinställt färg byter den till blåa annars byter tillbaka till förinställd färg
            if (ColorFlag == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Fär på texten har ändrats!");
                ColorFlag = true;
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("Fär på texten har ändrats  tillbaka !");
                ColorFlag = false;
            }

        }

        //4-Den här funktion skriver ut dagens datum.
        public static void PrintDate()
        {
            Console.WriteLine("Idag är : " + DateTime.Now);
        }

        //5- Den här funktion Tar två input värden, sedan skriver ut vilket av dem som är störst.
        public static int GetGreaterNum(int FirstNumber, int SecundNumber)
        {
            return (FirstNumber < SecundNumber) ? SecundNumber : FirstNumber;

        }

        //6-Funktion som genererar att slumpmässigt tal mellan 1 och 100. Användaren ska sedan
        //    gissa talet. Gissar användaren rätt så ska ett meddelande säga detta, samt hur många 
        //    försök det tog. Gissar användaren fel ska ett meddelande visas som informerar ifall
        //    talet var för stort eller för litet
        public static void GuessRandomNumber()
        {
            int guessNumber = -1;
            int counter = 0;
            
            Random randomValue = new Random();// Skapar en slumplig varjabel
            int rndnumber = randomValue.Next(1, 100);//Skapar ett slumpligt tall mellan 1-100
           
            while (rndnumber != guessNumber)
            {
                counter++;

                Console.WriteLine("Skriv in gissade tal!");
                guessNumber = Convert.ToInt32(ChekVaildInput());//Tar gissade tal och kontrollerar att användaren inmatade digital typ
                
                if (guessNumber == rndnumber)
                    Console.WriteLine("Gissade [RÄTT]!"+" Antalet av försök :["+counter+"]");
                else
                    if (guessNumber < rndnumber)
                    Console.WriteLine("Gissade [FÖR LITET]!");
                else
                    Console.WriteLine("Gissade [FÖR STORT]!");
            }
        }

        //7-Den här funktionen tar en godtikligt text från användaren och sparar i en text fil
        public static void SaveToFile()
        {
           //Tar text från användaren
            Console.WriteLine();
            Console.WriteLine("Skriv in en textrad. ");
            string text = Console.ReadLine();

            //Sparar texten i en text fil
            try
            {
                StreamWriter fWriter = new StreamWriter(fileAddress, true);//görs en new Streamwriter med bestämd fil adress

                fWriter.WriteLine(text);//skriver användaren text i fil
                fWriter.Close();//stänger ner streamwritern
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error :"+exc.Message);
            }
        }

        //8- Den här funktionen läser texten från filen och skriver ut i Console fönstret
        public static void ReadFromFile()
        {
            try
            {
                StreamReader freader = new StreamReader(fileAddress);//görs en new Streamreder med bestämd fil adress
                
                while (!freader.EndOfStream)//Loopar genom filen och skriver ut rader
                {
                    string rad = freader.ReadLine();
                    Console.WriteLine(rad);
                }
                freader.Close();//ständer ner Streamreder
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine("Error :"+exc.Message);
            } 
        }

        //9-Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt
        //  till 2 och upphöjt till 10
        public static double GetRootPower(double InputNumber)
        {
            return Math.Pow(Math.Pow(Math.Sqrt(InputNumber), 2), 10);
        }

        //10-Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.
        //  En ”tab” ska läggas in efter varje nummer. Försöka att ställa upp det så det blir relativt läsbart.
        public static void MultiplyToTen()
        {
            Console.WriteLine("{0,2}\t{1,2}\t{2,3}", "T1", "T2", "Res");
            Console.WriteLine("-------------------");
            for (int i = 1; i < 11; i++)
            {
                //for (int j = 1; j < 11; j++)
                //{
                Console.WriteLine("{0,2}\t{1,2}\t{2,3}", i, i, (i * i));
                //}

            }
            //Console.WriteLine("{0,2}\t{1,2}\t{2,3}", 10,11,110);
            //Console.WriteLine("|{0}|\t|{1}   |",10,11);

        }

        //11.Funktion som skapar två arrayer.Den första fylls med slumpmässiga tal.
        //Den andra fylls med talen från den första i stigande ordning.
        public static void ArrayOrdering()
        {
            Random randomValue = new Random();
            int[] RandomArray = new int[9];
            int[] OrderedArray = new int[9];

            //Fyller arrayen med slumpmässiga tal
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = randomValue.Next(1, 100);
            }
            
            //Koperar första arrayen till OrderdArray
            RandomArray.CopyTo(OrderedArray, 0);
            
            //sorterar OrderedArray stigande
            for (int l = 0; l < OrderedArray.Length; l++)
            {
                for (int k = 0; k < OrderedArray.Length - 1; k++)
                {
                    int transfer = -1;
                    if (OrderedArray[k] < OrderedArray[k + 1])
                    {
                        transfer = OrderedArray[k];
                        OrderedArray[k] = OrderedArray[k + 1];
                        OrderedArray[k + 1] = transfer;
                    }
                }
            }

            //skriver ut två arrayer
            Console.WriteLine("{0,3}\t{1,3}", "SlumpligArray", "SorteradArray");
            Console.WriteLine("-------------------------------");
            for (int j = 0; j < RandomArray.Length; j++)
            {
                Console.WriteLine("{0,-12}\t{1,-12}", RandomArray[j], OrderedArray[j]);
            }


        }

        //12-Upptäcker ordet som inmatas är palindrom eller ej
        public static void Ispalindrom()
        {
            Console.WriteLine("Skriv in en godtycklig ord!");
            string InputWord = Console.ReadLine();
            char[] InputWordChar = InputWord.ToCharArray();
            bool flag = true;
            int counter = 0;
            while (flag == true && counter < InputWordChar.Length)
            {
                if (InputWordChar[counter].Equals(InputWordChar[(InputWordChar.Length - 1 - counter)]) == false)
                    flag = false;
                //bool result = InputWordChar[i].Equals(InputWordChar[(InputWordChar.Length - 1 - i)]);
                Console.WriteLine(InputWordChar[counter] + "-" + InputWordChar[(InputWordChar.Length - 1 - counter)] + "-" + flag);
                counter++;
            }
            if (flag == true)
                Console.WriteLine("Den Är Palindrom!");
            else
                Console.WriteLine("Den Är Inte Palindrom!");

        }

        //13.Funktion som tar två tal från användaren och skriver sedan ut "
        //"alla siffror som är mellan de två Talen.\n"
        public static void WritingIntervalNo()
        {
            //Lokal varjebler
            int firstNumber = 0;
            int secondNumber = 0;

            Console.WriteLine("Skriv in Första Tal!");
            firstNumber = (int)ChekVaildInput();
            Console.WriteLine("Skriv in Andra Tal!");
            secondNumber = (int)ChekVaildInput();
            
            //Byter stygande första och andra om behövs
            if (firstNumber > secondNumber)
            {
                int transfer = firstNumber;
                firstNumber = secondNumber;
                secondNumber = transfer;

            }

            Console.WriteLine("Tal Mellan[" + firstNumber + "]-[" + secondNumber + "]\n" +
                  "------------------");
            //line och sidan lokala varjabler
            int linecounter = 0;
            int pageCounter = 0;

            //efter varje 10 stycker skriver ny linje och efter varje 10 linjer byter sidan
            for (int i = firstNumber + 1; i < secondNumber; i++)
            {
                //string p= (i + 1 < secondNumber) ? "," : "";
                Console.Write((i + 1 < secondNumber) ? i + "," : i + "");
                linecounter++;
                if (linecounter == 10)
                {
                    Console.WriteLine("\n");
                    linecounter = 0;
                    pageCounter++;
                }
                if (pageCounter == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Tryck Enter se mer:");
                    Console.ResetColor();
                    Console.ReadKey();
                    pageCounter = 0;
                }

            }
            Console.WriteLine();
            //Console.WriteLine(Console.CursorTop);

        }

        //14
        public static void OrderOddEvenNumber()
        {

            Console.WriteLine("Skriv in en sträng av värden komma deparerade!");
            string strNumbers = Console.ReadLine();

            string strOdd = "";
            string strEven = "";
            string temp = "";
            for (int i = 0; i < strNumbers.Length; i++)
            {
                char c = char.Parse(strNumbers.Substring(i, 1));
                if (c != ',')
                    temp += c;
                else
                {
                    if (Convert.ToInt32(temp) % 2 == 0)
                        strEven += (strEven.Length != 0) ? '-' + temp : temp;
                    else if (Convert.ToInt32(temp) % 2 != 0)
                        strOdd += (strOdd.Length != 0) ? '-' + temp : temp;
                    temp = "";
                }


            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Udda värden  :" + strOdd);
            Console.WriteLine("Jämna värden :" + strEven);
        }

        //15
        public static void AddStringNumbers()
        {
            string temp = "";
            int total = 0;
            Console.WriteLine("Skriv in en sträng av värden komma deparerade!");
            string strNumbers = Console.ReadLine();

            char LastItem = char.Parse(strNumbers.Substring(strNumbers.Length - 1, 1));//
            if (LastItem != ',')
                strNumbers += ',';

            for (int i = 0; i < strNumbers.Length; i++)
            {
                char c = char.Parse(strNumbers.Substring(i, 1));
                if (c != ',')
                    temp += c;
                else
                {
                    total += int.Parse(temp);
                    temp = "";
                }


            }
            Console.WriteLine("Summan av nummer är :[" + total + "]");
        }
        //==============================================================================
        //Den här funktion skriver ut MenySystem på console fönster
        public static void PrintMenu()
        {
            //Skriver ut en röd linje som beskriver hur användaren ska börja.
            Console.Clear();
            Console.WriteLine();//Instoppar  en tom linje 
            Console.ForegroundColor = ConsoleColor.Red;//Ändrar Text färg för första linje
            Console.WriteLine("*** Välj EN MENYALTERNATIV! DVS SKRIV IN RADNUMMER STRICK PÅ ENTER.***\n" +
                                  "SISTA ALTERNATIVS VAL:");//Skriver ut första linje innan MenySystem 
            Console.ResetColor();//Ändrar Text färg tillbaka för Menysystem

            //Skriver ut MenyAlternativ på grön färg 
            Console.ForegroundColor = ConsoleColor.Green;//Ändrar Text färg för MenyAlternativ
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(
                              "0. Koppla från Programmet. \n" +
                              "1. Funktion som skriver ut ”Hello World” i konsolen. \n" +
                              "2. Skriv in Förnamn, Efternamn och Ålder, dessa skrivs ut i Console fönstret. \n" +
                              "3. Ändrar färgen på texten och ändrar tillbaka vid åter användning.  \n" +
                              "4. Skriver ut dagens datum.\n" +
                              "5. Skriv in två värde, den största värdet skrivs ut. \n" +
                              "6. Gissa fram den genererade slumpmässiga talet mellan 1 och 100. \n" +
                              "7. Skriv in ett text, som sedan sparas in i en fil på hårddisken\n"+
                              "8. En fil läses in från hårddisken\n"+
                              "9. Skriv in ett decimal tal och få tillbaka roten ur, upphöjt till 2 och upphöjt till 10 .\n" +
                              "10.Multiplikationstabell från 1 till 10 skrivs ut \n" +
                              "11.Två arrayer Skapas .Den första fylls med slumpmässiga tal,\n" +
                              "   kopieras till den andra och sorteras stigande.\n" +
                              "12.Skriv in ett ord,programmet bestämmer om det är  palindrom eller ej.\n" +
                              "13.Skriv in Två tal, sedan skrivs ut alla siffror som ligger mellan de två talen.\n" +
                              "14.Skriv in en sträng av kommaseparerade värde, \n"+
                              "   funktionen får dem sorterade efter udda och jämna värden.\n" +
                              "15.Skriv in ett antal värden(komma - separerade siffor) som sedan adderas och skrivs ut.\n"+
                              "16.Ange namnet på din karaktär och en motståndare. Hälsa,Styrka och Tur fylls med slumpliga tal. "
                              );//Skriver ut MenyAlternativ
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ResetColor();//Ändrar tillbaka text färg 
        }

        // Den här funktionb ber användaren att välja en MenyAlternativ
        // samt om cursorsTop position bli > 50 ber "Tryck Enter-->Representerar MenySystem"
        static void PrintRequesMenuItem()
        {
            int currenCuerser = Console.CursorTop;// tar cursors nuvarande position            
            
            if (currenCuerser > 50)//Om cursor positions top > 50 leder cursor till linje 17 som början av program och ber att användaren välja meyAlternativ nummer
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Tryck Enter-->Representerar MenySystem");
                Console.ResetColor();
                Console.ReadKey();
                PrintMenu();
                SelectedMenuItem(menuItem);
                Console.ForegroundColor = ConsoleColor.Red;//Ändrar Text färg för första linje
                Console.WriteLine("*Inmata en menyalternativ nummer!*");
                Console.ResetColor();//Ändrar Text färg tillbaka för Menysystem

            }
            else//Ber att användaren välja meyAlternativ nummer
            {
                Console.ForegroundColor = ConsoleColor.Red;//Ändrar Text färg för första linje
                Console.WriteLine("*Mata in en menyalternativ nummer!*");
                Console.ResetColor();//Ändrar Text färg tillbaka för Menysystem
            }


        }

        //Den här funktion sparar och visar MenyAlternativ som har valts på andra line
        static void SelectedMenuItem(int SelectedItem)
        {
            int currenCuerser = Console.CursorTop;
            Console.SetCursorPosition(23, 2);// sätter cursor position på rad 2 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + SelectedItem + "]");//skriver ut sista MenyAlternativ numret som har valt
            Console.ResetColor();
            Console.SetCursorPosition(0, currenCuerser);//Sätter cursor position på line 17 lika som position i programmets start
        }

        //Den här funktionen Kontrollerar att användaren skriver in tal annars loopar till skriver rätt värde 
        public static double ChekVaildInput()
        {
            double InputValue = -1;
            bool Isvlue = false;
            
            do//Kontrollerar om användare matar in tal 
            {
                Isvlue = Double.TryParse(Console.ReadLine(), out InputValue);
                if (Isvlue == false)
                {
                    Console.WriteLine("Ogiltig Input, Skriv in en av de MenyAlternativNummer!");
                }
            } while (Isvlue == false);
            return InputValue;
        }
    }
    //16-Classen för uppgift nummer 16
    public class Person
    {
        private string _yourName;
        private string _opponent;
        private int _heakth;
        private int _power;
        private int _lucky;
        private int _oheakth;
        private int _opower;
        private int _olucky;

        public string YourName { get => _yourName; set=> _yourName = value; }
        public string Opponent { get => _opponent; set => _opponent = value; }
        public int Helsa { get => _heakth; set => _heakth = value; }
        public  int Styrka { get => _power; set => _power = value; }
        public int Lucky { get => _lucky; set => _lucky = value; }
        public int HelsaOpponent { get => _oheakth; set => _oheakth = value; }
        public int StyrkaOpponent { get => _opower; set => _opower = value; }
        public int LuckyOpponent { get => _olucky; set => _olucky = value; }
        public void PrintInfo()
        {
            Console.WriteLine("\t{0,-9}\t{1,-16}", "Ditt Namn", "Motståndare Namn");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\t{0,-9}\t{1,-16}",  _yourName,_opponent);
            Console.WriteLine("Hälsa   {0,-9}\t{1,-16}", _heakth, _oheakth);
            Console.WriteLine("Styrcka {0,-9}\t{1,-16}", _power, _opower);
            Console.WriteLine("Tur     {0,-9}\t{1,-16}", _lucky, _olucky);
            
        }

    }
}
