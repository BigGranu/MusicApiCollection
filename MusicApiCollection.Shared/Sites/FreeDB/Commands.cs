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

namespace MusicApiCollection.Sites.FreeDB
{
    /// <summary>
    ///     Commands
    /// </summary>
    internal class Commands
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        public static string Categories { get; } = "cmd=cddb+lscat" + Hello();

        public static string Version { get; } = "cmd=ver" + Hello();

        public static string Sites { get; } = "cmd=sites" + Hello();

        public static string Help { get; } = "cmd=help" + Hello();

        /// <summary>
        ///     Build a Command for Read
        /// </summary>
        /// <param name="categorie">Categorie</param>
        /// <param name="discId">DiscId</param>
        /// <returns></returns>
        public static string Read(string categorie, string discId)
        {
            var command = "";

            var le = new LogEntry("Sites.FreeDB", "Commands", "Read");
            le.Parameters.Add(new Para("categorie", categorie));
            le.Parameters.Add(new Para("discId", discId));
            Logging.NewLogEntry(le);

            try
            {
                command += "cmd=cddb+read+";
                command += categorie;
                command += "+";
                command += discId;
                command += Hello();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return command;
        }

        /// <summary>
        /// Build Command for Query
        /// </summary>
        /// <param name="discId">DiscId</param>
        /// <param name="tracksCount">Number of Tracks</param>
        /// <param name="offsets">Frame offset of the starting location of each track</param>
        /// <param name="length">Total playing length of CD in seconds</param>
        /// <returns></returns>
        public static string Query(string discId, int tracksCount, List<string> offsets, int length)
        {
            var command = "";

            try
            {
                command += "cmd=cddb+query+";
                command += discId;
                command += "+";
                command += tracksCount.ToString();
                command = offsets.Aggregate(command, (current, s) => current + ("+" + s));
                command += "+";
                command += length.ToString();
                command += Hello();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return command;
        }

        /// <summary>
        ///     Build the Infoquery
        /// </summary>
        /// <returns></returns>
        private static string Hello()
        {
            var query = "";
            
            Logging.NewLogEntry(new LogEntry("Sites.FreeDB", "Commands", "Hello"));

            try
            {
                query += "&hello=";
                query += Settings.FreeDb.Username.Replace(" ", "_");
                query += "+";
                query += Settings.FreeDb.Hostname.Replace(" ", "_");
                query += "+";
                query += Settings.FreeDb.Clientname.Replace(" ", "_");
                query += "+";
                query += Settings.FreeDb.Version.Replace(" ", "_");
                query += "+";
                query += "&proto=" + Settings.FreeDb.Level;
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return query;
        }
    }
}