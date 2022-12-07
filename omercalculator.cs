using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
namespace Calculator
{
	class OmerZafar
	{
		static void Main(string[] args)
		{

			string choice = "0";
			PauseTime();
			while (choice != "6")
			{
			Jump2: //Move to main menu  
				Console.Clear();
				MainMenu();
				choice = GetUserChoice("What is your choice : ", choice);
				if (choice == "1")
				{
				Jump3: //Screen Clear  

					Console.Clear();
					MathFunction();
					string a;
					do
					{
						Console.Write(" \n Please enter your choice : ");
						String operand = Console.ReadLine();
						switch (operand)
						{
							case "1":
								Addition();
								break;
							case "2":
								Subtraction();
								break;
							case "3":
								Multiplication();
								break;
							case "4":
								Division();
								break;
							case "5":
								Power();
								break;
							case "6":
								SquareRoot();
								break;
							case "7":
								Factorial();
								break;
							case "8":
								MathCeiling();
								break;
							case "9":
								MathFloor();
								break;
							case "10":
								MathAbsolute();
								break;
							case "11":
								MathMax();
								break;
							case "12":
								MathMin();
								break;
							case "13":
								HeroFormula();
								break;
							case "14":
								DistanceFormula();
								break;
							case "15":
								PrimeNumber();
								break;
							case "16":
								FibernaciSeries();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("Invalid Operation");
								Console.ResetColor();
								break;
						}
					//if user enter invalid so it will jump to math menu box.  //
					Jump1:

						MessageBox();
						Console.Write("Select your opition :: ");

						a = (Console.ReadLine());
						if (a == "C" || a == "c")
						{
							goto Jump3;

						}
						else if (a == "M" || a == "m")
						{

							goto Jump2;
						}
						else if (a == "x" || a == "X")
						{
							ExitMessage();
							Environment.Exit(0);
						}
						else if (a != "y" && a != "Y" && a != "m" && a != "M" && a != "x" && a != "X" && a != "c" && a != "C")
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("invalid key Please Enter Correct Key");
							Console.ResetColor();

							goto Jump1;

						}

						MathFunction();
					} while (a == "y" || a == "Y");
				}
				else if (choice == "2")
				{
				Jump5:
					Console.Clear();
					PhysicsSection();
					string a;
					do
					{
						Console.Write("Please enter your choice : ");
						string operand = (Console.ReadLine());
						switch (operand)
						{
							case "1":
								Speed();
								break;
							case "2":
								Acceleration();
								break;
							case "3":
								Velocity();
								break;
							case "4":
								AverageVelocity();
								break;
							case "5":
								Distance();
								break;
							case "6":
								NewtonSecondLaw();
								break;
							case "7":
								GravitaionalForce();
								break;
							case "8":
								ReducedMass();
								break;
							case "9":
								KinecticEnergy();
								break;
							case "10":
								FarheneitCelsius();
								break;
							case "11":
								CelsiusKelvin();
								break;
							case "12":
								PotentionalEnergy();
								break;
							case "13":
								TimeDilution();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("Invalid Operation");
								Console.ResetColor();
								break;
						}
					// Jump , If user enter incorrect string  //
					Jump4:
						MessageBox();
						// Message box of continue,quit,etc  //
						Console.Write("Select your opition :: ");
						a = (Console.ReadLine());

						if (a == "C" || a == "c")
						{
							Console.Clear();

							goto Jump5;
						}
						else if (a == "M" || a == "m")
						{

							goto Jump2;
						}
						else if (a == "x" || a == "X")
						{
							ExitMessage();
							Environment.Exit(0);
						}
						else if (a != "y" && a != "Y" && a != "m" && a != "M" && a != "x" && a != "X" && a != "c" && a != "C")
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("invalid key");
							Console.ResetColor();
							goto Jump4;
						}
						PhysicsSection();
					} while (a == "y" || a == "Y");
					Console.Clear();
					{
					}
				}
				else if (choice == "3")
				{
				Jump9:
					Console.Clear();
					MatrixMenu();
					string a;
					do
					{
						Console.Write("Please Enter your choice : ");
						string operand = Console.ReadLine();

						switch (operand)
						{
							case "1":
								MatrixAddition();
								break;
							case "2":
								MatrixSubtraction();
								break;
							case "3":
								MatrixMultiplication();
								break;
							case "4":
								MatrixDivision();
								break;
							case "5":
								TransposeOfMatrix();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("Invalid Operation");
								Console.ResetColor();
								break;
						}
					Jump8:
						MessageBox();
						Console.Write("Select your opition :: ");
						a = Console.ReadLine();
						if (a == "C" || a == "c")
						{
							Console.Clear();
							goto Jump9;
						}
						else if (a == "M" || a == "m")
						{
							goto Jump2;
						}
						else if (a == "x" || a == "X")
						{
							ExitMessage();
							Environment.Exit(0);
						}
						else if (a != "y" && a != "Y" && a != "m" && a != "M" && a != "x" && a != "X" && a != "c" && a != "C")
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("invalid key");
							Console.ResetColor();
							goto Jump8;
						}
						MatrixMenu();
					} while (a == "y" || a == "Y");
					Console.Clear();
				}
				else if (choice == "4")
				{
				Jump11a:
					Console.Clear();
					TrignometricMessage();
					string a;
					do
					{
						Console.Write("Please Enter your choice : ");
						string operand = Console.ReadLine();
						switch (operand)
						{
							case "1":
								SinAngle();
								break;
							case "2":
								CosAngle();
								break;
							case "3":
								TanAngle();
								break;
							case "4":
								CosecAngle();
								break;
							case "5":
								Sec();
								break;
							case "6":
								CotAngle();
								break;
							case "7":
								LawOfCosine();
								break;
							case "8":
								DegreeToRadian();
								break;
							case "9":
								RadianToDegree();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("Invalid Operation");
								Console.ResetColor();
								break;
						}
					Jump10a:
						MessageBox();
						Console.Write("Select your opition :: ");
						a = (Console.ReadLine());
						if (a == "C" || a == "c")
						{
							Console.Clear();
							goto Jump11a;
						}
						else if (a == "M" || a == "m")
						{
							goto Jump2;
						}
						else if (a == "x" || a == "X")
						{
							ExitMessage();
							Environment.Exit(0);
						}
						else if (a != "y" && a != "Y" && a != "m" && a != "M" && a != "x" && a != "X" && a != "c" && a != "C")
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("invalid key");
							Console.ResetColor();
							goto Jump10a;
						}
						TrignometricMessage();
					} while (a == "y" || a == "Y");
					Console.Clear();
				}
				else if (choice == "5")
				{
				Jump11:
					Console.Clear();
					UniqueMenu();
					string a;
					do
					{
						Console.Write("Please Enter your choice : ");
						string operand = Console.ReadLine();
						switch (operand)
						{
							case "1":
								QuadraticFormula();
								break;
							case "2":
								BubbleSort();
								break;
							case "3":
								ProfitOrLoss();
								break;
							case "4":
								DecimalToBinary();
								break;
							case "5":
								BinaryToDecimal();
								break;
							case "6":
								DecimalToHexadecimal();
								break;
							case "7":
								PythagorasTheorem();
								break;
							case "8":
								BinomialCofficent();
								break;
							case "9":
								WholeSquarePositive();
								break;
							case "10":
								WholeSquareNegative();
								break;
							case "11":
								RandomNumber();
								break;
							case "12":
								MultiplyTable();
								break;
							case "13":
								AppendFile();
								break;
							case "14":
								TruncateFile();
								break;
							case "15":
								File12();


								break;
							default:
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("Invalid Operation");
								Console.ResetColor();
								break;
						}
					Jump10:
						MessageBox();
						Console.Write("Select your opition :: ");
						a = (Console.ReadLine());
						if (a == "C" || a == "c")
						{
							Console.Clear();
							goto Jump11;
						}
						else if (a == "M" || a == "m")
						{
							goto Jump2;
						}
						else if (a == "x" || a == "X")
						{
							ExitMessage();
							Environment.Exit(0);
						}
						else if (a != "y" && a != "Y" && a != "m" && a != "M" && a != "x" && a != "X" && a != "c" && a != "C")
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("invalid key");
							Console.ResetColor();
							goto Jump10;
						}
						UniqueMenu();
					} while (a == "y" || a == "Y");

					Console.Clear();
				}
				else if (choice == "6")
				{
					ExitMessage();
				}
			}
		}
		public static string GetUserChoice(string question, string choice)
		{
			Console.Write(question);
			return Console.ReadLine();
		}
		public static void PauseTime()
		{

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("  ___________________________________________________");
			Console.WriteLine(" | Welcome To The Digital Calculator OMER & MUJTABA  |");
			Console.WriteLine(" |___________________________________________________|");
			Thread.Sleep(2000);
			Console.Clear();

		}
		public static void MainMenu()
		{



			Console.WriteLine(" ____________________________________");
			Console.WriteLine("|             Main Menu              |");
			Console.WriteLine("|____________________________________|");
			Console.WriteLine("|                                    |");
			Console.WriteLine("|  Press 1 For Math Section          |");
			Console.WriteLine("|  Press 2 For Physics Section       |");
			Console.WriteLine("|  Press 3 For Matrix Section        |");
			Console.WriteLine("|  Press 4 For Trignometric Section  |");
			Console.WriteLine("|  Press 5 For Unique Function       |");
			Console.WriteLine("|  Press 6 For Quit                  |");
			Console.WriteLine("|____________________________________|");
			Console.ResetColor();
		}
		public static void MathFunction()
		{
			Console.WriteLine(" ___________________________________");
			Console.WriteLine("|    Welcome to Math Operations     |");
			Console.WriteLine("|___________________________________|");
			Console.WriteLine("|                                   |");
			Console.WriteLine("|  Press 1  For  Addition           |");
			Console.WriteLine("|  Press 2  For  Subtraction        |");
			Console.WriteLine("|  Press 3  For  Multiplication     |");
			Console.WriteLine("|  Press 4  For  Division           |");
			Console.WriteLine("|  Press 5  For  Power              |");
			Console.WriteLine("|  Press 6  For  Square Root        |");
			Console.WriteLine("|  Press 7  For  Factorial          |");
			Console.WriteLine("|  Press 8  For  Math Ceiling       |");
			Console.WriteLine("|  Press 9  For  Math Floor         |");
			Console.WriteLine("|  Press 10 For  Math Absolute      |");
			Console.WriteLine("|  Press 11 For  MATH MAX           |");
			Console.WriteLine("|  Press 12 For  MATH MIN           |");
			Console.WriteLine("|  Press 13 For  Hero Formula       |");
			Console.WriteLine("|  Press 14 For  Distance Formula   |");
			Console.WriteLine("|  Press 15 For  Prime Number       |");
			Console.WriteLine("|  Press 16 For  Fibernaci Series   |");
			Console.WriteLine("|___________________________________|");
			Console.ResetColor();
		}
		public static void Addition()
		{
			Welcome("\n                  ADDITION ");

			{
				try
				{
					Console.Write("\nPlease enter the first integer: ");
					double num1 = Convert.ToDouble(Console.ReadLine());
					Console.Write("Please enter the second integer: ");
					double num2 = Convert.ToDouble(Console.ReadLine());
					double result = num1 + num2;
					Console.WriteLine("Addition : " + result);
				}
				catch (Exception e)
				{

					Console.WriteLine(e.Message);
				}
			}
		}
		public static void Subtraction()
		{
			Welcome("\n                SUBTRACTION ");
			try
			{
				Console.Write("\nPlease enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Please enter the second integer: ");
				double num2 = Convert.ToDouble(Console.ReadLine());
				double result = num1 - num2;
				Console.WriteLine("Subtraction :" + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Multiplication()
		{
			Welcome("\n                Multiplication ");
			try
			{
				Console.Write("\nPlease enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Please enter the second integer: ");
				double num2 = Convert.ToDouble(Console.ReadLine());
				double result = num1 * num2;
				Console.WriteLine("Multiplication : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Division()
		{
			Welcome("\n                Division ");
			try
			{
				Console.Write("\nPlease enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Please enter the second integer: ");
				double num2 = Convert.ToDouble(Console.ReadLine());
				double result = num1 / num2;
				Console.WriteLine("Division : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Power()
		{
			Welcome("\n                Power ");
			try
			{
				Console.Write("\nPlease enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Please enter the first integer: ");
				double num2 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Pow(num1, num2);
				Console.WriteLine(result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void SquareRoot()
		{
			Welcome("\n                Square Root ");
			try
			{
				Console.Write("\nPlease enter the number : ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Sqrt(num1);
				Console.WriteLine("Square Root : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Factorial()
		{
			Welcome("\n                Factorial ");
			try
			{
				Console.Write("\nPlease enter the number to be factorial : ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				double result = 1;
				for (int i = 1; i <= num1; i++)
				{
					result *= i;
				}
				Console.WriteLine("Factorial : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MathCeiling()
		{
			Welcome("\n               Math Ceiling         ");
			try
			{
				Console.Write("\n Please enter integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Ceiling(num1);
				Console.WriteLine("Math Ceiling : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MathFloor()
		{

			Welcome("\n                Math Floor ");
			try
			{
				Console.Write("\nPlease enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Floor(num1);
				Console.WriteLine("Math Floor : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MathAbsolute()
		{
			Welcome("\n                Math Abolute     ");
			try
			{
				Console.Write("\n Please enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Abs(num1);
				Console.WriteLine("Math Absolute : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MathMax()
		{
			Welcome("\n                Math Max     ");
			try
			{
				Console.Write("\nPlease enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Please enter the second integer: ");
				double num2 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Max(num1, num2);
				Console.WriteLine("Math Max : " + result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MathMin()
		{
			Welcome("\n                Math Min ");
			try
			{
				Console.Write("\n Please enter the first integer: ");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Please enter the second integer: ");
				double num2 = Convert.ToDouble(Console.ReadLine());
				double result = Math.Min(num1, num2);
				Console.WriteLine("Math Min : " + result);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

			}

		}
		public static void HeroFormula()
		{
			Welcome(" \n                Hero Formula ");
			try
			{
				double A, B, C, S, Area;
				Console.Write(" \n Enter your first side lenght : ");
				A = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter your second side lenght : ");
				B = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter your third side lenght : ");
				C = Convert.ToDouble(Console.ReadLine());
				S = (A + B + C) / 2;
				Area = (S * (S - A) * (S - B) * (S - C));
				Area = Math.Sqrt(Area);
				Console.WriteLine("Area of Triangle is : " + Area);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}


		}
		public static void DistanceFormula()
		{
			Welcome("\n                Distance Formula ");
			try
			{
				double x1, x2, y1, y2, distance, insideSquareRoot;
				Console.Write(" \n Enter the value of X1 :: ");
				x1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of X2 :: ");
				x2 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of Y1 :: ");
				y1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of Y2 ");
				y2 = Convert.ToDouble(Console.ReadLine());
				insideSquareRoot = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
				distance = Math.Sqrt(insideSquareRoot);
				Console.WriteLine("Distance = " + distance);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void PrimeNumber()
		{
			Welcome("\n                  Prime Number ");
			try
			{
				Console.Write(" \n Enter the number to check is it prime number :: ");
				var lenght = Convert.ToInt32(Console.ReadLine());
				int count = 0;
				for (int i = 1; i <= lenght; i++)
				{
					if (lenght % i == 0)
					{
						count++;
					}
				}
				if (count == 2)
				{
					Console.WriteLine("Number Entered By User is Prime Number ");
				}
				else
				{
					Console.WriteLine("Not A Prime Number");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void FibernaciSeries()
		{
			Welcome("\n               Fibernaci Series           ");
			try
			{
				int a, b, c, range;
				a = 0;
				b = 1;
				Console.Write("\n Enter the range of fibernaci series : ");
				range = Convert.ToInt32(Console.ReadLine());
				Console.Write(a + "\n" + b + "\n");
				for (int i = 2; i < range; i++)
				{
					c = a + b;
					Console.WriteLine("" + c + " ");
					a = b;
					b = c;
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Welcome(string Message)
		{
			// 45 time invoke
			Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine(Message);
			Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		}
		public static void MessageBox()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" _____________________________________________");
			Console.WriteLine("|                                             |");
			Console.WriteLine("|  If You Want To Go To menu Press   ( M ):   |");
			Console.WriteLine("|  If You Want To Continue Press     ( Y ):   |");
			Console.WriteLine("|  If You Want To Exit Press         ( X ):   |");
			Console.WriteLine("|  If You Want To Clear Screen Press ( C ):   |");
			Console.WriteLine("|_____________________________________________|");
			Console.ResetColor();
		}
		public static void PhysicsSection()
		{

			Console.WriteLine(" _________________________________________");
			Console.WriteLine("|      Welcome to Physics Operations      |");
			Console.WriteLine("|_________________________________________|");
			Console.WriteLine("|                                         |");
			Console.WriteLine("|  Press 1  for Finding Speed             |");
			Console.WriteLine("|  Press 2  for Finding Acceleration      |");
			Console.WriteLine("|  Press 3  for Finding Velocity          |");
			Console.WriteLine("|  Press 4  for Finding Average Velocity  |");
			Console.WriteLine("|  Press 5  for Finding Distance          |");
			Console.WriteLine("|  Press 6  for Finding Newton Second Law |");
			Console.WriteLine("|  Press 7  for Finding GravitaionalForce |");
			Console.WriteLine("|  Press 8  for Finding Reduced Mass      |");
			Console.WriteLine("|  Press 9  for Kinectic Energy           |");
			Console.WriteLine("|  Press 10 for Farheneit To Celsius      |");
			Console.WriteLine("|  Press 11 for Celsius To Kelvin         |");
			Console.WriteLine("|  Press 12 for Potentional Energy        |");
			Console.WriteLine("|  Press 13 for TimeDilution              |");
			Console.WriteLine("|_________________________________________|");
		}
		public static void Speed()
		{
			Welcome("\n                Speed ");
			try
			{
				Console.Write("\n Enter Value Of Distance : ");
				double distance = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter Time : ");
				double time = Convert.ToDouble(Console.ReadLine());
				double speed = (distance / time);
				Console.WriteLine("Speed = " + speed + " meter per sec ");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Acceleration()
		{
			Welcome("\n                Acceleration ");
			try
			{
				Console.Write("\n Enter intial velocity : ");
				double intialVelocity = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter final velocity : ");
				double finalVelocity = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter time  : ");
				double time = Convert.ToDouble(Console.ReadLine());
				double accelaration = ((finalVelocity - intialVelocity)) / time;
				Console.WriteLine("The Accelaration is = " + accelaration + " meter per square ");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void KinecticEnergy()
		{
			Welcome("\n                Kinectic Energy ");
			try
			{
				Console.Write(" \n Put the Value of Mass : ");
				double mass = Convert.ToDouble(Console.ReadLine());
				Console.Write("Put The Velocity : ");
				double velocity = Convert.ToDouble(Console.ReadLine());
				double kineticEnergy = (0.5 * mass * (velocity * velocity));
				Console.WriteLine("The Kinetic Energy is" + " " + kineticEnergy + " Joule ");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void ReducedMass()
		{
			Welcome("\n                Reduced Mass  ");
			try
			{
				Console.Write("\n Enter Mass of Body One (m1) : ");
				double firstMass = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter Mass of Body two (m2) : ");
				double secondMass = Convert.ToDouble(Console.ReadLine());
				double reducedMass = (firstMass * secondMass) / (firstMass + secondMass);
				Console.WriteLine("The Reduced Mass is" + " " + reducedMass + ":" + "(kg)");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void AverageVelocity()
		{
			Welcome("\n                Average Velocity ");
			try
			{
				Console.Write("\n Enter Intial Velocity : ");
				double intialVelocity = Convert.ToDouble(Console.ReadLine());
				Console.Write(" Enter Final Velocity : ");
				double finalVelocity = Convert.ToDouble(Console.ReadLine());
				double averageVelocity = (intialVelocity + finalVelocity) / 2;
				Console.WriteLine("The Average Velocity is :" + " " + averageVelocity + " (m/s) ");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Distance()
		{
			Welcome("\n                Distance ");
			try
			{
				Console.Write(" \n Put Initial Velocity : ");
				double velocity = Convert.ToDouble(Console.ReadLine());

				Console.Write("Put The Time : ");
				double time = Convert.ToDouble(Console.ReadLine());

				Console.Write("Put THe Accelaration : ");
				double acceleration = Convert.ToDouble(Console.ReadLine());

				double Distance = (velocity * time) + ((acceleration * (time * time)) * 1.00 / 2.00);
				Console.WriteLine(" The Distance is :" + " " + Distance + "(km)");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void FarheneitCelsius()
		{
			Welcome("\n             Farhenheit To Celsius          ");
			try
			{
				Console.Write("\nEnter Fahrenheit temperature : ");
				double fahrenheit = Convert.ToDouble(Console.ReadLine());
				double celsius = (fahrenheit - 32) * 5 / 9;
				Console.WriteLine("The converted Celsius temperature is" + " " + celsius + "°C");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Velocity()
		{
			Welcome("\n                Velocity ");
			try
			{
				Console.Write("\nEnter Initial velocity:");
				double intialVelocity = Convert.ToDouble(Console.ReadLine());

				Console.Write(" Enter time :");
				double time = Convert.ToDouble(Console.ReadLine());

				Console.Write(" Please acceleartion : ");
				double acceleartion = Convert.ToDouble(Console.ReadLine());
				double vf = intialVelocity + (acceleartion * time);

				Console.WriteLine("Final Velocity = " + vf + "meter per second");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void NewtonSecondLaw()
		{
			Welcome("\n                Newton Second Law ");
			try
			{
				Console.Write("\n Enter mass : ");
				double mass = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter acceleration : ");
				double acceleartion = Convert.ToDouble(Console.ReadLine());
				double force = mass * acceleartion;
				Console.WriteLine("Force : " + force);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void GravitaionalForce()
		{
			Welcome("\n                Gravitational Force ");
			try
			{
				double G = 6.673 * Math.Pow(10, -11);
				Console.Write(" \n Enter first mass  : ");
				double m1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter second mass  : ");
				double m2 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter radius : ");
				double r = Convert.ToDouble(Console.ReadLine());
				double F = (G * m1 * m2) / Math.Pow(r, 2);
				Console.WriteLine("Gravitational Force : " + F);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void TimeDilution()
		{
			Welcome("\n                Time Dilution ");
			try
			{
				double speedLight = 3 * Math.Pow(10, 8);
				Console.Write("\n Enter the time : ");
				double time1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter velocity : ");
				double velocity = Convert.ToDouble(Console.ReadLine());
				velocity = Math.Pow(velocity, 2.00);
				speedLight = Math.Pow(speedLight, 2.00);
				double domiator = 1 - velocity / speedLight;
				double t = time1 / Math.Sqrt(domiator);
				Console.WriteLine("Time Observed = " + t + " Periods Of The Radiation");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void CelsiusKelvin()
		{
			Welcome("\n                Celsius To Kelvin ");
			try
			{
				Console.Write("\n Enter the value of Celsius to be calculated into Kelvin : ");
				Double Tc = Convert.ToDouble(Console.ReadLine());
				double Tk = Tc + 273;
				Console.WriteLine("Tk = " + Tk + "°C");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void PotentionalEnergy()
		{
			Welcome("\n                Potentional Energy          ");
			try
			{
				double g = 9.8;
				Console.Write("\n Enter  Mass : ");
				double mass = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter Height  : ");
				double height = Convert.ToDouble(Console.ReadLine());
				double P = mass * g * height;
				Console.Write("Potentional Energy = {0}", P + "J \n");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MatrixMenu()
		{

			Console.WriteLine(" _________________________________________");
			Console.WriteLine("|      Welcome to Matrix Section          |");
			Console.WriteLine("|_________________________________________|");
			Console.WriteLine("|                                         |");
			Console.WriteLine("|  Press 1 For Addition Of Matrix         |");
			Console.WriteLine("|  Press 2 For Subtraction Of Matrix      |");
			Console.WriteLine("|  Press 3 For Multiplication Of Matrix   |");
			Console.WriteLine("|  Press 4 For Division Of Matrix         |");
			Console.WriteLine("|  Press 5 For Transpose Of Matrix        |");
			Console.WriteLine("|_________________________________________|");
			Console.ResetColor();
		}
		public static void MatrixAddition()
		{
			Welcome("\n               Matrix Addition   ");
			try
			{
				Console.Write("\n Enter No Of Rows :: ");
				int row = int.Parse(Console.ReadLine());
				Console.Write("Enter No Of Columns :: ");
				int column = int.Parse(Console.ReadLine());
				if (row == column)
				{
					int[,] matraxA = new int[row, column];
					int[,] matraxB = new int[row, column];
					int[,] matraxC = new int[row, column];
					Console.WriteLine();
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{

						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxA[i, j] = int.Parse(Console.ReadLine());

						}
					}
					Console.WriteLine();
					Console.WriteLine("       :: First Matrix :: ");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("\t" + matraxA[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{

						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxB[i, j] = int.Parse(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("      :: Second Matrix :: ");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("\t" + matraxB[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("---------------------------------");
					Console.WriteLine(" :: Addition Of Two Matrixes :: ");
					Console.WriteLine("---------------------------------");
					for (int i = 0; i < matraxC.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxC.GetLength(1); j++)
						{
							matraxC[i, j] = matraxA[i, j] + matraxB[i, j];
							Console.Write("\t" + matraxC[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("Invalid! Row and Column.");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MatrixMultiplication()
		{
			Welcome("\n             Matrix Multiplication       ");
			try
			{
				Console.Write("\n Enter No Of Rows :: ");
				int row = int.Parse(Console.ReadLine());
				Console.Write("Enter No Of Columns :: ");
				int column = int.Parse(Console.ReadLine());
				if (row == column)
				{
					int[,] matraxA = new int[row, column];
					int[,] matraxB = new int[row, column];
					int[,] matraxC = new int[row, column];
					Console.WriteLine();
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{
							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxA[i, j] = int.Parse(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("       :: First Matrix :: ");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("\t" + matraxA[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxB[i, j] = int.Parse(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("      :: Second Matrix :: ");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("\t" + matraxB[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("---------------------------------");
					Console.WriteLine(" :: Multiplication :: ");
					Console.WriteLine("---------------------------------");
					for (int i = 0; i < matraxC.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxC.GetLength(1); j++)
						{
							matraxC[i, j] = matraxA[i, j] * matraxB[i, j];
							Console.Write("\t" + matraxC[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("Invalid! Row And Column :");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MatrixDivision()
		{
			Welcome("\n              Matrix Division       ");
			try
			{
				Console.Write("\n Enter No Of Rows :: ");
				int row = int.Parse(Console.ReadLine());
				Console.Write("Enter No Of Columns :: ");
				int column = int.Parse(Console.ReadLine());
				if (row == column)
				{
					double[,] matraxA = new double[row, column];
					double[,] matraxB = new double[row, column];
					double[,] matraxC = new double[row, column];
					Console.WriteLine();
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxA[i, j] = int.Parse(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("       :: First Matrix ::     ");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("\t" + matraxA[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxB[i, j] = Convert.ToDouble(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("      :: Second Matrix ::    ");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("\t" + matraxB[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("---------------------------------");
					Console.WriteLine("         :: Division ::          ");
					Console.WriteLine("---------------------------------");
					for (int i = 0; i < matraxC.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxC.GetLength(1); j++)
						{
							matraxC[i, j] = (matraxA[i, j] / matraxB[i, j]);
							Console.Write("\t" + matraxC[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("Invalid! Row And Column Should Be Equal ");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void MatrixSubtraction()
		{
			Welcome("\n              Matrix Subtraction      ");
			try
			{
				Console.Write("\n Enter No Of Rows :: ");
				int row = int.Parse(Console.ReadLine());
				Console.Write("Enter No Of Columns :: ");
				int column = int.Parse(Console.ReadLine());
				if (row == column)
				{
					int[,] matraxA = new int[row, column];
					int[,] matraxB = new int[row, column];
					int[,] matraxC = new int[row, column];
					Console.WriteLine();
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxA[i, j] = int.Parse(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("       :: First Matrix :: ");
					for (int i = 0; i < matraxA.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxA.GetLength(1); j++)
						{

							Console.Write("\t" + matraxA[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("Input Element at require index");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("Enter element at index ({0}),({1}) ::", i, j);
							matraxB[i, j] = int.Parse(Console.ReadLine());
						}
					}
					Console.WriteLine();
					Console.WriteLine("      :: Second Matrix  ::      ");
					for (int i = 0; i < matraxB.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxB.GetLength(1); j++)
						{

							Console.Write("\t" + matraxB[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
					Console.WriteLine("---------------------------------");
					Console.WriteLine("        :: Subtraction ::    ");
					Console.WriteLine("---------------------------------");
					for (int i = 0; i < matraxC.GetLength(0); i++)
					{
						Console.Write(" | ");
						for (int j = 0; j < matraxC.GetLength(1); j++)
						{
							matraxC[i, j] = (matraxA[i, j] - matraxB[i, j]);
							Console.Write("\t" + matraxC[i, j] + "\t");
						}
						Console.Write(" | ");
						Console.WriteLine();
					}
				}
				else if (row != column)
				{
					Console.WriteLine("Invalid! Row And Column Are Not Equal ");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void TransposeOfMatrix()
		{
			Welcome("\n                  Tranpose Of Matrix ");
			try
			{
				int m, n, i, j;
				Console.Write("\n Enter the lenght of Row : ");
				m = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter the lenght of Column : ");
				n = Convert.ToInt32(Console.ReadLine());
				int[,] A = new int[m, n];
				for (i = 0; i < m; i++)
				{
					for (j = 0; j < n; j++)
					{
						Console.Write("Enter element at index ({0}),({1}) :: ", i, j);
						A[i, j] = Convert.ToInt32(Console.ReadLine());
					}
				}
				//if u want to clear screen = Omer
				Console.WriteLine("\nMatrix A : ");
				for (i = 0; i < m; i++)
				{
					for (j = 0; j < n; j++)
					{
						Console.Write(A[i, j] + "\t");

					}
					Console.WriteLine();
				}
				Console.WriteLine("Transpose Matrix : ");
				for (i = 0; i < m; i++)
				{
					for (j = 0; j < n; j++)
					{
						Console.Write(A[j, i] + "\t");

					}
					Console.WriteLine();
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void TrignometricMessage()
		{

			Console.WriteLine(" _________________________________________");
			Console.WriteLine("|      Welcome to Trignometric Section    |");
			Console.WriteLine("|_________________________________________|");
			Console.WriteLine("|                                         |");
			Console.WriteLine("|  Press 1  For To Find Sin               |");
			Console.WriteLine("|  Press 2  For To Find Cos               |");
			Console.WriteLine("|  Press 3  For To Find Tan               |");
			Console.WriteLine("|  Press 4  For To Find Cosec             |");
			Console.WriteLine("|  Press 5  For To Find Sec               |");
			Console.WriteLine("|  Press 6  For To Find Cot               |");
			Console.WriteLine("|  Press 7  For To Find Law Of Cosine     |");
			Console.WriteLine("|  Press 8  For Degree To Radian          |");
			Console.WriteLine("|  Press 9  For Radian To Degree          |");
			Console.WriteLine("|_________________________________________|");
		}
		public static void SinAngle()
		{
			Console.WriteLine("----------------------For Sin------------------");
			try
			{
				Console.Write("enter angle :: ");
				int angleSin = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(Math.Sin(angleSin));

			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void CosAngle()
		{
			Console.WriteLine("----------------------For Cos------------------");
			try
			{
				Console.Write("Enter angle :: ");
				int angleCos = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(Math.Cos(angleCos));
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void TanAngle()
		{
			Console.WriteLine("----------------------For Tan-----------------------");
			try
			{
				Console.Write("Enter angle :: ");
				int angleTan = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(Math.Tan(angleTan));
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void CosecAngle()
		{
			Console.WriteLine("----------------------For Cosec------------------------");

			try
			{
				AngleChoose();
				double angle = Convert.ToDouble(Console.ReadLine());
				if (angle == 0)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[1]);

				}
				else if (angle == 15)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[2]);
				}
				else if (angle == 30)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[3]);
				}
				else if (angle == 45)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[4]);
				}
				else if (angle == 60)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[5]);
				}
				else if (angle == 75)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[6]);
				}
				else if (angle == 90)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[7]);
				}
				else if (angle == 105)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[8]);
				}
				else if (angle == 120)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[9]);
				}
				else if (angle == 135)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[10]);
				}
				else if (angle == 150)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[11]);
				}
				else if (angle == 165)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[12]);
				}
				else if (angle == 180)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[13]);
				}
				else if (angle == 360)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[14]);
				}
				else
				{
					Console.WriteLine("Invalid Angle");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void Sec()
		{
			Console.WriteLine("----------------------For Sec-------------------------");
			try
			{
				AngleChoose();
				double angle = Convert.ToDouble(Console.ReadLine());
				if (angle == 0)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[16]);
				}
				else if (angle == 15)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[17]);
				}
				else if (angle == 30)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[18]);
				}
				else if (angle == 45)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[19]);
				}
				else if (angle == 60)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[20]);
				}
				else if (angle == 75)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[21]);
				}
				else if (angle == 90)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[22]);
				}
				else if (angle == 105)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[23]);
				}
				else if (angle == 120)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[24]);
				}
				else if (angle == 135)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[25]);
				}
				else if (angle == 150)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[26]);
				}
				else if (angle == 165)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[27]);
				}
				else if (angle == 180)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[28]);
				}
				else if (angle == 360)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[29]);
				}
				else
				{
					Console.WriteLine("Invalid Angle");
				}

			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void CotAngle()
		{
			Console.WriteLine("----------------------For Cot-----------------------");
			try
			{
				AngleChoose();
				double angle = Convert.ToDouble(Console.ReadLine());
				if (angle == 0)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[31]);
				}
				else if (angle == 15)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[32]);
				}
				else if (angle == 30)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[33]);
				}
				else if (angle == 45)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[34]);
				}
				else if (angle == 60)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[35]);
				}
				else if (angle == 75)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[36]);
				}
				else if (angle == 90)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[37]);
				}
				else if (angle == 105)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[38]);
				}
				else if (angle == 120)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[39]);
				}
				else if (angle == 135)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[40]);
				}
				else if (angle == 150)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[41]);
				}
				else if (angle == 165)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[42]);
				}
				else if (angle == 180)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[43]);
				}
				else if (angle == 360)
				{
					string[] lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\PFLAB\trignometricfile.txt");
					Console.WriteLine(lines[44]);
				}
				else
				{
					Console.WriteLine("Invalid Angle");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void LawOfCosine()
		{
			try
			{
				double c, a, b, d, result;
				Console.Write("Enter the value of a ::");
				a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of b ::");
				b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of angle ::");
				d = Convert.ToDouble(Console.ReadLine());
				d = Math.Cos(d);
				c = Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * d;
				result = Math.Sqrt(c);
				Console.WriteLine("Law Of Consine = " + result);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
		public static void DegreeToRadian()
		{
			try
			{
				Console.Write("Enter the angle :: ");
				double angle = Convert.ToDouble(Console.ReadLine());
				double res = Math.Cos(Math.PI * angle / 180.0);
				Console.WriteLine("Radian =" + res);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void RadianToDegree()
		{
			try
			{
				Console.Write("Enter the angle :: ");
				double radians = Convert.ToDouble(Console.ReadLine());
				double res = Math.Cos(180 / Math.PI) * radians;
				Console.WriteLine("Radian =" + res);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void UniqueMenu()
		{

			Console.WriteLine(" _________________________________________");
			Console.WriteLine("|      Welcome to Unique Section          |");
			Console.WriteLine("|_________________________________________|");
			Console.WriteLine("|                                         |");
			Console.WriteLine("|  Press 1  For Quadratic Formula         |");
			Console.WriteLine("|  Press 2  For Bubble Sort               |");
			Console.WriteLine("|  Press 3  For Profit Or Loss            |");
			Console.WriteLine("|  Press 4  For Decimal To Binary         |");
			Console.WriteLine("|  Press 5  For Binary To Decimal         |");
			Console.WriteLine("|  Press 6  For Decimal To Hexadecimal    |");
			Console.WriteLine("|  Press 7  For Pythagoras Theorem        |");
			Console.WriteLine("|  Press 8  For Binomial Cofficent        |");
			Console.WriteLine("|  Press 9  For Whole Square Positive     |");
			Console.WriteLine("|  Press 10 For Whole Square Negative     |");
			Console.WriteLine("|  Press 11 For Random Number             |");
			Console.WriteLine("|  Press 12 For Multiply Table            |");
			Console.WriteLine("|  Press 13 For Appending Notes (FILING)  |");
			Console.WriteLine("|  Press 14 For Deleting Notes (Filing)   |");
			Console.WriteLine("|  Press 15 For Reading Notes (Filing)    |");
			Console.WriteLine("|_________________________________________|");
			Console.ResetColor();
		}
		public static void QuadraticFormula()
		{
			try
			{
				Console.Write("Enter the vaue of a :: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of b :: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter value of c :: ");
				double c = Convert.ToDouble(Console.ReadLine());
				double D = b * b - 4 * a * c;
				if (D >= 0)
				{
					double x1 = (-b + Math.Sqrt(D)) / (2 * a);
					double x2 = (-b - Math.Sqrt(D)) / (2 * a);
					Console.WriteLine("Roots are: " + x1 + ", " + x2);
				}
				else
				{
					double x1 = -b / (2 * a);
					double x2 = Math.Sqrt(-D) / (2 * a);
					Console.WriteLine("Roots are: " + x1 + "±" + x2 + "i");
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void BubbleSort()
		{
			Welcome("\n                Bubble Sort  ");
			try
			{
				Console.Write(" \n Enter the lenght to sort using bubble sort :: ");
				int lenght = Convert.ToInt32(Console.ReadLine());
				double[] myArray = new double[lenght];
				for (int i = 0; i < myArray.Length; i++)
				{
					Console.Write("Value at index ({0} ) :: ", i);
					myArray[i] = Convert.ToDouble(Console.ReadLine());
				}
				Console.Write(" ");
				bool checkVariable = true;
				double checkvariable2;
				double numLength = myArray.Length;
				for (int i = 1; (i <= (numLength - 1)) && checkVariable; i++)
				{
					checkVariable = false;
					for (int j = 0; j < (numLength - 1); j++)
					{
						if (myArray[j + 1] > myArray[j])
						{
							checkvariable2 = myArray[j];
							myArray[j] = myArray[j + 1];
							myArray[j + 1] = checkvariable2;
							checkVariable = true;
						}
					}
				}
				Console.WriteLine("-----------------------------------------------------");
				Console.WriteLine("Sorted Out Using Bubble Sort(Decending to Ascending)");
				Console.WriteLine("-----------------------------------------------------");
				foreach (double num in myArray)
				{
					Console.WriteLine("{0} ", num);

				}
				Console.Write("");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void ProfitOrLoss()
		{
			Welcome("\n               Profit Or Loss  ");
			try
			{
				Console.Write("\n" + "Enter cost price :");
				double costPrice = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter sell price : ");
				double sellPrice = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter value of c to coninue to see profit or loss : ");
				char a = Convert.ToChar(Console.ReadLine());
				if (a == 'c')
				{
					if (costPrice > sellPrice)
					{
						Console.WriteLine(":: Its Profit :: ");
						double profit = costPrice - sellPrice;
						Console.Write("Profit = {0}", profit + "\n");
					}
					if (a == 'c')
					{
						if (sellPrice > costPrice)
						{
							Console.WriteLine(" :: Its loss :: ");
							double lost = sellPrice - costPrice;
							Console.WriteLine("Loss = {0}", lost);
						}
					}
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void DecimalToBinary()
		{
			Welcome("\n              Decimal To Binary  ");

			try
			{
				Console.Write("\n Input a Number : ");
				string answer = Console.ReadLine();
				double num = Convert.ToDouble(answer);
				string result = "";
				while (num > 1)
				{
					double remainder = num % 2;
					result = Convert.ToString(remainder) + result;
					num /= 2;
				}
				result = Convert.ToString(num) + result;
				Console.WriteLine("Binary: {0}", result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void BinaryToDecimal()
		{
			Welcome("\n              Binary To Decimal  ");
			try
			{
				string answer;
				string result;
				Console.Write("\n Input a Number : ");
				answer = Console.ReadLine();
				int num = Convert.ToInt32(answer);
				result = "";
				while (num > 1)
				{
					int remainder = num % 2;
					result = Convert.ToString(remainder) + result;
					num /= 2;
				}
				result = Convert.ToString(num) + result;
				Console.WriteLine("Binary: {0}", result);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void DecimalToHexadecimal()
		{
			Welcome("\n            Decimal To Hexadecimal  ");
			try
			{
				int dec, q, dn = 0, m, l;
				int swap;
				int s;
				Console.Write(" \n Input  any Decimal number: ");
				dec = Convert.ToInt32(Console.ReadLine());
				q = dec;
				for (l = q; l > 0; l = l / 16)
				{
					swap = l % 16;
					if (swap < 10)
						swap = swap + 48;
					else
						swap = swap + 55;
					dn = dn * 100 + swap;
				}
				Console.Write("\nThe equivalent Hexadecimal Number : ");
				for (m = dn; m > 0; m = m / 100)
				{
					s = m % 100;
					Console.Write("{0}", (char)s);
				}
				Console.Write("\n\n");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void PythagorasTheorem()
		{
			Welcome("\n             Pythagoras Theorem   ");
			try
			{
				double a, b, pythagoreanTheorem;
				Console.Write("\n Enter the First Value ");
				a = double.Parse(Console.ReadLine());
				Console.Write("Enter the Second Value ");
				b = double.Parse(Console.ReadLine());
				pythagoreanTheorem = Math.Sqrt(a * a + b * b);
				Console.WriteLine(" c : {0}", pythagoreanTheorem);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void BinomialCofficent()
		{
			Welcome("\n             Binomial Cofficent  ");
			try
			{
				Console.Write("\n Enter Value of A :: ");
				double A = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter Value of X :: ");
				double X = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter Value of n :: ");
				double n = Convert.ToDouble(Console.ReadLine());
				Series(A, X, n);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void WholeSquarePositive()
		{
			Welcome("\n            Whole Square Positive ");
			try
			{
				Console.Write("\n Enter the value of a :: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of b :: ");
				double b = Convert.ToDouble(Console.ReadLine());
				double f = Math.Pow(a, 2) + (2 * a * b) + Math.Pow(b, 2);
				Console.WriteLine("Value = " + f);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void WholeSquareNegative()
		{
			Welcome("\n         Whole Square Negative ");
			//A minus B Whole Square
			try
			{
				Console.Write("\n Enter the value of a :: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter the value of b :: ");
				double b = Convert.ToDouble(Console.ReadLine());
				// f = (a+b)^2 or Math.Pow(a+b,2) 
				double f = Math.Pow(a, 2) - (2 * a * b) + Math.Pow(b, 2);
				Console.WriteLine("Value = " + f);
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void RandomNumber()
		{
			Welcome("\n                RandomNumber ");
			try
			{
				Console.Write(" \n Enter the range how many random number you want to generate :: ");
				int randomNumberLenght = Convert.ToInt32(Console.ReadLine());
				int[] randomNum = new int[randomNumberLenght];
				Random RandomNumber = new Random();
				for (int i = 0; i < randomNum.Length; i++)
				{
					randomNum[i] = RandomNumber.Next(1, 21);
				}
				Console.WriteLine(" \n First {0} Random Number", randomNumberLenght);
				foreach (int j in randomNum)
				{
					Console.WriteLine(" " + j + " ");
				}
				int mx = randomNum[0];
				int mn = randomNum[0];
				for (int i = 0; i < randomNum.Length; i++)
				{
					if (randomNum[i] > mx)
					{
						mx = randomNum[i];
					}
					if (randomNum[i] < mn)
					{
						mn = randomNum[i];
					}
				}
				double sum = 0, avg = 0;
				for (int i = 0; i < randomNum.Length; i++)
				{
					sum += randomNum[i];
				}
				avg = sum / randomNum.Length;
				Console.WriteLine("The Sum is : " + sum);
				Console.WriteLine("The Average is : " + avg);
				Console.Write("Maximum element is : {0}\n", mx);
				Console.Write("Minimum element is : {0}\n\n", mn);

			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}


		}
		public static void MultiplyTable()
		{
			Welcome("\n               MultiplyTable ");
			try
			{
				Console.Write("\n Enter the table number :: ");
				int tableNumber = Convert.ToInt32(Console.ReadLine());
				for (int i = 1; i <= 10; i++)
				{
					int result = tableNumber * i;
					Console.WriteLine("{0} X {1} = {2}", tableNumber, i, result);
				}

			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}


		static void Series(double A, double X, double n)
		{
			double term = Math.Pow(A, n);
			try
			{
				Console.Write(term + " ");
				for (int i = 1; i <= n; i++)
				{
					//Binary Cofficent Formula
					term = term * X * (n - i + 1)
										/ (i * A);
				}
				Console.Write("\n" + term + "\n");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}

		}
		public static void AngleChoose()
		{
			Console.WriteLine("Choose the angle you want From Here to calculate :: ");
			Console.Write(" 0 \n 15 \n 30 \n 45 \n 60 \n 75 \n 90 \n 105 \n 120 \n 135 \n 150 \n 165 \n 180 \n 360 \n");
			Console.Write("Enter the angle you want to know :: ");
		}

		public static void ExitMessage()
		{
			Thread.Sleep(1000);

			Console.ForegroundColor = ConsoleColor.White;
			for (int i = 0; i <= 100; i++)
			{
				Console.Write($"\rProgress: {i}%   ");
				Thread.Sleep(15);
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n-------------Thank You! For Using This Calcualtor-------------");
			Console.WriteLine("--------------------You Have Exit The Program-----------------");
			Console.WriteLine("Current date and time: {0}", DateTime.Now);

			Console.ResetColor();


		}
		public static void ReadFile()
		{
			try
			{
				FileStream F = new FileStream(@"C:\Users\Administrator\Desktop\PFLAB\form1.txt.", FileMode.OpenOrCreate, FileAccess.ReadWrite);
				StreamReader reader = new StreamReader(F);
				string line;
				do
				{
					line = "";
					char character;
					while ((character = (char)reader.Read()) != '\n')
					{
						line += character;
					}
					Console.WriteLine(line);

				} while (line != "");
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}





		}
		public static void AppendFile()
		{
			FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\PFLAB\form1.txt", FileMode.Append, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs);
			Console.WriteLine("Enter the text which you want to write to the file");
			string str = Console.ReadLine();
			sw.WriteLine(str);
			sw.Flush();
			sw.Close();

		}
		public static void TruncateFile()
		{
			string path = @"C:\Users\Administrator\Desktop\PFLAB\form1.txt";
			using (FileStream file = new FileStream(path, FileMode.Truncate, FileAccess.Write))
			{

				Console.WriteLine("File Written Sucessfully..");
			}
		}


		public static void File12()
		{
			string fullFilePath = @"C:\Users\Administrator\Desktop\PFLAB\myfile1000";

			List<string> items = File.ReadAllLines(fullFilePath).Select(line => line.Split('p').Last()).ToList();
		}
	}
}
