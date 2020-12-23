using System;
using System.IO;

namespace TwentyTwentySolutions
{
	public class DayTwo
	{
		public string PartA(string puzzleInputPath) {
			// Get the puzzle input into the PolicyAndPassword[] array
			string[] input = File.ReadAllLines(puzzleInputPath);
			PolicyAndPassword[] pp = new PolicyAndPassword[input.Length];

			for (int i = 0; i < input.Length; i++) {
				pp[i] = StringInputToPolicy(input[i]);
			}

			// Determine how many passwords are valid
			int numValid = 0;
			int hits = -1;

			// For each PolicyAndPassword, determine the number of times
			// the letter is in the password. If it's within the valid
			// number range, then add one to numValid!
			for (int i = 0; i < pp.Length; i++) {
				hits = CountLetterHits(pp[i].letter, pp[i].password);

				if ((hits >= pp[i].min) && (hits <= pp[i].max))
					numValid++;
			}

			return numValid.ToString();
		}

		public string PartB(string puzzleInputPath) {
			// Get the puzzle input into the PolicyAndPassword[] array
			string[] input = File.ReadAllLines(puzzleInputPath);
			PolicyAndPassword[] pp = new PolicyAndPassword[input.Length];

			for (int i = 0; i < input.Length; i++) {
				pp[i] = StringInputToPolicy(input[i]);
			}

			// Determine how many passwords are valid
			int numValid = 0;
			bool letterIsAtFirstLocation = false;
			bool letterIsAtSecondLocation = false;

			// Find out if the letter is at the min and max location.
			// If it's at only one of them, add one to numValid.
			for (int i = 0; i < pp.Length; i++) {
				letterIsAtFirstLocation = pp[i].password[pp[i].min - 1] == pp[i].letter;
				letterIsAtSecondLocation = pp[i].password[pp[i].max - 1] == pp[i].letter;

				// If only one of them is true (exclusive or)
				if (letterIsAtFirstLocation ^ letterIsAtSecondLocation) 
					numValid++;
			}

			return numValid.ToString();
		}

		// This will hold the data we read in from each line.
		private struct PolicyAndPassword {
			public int min;
			public int max;
			public char letter;
			public string password;
		}

		// From a line in the input file, build its PolicyAndPassword struct.
		private PolicyAndPassword StringInputToPolicy(string input) {
			PolicyAndPassword p;
			p.min = int.Parse(input.Substring(0, input.IndexOf("-")));
			p.max = int.Parse(input.Substring(input.IndexOf("-") + 1, input.IndexOf(" ") - input.IndexOf("-") - 1));
			p.letter = char.Parse(input.Substring(input.IndexOf(":") - 1, 1));
			p.password = input.Substring(input.IndexOf(":") + 1).Trim();
			return p;
		}

		// Return how many times a character shows up in a string.
		private int CountLetterHits(char character, string toCheck) {
			int total = 0;

			for (int i = 0; i < toCheck.Length; i++) {
				if (toCheck[i] == character)
					total++;
			}

			return total;
		}

		// Print the PolicyAndPassword struct data. Mostly for testing.
		private void PrintPolicyAndPassword(PolicyAndPassword pp) {
			Console.WriteLine("From " + pp.min + " to " + pp.max + " for " + pp.letter.ToString() + " in " + pp.password);
		}
	}
}