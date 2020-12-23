using System;
using System.IO;

namespace TwentyTwentySolutions
{
	public class DayOne
	{
		public string PartA(string puzzleInputPath) {
			// Get the puzzle input into the numbers[] array
			string[] input = File.ReadAllLines(puzzleInputPath);
			int[] numbers = new int[input.Length];

			for (int i = 0; i < input.Length; i++) {
				numbers[i] = int.Parse(input[i]);
			}

			// Determine which two sum to 2020 and get the product
			int num1, num2, product;
			bool keepGoing = true;
			product = 0;

			for (int i = 0; i < numbers.Length && keepGoing; i++) {
				num1 = numbers[i];
				for (int j = i + 1; j < numbers.Length && keepGoing; j++) {
					num2 = numbers[j];

					if ((num1 + num2) == 2020) {
						product = num1 * num2;
						keepGoing = false;
					}
				}
			}

			return product.ToString();
		}

		public string PartB(string puzzleInputPath) {
			// Get the puzzle input into the numbers[] array
			string[] input = File.ReadAllLines(puzzleInputPath);
			int[] numbers = new int[input.Length];

			for (int i = 0; i < input.Length; i++) {
				numbers[i] = int.Parse(input[i]);
			}

			// Determine which three sum to 2020 and get the product
			int num1, num2, num3, product;
			bool keepGoing = true;
			product = 0;

			for (int i = 0; i < numbers.Length && keepGoing; i++) {
				num1 = numbers[i];
				for (int j = i + 1; j < numbers.Length && keepGoing; j++) {
					num2 = numbers[j];
					for (int k = j + 1; k < numbers.Length && keepGoing; k++) {
						num3 = numbers[k];

						if ((num1 + num2 + num3) == 2020) {
							product = num1 * num2 * num3;
							keepGoing = false;
						}
					}
				}
			}

			return product.ToString();
		}
	}
}