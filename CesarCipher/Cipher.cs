using System;
using System.Text;

namespace CesarCipher
{
    public class Cipher
    {
        public static string Encrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseASCII = char.IsUpper(character) ? 'A' : 'a';
                    result.Append((char)(((character + shift - baseASCII) % 26) + baseASCII));
                }
                else if(character>=49 && character<=57)
                {
                    result.Append((char)((character + shift - 49) % 9 + 49 ));
                }
                else
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }


        public static string Decrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();
            int charshift = 26 - shift;
            int numshift = 9 - shift;

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseASCII = char.IsUpper(character) ? 'A' : 'a';
                    result.Append((char)(((character + charshift - baseASCII) % 26) + baseASCII));
                }
                else if(character>=49 && character<=57)
                {
                    result.Append((char)((character + numshift - 49) % 9 + 49 ));
                }
                else
                {
                    result.Append(character);
                }
            }
            return result.ToString();
        }
    }
}
