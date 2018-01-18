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

			string[] answerKey = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B","D","A" };
			string [] questions = {"question 1", "question 2", "question 3", "question 4", "question 5", "question 6", "question 7", "question 8", "question 9", "question 10", "question 11", "question 12", "question 13", "question 14", "question 15", "question 16", "question 17", "question 18", "question 19", "question 20" };
			string options = ("A, B, C, or D?");
			string userAnswer = ("");
			int correctHolder=0;
			int incorrectHolder=0;
			int PASS_SCORE = 15;

			Console.WriteLine("Welcome to the Minnesota DMV drivers test");
			Console.WriteLine("The test will consist of 20 multiple questions, you must get 20 correct to pass.");
			Console.WriteLine("Press enter to continue...");
			Console.ReadLine();
			int x = 0;
			while (x < questions.Length) {

				Console.WriteLine(questions[x]);
				Console.WriteLine(options);
				userAnswer = Console.ReadLine().ToUpper();

				if (userAnswer == answerKey[x])
				{
					correctHolder = correctHolder + 1;
				} 
				else  {
					incorrectHolder = incorrectHolder + 1; }
				x++;

			}
		}
	}
}
