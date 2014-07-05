//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Telerik">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

// Task 01. Open project located in '4. Code Documentation and Comments Homework.zip' and:
//          - Add comments where necessary
//          - For each public member add documentation as C# XML Documentation Comments
//          - * Play with Sandcastle / other tools and try to generate CHM book

// I used VSdocman for generating the CHM book. I couldn't get Sandcastle to work for me (Windows 7 64bit / VS2013).
// You can see what it generated in the folder 'Telerik.Ils.Common Documentation' (start the file 'index.html').

namespace Telerik.Ils.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Provides a set of methods for string manipulation
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string's bytes to hashed data and turns them into a hexadecimal representation of its characters
        /// </summary>
        /// <param name="input">The string that will be converted</param>
        /// <returns>The hexadecimal representation of the input's characters</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Converts a string into a boolean value
        /// </summary>
        /// <param name="input">The string that will be converted (ex. "true", "false", "yes", "no", "1", "0", "да", "не")</param>
        /// <returns>A boolean value representing the strings meaning</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts a string into a numeric value of type 'short'
        /// </summary>
        /// <param name="input">The string that will be converted</param>
        /// <returns>A numeric value representing the strings meaning</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts a string into an integer numeric value
        /// </summary>
        /// <param name="input">The string that will be converted</param>
        /// <returns>A numeric value representing the strings meaning</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts a string into a numeric value of type 'long'
        /// </summary>
        /// <param name="input">The string that will be converted</param>
        /// <returns>A numeric value representing the strings meaning</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts a string into a DateTime value
        /// </summary>
        /// <param name="input">The string that will be converted</param>
        /// <returns>A DateTime value representing the strings meaning</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes the first letter of a string
        /// </summary>
        /// <param name="input">The string that will be processed</param>
        /// <returns>The inputted string with its first character capitalized</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Processes a string and gives back a substring between specified starting and ending substrings
        /// </summary>
        /// <param name="input">The string that will be processed</param>
        /// <param name="startString">The substring after which the substring should be gotten</param>
        /// <param name="endString">The substring before which the substring should be gotten</param>
        /// <param name="startFrom">The index in the inputted string from which the method should start</param>
        /// <returns>A string between the values of startString and endString</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts a string written in cyrillic to latin letters
        /// </summary>
        /// <param name="input">The string in cyrillic to be processed</param>
        /// <returns>A string representation of the inputted string in latin letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                {
                    "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
                    "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                };
            var latinRepresentationsOfBulgarianLetters = new[]
                {
                    "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k", "l", "m", "n", "o",
                    "p", "r", "s", "t", "u", "f", "h", "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts a string written in latin to cyrillic letters
        /// </summary>
        /// <param name="input">The string in latin to be processed</param>
        /// <returns>A string representation of the inputted string in cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                {
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                    "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                {
                    "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к", "л", "м",
                    "н", "о", "п", "я", "р", "с", "т", "у", "ж", "в", "ь", "ъ", "з"
                };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts a username to a valid string by converting it's letters to latin if there are cyrillic ones
        /// </summary>
        /// <param name="input">Username to be processed</param>
        /// <returns>A valid username</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts a filename to a valid string by converting it's letters to latin if there are cyrillic ones
        /// </summary>
        /// <param name="input">Filename to be processed</param>
        /// <returns>A valid filename</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets the first characters of a string
        /// </summary>
        /// <param name="input">String from which the characters should be gotten</param>
        /// <param name="charsCount">Number of characters to get</param>
        /// <returns>A substring of the first characters of a string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets the file extension of a file if such exists
        /// </summary>
        /// <param name="fileName">File whose extension is needed</param>
        /// <returns>The files extension</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Gets a files content type by its extension
        /// </summary>
        /// <param name="fileExtension">The extension for which the content type is needed</param>
        /// <returns>The content type for the file extension entered</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                {
                    { "jpg", "image/jpeg" },
                    { "jpeg", "image/jpeg" },
                    { "png", "image/x-png" },
                    { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
                    { "doc", "application/msword" },
                    { "pdf", "application/pdf" },
                    { "txt", "text/plain" },
                    { "rtf", "application/rtf" }
                };

            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string to an array of its characters byte values
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>An array of the byte values of the characters</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
