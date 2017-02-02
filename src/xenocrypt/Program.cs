/*
 * 
    xenocrypt - Simple program to decrypt and encrypt different ciphers.
    Copyright (C) 2017  xenocidewiki

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xenocrypt;

namespace xenocrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted_text   = "SEHS LZY TSNCH AT GSI TWTS IXJRD?";
            string decrypted_text   = "Have you heard of the high elves?";
            string vigenere_key     = "LEMON";

            string encrypted_vigenere_cipher = Crypto.Encrypt.VigenereCypherEncrypt(decrypted_text, vigenere_key, Crypto.Alphabet.generic);
            string decrypted_vigenere_cipher = Crypto.Decrypt.VigenereCipherDecrypt(encrypted_text, vigenere_key, Crypto.Alphabet.generic);

            Console.WriteLine(encrypted_vigenere_cipher);
            Console.WriteLine(decrypted_vigenere_cipher);

            Console.ReadKey();
        }
    }
}
