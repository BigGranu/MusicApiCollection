using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class metadata
    {
        private annotationlist annotationlistField;

        private XmlElement anyField;

        private def_areaelement_inner areaField;

        private arealist arealistField;
        private artist artistField;

        private artistlist artistlistField;

        private cdstublist cdstublistField;

        private collection collectionField;

        private collectionlist collectionlistField;

        private DateTime createdField;

        private bool createdFieldSpecified;

        private disc discField;

        private editor editorField;

        private editorlist editorlistField;

        private entitylist entitylistField;

        private @event eventField;

        private eventlist eventlistField;

        private freedbdisclist freedbdisclistField;

        private string generatorField;

        private genrelist genrelistField;

        private instrument instrumentField;

        private instrumentlist instrumentlistField;

        private isrc isrcField;

        private isrclist isrclistField;

        private label labelField;

        private labellist labellistField;

        private place placeField;

        private placelist placelistField;

        private puid puidField;

        private rating ratingField;

        // private Recording recordingField;

        private recordinglist recordinglistField;

        private release releaseField;

        private releasegroup releasegroupField;

        private releasegrouplist releasegrouplistField;

        private releaselist releaselistField;

        private series seriesField;

        private serieslist serieslistField;

        private taglist taglistField;

        private url urlField;

        private urllist urllistField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        private work workField;

        private worklist worklistField;

        /// <remarks />
        [XmlElement("artist")]
        public artist Artist { get; set; }

        /// <remarks />
        [XmlElement("release")]
        public release Release { get; set; }

        /// <remarks />
        [XmlElement("release-group")]
        public releasegroup Releasegroup { get; set; }

        /// <remarks />
        [XmlElement("recording")]
        public Recording Recording { get; set; }

        /// <remarks />
        [XmlElement("label")]
        public label Label { get; set; }

        /// <remarks />
        public work work
        {
            get => workField;
            set => workField = value;
        }

        /// <remarks />
        public def_areaelement_inner area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        public place place
        {
            get => placeField;
            set => placeField = value;
        }

        /// <remarks />
        public instrument instrument
        {
            get => instrumentField;
            set => instrumentField = value;
        }

        /// <remarks />
        public series series
        {
            get => seriesField;
            set => seriesField = value;
        }

        /// <remarks />
        public @event @event
        {
            get => eventField;
            set => eventField = value;
        }

        /// <remarks />
        public url url
        {
            get => urlField;
            set => urlField = value;
        }

        /// <remarks />
        public puid puid
        {
            get => puidField;
            set => puidField = value;
        }

        /// <remarks />
        public isrc isrc
        {
            get => isrcField;
            set => isrcField = value;
        }

        /// <remarks />
        public disc disc
        {
            get => discField;
            set => discField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string Userrating { get; set; }

        /// <remarks />
        public collection collection
        {
            get => collectionField;
            set => collectionField = value;
        }

        /// <remarks />
        public editor editor
        {
            get => editorField;
            set => editorField = value;
        }

        /// <remarks />
        [XmlElement("artist-list")]
        public artistlist Artistlist { get; set; }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist Releaselist { get; set; }

        /// <remarks />
        [XmlElement("release-group-list")]
        public releasegrouplist Releasegrouplist { get; set; }

        /// <remarks />
        [XmlElement("recording-list")]
        public recordinglist Recordinglist { get; set; }

        /// <remarks />
        [XmlElement("label-list")]
        public labellist Labellist { get; set; }

        /// <remarks />
        [XmlElement("work-list")]
        public worklist Worklist { get; set; }

        /// <remarks />
        [XmlElement("area-list")]
        public arealist Arealist { get; set; }

        /// <remarks />
        [XmlElement("place-list")]
        public placelist placelist
        {
            get => placelistField;
            set => placelistField = value;
        }

        /// <remarks />
        [XmlElement("instrument-list")]
        public instrumentlist instrumentlist
        {
            get => instrumentlistField;
            set => instrumentlistField = value;
        }

        /// <remarks />
        [XmlElement("series-list")]
        public serieslist serieslist
        {
            get => serieslistField;
            set => serieslistField = value;
        }

        /// <remarks />
        [XmlElement("event-list")]
        public eventlist eventlist
        {
            get => eventlistField;
            set => eventlistField = value;
        }

        /// <remarks />
        [XmlElement("url-list")]
        public urllist urllist
        {
            get => urllistField;
            set => urllistField = value;
        }

        /// <remarks />
        [XmlElement("isrc-list")]
        public isrclist isrclist
        {
            get => isrclistField;
            set => isrclistField = value;
        }

        /// <remarks />
        [XmlElement("annotation-list")]
        public annotationlist annotationlist
        {
            get => annotationlistField;
            set => annotationlistField = value;
        }

        /// <remarks />
        [XmlElement("cdstub-list")]
        public cdstublist cdstublist
        {
            get => cdstublistField;
            set => cdstublistField = value;
        }

        /// <remarks />
        [XmlElement("freedb-disc-list")]
        public freedbdisclist freedbdisclist
        {
            get => freedbdisclistField;
            set => freedbdisclistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        [XmlElement("collection-list")]
        public collectionlist collectionlist
        {
            get => collectionlistField;
            set => collectionlistField = value;
        }

        /// <remarks />
        [XmlElement("editor-list")]
        public editorlist Editorlist { get; set; }

        /// <remarks />
        [XmlElement("entity-list")]
        public entitylist Entitylist { get; set; }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string generator { get; set; }

        /// <remarks />
        [XmlAttribute]
        public DateTime created
        {
            get => createdField;
            set => createdField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool createdSpecified
        {
            get => createdFieldSpecified;
            set => createdFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class artist
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private def_areaelement_inner areaField;

        private def_areaelement_inner beginareaField;

        private string countryField;

        private string disambiguationField;

        private def_areaelement_inner endareaField;

        private gender genderField;

        private genrelist genrelistField;

        private string idField;

        private string ipiField;

        private List<string> ipilistField;

        private List<string> isnilistField;

        private lifespan lifespanField;
        private string nameField;

        private rating ratingField;

        private recordinglist recordinglistField;

        private relationlist[] relationlistField;

        private releasegrouplist releasegrouplistField;

        private releaselist releaselistField;

        private string sortnameField;

        private taglist taglistField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        private worklist worklistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlElement("sort-name")]
        public string sortname
        {
            get => sortnameField;
            set => sortnameField = value;
        }

        /// <remarks />
        public gender gender
        {
            get => genderField;
            set => genderField = value;
        }

        /// <remarks />
        public string country
        {
            get => countryField;
            set => countryField = value;
        }

        /// <remarks />
        public def_areaelement_inner area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        [XmlElement("begin-area")]
        public def_areaelement_inner beginarea
        {
            get => beginareaField;
            set => beginareaField = value;
        }

        /// <remarks />
        [XmlElement("end-area")]
        public def_areaelement_inner endarea
        {
            get => endareaField;
            set => endareaField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public string ipi
        {
            get => ipiField;
            set => ipiField = value;
        }

        /// <remarks />
        [XmlArray("ipi-list")]
        [XmlArrayItem("ipi", IsNullable = false)]
        public List<string> ipilist
        {
            get => ipilistField;
            set => ipilistField = value;
        }

        /// <remarks />
        [XmlArray("isni-list")]
        [XmlArrayItem("isni", IsNullable = false)]
        public List<string> isnilist
        {
            get => isnilistField;
            set => isnilistField = value;
        }

        /// <remarks />
        [XmlElement("life-span")]
        public lifespan lifespan
        {
            get => lifespanField;
            set => lifespanField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("recording-list")]
        public recordinglist recordinglist
        {
            get => recordinglistField;
            set => recordinglistField = value;
        }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist releaselist
        {
            get => releaselistField;
            set => releaselistField = value;
        }

        /// <remarks />
        [XmlElement("release-group-list")]
        public releasegrouplist releasegrouplist
        {
            get => releasegrouplistField;
            set => releasegrouplistField = value;
        }

        /// <remarks />
        [XmlElement("work-list")]
        public worklist worklist
        {
            get => worklistField;
            set => worklistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string userrating
        {
            get => userratingField;
            set => userratingField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class gender
    {
        private string idField;

        private List<string> textField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(TypeName = "def_area-element_inner", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("begin-area", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class def_areaelement_inner
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private List<string> iso31661codelistField;

        private List<string> iso31662codelistField;

        private List<string> iso31663codelistField;

        private lifespan lifespanField;
        private string nameField;

        private relationlist[] relationlistField;

        private string sortnameField;

        private taglist taglistField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlElement("sort-name")]
        public string sortname
        {
            get => sortnameField;
            set => sortnameField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        [XmlArray("iso-3166-1-code-list")]
        [XmlArrayItem("iso-3166-1-code", IsNullable = false)]
        public List<string> iso31661codelist
        {
            get => iso31661codelistField;
            set => iso31661codelistField = value;
        }

        /// <remarks />
        [XmlArray("iso-3166-2-code-list")]
        [XmlArrayItem("iso-3166-2-code", IsNullable = false)]
        public List<string> iso31662codelist
        {
            get => iso31662codelistField;
            set => iso31662codelistField = value;
        }

        /// <remarks />
        [XmlArray("iso-3166-3-code-list")]
        [XmlArrayItem("iso-3166-3-code", IsNullable = false)]
        public List<string> iso31663codelist
        {
            get => iso31663codelistField;
            set => iso31663codelistField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        [XmlElement("life-span")]
        public lifespan lifespan
        {
            get => lifespanField;
            set => lifespanField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class annotation
    {
        private XmlElement anyField;
        private string entityField;

        private string nameField;

        private string textField;

        private string typeField;

        /// <remarks />
        [XmlElement(DataType = "anyURI")]
        public string entity
        {
            get => entityField;
            set => entityField = value;
        }

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string text
        {
            get => textField;
            set => textField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("life-span", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class lifespan
    {
        private string beginField;

        private ended endedField;

        private bool endedFieldSpecified;

        private string endField;

        /// <remarks />
        public string begin
        {
            get => beginField;
            set => beginField = value;
        }

        /// <remarks />
        public string end
        {
            get => endField;
            set => endField = value;
        }

        /// <remarks />
        public ended ended
        {
            get => endedField;
            set => endedField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool endedSpecified
        {
            get => endedFieldSpecified;
            set => endedFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum ended
    {
        /// <remarks />
        @true
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("alias-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class aliaslist
    {
        private alias[] aliasField;

        private string countField;

        private string offsetField;

        /// <remarks />
        [XmlElement("alias")]
        public alias[] alias
        {
            get => aliasField;
            set => aliasField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class alias
    {
        private string begindateField;

        private string enddateField;
        private string localeField;

        private string primaryField;

        private string sortnameField;

        private List<string> textField;

        private string typeField;

        private string typeidField;

        /// <remarks />
        [XmlAttribute]
        public string locale
        {
            get => localeField;
            set => localeField = value;
        }

        /// <remarks />
        [XmlAttribute("sort-name")]
        public string sortname
        {
            get => sortnameField;
            set => sortnameField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string primary
        {
            get => primaryField;
            set => primaryField = value;
        }

        /// <remarks />
        [XmlAttribute("begin-date")]
        public string begindate
        {
            get => begindateField;
            set => begindateField = value;
        }

        /// <remarks />
        [XmlAttribute("end-date")]
        public string enddate
        {
            get => enddateField;
            set => enddateField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("relation-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class relationlist
    {
        private string countField;

        private string offsetField;
        private relation[] relationField;

        private string targettypeField;

        /// <remarks />
        [XmlElement("relation")]
        public relation[] relation
        {
            get => relationField;
            set => relationField = value;
        }

        /// <remarks />
        [XmlAttribute("target-type", DataType = "anyURI")]
        public string targettype
        {
            get => targettypeField;
            set => targettypeField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class relation
    {
        private relationAttribute[] attributelistField;

        private string beginField;

        private def_direction directionField;

        private bool directionFieldSpecified;

        private ended endedField;

        private bool endedFieldSpecified;

        private string endField;

        private object itemField;

        private string orderingkeyField;

        private string sourcecreditField;

        private string targetcreditField;
        private target targetField;

        private string typeField;

        private string typeidField;

        /// <remarks />
        public target target
        {
            get => targetField;
            set => targetField = value;
        }

        /// <remarks />
        [XmlElement("ordering-key", DataType = "nonNegativeInteger")]
        public string orderingkey
        {
            get => orderingkeyField;
            set => orderingkeyField = value;
        }

        /// <remarks />
        public def_direction direction
        {
            get => directionField;
            set => directionField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool directionSpecified
        {
            get => directionFieldSpecified;
            set => directionFieldSpecified = value;
        }

        /// <remarks />
        [XmlArray("attribute-list")]
        [XmlArrayItem("attribute", IsNullable = false)]
        public relationAttribute[] attributelist
        {
            get => attributelistField;
            set => attributelistField = value;
        }

        /// <remarks />
        public string begin
        {
            get => beginField;
            set => beginField = value;
        }

        /// <remarks />
        public string end
        {
            get => endField;
            set => endField = value;
        }

        /// <remarks />
        public ended ended
        {
            get => endedField;
            set => endedField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool endedSpecified
        {
            get => endedFieldSpecified;
            set => endedFieldSpecified = value;
        }

        /// <remarks />
        [XmlAnyElement]
        [XmlElement("area", typeof(def_areaelement_inner))]
        [XmlElement("artist", typeof(artist))]
        [XmlElement("event", typeof(@event))]
        [XmlElement("instrument", typeof(instrument))]
        [XmlElement("label", typeof(label))]
        [XmlElement("place", typeof(place))]
        [XmlElement("recording", typeof(Recording))]
        [XmlElement("release", typeof(release))]
        [XmlElement("release-group", typeof(releasegroup))]
        [XmlElement("series", typeof(series))]
        [XmlElement("work", typeof(work))]
        public object Item
        {
            get => itemField;
            set => itemField = value;
        }

        /// <remarks />
        [XmlElement("source-credit")]
        public string sourcecredit
        {
            get => sourcecreditField;
            set => sourcecreditField = value;
        }

        /// <remarks />
        [XmlElement("target-credit")]
        public string targetcredit
        {
            get => targetcreditField;
            set => targetcreditField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class target
    {
        private string idField;

        private string valueField;

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlText(DataType = "anyURI")]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("direction", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum def_direction
    {
        /// <remarks />
        both,

        /// <remarks />
        forward,

        /// <remarks />
        backward
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class relationAttribute
    {
        private string creditedasField;

        private List<string> textField;
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }

        /// <remarks />
        [XmlAttribute("credited-as")]
        public string creditedas
        {
            get => creditedasField;
            set => creditedasField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class @event
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private cancelled cancelledField;

        private bool cancelledFieldSpecified;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private eventLifespan lifespanField;
        private string nameField;

        private rating ratingField;

        private relationlist[] relationlistField;

        private string setlistField;

        private taglist taglistField;

        private string timeField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public cancelled cancelled
        {
            get => cancelledField;
            set => cancelledField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool cancelledSpecified
        {
            get => cancelledFieldSpecified;
            set => cancelledFieldSpecified = value;
        }

        /// <remarks />
        [XmlElement("life-span")]
        public eventLifespan lifespan
        {
            get => lifespanField;
            set => lifespanField = value;
        }

        /// <remarks />
        public string time
        {
            get => timeField;
            set => timeField = value;
        }

        /// <remarks />
        public string setlist
        {
            get => setlistField;
            set => setlistField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string userrating
        {
            get => userratingField;
            set => userratingField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum cancelled
    {
        /// <remarks />
        @true
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class eventLifespan
    {
        private string beginField;

        private string endField;

        /// <remarks />
        public string begin
        {
            get => beginField;
            set => beginField = value;
        }

        /// <remarks />
        public string end
        {
            get => endField;
            set => endField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("tag-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class taglist
    {
        private string countField;

        private string offsetField;
        private tag[] tagField;

        /// <remarks />
        [XmlElement("tag")]
        public tag[] tag
        {
            get => tagField;
            set => tagField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class tag
    {
        private string countField;
        private string nameField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("user-tag-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class usertaglist
    {
        private string countField;

        private string offsetField;
        private usertag[] usertagField;

        /// <remarks />
        [XmlElement("user-tag")]
        public usertag[] usertag
        {
            get => usertagField;
            set => usertagField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("user-tag", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class usertag
    {
        private string nameField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("genre-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class genrelist
    {
        private string countField;
        private genre[] genreField;

        private string offsetField;

        /// <remarks />
        [XmlElement("genre")]
        public genre[] genre
        {
            get => genreField;
            set => genreField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class genre
    {
        private string countField;
        private string nameField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("user-genre-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class usergenrelist
    {
        private string countField;

        private string offsetField;
        private usergenre[] usergenreField;

        /// <remarks />
        [XmlElement("user-genre")]
        public usergenre[] usergenre
        {
            get => usergenreField;
            set => usergenreField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("user-genre", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class usergenre
    {
        private string nameField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class rating
    {
        private float valueField;
        private string votescountField;

        /// <remarks />
        [XmlAttribute("votes-count", DataType = "nonNegativeInteger")]
        public string votescount
        {
            get => votescountField;
            set => votescountField = value;
        }

        /// <remarks />
        [XmlText]
        public float Value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class instrument
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private string descriptionField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;
        private string nameField;

        private relationlist[] relationlistField;

        private taglist taglistField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public string description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class label
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private def_areaelement_inner areaField;

        private string countryField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private string ipiField;

        private List<string> ipilistField;

        private List<string> isnilistField;

        private string labelcodeField;

        private lifespan lifespanField;
        private string nameField;

        private rating ratingField;

        private relationlist[] relationlistField;

        private releaselist releaselistField;

        private string sortnameField;

        private taglist taglistField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlElement("sort-name")]
        public string sortname
        {
            get => sortnameField;
            set => sortnameField = value;
        }

        /// <remarks />
        [XmlElement("label-code", DataType = "nonNegativeInteger")]
        public string labelcode
        {
            get => labelcodeField;
            set => labelcodeField = value;
        }

        /// <remarks />
        public string ipi
        {
            get => ipiField;
            set => ipiField = value;
        }

        /// <remarks />
        [XmlArray("ipi-list")]
        [XmlArrayItem("ipi", IsNullable = false)]
        public List<string> ipilist
        {
            get => ipilistField;
            set => ipilistField = value;
        }

        /// <remarks />
        [XmlArray("isni-list")]
        [XmlArrayItem("isni", IsNullable = false)]
        public List<string> isnilist
        {
            get => isnilistField;
            set => isnilistField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public string country
        {
            get => countryField;
            set => countryField = value;
        }

        /// <remarks />
        public def_areaelement_inner area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        [XmlElement("life-span")]
        public lifespan lifespan
        {
            get => lifespanField;
            set => lifespanField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist releaselist
        {
            get => releaselistField;
            set => releaselistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string userrating
        {
            get => userratingField;
            set => userratingField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class releaselist
    {
        private string countField;

        private string offsetField;
        private release[] releaseField;

        /// <remarks />
        [XmlElement("release")]
        public release[] release
        {
            get => releaseField;
            set => releaseField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class release
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private namecredit[] artistcreditField;

        private string asinField;

        private string barcodeField;

        private collectionlist collectionlistField;

        private string countryField;

        private coverartarchive coverartarchiveField;

        private string dateField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private labelinfolist labelinfolistField;

        private mediumlist mediumlistField;

        private string packagingField;

        private def_quality qualityField;

        private bool qualityFieldSpecified;

        private relationlist[] relationlistField;

        private releaseeventlist releaseeventlistField;

        private releasegroup releasegroupField;

        private status statusField;

        private taglist taglistField;

        private textrepresentation textrepresentationField;
        private string titleField;

        private usergenrelist usergenrelistField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        public status status
        {
            get => statusField;
            set => statusField = value;
        }

        /// <remarks />
        public def_quality quality
        {
            get => qualityField;
            set => qualityField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool qualitySpecified
        {
            get => qualityFieldSpecified;
            set => qualityFieldSpecified = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public string packaging
        {
            get => packagingField;
            set => packagingField = value;
        }

        /// <remarks />
        [XmlElement("text-representation")]
        public textrepresentation textrepresentation
        {
            get => textrepresentationField;
            set => textrepresentationField = value;
        }

        /// <remarks />
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit", IsNullable = false)]
        public namecredit[] artistcredit
        {
            get => artistcreditField;
            set => artistcreditField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("release-group")]
        public releasegroup releasegroup
        {
            get => releasegroupField;
            set => releasegroupField = value;
        }

        /// <remarks />
        public string date
        {
            get => dateField;
            set => dateField = value;
        }

        /// <remarks />
        public string country
        {
            get => countryField;
            set => countryField = value;
        }

        /// <remarks />
        [XmlElement("release-event-list")]
        public releaseeventlist releaseeventlist
        {
            get => releaseeventlistField;
            set => releaseeventlistField = value;
        }

        /// <remarks />
        public string barcode
        {
            get => barcodeField;
            set => barcodeField = value;
        }

        /// <remarks />
        public string asin
        {
            get => asinField;
            set => asinField = value;
        }

        /// <remarks />
        [XmlElement("cover-art-archive")]
        public coverartarchive coverartarchive
        {
            get => coverartarchiveField;
            set => coverartarchiveField = value;
        }

        /// <remarks />
        [XmlElement("label-info-list")]
        public labelinfolist labelinfolist
        {
            get => labelinfolistField;
            set => labelinfolistField = value;
        }

        /// <remarks />
        [XmlElement("medium-list")]
        public mediumlist mediumlist
        {
            get => mediumlistField;
            set => mediumlistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        [XmlElement("collection-list")]
        public collectionlist collectionlist
        {
            get => collectionlistField;
            set => collectionlistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class status
    {
        private string idField;

        private List<string> textField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("quality", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum def_quality
    {
        /// <remarks />
        low,

        /// <remarks />
        normal,

        /// <remarks />
        high
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("text-representation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class textrepresentation
    {
        private string languageField;

        private string scriptField;

        /// <remarks />
        public string language
        {
            get => languageField;
            set => languageField = value;
        }

        /// <remarks />
        public string script
        {
            get => scriptField;
            set => scriptField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("name-credit", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class namecredit
    {
        private artist artistField;

        private string joinphraseField;
        private string nameField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public artist artist
        {
            get => artistField;
            set => artistField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string joinphrase
        {
            get => joinphraseField;
            set => joinphraseField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-group", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class releasegroup
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private namecredit[] artistcreditField;

        private string disambiguationField;

        private string firstreleasedateField;

        private genrelist genrelistField;

        private string idField;

        private primarytype primarytypeField;

        private rating ratingField;

        private relationlist[] relationlistField;

        private releaselist releaselistField;

        private secondarytype[] secondarytypelistField;

        private taglist taglistField;
        private string titleField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        [XmlElement("first-release-date")]
        public string firstreleasedate
        {
            get => firstreleasedateField;
            set => firstreleasedateField = value;
        }

        /// <remarks />
        [XmlElement("primary-type")]
        public primarytype primarytype
        {
            get => primarytypeField;
            set => primarytypeField = value;
        }

        /// <remarks />
        [XmlArray("secondary-type-list")]
        [XmlArrayItem("secondary-type", IsNullable = false)]
        public secondarytype[] secondarytypelist
        {
            get => secondarytypelistField;
            set => secondarytypelistField = value;
        }

        /// <remarks />
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit", IsNullable = false)]
        public namecredit[] artistcredit
        {
            get => artistcreditField;
            set => artistcreditField = value;
        }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist releaselist
        {
            get => releaselistField;
            set => releaselistField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string userrating
        {
            get => userratingField;
            set => userratingField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("primary-type", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class primarytype
    {
        private string idField;

        private List<string> textField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("secondary-type", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class secondarytype
    {
        private string idField;

        private List<string> textField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-event-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class releaseeventlist
    {
        private string countField;

        private string offsetField;
        private releaseevent[] releaseeventField;

        /// <remarks />
        [XmlElement("release-event")]
        public releaseevent[] releaseevent
        {
            get => releaseeventField;
            set => releaseeventField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-event", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class releaseevent
    {
        private def_areaelement_inner areaField;
        private string dateField;

        /// <remarks />
        public string date
        {
            get => dateField;
            set => dateField = value;
        }

        /// <remarks />
        public def_areaelement_inner area
        {
            get => areaField;
            set => areaField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("cover-art-archive", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class coverartarchive
    {
        private artwork artworkField;

        private back backField;

        private string countField;

        private darkened darkenedField;

        private bool darkenedFieldSpecified;

        private front frontField;

        /// <remarks />
        public artwork artwork
        {
            get => artworkField;
            set => artworkField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        public front front
        {
            get => frontField;
            set => frontField = value;
        }

        /// <remarks />
        public back back
        {
            get => backField;
            set => backField = value;
        }

        /// <remarks />
        public darkened darkened
        {
            get => darkenedField;
            set => darkenedField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool darkenedSpecified
        {
            get => darkenedFieldSpecified;
            set => darkenedFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum artwork
    {
        /// <remarks />
        @true,

        /// <remarks />
        @false
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum front
    {
        /// <remarks />
        @true,

        /// <remarks />
        @false
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum back
    {
        /// <remarks />
        @true,

        /// <remarks />
        @false
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum darkened
    {
        /// <remarks />
        @true
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("label-info-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class labelinfolist
    {
        private string countField;
        private labelinfo[] labelinfoField;

        private string offsetField;

        /// <remarks />
        [XmlElement("label-info")]
        public labelinfo[] labelinfo
        {
            get => labelinfoField;
            set => labelinfoField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("label-info", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class labelinfo
    {
        private string catalognumberField;

        private label labelField;

        /// <remarks />
        [XmlElement("catalog-number")]
        public string catalognumber
        {
            get => catalognumberField;
            set => catalognumberField = value;
        }

        /// <remarks />
        public label label
        {
            get => labelField;
            set => labelField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("medium-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class mediumlist
    {
        private string countField;

        private medium[] mediumField;

        private string offsetField;
        private string trackcountField;

        /// <remarks />
        [XmlElement("track-count", DataType = "nonNegativeInteger")]
        public string trackcount
        {
            get => trackcountField;
            set => trackcountField = value;
        }

        /// <remarks />
        [XmlElement("medium")]
        public medium[] medium
        {
            get => mediumField;
            set => mediumField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class medium
    {
        private datatracklist datatracklistField;

        private disclist disclistField;

        private format formatField;

        private string positionField;

        private def_trackdata pregapField;
        private string titleField;

        private mediumTracklist tracklistField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string position
        {
            get => positionField;
            set => positionField = value;
        }

        /// <remarks />
        public format format
        {
            get => formatField;
            set => formatField = value;
        }

        /// <remarks />
        [XmlElement("disc-list")]
        public disclist disclist
        {
            get => disclistField;
            set => disclistField = value;
        }

        /// <remarks />
        public def_trackdata pregap
        {
            get => pregapField;
            set => pregapField = value;
        }

        /// <remarks />
        [XmlElement("track-list")]
        public mediumTracklist tracklist
        {
            get => tracklistField;
            set => tracklistField = value;
        }

        /// <remarks />
        [XmlElement("data-track-list")]
        public datatracklist datatracklist
        {
            get => datatracklistField;
            set => datatracklistField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class format
    {
        private string idField;

        private List<string> textField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("disc-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class disclist
    {
        private string countField;
        private disc[] discField;

        private string offsetField;

        /// <remarks />
        [XmlElement("disc")]
        public disc[] disc
        {
            get => discField;
            set => discField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class disc
    {
        private XmlElement anyField;

        private string idField;

        private offsetlist offsetlistField;

        private releaselist releaselistField;
        private string sectorsField;

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string sectors
        {
            get => sectorsField;
            set => sectorsField = value;
        }

        /// <remarks />
        [XmlElement("offset-list")]
        public offsetlist offsetlist
        {
            get => offsetlistField;
            set => offsetlistField = value;
        }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist releaselist
        {
            get => releaselistField;
            set => releaselistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("offset-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class offsetlist
    {
        private string countField;

        private string offset1Field;
        private offset[] offsetField;

        /// <remarks />
        [XmlElement("offset")]
        public offset[] offset
        {
            get => offsetField;
            set => offsetField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute("offset", DataType = "nonNegativeInteger")]
        public string offset1
        {
            get => offset1Field;
            set => offset1Field = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class offset
    {
        private string positionField;

        private string valueField;

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string position
        {
            get => positionField;
            set => positionField = value;
        }

        /// <remarks />
        [XmlText(DataType = "nonNegativeInteger")]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(TypeName = "def_track-data", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("pregap", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class def_trackdata
    {
        private namecredit[] artistcreditField;

        private string idField;

        private string lengthField;

        private string numberField;
        private string positionField;

        private Recording recordingField;

        private string titleField;

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string position
        {
            get => positionField;
            set => positionField = value;
        }

        /// <remarks />
        public string number
        {
            get => numberField;
            set => numberField = value;
        }

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string length
        {
            get => lengthField;
            set => lengthField = value;
        }

        /// <remarks />
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit", IsNullable = false)]
        public namecredit[] artistcredit
        {
            get => artistcreditField;
            set => artistcreditField = value;
        }

        /// <remarks />
        public Recording recording
        {
            get => recordingField;
            set => recordingField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("recording", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Recording
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private namecredit[] artistcreditField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private isrclist isrclistField;

        private string lengthField;

        private puidlist puidlistField;

        private rating ratingField;

        private relationlist[] relationlistField;

        private releaselist releaselistField;

        private taglist taglistField;
        private string titleField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        private video videoField;

        private bool videoFieldSpecified;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string length
        {
            get => lengthField;
            set => lengthField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public video video
        {
            get => videoField;
            set => videoField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool videoSpecified
        {
            get => videoFieldSpecified;
            set => videoFieldSpecified = value;
        }

        /// <remarks />
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit", IsNullable = false)]
        public namecredit[] artistcredit
        {
            get => artistcreditField;
            set => artistcreditField = value;
        }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist releaselist
        {
            get => releaselistField;
            set => releaselistField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("puid-list")]
        public puidlist puidlist
        {
            get => puidlistField;
            set => puidlistField = value;
        }

        /// <remarks />
        [XmlElement("isrc-list")]
        public isrclist isrclist
        {
            get => isrclistField;
            set => isrclistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string userrating
        {
            get => userratingField;
            set => userratingField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum video
    {
        /// <remarks />
        @true
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("puid-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class puidlist
    {
        private string countField;

        private string offsetField;
        private puid[] puidField;

        /// <remarks />
        [XmlElement("puid")]
        public puid[] puid
        {
            get => puidField;
            set => puidField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class puid
    {
        private XmlElement anyField;

        private string idField;
        private recordinglist recordinglistField;

        /// <remarks />
        [XmlElement("recording-list")]
        public recordinglist recordinglist
        {
            get => recordinglistField;
            set => recordinglistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("recording-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class recordinglist
    {
        private string countField;

        private string offsetField;
        private Recording[] recordingField;

        /// <remarks />
        [XmlElement("recording")]
        public Recording[] recording
        {
            get => recordingField;
            set => recordingField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("isrc-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class isrclist
    {
        private string countField;
        private isrc[] isrcField;

        private string offsetField;

        /// <remarks />
        [XmlElement("isrc")]
        public isrc[] isrc
        {
            get => isrcField;
            set => isrcField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class isrc
    {
        private XmlElement anyField;

        private string idField;
        private recordinglist recordinglistField;

        /// <remarks />
        [XmlElement("recording-list")]
        public recordinglist recordinglist
        {
            get => recordinglistField;
            set => recordinglistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class mediumTracklist
    {
        private string countField;

        private string offsetField;
        private def_trackdata[] trackField;

        /// <remarks />
        [XmlElement("track")]
        public def_trackdata[] track
        {
            get => trackField;
            set => trackField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("data-track-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class datatracklist
    {
        private string countField;

        private string offsetField;
        private def_trackdata[] trackField;

        /// <remarks />
        [XmlElement("track")]
        public def_trackdata[] track
        {
            get => trackField;
            set => trackField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("collection-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class collectionlist
    {
        private collection[] collectionField;

        private string countField;

        private string offsetField;

        /// <remarks />
        [XmlElement("collection")]
        public collection[] collection
        {
            get => collectionField;
            set => collectionField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class collection
    {
        private arealist arealistField;

        private artistlist artistlistField;

        private string editorField;

        private string entitytypeField;

        private eventlist eventlistField;

        private string idField;

        private instrumentlist instrumentlistField;

        private labellist labellistField;
        private string nameField;

        private placelist placelistField;

        private recordinglist recordinglistField;

        private releasegrouplist releasegrouplistField;

        private releaselist releaselistField;

        private serieslist serieslistField;

        private string typeField;

        private string typeidField;

        private worklist worklistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string editor
        {
            get => editorField;
            set => editorField = value;
        }

        /// <remarks />
        [XmlElement("area-list")]
        public arealist arealist
        {
            get => arealistField;
            set => arealistField = value;
        }

        /// <remarks />
        [XmlElement("artist-list")]
        public artistlist artistlist
        {
            get => artistlistField;
            set => artistlistField = value;
        }

        /// <remarks />
        [XmlElement("event-list")]
        public eventlist eventlist
        {
            get => eventlistField;
            set => eventlistField = value;
        }

        /// <remarks />
        [XmlElement("instrument-list")]
        public instrumentlist instrumentlist
        {
            get => instrumentlistField;
            set => instrumentlistField = value;
        }

        /// <remarks />
        [XmlElement("label-list")]
        public labellist labellist
        {
            get => labellistField;
            set => labellistField = value;
        }

        /// <remarks />
        [XmlElement("place-list")]
        public placelist placelist
        {
            get => placelistField;
            set => placelistField = value;
        }

        /// <remarks />
        [XmlElement("recording-list")]
        public recordinglist recordinglist
        {
            get => recordinglistField;
            set => recordinglistField = value;
        }

        /// <remarks />
        [XmlElement("release-list")]
        public releaselist releaselist
        {
            get => releaselistField;
            set => releaselistField = value;
        }

        /// <remarks />
        [XmlElement("release-group-list")]
        public releasegrouplist releasegrouplist
        {
            get => releasegrouplistField;
            set => releasegrouplistField = value;
        }

        /// <remarks />
        [XmlElement("series-list")]
        public serieslist serieslist
        {
            get => serieslistField;
            set => serieslistField = value;
        }

        /// <remarks />
        [XmlElement("work-list")]
        public worklist worklist
        {
            get => worklistField;
            set => worklistField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }

        /// <remarks />
        [XmlAttribute("entity-type", DataType = "anyURI")]
        public string entitytype
        {
            get => entitytypeField;
            set => entitytypeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("area-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class arealist
    {
        private def_areaelement_inner[] areaField;

        private string countField;

        private string offsetField;

        /// <remarks />
        [XmlElement("area")]
        public def_areaelement_inner[] area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("artist-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class artistlist
    {
        private artist[] artistField;

        private string countField;

        private string offsetField;

        /// <remarks />
        [XmlElement("artist")]
        public artist[] artist
        {
            get => artistField;
            set => artistField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("event-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class eventlist
    {
        private string countField;
        private @event[] eventField;

        private string offsetField;

        /// <remarks />
        [XmlElement("event")]
        public @event[] @event
        {
            get => eventField;
            set => eventField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("instrument-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class instrumentlist
    {
        private string countField;
        private instrument[] instrumentField;

        private string offsetField;

        /// <remarks />
        [XmlElement("instrument")]
        public instrument[] instrument
        {
            get => instrumentField;
            set => instrumentField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("label-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class labellist
    {
        private string countField;
        private label[] labelField;

        private string offsetField;

        /// <remarks />
        [XmlElement("label")]
        public label[] label
        {
            get => labelField;
            set => labelField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("place-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class placelist
    {
        private string countField;

        private string offsetField;
        private place[] placeField;

        /// <remarks />
        [XmlElement("place")]
        public place[] place
        {
            get => placeField;
            set => placeField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class place
    {
        private string addressField;

        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private def_areaelement_inner areaField;

        private coordinates coordinatesField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private lifespan lifespanField;
        private string nameField;

        private relationlist[] relationlistField;

        private taglist taglistField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        public string address
        {
            get => addressField;
            set => addressField = value;
        }

        /// <remarks />
        public coordinates coordinates
        {
            get => coordinatesField;
            set => coordinatesField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public def_areaelement_inner area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        [XmlElement("life-span")]
        public lifespan lifespan
        {
            get => lifespanField;
            set => lifespanField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class coordinates
    {
        private string latitudeField;

        private string longitudeField;

        /// <remarks />
        public string latitude
        {
            get => latitudeField;
            set => latitudeField = value;
        }

        /// <remarks />
        public string longitude
        {
            get => longitudeField;
            set => longitudeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-group-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class releasegrouplist
    {
        private string countField;

        private string offsetField;
        private releasegroup[] releasegroupField;

        /// <remarks />
        [XmlElement("release-group")]
        public releasegroup[] releasegroup
        {
            get => releasegroupField;
            set => releasegroupField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("series-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class serieslist
    {
        private string countField;

        private string offsetField;
        private series[] seriesField;

        /// <remarks />
        [XmlElement("series")]
        public series[] series
        {
            get => seriesField;
            set => seriesField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class series
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;
        private string nameField;

        private string orderingattributeField;

        private relationlist[] relationlistField;

        private taglist taglistField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        [XmlElement("ordering-attribute")]
        public string orderingattribute
        {
            get => orderingattributeField;
            set => orderingattributeField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("work-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class worklist
    {
        private string countField;

        private string offsetField;
        private work[] workField;

        /// <remarks />
        [XmlElement("work")]
        public work[] work
        {
            get => workField;
            set => workField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class work
    {
        private aliaslist aliaslistField;

        private annotation annotationField;

        private XmlElement anyField;

        private namecredit[] artistcreditField;

        private workAttribute[] attributelistField;

        private string disambiguationField;

        private genrelist genrelistField;

        private string idField;

        private string iswcField;

        private iswclist iswclistField;

        private string languageField;

        private languagelist languagelistField;

        private rating ratingField;

        private relationlist[] relationlistField;

        private taglist taglistField;
        private string titleField;

        private string typeField;

        private string typeidField;

        private usergenrelist usergenrelistField;

        private string userratingField;

        private usertaglist usertaglistField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        public string language
        {
            get => languageField;
            set => languageField = value;
        }

        /// <remarks />
        [XmlElement("language-list")]
        public languagelist languagelist
        {
            get => languagelistField;
            set => languagelistField = value;
        }

        /// <remarks />
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit", IsNullable = false)]
        public namecredit[] artistcredit
        {
            get => artistcreditField;
            set => artistcreditField = value;
        }

        /// <remarks />
        public string iswc
        {
            get => iswcField;
            set => iswcField = value;
        }

        /// <remarks />
        [XmlElement("iswc-list")]
        public iswclist iswclist
        {
            get => iswclistField;
            set => iswclistField = value;
        }

        /// <remarks />
        [XmlArray("attribute-list")]
        [XmlArrayItem("attribute", IsNullable = false)]
        public workAttribute[] attributelist
        {
            get => attributelistField;
            set => attributelistField = value;
        }

        /// <remarks />
        public annotation annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public string disambiguation
        {
            get => disambiguationField;
            set => disambiguationField = value;
        }

        /// <remarks />
        [XmlElement("alias-list")]
        public aliaslist aliaslist
        {
            get => aliaslistField;
            set => aliaslistField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlElement("tag-list")]
        public taglist taglist
        {
            get => taglistField;
            set => taglistField = value;
        }

        /// <remarks />
        [XmlElement("user-tag-list")]
        public usertaglist usertaglist
        {
            get => usertaglistField;
            set => usertaglistField = value;
        }

        /// <remarks />
        [XmlElement("genre-list")]
        public genrelist genrelist
        {
            get => genrelistField;
            set => genrelistField = value;
        }

        /// <remarks />
        [XmlElement("user-genre-list")]
        public usergenrelist usergenrelist
        {
            get => usergenrelistField;
            set => usergenrelistField = value;
        }

        /// <remarks />
        public rating rating
        {
            get => ratingField;
            set => ratingField = value;
        }

        /// <remarks />
        [XmlElement("user-rating", DataType = "nonNegativeInteger")]
        public string userrating
        {
            get => userratingField;
            set => userratingField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("language-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class languagelist
    {
        private string countField;
        private languagelistLanguage[] languageField;

        private string offsetField;

        /// <remarks />
        [XmlElement("language")]
        public languagelistLanguage[] language
        {
            get => languageField;
            set => languageField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class languagelistLanguage
    {
        private languagelistLanguageFluency fluencyField;

        private bool fluencyFieldSpecified;

        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public languagelistLanguageFluency fluency
        {
            get => fluencyField;
            set => fluencyField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool fluencySpecified
        {
            get => fluencyFieldSpecified;
            set => fluencyFieldSpecified = value;
        }

        /// <remarks />
        [XmlText]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public enum languagelistLanguageFluency
    {
        /// <remarks />
        basic,

        /// <remarks />
        intermediate,

        /// <remarks />
        advanced,

        /// <remarks />
        native
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("iswc-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class iswclist
    {
        private string countField;
        private List<string> iswcField;

        private string offsetField;

        /// <remarks />
        [XmlElement("iswc")]
        public List<string> iswc
        {
            get => iswcField;
            set => iswcField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class workAttribute
    {
        private List<string> textField;
        private string typeField;

        private string typeidField;

        private string valueidField;

        /// <remarks />
        [XmlAttribute]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute("type-id")]
        public string typeid
        {
            get => typeidField;
            set => typeidField = value;
        }

        /// <remarks />
        [XmlAttribute("value-id")]
        public string valueid
        {
            get => valueidField;
            set => valueidField = value;
        }

        /// <remarks />
        [XmlText]
        public List<string> Text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class url
    {
        private string idField;

        private relationlist[] relationlistField;
        private string resourceField;

        /// <remarks />
        public string resource
        {
            get => resourceField;
            set => resourceField = value;
        }

        /// <remarks />
        [XmlElement("relation-list")]
        public relationlist[] relationlist
        {
            get => relationlistField;
            set => relationlistField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "anyURI")]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class editor
    {
        private string ageField;

        private def_areaelement_inner areaField;

        private string bioField;

        private editinformation editinformationField;

        private gender genderField;

        private string homepageField;

        private string idField;

        private languagelist languagelistField;

        private string membersinceField;
        private string nameField;

        private string privsField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlElement("member-since")]
        public string membersince
        {
            get => membersinceField;
            set => membersinceField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string privs
        {
            get => privsField;
            set => privsField = value;
        }

        /// <remarks />
        public gender gender
        {
            get => genderField;
            set => genderField = value;
        }

        /// <remarks />
        public string age
        {
            get => ageField;
            set => ageField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "anyURI")]
        public string homepage
        {
            get => homepageField;
            set => homepageField = value;
        }

        /// <remarks />
        public string bio
        {
            get => bioField;
            set => bioField = value;
        }

        /// <remarks />
        public def_areaelement_inner area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        [XmlElement("language-list")]
        public languagelist languagelist
        {
            get => languagelistField;
            set => languagelistField = value;
        }

        /// <remarks />
        [XmlElement("edit-information")]
        public editinformation editinformation
        {
            get => editinformationField;
            set => editinformationField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("edit-information", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class editinformation
    {
        private string autoeditsacceptedField;
        private string editsacceptedField;

        private string editsfailedField;

        private string editsrejectedField;

        /// <remarks />
        [XmlElement("edits-accepted", DataType = "nonNegativeInteger")]
        public string editsaccepted
        {
            get => editsacceptedField;
            set => editsacceptedField = value;
        }

        /// <remarks />
        [XmlElement("edits-rejected", DataType = "nonNegativeInteger")]
        public string editsrejected
        {
            get => editsrejectedField;
            set => editsrejectedField = value;
        }

        /// <remarks />
        [XmlElement("auto-edits-accepted", DataType = "nonNegativeInteger")]
        public string autoeditsaccepted
        {
            get => autoeditsacceptedField;
            set => autoeditsacceptedField = value;
        }

        /// <remarks />
        [XmlElement("edits-failed", DataType = "nonNegativeInteger")]
        public string editsfailed
        {
            get => editsfailedField;
            set => editsfailedField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("url-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class urllist
    {
        private string countField;

        private string offsetField;
        private url[] urlField;

        /// <remarks />
        [XmlElement("url")]
        public url[] url
        {
            get => urlField;
            set => urlField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("annotation-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class annotationlist
    {
        private annotation[] annotationField;

        private string countField;

        private string offsetField;

        /// <remarks />
        [XmlElement("annotation")]
        public annotation[] annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("cdstub-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class cdstublist
    {
        private cdstub[] cdstubField;

        private string countField;

        private string offsetField;

        /// <remarks />
        [XmlElement("cdstub")]
        public cdstub[] cdstub
        {
            get => cdstubField;
            set => cdstubField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class cdstub
    {
        private XmlElement anyField;

        private string artistField;

        private string barcodeField;

        private string commentField;

        private string idField;
        private string titleField;

        private cdstubTracklist tracklistField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        public string artist
        {
            get => artistField;
            set => artistField = value;
        }

        /// <remarks />
        public string barcode
        {
            get => barcodeField;
            set => barcodeField = value;
        }

        /// <remarks />
        public string comment
        {
            get => commentField;
            set => commentField = value;
        }

        /// <remarks />
        [XmlElement("track-list")]
        public cdstubTracklist tracklist
        {
            get => tracklistField;
            set => tracklistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class cdstubTracklist
    {
        private string countField;

        private string offsetField;
        private cdstubTracklistTrack[] trackField;

        /// <remarks />
        [XmlElement("track")]
        public cdstubTracklistTrack[] track
        {
            get => trackField;
            set => trackField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class cdstubTracklistTrack
    {
        private string artistField;

        private string lengthField;
        private string titleField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        public string artist
        {
            get => artistField;
            set => artistField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "nonNegativeInteger")]
        public string length
        {
            get => lengthField;
            set => lengthField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("freedb-disc-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class freedbdisclist
    {
        private string countField;
        private freedbdisc[] freedbdiscField;

        private string offsetField;

        /// <remarks />
        [XmlElement("freedb-disc")]
        public freedbdisc[] freedbdisc
        {
            get => freedbdiscField;
            set => freedbdiscField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("freedb-disc", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class freedbdisc
    {
        private XmlElement anyField;

        private string artistField;

        private string categoryField;

        private string idField;
        private string titleField;

        private cdstubTracklist tracklistField;

        private string yearField;

        /// <remarks />
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks />
        public string artist
        {
            get => artistField;
            set => artistField = value;
        }

        /// <remarks />
        public string category
        {
            get => categoryField;
            set => categoryField = value;
        }

        /// <remarks />
        public string year
        {
            get => yearField;
            set => yearField = value;
        }

        /// <remarks />
        [XmlElement("track-list")]
        public cdstubTracklist tracklist
        {
            get => tracklistField;
            set => tracklistField = value;
        }

        /// <remarks />
        [XmlAnyElement]
        public XmlElement Any
        {
            get => anyField;
            set => anyField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get => idField;
            set => idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("editor-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class editorlist
    {
        private string countField;
        private editor[] editorField;

        private string offsetField;

        /// <remarks />
        [XmlElement("editor")]
        public editor[] editor
        {
            get => editorField;
            set => editorField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("entity-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class entitylist
    {
        private def_areaelement_inner[] areaField;
        private artist[] artistField;

        private string countField;

        private @event[] eventField;

        private instrument[] instrumentField;

        private label[] labelField;

        private string offsetField;

        private place[] placeField;

        private Recording[] recordingField;

        private release[] releaseField;

        private releasegroup[] releasegroupField;

        private series[] seriesField;

        private work[] workField;

        /// <remarks />
        [XmlElement("artist")]
        public artist[] artist
        {
            get => artistField;
            set => artistField = value;
        }

        /// <remarks />
        [XmlElement("release")]
        public release[] release
        {
            get => releaseField;
            set => releaseField = value;
        }

        /// <remarks />
        [XmlElement("release-group")]
        public releasegroup[] releasegroup
        {
            get => releasegroupField;
            set => releasegroupField = value;
        }

        /// <remarks />
        [XmlElement("recording")]
        public Recording[] recording
        {
            get => recordingField;
            set => recordingField = value;
        }

        /// <remarks />
        [XmlElement("label")]
        public label[] label
        {
            get => labelField;
            set => labelField = value;
        }

        /// <remarks />
        [XmlElement("work")]
        public work[] work
        {
            get => workField;
            set => workField = value;
        }

        /// <remarks />
        [XmlElement("area")]
        public def_areaelement_inner[] area
        {
            get => areaField;
            set => areaField = value;
        }

        /// <remarks />
        [XmlElement("place")]
        public place[] place
        {
            get => placeField;
            set => placeField = value;
        }

        /// <remarks />
        [XmlElement("instrument")]
        public instrument[] instrument
        {
            get => instrumentField;
            set => instrumentField = value;
        }

        /// <remarks />
        [XmlElement("series")]
        public series[] series
        {
            get => seriesField;
            set => seriesField = value;
        }

        /// <remarks />
        [XmlElement("event")]
        public @event[] @event
        {
            get => eventField;
            set => eventField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get => countField;
            set => countField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string offset
        {
            get => offsetField;
            set => offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("secondary-type-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class secondarytypelist
    {
        private secondarytype[] secondarytypeField;

        /// <remarks />
        [XmlElement("secondary-type")]
        public secondarytype[] secondarytype
        {
            get => secondarytypeField;
            set => secondarytypeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("artist-credit", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class artistcredit
    {
        private namecredit[] namecreditField;

        /// <remarks />
        [XmlElement("name-credit")]
        public namecredit[] namecredit
        {
            get => namecreditField;
            set => namecreditField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("ipi-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class ipilist
    {
        private List<string> ipiField;

        /// <remarks />
        [XmlElement("ipi")]
        public List<string> ipi
        {
            get => ipiField;
            set => ipiField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("isni-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class isnilist
    {
        private List<string> isniField;

        /// <remarks />
        [XmlElement("isni")]
        public List<string> isni
        {
            get => isniField;
            set => isniField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("iso-3166-1-code-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class iso31661codelist
    {
        private List<string> iso31661codeField;

        /// <remarks />
        [XmlElement("iso-3166-1-code")]
        public List<string> iso31661code
        {
            get => iso31661codeField;
            set => iso31661codeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("iso-3166-2-code-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Iso31662Codelist
    {
        /// <remarks />
        [XmlElement("iso-3166-2-code")]
        public List<string> Iso31662Code { get; set; }
    }

    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("iso-3166-3-code-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Iso31663Codelist
    {
        /// <remarks />
        [XmlElement("iso-3166-3-code")]
        public List<string> Iso31663Code { get; set; }
    }
}