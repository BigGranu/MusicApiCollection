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
using System.Linq;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.FreeDB.Data
{
    /// <summary>
    ///     Query
    /// </summary>
    public class Query
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public QueryResult Data = new QueryResult();

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = string.Empty;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Create new Query and clear the log
        /// </summary>
        public Query()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Query with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Query(QueryResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     QueryResult
    /// </summary>
    public class QueryResult
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Server response code (three digit code)
        /// </summary>
        public string Code = string.Empty;

        /// <summary>
        ///     Informations about the code
        /// </summary>
        public string Info = string.Empty;

        /// <summary>
        ///     List of Results
        /// </summary>
        public List<QueryResultCd> Results = new List<QueryResultCd>();

        /// <summary>
        ///     Response
        /// </summary>
        public QueryResult()
        {
        }

        /// <summary>
        ///     Response
        /// </summary>
        public QueryResult(string value)
        {
            try
            {
                Results = new List<QueryResultCd>();
                var l = value.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (l.Count > 0)
                {
                    Code = l[0].Substring(0, 3);
                    Info = l[0].Substring(4).Replace("(until terminating `.')", "").Trim();
                    l.Remove(l[0]);
                }

                if (l.Count <= 0) return;

                foreach (var line in l)
                {
                    if (line.StartsWith(".")) continue;

                    var cd = new QueryResultCd();

                    var list = line.Split(new[] { " " }, StringSplitOptions.None);

                    if (list.Length > 0)
                    {
                        cd.Categorie = list[0];
                        cd.DiscId = list[1];
                    }

                    var at = line.Replace(cd.Categorie, "").Replace(cd.DiscId, "").Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

                    if (at.Length > 0)
                    {
                        cd.Artist = at[0].Trim();
                        cd.Title = at[1].Trim();
                    }

                    Results.Add(cd);
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }
        }
    }

    /// <summary>
    ///     Queryresult as CD
    /// </summary>
    public class QueryResultCd
    {
        /// <summary>
        ///     Categorie
        /// </summary>
        public string Categorie = string.Empty;

        /// <summary>
        ///     DiscId
        /// </summary>
        public string DiscId = string.Empty;

        /// <summary>
        ///     Artist
        /// </summary>
        public string Artist = string.Empty;

        /// <summary>
        ///     itle
        /// </summary>
        public string Title = string.Empty;
    }
}