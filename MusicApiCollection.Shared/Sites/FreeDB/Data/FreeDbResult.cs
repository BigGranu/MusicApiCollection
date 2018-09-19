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

namespace MusicApiCollection.Sites.FreeDB.Data
{    
    /// <remarks />
    public class Result
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public FreeDbResult Data { get; set; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = Exceptions.Message;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred { get; set; } = Exceptions.ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Create new Result and clear the log
        /// </summary>
        public Result()
        {
        }

        /// <summary>
        ///     Create new Result with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Result(FreeDbResult data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     Server response
    /// </summary>
    public class FreeDbResult
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Artist
        /// </summary>
        public string Artist = string.Empty;

        /// <summary>
        ///     Categorie
        /// </summary>
        public string Categorie = string.Empty;

        /// <summary>
        ///     Server response code (three digit code)
        /// </summary>
        public string Code = string.Empty;

        /// <summary>
        ///     DiscId
        /// </summary>
        public string DiscId = string.Empty;

        /// <summary>
        ///     Informations about the code
        /// </summary>
        public string Info = string.Empty;

        /// <summary>
        ///     List of Results
        /// </summary>
        public List<string> Results;

        /// <summary>
        ///     itle
        /// </summary>
        public string Title = string.Empty;

        /// <summary>
        ///     Response
        /// </summary>
        public FreeDbResult()
        {
        }

        /// <summary>
        ///     Response
        /// </summary>
        public FreeDbResult(string value)
        {
            try
            {
                Results = new List<string>();
                var l = value.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (l.Count > 0)
                {
                    Code = l[0].Substring(0, 3);
                    Info = l[0].Substring(4).Replace("(until terminating `.')", "").Trim();
                    l.Remove(l[0]);
                }

                if (l.Count <= 0) return;
                foreach (var s in l.Where(s => s != "."))
                {
                    Results.Add(s);
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }
        }
    }
}