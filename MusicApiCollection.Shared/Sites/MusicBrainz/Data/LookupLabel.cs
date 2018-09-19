using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class LookupLabel
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <remarks />
        [XmlElement("label")]
        public LookupLabelResult Data { get; set; }

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
        ///     Create new LookupRelease and clear the log
        /// </summary>
        public LookupLabel()
        {
        }

        /// <summary>
        ///     Create new LookupRelease with Result
        /// </summary>
        /// <param name="data">Result</param>
        public LookupLabel(LookupLabelResult data)
        {
            if (data == null)
                data = new LookupLabelResult();

            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class LookupLabelResult
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "sort-name")]
        public string Sortname { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "area")]
        public LookupLabelArea Area { get; set; }
        [XmlElement(ElementName = "life-span")]
        public LookupLabelLifespan Lifespan { get; set; }
        [XmlElement(ElementName = "alias-list")]
        public LookupLabelAliaslist Aliaslist { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "type-id")]
        public string Typeid { get; set; }
        [XmlAttribute(AttributeName = "score", Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public string Score { get; set; }
        [XmlElement(ElementName = "disambiguation")]
        public string Disambiguation { get; set; }
        [XmlElement(ElementName = "label-code")]
        public string Labelcode { get; set; }
    }

    [XmlRoot(ElementName = "life-span")]
    public class LookupLabelLifespan
    {
        [XmlElement(ElementName = "ended")]
        public string Ended { get; set; }
        [XmlElement(ElementName = "begin")]
        public string Begin { get; set; }
    }

    [XmlRoot(ElementName = "area")]
    public class LookupLabelArea
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "sort-name")]
        public string Sortname { get; set; }
        [XmlElement(ElementName = "life-span")]
        public LookupLabelLifespan Lifespan { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "type-id")]
        public string Typeid { get; set; }
    }

    [XmlRoot(ElementName = "alias")]
    public class LookupLabelAlias
    {
        [XmlAttribute(AttributeName = "sort-name")]
        public string Sortname { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "alias-list")]
    public class LookupLabelAliaslist
    {
        [XmlElement(ElementName = "alias")]
        public List<LookupLabelAlias> Alias { get; set; }
    }

    [XmlRoot(ElementName = "label-list")]
    public class LookupLabelLabellist
    {
        [XmlElement(ElementName = "label")]
        public List<Label> Label { get; set; }
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; }
        [XmlAttribute(AttributeName = "offset")]
        public string Offset { get; set; }
    }

    [XmlRoot(ElementName = "metadata")]
    public class LookupLabelMetadata
    {
        [XmlElement(ElementName = "label-list")]
        public LookupLabelLabellist Labellist { get; set; }
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
    }

}
