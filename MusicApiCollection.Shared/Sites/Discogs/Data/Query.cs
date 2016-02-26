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

using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.Discogs.Data
{
    /// <remarks />
    [DataContract]
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
        /// Create new Query and clear the log
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

    /// <remarks />
    [DataContract]
    public class QueryResult
    {
        /// <remarks />
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; } = new Pagination();

        /// <remarks />
        [DataMember(Name = "results")]
        public List<Result> Results { get; set; } = new List<Result> {new Result()};
    }

    /// <remarks />
    [DataContract]
    public class Result
    {
        /// <remarks />
        [DataMember(Name = "thumb")]
        public string Thumb { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "style")]
        public List<string> Style { get; set; } = new List<string> {""};

        /// <remarks />
        [DataMember(Name = "format")]
        public List<string> Format { get; set; } = new List<string> {""};

        /// <remarks />
        [DataMember(Name = "country")]
        public string Country { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "barcode")]
        public List<string> Barcode { get; set; } = new List<string> {""};

        /// <remarks />
        [DataMember(Name = "community")]
        public Community Community { get; set; } = new Community();

        /// <remarks />
        [DataMember(Name = "label")]
        public List<string> Label { get; set; } = new List<string> {""};

        /// <remarks />
        [DataMember(Name = "catno")]
        public string Catno { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "year")]
        public string Year { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "genre")]
        public List<string> Genre { get; set; } = new List<string> {""};
    }
}
