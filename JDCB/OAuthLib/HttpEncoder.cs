﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OAuthLib
{
    /// <summary>
    /// Provides implementation of RFC3986 Percent Encoding mechanism.
    /// </summary>
    public class HttpEncoder
    {
        /// <summary>
        /// Performs upper case percent encoding against the specified <paramref name="input"/>.
        /// </summary>
        /// <param name="input">The string to encode.</param>
        /// <returns>Encode string.</returns>
        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder newStr = new StringBuilder();

            foreach (var item in input)
            {
                if (IsReverseChar(item))
                {
                    newStr.Append("%");
                    var temp = ((int)item).ToString("X2");
                    newStr.Append(temp);
                }
                else
                    newStr.Append(item);
            }

            return newStr.ToString();
        }

        /// <summary>
        /// Performs lower case percent encoding (url-encodes) on the <paramref name="input"/> as what HttpUtility.UrlEncode does.
        /// </summary>
        /// <param name="input">The string to encode.</param>
        /// <returns>Encode string.</returns>
        public static string UrlEncode(string input)
        {
            StringBuilder newBytes = new StringBuilder();
            var urf8Bytes = Encoding.UTF8.GetBytes(input);
            foreach (var item in urf8Bytes)
            {
                if (IsReverseChar((char)item))
                {
                    newBytes.Append('%');
                    newBytes.Append(item.ToString("X2"));

                }
                else
                    newBytes.Append((char)item);
            }

            return newBytes.ToString();
        }

        private static bool IsReverseChar(char c)
        {
            return !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')
                    || c == '-' || c == '_' || c == '.' || c == '~');
        }

        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, 0);

        /// <summary>
        /// Gets the seconds from 1970/1/1.
        /// </summary>
        /// <param name="time">The time to calculate from.</param>
        /// <returns>The seconds.</returns>
        public static int ToUnixTime(DateTime time)
        {
            return (int)(time.ToUniversalTime() - UnixEpoch).TotalSeconds;
        }
    }
}
