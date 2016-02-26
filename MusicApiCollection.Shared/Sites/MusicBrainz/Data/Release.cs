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
    public class Release
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ReleaseResult Data = new ReleaseResult();

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
        ///     Create new Release and clear the log
        /// </summary>
        public Release()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Release with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Release(ReleaseResult data)
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
    public class ReleaseMetadata
    {
        /// <remarks />
        [XmlElement("release-list")]
        public ReleaseResult Releaselist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class ReleaseResult
    {
        /// <remarks />
        [XmlElement("release")]
        public List<ReleaseData> Data { get; set; } = new List<ReleaseData> {new ReleaseData()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class ReleaseData
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("packaging")]
        public string Packaging { get; set; } = string.Empty;

        /// <remarks/>
        [XmlElement("quality")]
        public string Quality { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("annotation")]
        public ReleaseAnnotation Annotation { get; set; } = new ReleaseAnnotation();

        /// <remarks />
        [XmlElement("Text-representation")]
        public ReleaseTextrepresentation Textrepresentation { get; set; } = new ReleaseTextrepresentation();

        /// <remarks />
        [XmlArray("artist-credit"), XmlArrayItem("name-credit", IsNullable = false)]
        public List<ReleaseNamecredit> Artistcredit { get; set; } = new List<ReleaseNamecredit> {new ReleaseNamecredit()};

        /// <remarks />
        [XmlElement("release-group")]
        public ReleaseReleasegroup Releasegroup { get; set; } = new ReleaseReleasegroup();

        /// <remarks />
        [XmlElement("date")]
        public string Date { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("country")]
        public string Country { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("release-event-list")]
        public ReleaseReleaseeventlist Releaseeventlist { get; set; } = new ReleaseReleaseeventlist();

        /// <remarks />
        [XmlElement("barcode")]
        public string Barcode { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("asin")]
        public string Asin { get; set; } = string.Empty;

        /// <remarks/>
        [XmlElement("cover-art-archive")]
        public Coverartarchive Coverartarchive { get; set; } = new Coverartarchive();

        /// <remarks />
        [XmlArray("label-info-list"), XmlArrayItem("label-info", IsNullable = false)]
        public List<ReleaseLabelinfo> Labelinfolist { get; set; } = new List<ReleaseLabelinfo> {new ReleaseLabelinfo()};

        /// <remarks />
        [XmlElement("medium-list")]
        public ReleaseMediumlist Mediumlist { get; set; } = new ReleaseMediumlist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public int Score { get; set; }
    }

    /// <remarks />
    public class ReleaseAnnotation
    {
        /// <remarks />
        [XmlElement("text")]
        public string Text { get; set; }
    }

    /// <remarks />
    public class ReleaseTextrepresentation
    {
        /// <remarks />
        [XmlElement("language")]
        public string Language { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("script")]
        public string Script { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleaseNamecredit
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("artist")]
        public ReleaseArtist Artist { get; set; } = new ReleaseArtist();

        /// <remarks />
        [XmlAttribute("joinphrase")]
        public string Joinphrase { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleaseArtist
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("disambiguation")]
        public string Disambiguation { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("alias-list")]
        public ReleaseAliaslist Aliaslist { get; set; } = new ReleaseAliaslist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleaseAliaslist
    {
        /// <remarks />
        [XmlElement("alias")]
        public List<Alias> Alias { get; set; } = new List<Alias> {new Alias()};
    }

    /// <remarks />
    public class ReleaseReleasegroup
    {
        /// <remarks />
        [XmlElement("primary-type")]
        public string Primarytype { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("secondary-type-list")]
        public ReleaseSecondarytypelist Secondarytypelist { get; set; } = new ReleaseSecondarytypelist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleaseSecondarytypelist
    {
        /// <remarks />
        [XmlElement("secondary-type")]
        public string Secondarytype { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleaseReleaseeventlist
    {
        /// <remarks />
        [XmlElement("release-event")]
        public ReleaseReleaseevent Releaseevent { get; set; } = new ReleaseReleaseevent();
    }

    /// <remarks />
    public class ReleaseReleaseevent
    {
        /// <remarks />
        [XmlElement("date")]
        public string Date { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("area")]
        public ReleaseArea Area { get; set; } = new ReleaseArea();
    }

    /// <remarks />
    public class ReleaseArea
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
    public class Coverartarchive
    {
        /// <remarks/>
        [XmlElement("artwork")]
        public bool Artwork { get; set; }

        /// <remarks/>
        [XmlElement("count")]
        public byte Count { get; set; }

        /// <remarks/>
        [XmlElement("front")]
        public bool Front { get; set; }

        /// <remarks/>
        [XmlElement("back")]
        public bool Back { get; set; }
    }

    /// <remarks />
    public class ReleaseLabelinfo
    {
        /// <remarks />
        [XmlElement("catalog-number")]
        public string Catalognumber { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("label")]
        public ReleaseLabelinfoLabel Label { get; set; } = new ReleaseLabelinfoLabel();
    }

    /// <remarks />
    public class ReleaseLabelinfoLabel
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleaseMediumlist
    {
        /// <remarks />
        [XmlElement("track-count")]
        public string Trackcount { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("medium")]
        public List<ReleaseMedium> Medium { get; set; } = new List<ReleaseMedium> {new ReleaseMedium()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }
    }

    /// <remarks />
    public class ReleaseMedium
    {
        /// <remarks />
        [XmlElement("position")]
        public string Position { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("format")]
        public string Format { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("disc-list")]
        public Disclist Disclist { get; set; } = new Disclist();

        /// <remarks />
        [XmlElement("track-list")]
        public GTracklist Tracklist { get; set; } = new GTracklist();
    }
}
