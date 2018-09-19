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
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MusicApiCollection.Events;
using MusicApiCollection.Sites.FreeDB.Data;

namespace MusicApiCollection.Sites.FreeDB
{
    /// <summary>
    /// </summary>
    internal class Parser
    {
        private readonly List<Tuple<Regex, Action<DiskResult, MatchCollection>>> _actions;
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        /// </summary>
        public Parser()
        {
            _actions = new List<Tuple<Regex, Action<DiskResult, MatchCollection>>>();

            Add(@"^\#\s+xmcd", (disk, collection) =>
            {
                if (collection.Count == 0)
                {
                    Exceptions.NewException(new InvalidDataException());
                }
            });

            Add(@"^\# \s* Track \s+ frame \s+ offsets \s*: \s* \n (^\# \s* (\d+) \s* \n)+", (disk, collection) =>
            {
                foreach (Capture capture in collection[0].Groups[2].Captures)
                {
                    disk.TrackFramesOffsets.Add(int.Parse(capture.Value));
                }
            });

            Add(@"Disc \s+ length \s*: \s* (\d+)", (disk, collection) =>
                disk.DiskLength = int.Parse(collection[0].Groups[1].Value)
                );

            Add("DISCID=(.+)", (disk, collection) =>
            {
                var strings = collection[0].Groups[1].Value.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
                disk.DiskIds.AddRange(strings.Select(x => x.Trim()));
            });

            Add("DTITLE=(.+)", (disk, collection) =>
            {
                var parts = collection[0].Groups[1].Value.Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    disk.Artist = parts[0].Trim();
                    disk.Title = parts[1].Trim();
                }
                else
                {
                    disk.Title = parts[0].Trim();
                }
            });

            Add(@"DYEAR=(\d+)", (disk, collection) =>
            {
                if (collection.Count == 0)
                    return;
                var value = collection[0].Groups[1].Value;
                if (value.Length > 4) // there is data like this
                {
                    value = value.Substring(value.Length - 4);
                }
                disk.Year = int.Parse(value).ToString();
            }
                );

            Add(@"DGENRE=(.+)", (disk, collection) =>
            {
                if (collection.Count == 0)
                    return;
                disk.Genre = collection[0].Groups[1].Value.Trim();
            }
                );

            Add(@"TTITLE\d+=(.+)", (disk, collection) =>
            {
                foreach (Match match in collection)
                {
                    disk.Tracks.Add(match.Groups[1].Value.Trim());
                }
            });

            Add(@"(EXTD\d*)=(.+)", (disk, collection) =>
            {
                foreach (Match match in collection)
                {
                    var key = match.Groups[1].Value;
                    string value;

                    if (disk.Attributes.TryGetValue(key, out value))
                    {
                        disk.Attributes[key] = value + match.Groups[2].Value.Trim();
                    }
                    else
                    {
                        disk.Attributes[key] = match.Groups[2].Value.Trim();
                    }
                }
            });
        }

        /// <summary>
        ///     Parse a XMCD string
        /// </summary>
        /// <param name="text">XMCD string</param>
        /// <returns>Disc</returns>
        public DiskResult Parse(string text)
        {
            var disk = new DiskResult();

            Logging.NewLogEntry(new LogEntry("Sites.FreeDB", "Parser", "Parse"));

            foreach (var action in _actions)
            {
                var collection = action.Item1.Matches(text);

                try
                {
                    action.Item2(disk, collection);
                }
                catch (Exception ex)
                {
                    Exceptions.NewException(ex);
                }
            }
            return disk;
        }

        private void Add(string regex, Action<DiskResult, MatchCollection> action)
        {
            try
            {
                var key = new Regex(regex, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline);
                _actions.Add(Tuple.Create(key, action));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }
        }
    }
}