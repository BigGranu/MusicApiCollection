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
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.FreeDB.Data
{
    /// <remarks />
    public class Disk
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public DiskResult Data = new DiskResult();

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
        ///     Create new Disk and clear the log
        /// </summary>
        public Disk()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Disk with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Disk(DiskResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     Data for a Disc
    /// </summary>
    public class DiskResult
    {
        /// <summary>
        ///     Title
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Artist
        /// </summary>
        public string Artist { get; set; } = string.Empty;

        /// <summary>
        ///     DiskLength
        /// </summary>
        public int DiskLength { get; set; }

        /// <summary>
        ///     Genre
        /// </summary>
        public string Genre { get; set; } = string.Empty;

        /// <summary>
        ///     Year
        /// </summary>
        public string Year { get; set; } = string.Empty;

        /// <summary>
        ///     DiskIds
        /// </summary>
        public List<string> DiskIds { get; set; } = new List<string>();

        /// <summary>
        ///     TrackFramesOffsets
        /// </summary>
        public List<int> TrackFramesOffsets { get; set; } = new List<int>();

        /// <summary>
        ///     Tracks
        /// </summary>
        public List<string> Tracks { get; set; } = new List<string>();

        /// <summary>
        ///     Attributes
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();
    }
}