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

namespace MusicApiCollection.Sites.Lyrics.LyricsOverload
{
    /// <summary>
    ///     Search in LyricsOverload
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Search a Lyric
        /// </summary>
        /// <param name="artist">Artist</param>
        /// <param name="title">SongTitle</param>
        /// <returns></returns>
        public static Lyric Lyric(string artist, string title)
        {
            var ret = new Lyric();

            var le = new LogEntry("Sites.Lyrics.LyricsOverload", "Search", "Lyric");
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("title", title));
            Logging.NewLogEntry(le);

            try
            {
                var ret2 =
                    Http.Request("http://www.lyricsoverload.com/BasicSearch.do?stdSearchField=%22" + artist +
                                 "%22%2C+%22" + title + "%22&searchType=track&pageNum=1&x=0&y=0");

                var ret3 =
                    Http.Request("http://www.lyricsoverload.com/" +
                                 Helper.GetSubstring(ret2, "- <b><a class=\"search\" href=\"/", "\""));

                ret.Data.Text =
                    Helper.GetSubstring(ret3, "<p class=\"lyrics\">", "</p>").Replace("<br>", "").Replace("\r", "\r\n");

                ret.Data.Writers = GetWriters(Helper.GetSubstring(ret3, ">Writer(s):", "<").Trim());
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Lyric(ret.Data);
        }


        private static List<Writer> GetWriters(string writers)
        {
            var ret = new List<Writer>();

            var le = new LogEntry("Sites.Lyrics.LyricsOverload", "Search", "Lyric");
            le.Parameters.Add(new Para("writers", writers));
            Logging.NewLogEntry(le);

            try
            {
                ret = writers.Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => Helper.ToWords(s).Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries))
                    .Select(names => new Writer {FirstName = names[1].Trim(), LastName = names[0].Trim()}).ToList();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return ret;
        }
    }
}