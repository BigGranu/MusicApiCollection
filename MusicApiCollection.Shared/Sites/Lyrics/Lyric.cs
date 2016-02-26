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

namespace MusicApiCollection.Sites.Lyrics
{
    /// <summary>
    ///     Result
    /// </summary>
    public class Lyric
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Data for the Request
        /// </summary>
        public LyricResult Data = new LyricResult();

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
        ///     Create new Lyric and clear the log
        /// </summary>
        public Lyric()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Lyric with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Lyric(LyricResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     Song Lyric
    /// </summary>
    public class LyricResult
    {
        /// <summary>
        ///     Songwrs
        /// </summary>
        public List<Writer> Writers { get; set; } = new List<Writer> {new Writer()};

        /// <summary>
        ///     Songtext
        /// </summary>
        public string Text { get; set; } = string.Empty;
    }

    /// <summary>
    ///     Songwriter
    /// </summary>
    public class Writer
    {
        /// <summary>
        ///     Fitstname
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        ///     Lastname
        /// </summary>
        public string LastName { get; set; } = string.Empty;
    }
}