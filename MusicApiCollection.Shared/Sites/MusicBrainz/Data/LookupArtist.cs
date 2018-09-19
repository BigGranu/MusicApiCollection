using System.Collections.Generic;
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class LookupArtist
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <remarks />
        [XmlElement("artist")]
        public LookupArtistResult Data { get; set; }

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
        ///     Create new LookupArea and clear the log
        /// </summary>
        public LookupArtist()
        {
        }

        /// <summary>
        ///     Create new LookupArea with Result
        /// </summary>
        /// <param name="data">Result</param>
        public LookupArtist(LookupArtistResult data)
        {
            if (data == null)
                data = new LookupArtistResult();

            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupArtistResult
    {
        /// <remarks />
        [XmlElement(ElementName = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "annotation")]
        public LookupArtistAnnotation Annotation { get; set; } = new LookupArtistAnnotation();

        /// <remarks />
        [XmlElement(ElementName = "ipi")]
        public string Ipi { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "ipi-list")]
        public LookupArtistIpilist Ipilist { get; set; } = new LookupArtistIpilist();

        /// <remarks />
        [XmlElement(ElementName = "isni-list")]
        public LookupArtistIsnilist Isnilist { get; set; } = new LookupArtistIsnilist();

        /// <remarks />
        [XmlElement(ElementName = "gender")]
        public LookupArtistGender Gender { get; set; } = new LookupArtistGender();

        /// <remarks />
        [XmlElement(ElementName = "country")]
        public string Country { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "area")]
        public LookupArtistArea Area { get; set; } = new LookupArtistArea();

        /// <remarks />
        [XmlElement("begin-area")]
        public GArea Beginarea { get; set; } = new GArea();

        /// <remarks />
        [XmlElement("end-area")]
        public GArea Endarea { get; set; } = new GArea();

        /// <remarks />
        [XmlElement("life-span", IsNullable = false)]
        public Lifespan Lifespan { get; set; } = new Lifespan();

        /// <remarks />
        [XmlElement(ElementName = "alias-list")]
        public LookupArtistAliaslist Aliaslist { get; set; }

        /// <remarks />
        [XmlElement(ElementName = "recording-list")]
        public LookupArtistRecordinglist Recordinglist { get; set; }

        /// <remarks />
        [XmlElement(ElementName = "tag-list")]
        public LookupArtistTaglist Taglist { get; set; } = new LookupArtistTaglist();

        /// <remarks />
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "type-id")]
        public string Typeid { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "annotation")]
    public class LookupArtistAnnotation
    {
        /// <remarks />
        [XmlElement(ElementName = "text")]
        public string Text { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "ipi-list")]
    public class LookupArtistIpilist
    {
        /// <remarks />
        [XmlElement(ElementName = "ipi")]
        public List<string> Ipi { get; set; } = new List<string> {""};
    }

    /// <remarks />
    [XmlRoot(ElementName = "isni-list")]
    public class LookupArtistIsnilist
    {
        /// <remarks />
        [XmlElement(ElementName = "isni")]
        public string Isni { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "gender")]
    public class LookupArtistGender
    {
        /// <remarks />
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Text { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "iso-3166-1-code-list")]
    public class LookupArtistIso31661codelist
    {
        /// <remarks />
        [XmlElement(ElementName = "iso-3166-1-code")]
        public string Iso31661code { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "area")]
    public class LookupArtistArea
    {
        /// <remarks />
        [XmlElement(ElementName = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "iso-3166-1-code-list")]
        public LookupArtistIso31661codelist Iso31661codelist { get; set; } = new LookupArtistIso31661codelist();

        /// <remarks />
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "alias")]
    public class LookupArtistAlias
    {
        /// <remarks />
        [XmlAttribute(AttributeName = "sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "type-id")]
        public string Typeid { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Text { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "primary")]
        public string Primary { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "locale")]
        public string Locale { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "alias-list")]
    public class LookupArtistAliaslist
    {
        /// <remarks />
        [XmlElement(ElementName = "alias")]
        public List<LookupArtistAlias> Alias { get; set; }

        /// <remarks />
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "isrc")]
    public class LookupArtistIsrc
    {
        /// <remarks />
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "isrc-list")]
    public class LookupArtistIsrclist
    {
        /// <remarks />
        [XmlElement(ElementName = "isrc")]
        public LookupArtistIsrc Isrc { get; set; } = new LookupArtistIsrc();

        /// <remarks />
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "tag")]
    public class LookupArtistTag
    {
        /// <remarks />
        [XmlElement(ElementName = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "tag-list")]
    public class LookupArtistTaglist
    {
        /// <remarks />
        [XmlElement(ElementName = "tag")]
        public List<LookupArtistTag> Tag { get; set; } = new List<LookupArtistTag>();
    }

    /// <remarks />
    [XmlRoot(ElementName = "recording")]
    public class LookupArtistRecording
    {
        /// <remarks />
        [XmlElement(ElementName = "title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "length")]
        public string Length { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "disambiguation")]
        public string Disambiguation { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "isrc-list")]
        public LookupArtistIsrclist Isrclist { get; set; } = new LookupArtistIsrclist();

        /// <remarks />
        [XmlElement(ElementName = "tag-list")]
        public LookupArtistTaglist Taglist { get; set; } = new LookupArtistTaglist();

        /// <remarks />
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement(ElementName = "video")]
        public string Video { get; set; } = string.Empty;
    }

    /// <remarks />
    [XmlRoot(ElementName = "recording-list")]
    public class LookupArtistRecordinglist
    {
        /// <remarks />
        [XmlElement(ElementName = "recording")]
        public List<LookupArtistRecording> Recording { get; set; } = new List<LookupArtistRecording>();

        /// <remarks />
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; } = string.Empty;
    }
}
