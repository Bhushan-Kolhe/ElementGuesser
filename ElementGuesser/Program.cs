using System;

namespace ElementGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display App info
            GetAppInfo();

            //Ask user for name
            Console.WriteLine("What is your name?");
            //Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            //Input name from user
            string inputName = Console.ReadLine();
            //Reset text colour
            Console.ResetColor();
            Console.WriteLine("Hello {0} Let's start...", inputName);

            while (true)
            {
                //Create a new Randon Object
                Random random = new Random();
                int No = random.Next(1, 109);


                //Change text colour
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Which is the {0} Element of Periodic Table", No);
                //Reset text colour
                Console.ResetColor();

                //Call game Function
                Game(No);

                
                //Ask to play Again
                Console.WriteLine("Do you want to play again? [Y or N]");
                
                //Change text colour
                Console.ForegroundColor = ConsoleColor.Blue;
                string a = Console.ReadLine().ToUpper();
                //Reset text colour
                Console.ResetColor();
                if ( a == "Y" )
                {
                    continue;
                }
                else
                {
                    return;
                }

            }

        }

        static void PrintColorMessage(string msg, ConsoleColor color)
        {
            //Change text colour
            Console.ForegroundColor = color;

            //Print Message
            Console.WriteLine(msg);

            //Reset text colour
            Console.ResetColor();
        }

        static void GetAppInfo()
        {
            //Basic app info
            string appName = "Element Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bhushan kolhe";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //Print app info
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuthor);

            //Reset text colour
            Console.ResetColor();

        }

        static void Game(int No)
        {

            while (true)
            {
                //Change text colour
                Console.ForegroundColor = ConsoleColor.Blue;
                string ans = Console.ReadLine();
                //Reset text colour
                Console.ResetColor();
                switch (No)
                {
                    case 1:
                        if (ans == "H" || ans.ToUpper() == "HYDROGEN")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 2:
                        if (ans == "He" || ans.ToUpper() == "HELIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 3:
                        if (ans == "Li" || ans.ToUpper() == "LITHIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 4:
                        if (ans == "be" || ans.ToUpper() == "BERYLLIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 5:
                        if (ans == "B" || ans.ToUpper() == "BORON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 6:
                        if (ans == "C" || ans.ToUpper() == "CARBON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 7:
                        if (ans == "N" || ans.ToUpper() == "NITROGEN")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 8:
                        if (ans == "O" || ans.ToUpper() == "OXYGEN")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 9:
                        if (ans == "F" || ans.ToUpper() == "FLOURINE")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 10:
                        if (ans == "Ne" || ans.ToUpper() == "NEON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 11:
                        if (ans == "Na" || ans.ToUpper() == "SODIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 12:
                        if (ans == "Mg" || ans.ToUpper() == "MAGNESIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 13:
                        if (ans == "Al" || ans.ToUpper() == "ALUMINIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 14:
                        if (ans == "Si" || ans.ToUpper() == "SILICON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 15:
                        if (ans == "P" || ans.ToUpper() == "PHOSPHORUS")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 16:
                        if (ans == "S" || ans.ToUpper() == "SULFUR")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 17:
                        if (ans == "Cl" || ans.ToUpper() == "CHLORINE")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 18:
                        if (ans == "Ar" || ans.ToUpper() == "ARGON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 19:
                        if (ans == "K" || ans.ToUpper() == "POTASSIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 20:
                        if (ans == "Ca" || ans.ToUpper() == "CALCIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 21:
                        if (ans == "Sc" || ans.ToUpper() == "SCANDIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 22:
                        if (ans == "Ti" || ans.ToUpper() == "TITANIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 23:
                        if (ans == "V" || ans.ToUpper() == "VANADIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 24:
                        if (ans == "Cr" || ans.ToUpper() == "CHROMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 25:
                        if (ans == "Mn" || ans.ToUpper() == "MANGANESE")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 26:
                        if (ans == "Fe" || ans.ToUpper() == "IRON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 27:
                        if (ans == "Co" || ans.ToUpper() == "COBALT")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 28:
                        if (ans == "Ni" || ans.ToUpper() == "NIKEL")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 29:
                        if (ans == "Cu" || ans.ToUpper() == "COPPER")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 30:
                        if (ans == "Zn" || ans.ToUpper() == "ZINC")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 31:
                        if (ans == "Ga" || ans.ToUpper() == "GALLIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 32:
                        if (ans == "Ge" || ans.ToUpper() == "GERMENIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 33:
                        if (ans == "As" || ans.ToUpper() == "ARSENIC")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 34:
                        if (ans == "Se" || ans.ToUpper() == "SELENIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 35:
                        if (ans == "Br" || ans.ToUpper() == "BROMINE")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 36:
                        if (ans == "Kr" || ans.ToUpper() == "KRYPTON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 37:
                        if (ans == "Rb" || ans.ToUpper() == "RUBIDIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;


                    case 38:
                        if (ans == "Sr" || ans.ToUpper() == "STRONTIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 39:
                        if (ans == "Y" || ans.ToUpper() == "YTTRIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 40:
                        if (ans == "Zr" || ans.ToUpper() == "ZIRCONIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 41:
                        if (ans == "Nb" || ans.ToUpper() == "NIOBIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 42:
                        if (ans == "Mo" || ans.ToUpper() == "MOLYBDENUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 43:
                        if (ans == "Tc" || ans.ToUpper() == "TECHNETIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 44:
                        if (ans == "Ru" || ans.ToUpper() == "RUTHENIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 45:
                        if (ans == "Rh" || ans.ToUpper() == "RHODIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 46:
                        if (ans == "Pd" || ans.ToUpper() == "PALLADIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 47:
                        if (ans == "Ag" || ans.ToUpper() == "SILVER")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 48:
                        if (ans == "Cd" || ans.ToUpper() == "CADMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 49:
                        if (ans == "In" || ans.ToUpper() == "INDIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 50:
                        if (ans == "Sn" || ans.ToUpper() == "TIN")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 51:
                        if (ans == "Sb" || ans.ToUpper() == "ANTIMONY")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 52:
                        if (ans == "Te" || ans.ToUpper() == "TELLURIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 53:
                        if (ans == "I" || ans.ToUpper() == "IODINE")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 54:
                        if (ans == "Xe" || ans.ToUpper() == "XENON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 55:
                        if (ans == "Cs" || ans.ToUpper() == "CESIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 56:
                        if (ans == "Ba" || ans.ToUpper() == "BARIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 57:
                        if (ans == "La" || ans.ToUpper() == "LANTHANUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 58:
                        if (ans == "Ce" || ans.ToUpper() == "CERIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 59:
                        if (ans == "Pr" || ans.ToUpper() == "PRASEODYMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 60:
                        if (ans == "Nd" || ans.ToUpper() == "NEODYMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 61:
                        if (ans == "Pm" || ans.ToUpper() == "PROMETHIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 62:
                        if (ans == "Sm" || ans.ToUpper() == "SAMARIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 63:
                        if (ans == "Eu" || ans.ToUpper() == "EUROPIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 64:
                        if (ans == "Gd" || ans.ToUpper() == "GADOLINIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 65:
                        if (ans == "Tb" || ans.ToUpper() == "TERBIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 66:
                        if (ans == "Dy" || ans.ToUpper() == "DYSPROSIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 67:
                        if (ans == "Ho" || ans.ToUpper() == "HOLMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 68:
                        if (ans == "Er" || ans.ToUpper() == "ERBIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 69:
                        if (ans == "Tm" || ans.ToUpper() == "THULIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 70:
                        if (ans == "Yb" || ans.ToUpper() == "YTTERBIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 71:
                        if (ans == "Lu" || ans.ToUpper() == "LUTETIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 72:
                        if (ans == "Hf" || ans.ToUpper() == "HAFNIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 73:
                        if (ans == "Ta" || ans.ToUpper() == "TANTALUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 74:
                        if (ans == "W" || ans.ToUpper() == "TUNGSTEN")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 75:
                        if (ans == "Re" || ans.ToUpper() == "RHENIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 76:
                        if (ans == "Os" || ans.ToUpper() == "OSMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 77:
                        if (ans == "Ir" || ans.ToUpper() == "IRIDIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 78:
                        if (ans == "Pt" || ans.ToUpper() == "PLATINIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 79:
                        if (ans == "Au" || ans.ToUpper() == "GOLD")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 80:
                        if (ans == "Hg" || ans.ToUpper() == "MERCURY")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 81:
                        if (ans == "Tl" || ans.ToUpper() == "THALLIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 82:
                        if (ans == "Pb" || ans.ToUpper() == "LEAD")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 83:
                        if (ans == "Bi" || ans.ToUpper() == "BISMUTH")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 84:
                        if (ans == "Po" || ans.ToUpper() == "POLONIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;


                    case 85:
                        if (ans == "At" || ans.ToUpper() == "ASTATINE")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 86:
                        if (ans == "Rn" || ans.ToUpper() == "RADON")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 87:
                        if (ans == "Fr" || ans.ToUpper() == "FRANCIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 88:
                        if (ans == "Ra" || ans.ToUpper() == "RADIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 89:
                        if (ans == "Ac" || ans.ToUpper() == "ACTINIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 90:
                        if (ans == "Th" || ans.ToUpper() == "THORIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 91:
                        if (ans == "Pa" || ans.ToUpper() == "PROTACTINIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 92:
                        if (ans == "U" || ans.ToUpper() == "URANIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 93:
                        if (ans == "Np" || ans.ToUpper() == "NEPTUNIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 94:
                        if (ans == "Pu" || ans.ToUpper() == "PLUTONIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 95:
                        if (ans == "Am" || ans.ToUpper() == "AMERICIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 96:
                        if (ans == "Cm" || ans.ToUpper() == "CURIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 97:
                        if (ans == "Bk" || ans.ToUpper() == "BERKILIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 98:
                        if (ans == "Cf" || ans.ToUpper() == "CALIFORNIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 99:
                        if (ans == "Es" || ans.ToUpper() == "EINSTEINIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 100:
                        if (ans == "Fm" || ans.ToUpper() == "FERMIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;


                    case 101:
                        if (ans == "Md" || ans.ToUpper() == "MENDELEVIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 102:
                        if (ans == "No" || ans.ToUpper() == "NOBILIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 103:
                        if (ans == "Lr" || ans.ToUpper() == "LAWRENCIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 105:
                        if (ans == "Db" || ans.ToUpper() == "DUBNIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 104:
                        if (ans == "Rf" || ans.ToUpper() == "RUTHERFORDIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 106:
                        if (ans == "Sg" || ans.ToUpper() == "SEABORGIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 107:
                        if (ans == "Bh" || ans.ToUpper() == "BHORIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 108:
                        if (ans == "Hs" || ans.ToUpper() == "HASSIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    case 109:
                        if (ans == "Mt" || ans.ToUpper() == "MEITNERIUM")
                        {
                            PrintColorMessage("Correct!!!", ConsoleColor.Yellow);
                            return;
                        }
                        else
                        {
                            PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                            continue;
                        }
                        break;

                    default:
                        PrintColorMessage("Answer is incorrect, Try again...", ConsoleColor.Red);
                        break;
                }
            }
        }
    }
}
