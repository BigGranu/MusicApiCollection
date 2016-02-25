#region Copyright (C) 2015-2016 BigGranu
/*
    Copyright (C) 2015-2016 BigGranu

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
using MusicApiCollection.Events;
using MusicApiCollection.Sites.FreeDB.Data;

namespace MusicApiCollection.Sites.FreeDB
{
    /// <summary>
    ///     Search on FreeDb
    /// </summary>
    public abstract class Search
    {
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Read entry from database
        /// </summary>
        /// <param name="categorie">Categorie</param>
        /// <param name="discId">DiscId</param>
        /// <returns></returns>
        public static Disk Read(string categorie, string discId)
        {
            var ret = new Disk();

            var le = new LogEntry("Sites.FreeDB", "Search", "Read");
            le.Parameters.Add(new Para("categorie", categorie));
            le.Parameters.Add(new Para("discId", discId));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = new Parser().Parse(Http.Post(Commands.Read(categorie, discId), Settings.FreeDb.ServerUrl));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Disk(ret.Data);
        }

        /// <summary>
        /// List the genre categories
        /// </summary>
        /// <returns></returns>
        public static Result Categories()
        {
            var ret = new Result();
            
            var le = new LogEntry("Sites.FreeDB", "Search", "Categories");
            le.Parameters.Add(new Para("", ""));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = new FreeDbResult(Http.Post(Commands.Categories, Settings.FreeDb.ServerUrl));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Result(ret.Data);
        }

        /// <summary>
        /// Server sites
        /// </summary>
        /// <returns></returns>
        public static Result Sites()
        {
            var ret = new Result();
            
            Logging.NewLogEntry(new LogEntry("Sites.FreeDB", "Search", "Sites"));

            try
            {
                ret.Data =  new FreeDbResult(Http.Post(Commands.Sites, Settings.FreeDb.ServerUrl));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Result(ret.Data);
        }

        /// <summary>
        /// Query database for matching entries
        /// </summary>
        /// <param name="discId">DiscId</param>
        /// <param name="tracksCount">Total number of tracks on CD</param>
        /// <param name="offsets">Frame offset of the starting location of each track</param>
        /// <param name="length">Total playing length of CD in seconds</param>
        /// <returns></returns>
        public static Query Query(string discId, int tracksCount, List<string> offsets, int length)
        {
            var ret = new Query();

            var le = new LogEntry("Sites.FreeDB", "Commands", "Query");
            le.Parameters.Add(new Para("discId", discId));
            le.Parameters.Add(new Para("tracksCount", tracksCount.ToString()));
            le.Parameters.Add(new Para("offsets", offsets.Count.ToString()));
            le.Parameters.Add(new Para("length", length.ToString()));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = new QueryResult(Http.Post(Commands.Query(discId, tracksCount, offsets, length), Settings.FreeDb.ServerUrl));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Query(ret.Data);
        }

        /// <summary>
        /// Server version
        /// </summary>
        /// <returns></returns>
        public static Result Version()
        {
            var ret = new Result();
            
            Logging.NewLogEntry(new LogEntry("Sites.FreeDB", "Search", "Version"));
            
            try
            {
                ret.Data = new FreeDbResult(Http.Post(Commands.Version, Settings.FreeDb.ServerUrl));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Result(ret.Data);
        }

        /// <summary>
        /// Help
        /// </summary>
        /// <returns></returns>
        public static Result Help()
        {
            var ret = new Result();
            
            Logging.NewLogEntry(new LogEntry("Sites.FreeDB", "Search", "Help"));

            try
            {
                ret.Data = new FreeDbResult(Http.Post(Commands.Help, Settings.FreeDb.ServerUrl));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Result(ret.Data);
        }
    }
}