using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ValidParentheses
    {
		/// <summary>
		/// Big O
		/// Complexity: O(n) : we go through the array of characters given and depending on the length of the string is the time it takes to push and remove the character from the stack 
		/// </summary>
		/// <param name="stringCharacters">string of characters</param>
		/// <returns>true if all characters was closed, false if some characters wasn't closed</returns>
		public bool IsValid(string stringCharacters) {
			if (validCloseOrEmptyChars(stringCharacters)) return false;

			Stack<char> characters = new Stack<char>();
			Dictionary<char, char> charsOfClose = new Dictionary<char, char>();
			charsOfClose.Add('(', ')');
			charsOfClose.Add('{', '}');
			charsOfClose.Add('[', ']');
			int lengthString = stringCharacters.Length, i = 0;

			while (i < lengthString) {
				if (validOpenChars(stringCharacters, i))
					characters.Push(stringCharacters[i]);

				else if (characters.Count > 0) {
					if (charsOfClose[characters.Peek()] == stringCharacters[i])
						characters.Pop();
					else
						return false;
				} else
					return false;
				i++;
			}
			return characters.Count == 0 & true;
		}
		/// <summary>
		/// Valid open chars
		/// </summary>
		/// <param name="stringCharacters">string of characters</param>
		/// <param name="i">index</param>
		/// <returns>return true or false</returns>
		private bool validOpenChars(string stringCharacters, int i) { 
			return (stringCharacters[i] == '(' || stringCharacters[i] == '{' || stringCharacters[i] == '[') ? true : false;
		}
		/// <summary>
		/// Validate start of string with closing characters and string is empty
		/// </summary>
		/// <param name="stringCharacters">string of characters</param>
		/// <returns>return true or false</returns>
		private bool validCloseOrEmptyChars(string stringCharacters) {
			if (stringCharacters.Length == 0) return true;
			return (stringCharacters[0] == ')' || stringCharacters[0] == '}' || stringCharacters[0] == ']') ? true : false;
		}
    }
}
