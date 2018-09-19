using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    class LookupRecording
    {
    }

    [XmlRoot(ElementName = "life-span", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingLifespan
    {
        [XmlElement(ElementName = "ended", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Ended { get; set; }
        [XmlElement(ElementName = "begin", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Begin { get; set; }
    }

    [XmlRoot(ElementName = "area", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingArea
    {
        [XmlElement(ElementName = "name", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Name { get; set; }
        [XmlElement(ElementName = "sort-name", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Sortname { get; set; }
        [XmlElement(ElementName = "life-span", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public LookupRecordingLifespan Lifespan { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "type-id")]
        public string Typeid { get; set; }
    }

    [XmlRoot(ElementName = "alias", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingAlias
    {
        [XmlAttribute(AttributeName = "sort-name")]
        public string Sortname { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "alias-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingAliaslist
    {
        [XmlElement(ElementName = "alias", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public List<LookupRecordingAlias> Alias { get; set; }
    }

    [XmlRoot(ElementName = "label", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingLabel
    {
        [XmlElement(ElementName = "name", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Name { get; set; }
        [XmlElement(ElementName = "sort-name", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Sortname { get; set; }
        [XmlElement(ElementName = "country", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Country { get; set; }
        [XmlElement(ElementName = "area", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public LookupRecordingArea Area { get; set; }
        [XmlElement(ElementName = "life-span", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public LookupRecordingLifespan Lifespan { get; set; }
        [XmlElement(ElementName = "alias-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public LookupRecordingAliaslist Aliaslist { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "type-id")]
        public string Typeid { get; set; }
        [XmlAttribute(AttributeName = "score", Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public string Score { get; set; }
        [XmlElement(ElementName = "disambiguation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Disambiguation { get; set; }
        [XmlElement(ElementName = "label-code", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Labelcode { get; set; }
    }

    [XmlRoot(ElementName = "label-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingLabellist
    {
        [XmlElement(ElementName = "label", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public List<Label> Label { get; set; }
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; }
        [XmlAttribute(AttributeName = "offset")]
        public string Offset { get; set; }
    }

    [XmlRoot(ElementName = "metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupRecordingMetadata
    {
        [XmlElement(ElementName = "label-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public LookupRecordingLabellist Labellist { get; set; }
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
    }
}
