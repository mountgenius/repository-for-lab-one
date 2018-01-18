using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
	class Program
	{
		static void Main(string[] args)
		{


				string[] answerKey = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
				string[] questions = { "question 1", "question 2", "question 3", "question 4", "question 5", "question 6", "question 7", "question 8", "question 9", "question 10", "question 11", "question 12", "question 13", "question 14", "question 15", "question 16", "question 17", "question 18", "question 19", "question 20" };
				string options = ("A, B, C, or D?");
				string userAnswer = ("");
				int correctHolder;
				int incorrectHolder;
				
				List<int> questionsMissed  = new List <int>();
				int PASS_SCORE = 15;
				int ans;
			int EXIT = -1; //Sentinel Value
				

				Console.WriteLine("Welcome to the Minnesota DMV drivers test");
				Console.WriteLine("The test will consist of 20 multiple questions, you must get 20 correct to pass.");
				Console.WriteLine("Enter 1 to enter test or -1 to exit the program");
				ans = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				while (ans != EXIT)
				{
				correctHolder = 0;
				incorrectHolder = 0;
				int x = 0;
				while (x < questions.Length)
				{

					Console.WriteLine(questions[x]);
					Console.WriteLine(options);
					userAnswer = Console.ReadLine().ToUpper();

					if (userAnswer == answerKey[x])
					{
						correctHolder = correctHolder + 1;
					}
					else
					{
						incorrectHolder = incorrectHolder + 1;
						questionsMissed.Add(x);
					}
					x++;
					Console.Clear();
				}
				Console.WriteLine("You got " + correctHolder + " correct and " + incorrectHolder + " incorrect.");
				if (correctHolder >= PASS_SCORE)
				{
					Console.WriteLine("You passed!");
				}
				else
				{
					Console.WriteLine("Sorry, you failed.");
				}

				foreach( var i in questionsMissed)
				{

					Console.WriteLine($" {questions[i]}");
				}
				questionsMissed.Clear();
				Console.WriteLine("Would you like to try the test again? Press 1 to continue or -1 to exit");

				ans = Convert.ToInt32(Console.ReadLine()) ;
				/*if (ans != "Y")
				{
					Console.WriteLine("GoodBye");
					break;
				}*/
			}//End of while loop
		}
	}
}
