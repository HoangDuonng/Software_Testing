using System;

namespace StringManipulation
{
    public class StringReverse
    {
        private string input;

        public StringReverse(string input)
        {
            this.input = input;
        }

        public string ReverseString()
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input), "Vui lòng nhập một chuỗi!");

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
