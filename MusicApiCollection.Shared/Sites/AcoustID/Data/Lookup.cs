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

using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.AcoustID.Data
{
    /// <summary>
    ///     Result
    /// </summary>
    public class Lookup
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Data for the Request
        /// </summary>
        public LookupResult Data = new LookupResult();

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage = string.Empty;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response = string.Empty;

        /// <summary>
        ///     Create new Lookup and clear the log
        /// </summary>
        public Lookup()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Lookup with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Lookup(LookupResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class LookupResult
    {
        /// <remarks />
        [DataMember(Name = "status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "results")]
        public List<Result> Results { get; set; } = new List<Result> {new Result()};
    }

    /// <remarks />
    [DataContract]
    public class Result
    {
        /// <remarks />
        [DataMember(Name = "recordings")]
        public List<RecordingResult> Recordings { get; set; } = new List<RecordingResult> {new RecordingResult()};

        /// <remarks />
        [DataMember(Name = "score")]
        public float Score { get; set; }

        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class RecordingResult
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "artists")]
        public List<Artist> Artists { get; set; } = new List<Artist> {new Artist()};

        /// <remarks />
        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; }
    }

    /// <remarks />
    [DataContract]
    public class Artist
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;
    }
}

