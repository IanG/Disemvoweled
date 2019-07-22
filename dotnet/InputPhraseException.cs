using System;

namespace Disemvoweling
{

	public class InputPhraseException : Exception
	{
		public InputPhraseException() {}

		public InputPhraseException(String message) : base(message) {}

		public InputPhraseException(String message, Exception inner) : base(message, inner) {}
	}
}