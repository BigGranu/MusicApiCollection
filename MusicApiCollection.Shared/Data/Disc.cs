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

namespace MusicApiCollection.Data
{
    /// <summary>
    ///     Global Disc
    /// </summary>
    public class Disc
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
        ///     Genre
        /// </summary>
        public string Categorie { get; set; } = string.Empty;

        /// <summary>
        ///     Year
        /// </summary>
        public string Year { get; set; } = string.Empty;

        /// <summary>
        ///     FrreDB DiskId
        /// </summary>
        public string FreeDbId { get; set; } = string.Empty;

        /// <summary>
        ///     FrreDB DiskId
        /// </summary>
        public string TheAudioDbId { get; set; } = string.Empty;

        /// <summary>
        ///     FrreDB DiskId
        /// </summary>
        public string MusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        ///     FrreDB DiskId
        /// </summary>
        public string GraceNoteId { get; set; } = string.Empty;

        /// <summary>
        ///     Tracks
        /// </summary>
        public List<DiscTrack> Tracks { get; set; } = new List<DiscTrack>();

        /// <summary>
        ///     Attributes
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();

        /// <summary>
        ///     Status
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        ///     Country
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        ///     Barcode
        /// </summary>
        public string Barcode { get; set; } = string.Empty;

        /// <summary>
        ///     Asin
        /// </summary>
        public string Asin { get; set; } = string.Empty;
    }

    /// <summary>
    ///     DiscTrack
    /// </summary>
    public class DiscTrack
    {
        /// <summary>
        ///     Frameoffset
        /// </summary>
        public int FrameOffset { get; set; }

        /// <summary>
        ///     Runtime
        /// </summary>
        public string RunTime { get; set; } = string.Empty;

        /// <summary>
        ///     Title
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Artist
        /// </summary>
        public string Artist { get; set; } = string.Empty;
    }
}