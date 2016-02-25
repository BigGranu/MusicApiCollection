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
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.GraceNote.Data
{
    /// <remarks />
    public class Album
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AlbumResult Data = new AlbumResult();

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
        ///     Create new Album and clear the log
        /// </summary>
        public Album()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Album with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Album(AlbumResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    [XmlRoot("RESPONSES", Namespace = "", IsNullable = false)]
    public class AlbumResult
    {
        /// <summary>
        /// </summary>
        [XmlElement("RESPONSE")]
        public Response Response { get; set; } = new Response();
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Response
    {
        /// <remarks />
        [XmlElement("RANGE")]
        public Range Range { get; set; } = new Range();

        /// <remarks />
        [XmlElement("ALBUM")]
        public List<ResponseAlbum> Album { get; set; } = new List<ResponseAlbum>();

        /// <remarks />
        [XmlAttribute("STATUS")]
        public string Status { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Range
    {
        /// <remarks />
        [XmlElement("COUNT")]
        public string Count { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("START")]
        public string Start { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("END")]
        public string End { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class ResponseAlbum
    {
        /// <remarks />
        [XmlElement("GN_ID")]
        public string GnId { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("ARTIST")]
        public string Artist { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("TITLE")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("PKG_LANG")]
        public string PkgLang { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("DATE")]
        public string Date { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("GENRE")]
        public List<Genre> Genre { get; set; } = new List<Genre>();

        /// <remarks />
        [XmlElement("MATCHED_TRACK_NUM")]
        public string MatchedTrackNum { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("TRACK_COUNT")]
        public string TrackCount { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("TRACK")]
        public List<Track> Track { get; set; } = new List<Track>();

        /// <remarks />
        [XmlAttribute("ORD")]
        public string Ord { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [XmlElement("URL")]
        public List<ResponseAlbumUrl> Url { get; set; } = new List<ResponseAlbumUrl>();
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Track
    {
        /// <remarks />
        [XmlElement("TRACK_NUM")]
        public string TrackNum { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("GN_ID")]
        public string GnId { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("TITLE")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("GENRE")]
        public List<Genre> Genre { get; set; } = new List<Genre>();

        /// <remarks />
        [XmlElement("MOOD")]
        public List<Mood> Mood { get; set; } = new List<Mood>();

        /// <remarks />
        [XmlElement("TEMPO")]
        public List<Tempo> Tempo { get; set; } = new List<Tempo>();
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class ResponseAlbumUrl
    {
        /// <remarks />
        [XmlAttribute("TYPE")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("SIZE")]
        public string Size { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("WIDTH")]
        public string Width { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("HEIGHT")]
        public string Height { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Genre
    {
        /// <remarks />
        [XmlAttribute("NUM")]
        public string Num { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("ID")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Mood
    {
        /// <remarks />
        [XmlAttribute("ORD")]
        public string Num { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("ID")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Tempo
    {
        /// <remarks />
        [XmlAttribute("ORD")]
        public string Num { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("ID")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}