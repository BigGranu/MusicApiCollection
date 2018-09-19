#region Copyright (C) 2015-2018 BigGranu
/*
    Copyright (C) 2015-2018 BigGranu

    This file is part of mInfo <https://github.com/BigGranu/MusicApiCollection>

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
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using MusicApiCollection.Events;

namespace MusicApiCollection
{
    /// <summary>
    ///     Helpers for All
    /// </summary>
    internal class Helper
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Calculate the Runtime for Tracks
        /// </summary>
        /// <param name="offsets">FrameOffsets</param>
        /// <param name="runtime">Runtime of the Disc</param>
        /// <returns></returns>
        public static List<string> CalculateTrackRuntimes(List<int> offsets, int runtime)
        {
            var rt = new List<string>();

            try
            {
                for (var i = 0; i <= offsets.Count - 2; i++)
                {
                    var t = (Convert.ToDouble(offsets[i + 1]) - Convert.ToDouble(offsets[i]))/75;
                    rt.Add(((int) (t/60)).ToString("00") + ":" + Convert.ToInt16(Math.Ceiling(t%60)).ToString("00"));
                }

                var d = runtime - Convert.ToDouble(offsets.Last())/75;
                rt.Add(((int) (d/60)).ToString("00") + ":" + Convert.ToInt16(Math.Ceiling(d%60)).ToString("00"));

                return rt;
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return new List<string>();
            }
        }

        /// <summary>
        ///     Get a Substring
        /// </summary>
        /// <param name="value">Original string</param>
        /// <param name="start">Start</param>
        /// <param name="ende">Ende</param>
        /// <returns></returns>
        public static string GetSubstring(string value, string start, string ende)
        {
            try
            {
                var a = value.IndexOf(start) + start.Length;
                if (a - start.Length <= 0) return "";
                var b = value.IndexOf(ende, a, StringComparison.Ordinal);
                return value.Substring(a, b - a);
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return "";
            }
        }

        /// <summary>
        ///     Get a Substring
        /// </summary>
        /// <param name="value">Original string</param>
        /// <param name="start">Start1</param>
        /// <param name="start2">Start after Start1</param>
        /// <param name="ende">Ende</param>
        /// <returns></returns>
        public static string GetSubstring(string value, string start, string start2, string ende)
        {
            try
            {
                var a = value.IndexOf(start) + start.Length;
                var a2 = value.IndexOf(start2, a, StringComparison.Ordinal) + start2.Length;
                var b = value.IndexOf(ende, a2, StringComparison.Ordinal);
                return value.Substring(a2, b - a2);
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return "";
            }
        }

        /// <summary>
        ///     Make first Letter ToUpper and all other ToLower
        /// </summary>
        /// <param name="value">String with the words</param>
        /// <returns></returns>
        public static string ToWords(string value)
        {
            try
            {
                var ret = value.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                var words = ret.Aggregate("", (current, s) => current + s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower() + " ");
                return words.Trim();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return "";
            }
        }
    }
}