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
using System.Xml.Schema;
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks />
    public class Recording
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public RecordingResult Data = new RecordingResult();

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
        ///     Create new Recording and clear the log
        /// </summary>
        public Recording()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Recording with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Recording(RecordingResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class RecordingMetadata
    {
        /// <remarks />
        [XmlElement("recording-list")]
        public RecordingResult Recordinglist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("recording-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class RecordingResult
    {
        /// <remarks />
        [XmlElement("recording")]
        public List<RecordingData> Data { get; set; } = new List<RecordingData> {new RecordingData()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class RecordingData
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("length")]
        public int Length { get; set; }

        /// <remarks />
        [XmlArray("artist-credit"), XmlArrayItem("name-credit", IsNullable = false)]
        public List<RecordingNamecredit> Artistcredit { get; set; } = new List<RecordingNamecredit> {new RecordingNamecredit()};

        /// <remarks />
        [XmlArray("release-list"), XmlArrayItem("release", IsNullable = false)]
        public List<RecordingRelease> Releaselist { get; set; } = new List<RecordingRelease> {new RecordingRelease()};

        /// <remarks />
        [XmlElement("isrc-list")]
        public RecordingIsrclist Isrclist { get; set; } = new RecordingIsrclist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public int Score { get; set; }
    }

    /// <remarks />
    public class RecordingNamecredit
    {
        /// <remarks />
        [XmlElement("artist")]
        public RecordingArtist Artist { get; set; } = new RecordingArtist();

        /// <remarks />
        [XmlAttribute("joinphrase")]
        public string Joinphrase { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingArtist
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
        public List<Alias> Aliaslist { get; set; } = new List<Alias> {new Alias()};

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingRelease
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [XmlArray("artist-credit"), XmlArrayItem("name-credit", IsNullable = false)]
        public List<RecordingNamecredit> Artistcredit { get; set; } = new List<RecordingNamecredit> {new RecordingNamecredit()};

        /// <remarks />
        [XmlElement("release-group")]
        public RecordingReleasegroup Releasegroup { get; set; } = new RecordingReleasegroup();

        /// <remarks />
        [XmlElement("date")]
        public string Date { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("country")]
        public string Country { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("release-event-list")]
        public RecordingReleaseeventlist Releaseeventlist { get; set; } = new RecordingReleaseeventlist();

        /// <remarks />
        [XmlElement("medium-list")]
        public RecordingMediumlist Mediumlist { get; set; } = new RecordingMediumlist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingReleasegroup
    {
        /// <remarks />
        [XmlElement("primary-type")]
        public string Primarytype { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("secondary-type-list")]
        public RecordingSecondarytypelist Secondarytypelist { get; set; } = new RecordingSecondarytypelist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingSecondarytypelist
    {
        /// <remarks />
        [XmlElement("secondary-type")]
        public string Secondarytype { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingReleaseeventlist
    {
        /// <remarks />
        [XmlElement("release-event")]
        public RecordingReleaseevent Releaseevent { get; set; } = new RecordingReleaseevent();
    }

    /// <remarks />
    public class RecordingReleaseevent
    {
        /// <remarks />
        [XmlElement("date")]
        public string Date { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("area")]
        public RecordingArea Area { get; set; } = new RecordingArea();
    }

    /// <remarks />
    public class RecordingArea
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("iso-3166-1-code-list")]
        public Iso31661Codelist Iso31661Codelist { get; set; } = new Iso31661Codelist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingMediumlist
    {
        /// <remarks />
        [XmlElement("track-count")]
        public int Trackcount { get; set; }

        /// <remarks />
        [XmlElement("medium")]
        public RecordingMedium Medium { get; set; } = new RecordingMedium();
    }

    /// <remarks />
    public class RecordingMedium
    {
        /// <remarks />
        [XmlElement("position")]
        public int Position { get; set; }

        /// <remarks />
        [XmlElement("format")]
        public string Format { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("track-list")]
        public RecordingTracklist Tracklist { get; set; } = new RecordingTracklist();
    }

    /// <remarks />
    public class RecordingTracklist
    {
        /// <remarks />
        [XmlElement("track")]
        public RecordingTrack Track { get; set; } = new RecordingTrack();

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class RecordingTrack
    {
        /// <remarks />
        [XmlElement("number")]
        public string Number { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("length")]
        public int Length { get; set; }

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class RecordingIsrclist
    {
        /// <remarks />
        [XmlElement("isrc")]
        public RecordingIsrc Isrc { get; set; } = new RecordingIsrc();
    }

    /// <remarks />
    public class RecordingIsrc
    {
        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }
}
