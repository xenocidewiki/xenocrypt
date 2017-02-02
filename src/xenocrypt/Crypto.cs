using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace xenocrypt
{
    class Crypto
    {
        public class Alphabet
        {
            public static string norwegian = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            public static string generic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public class Decrypt
        {
            public static string VigenereCipherDecrypt(string text, string key, string alphabet)
            {
                text    = text.ToUpper();
                key     = key.ToUpper();

                int x = 0;

                StringBuilder return_value = new StringBuilder(text.Length);

                for(int i = 0; i < text.Length; i++)
                {
                    if (!char.IsLetterOrDigit(text[i]))
                    {
                        return_value.Append(text[i]);
                        continue;
                    }

                    if (alphabet.Contains(text[i]))
                        return_value.Append(alphabet[(alphabet.IndexOf(text[i]) - alphabet.IndexOf(key[x]) + alphabet.Length) % alphabet.Length]);
                    else
                        return_value.Append(text[i]);

                    x = (x + 1) % key.Length;
                }

                return return_value.ToString();
            }
        }

        public class Encrypt
        {
            public static string VigenereCypherEncrypt(string text, string key, string alphabet)
            {
                text = text.ToUpper();
                key = key.ToUpper();

                int x = 0;

                StringBuilder return_value = new StringBuilder(text.Length);

                for (int i = 0; i < text.Length; i++)
                {
                    if (!char.IsLetterOrDigit(text[i]))
                    {
                        return_value.Append(text[i]);
                        continue;
                    }

                    if (alphabet.Contains(text[i]))
                        return_value.Append(alphabet[(alphabet.IndexOf(text[i]) + alphabet.IndexOf(key[x])) % alphabet.Length]);
                    else
                        return_value.Append(text[i]);

                    x = (x + 1) % key.Length;
                }

                return return_value.ToString();
            }
        }
    }
}
