using System;

namespace StringManipulation
{
    public class StringReverse
    {
        private string input;

        // Phương thức khởi tạo của lớp StringReverse, nhận vào một chuỗi đầu vào.
        public StringReverse(string input)
        {
            // Gán giá trị chuỗi đầu vào cho thuộc tính input của lớp.
            this.input = input;
        }

        // Phương thức để đảo ngược chuỗi đầu vào.
        public string ReverseString()
        {
            // Chuyển đổi chuỗi đầu vào thành mảng ký tự.
            char[] charArray = input.ToCharArray();
            // Đảo ngược mảng ký tự.
            Array.Reverse(charArray);
            // Tạo một chuỗi mới từ mảng ký tự đã đảo ngược và trả về chuỗi đó.
            return new string(charArray);
        }

    }
}
