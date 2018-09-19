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

namespace MusicApiCollection.Sites.TheAudioDB.Data
{
    /// <remarks />
    [DataContract]
    public class DiscographyList
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public DiscographyListResult Data = new DiscographyListResult();

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
        ///     Create new DiscographyList and clear the log
        /// </summary>
        public DiscographyList()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new DiscographyList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public DiscographyList(DiscographyListResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     List of Discogrphy
    /// </summary>
    [DataContract]
    public class DiscographyListResult
    {
        /// <summary>
        ///     List of Discogrphy
        /// </summary>
        [DataMember(Name = "album")]
        public List<Discography> List { get; set; } = new List<Discography>();
    }

    /// <summary>
    ///     Data for a Discogrphy
    /// </summary>
    [DataContract]
    public class Discography
    {
        /// <summary>
        ///     Album
        /// </summary>
        [DataMember(Name = "strAlbum")]
        public string StrAlbum { get; set; } = string.Empty;

        /// <summary>
        ///     Year of Release
        /// </summary>
        [DataMember(Name = "intYearReleased")]
        public int? IntYearReleased { get; set; }
    }
}
