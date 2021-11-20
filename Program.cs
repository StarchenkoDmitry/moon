using System;
using System.Text;

namespace MyFirstLangConsole
{
    public class Program
    {

        public static void Main()
        {
            // The encoding.
            var enc = new UTF32Encoding();

            // Create a string.
            String s = "This string contains two characters " +
                       "with codes outside the ASCII code range: " +
                       "Pi (\u03A0) and Sigma (\u03A3).";
            Console.WriteLine("Original string:");
            Console.WriteLine("   {0}", s);

            // Encode the string.
            Byte[] encodedBytes = enc.GetBytes(s);
            Console.WriteLine();
            Console.WriteLine("Encoded bytes:");
            for (int ctr = 0; ctr < encodedBytes.Length; ctr++)
            {
                Console.Write("[{0:X2}]{1}", encodedBytes[ctr],
                                             (ctr + 1) % 4 == 0 ? " " : "");
                if ((ctr + 1) % 16 == 0) Console.WriteLine();
            }
            Console.WriteLine();

            // Decode bytes back to string.
            // Notice Pi and Sigma characters are still present.
            String decodedString = enc.GetString(encodedBytes);
            Console.WriteLine();
            Console.WriteLine("Decoded string:");
            Console.WriteLine("   {0}", decodedString);
        }

        public static void Main3()
        {
            // Create a UTF-8 encoding.
            UTF8Encoding utf8 = new UTF8Encoding();

            // A Unicode string with two characters outside an 8-bit code range.
            String unicodeString =
                "This Unicode string has 2 characters outside the " +
                "ASCII range:Дратуте\n" +
                "Pi (\u03a0), and Sigma (\u03a3)." +
                "\nА, 阿, ā. Б, 贝, bèi. В, 非, fēi. Г, 给, gěi. Д, 得, děi. Е, 也, yě. Ё, 用, yòng. Ж, 热, rè. З, 赛, sài. И, 伊, yī. Й, 伊可罗肯, yīkěluókěn. К, 卡, kǎ.";
            Console.WriteLine("Original string:");
            Console.WriteLine(unicodeString);

            // Encode the string.
            Byte[] encodedBytes = utf8.GetBytes(unicodeString);
            Console.WriteLine();
            Console.WriteLine("Encoded bytes:");
            for (int ctr = 0; ctr < encodedBytes.Length; ctr++)
            {
                Console.Write("{0:X2} ", encodedBytes[ctr]);
                if ((ctr + 1) % 25 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();

            // Decode bytes back to string.
            String decodedString = utf8.GetString(encodedBytes);
            Console.WriteLine();
            Console.WriteLine("Decoded bytes:");
            Console.WriteLine(decodedString);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            string a = "hello";
            string b = "h";
            // Append to contents of 'b'
            b += "ello";
            Console.WriteLine(a == b);
            Console.WriteLine(object.ReferenceEquals(a, b));


            //string str = "String";
            //Console.WriteLine(str.Trim);


            Console.WriteLine(sizeof(Char).ToString());
            Console.ReadKey();
        }
    }
}
