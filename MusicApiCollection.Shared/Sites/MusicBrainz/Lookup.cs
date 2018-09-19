#region Copyright (C) 2015-2018 BigGranu
/*
    Copyright (C) 2015-2018 BigGranu

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

using System;
using System.Collections.Generic;
using MusicApiCollection.Events;
using MusicApiCollection.Sites.MusicBrainz.Data;

namespace MusicApiCollection.Sites.MusicBrainz
{
    /// <summary>
    /// Perform a lookup of an entity when you have the MBID for that entity
    /// </summary>
    public class Lookup
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupArea Area(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupArea();

            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "Area", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret.Data = Xml.Deserialize<LookupArea>(Http.Request("http://musicbrainz.org/ws/2/area/" + musicBrainzId + "?inc=aliases+tags")).Data ?? new LookupAreaResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupArea(ret.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupArtist Artist(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupArtist();

            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "Artist", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret = Xml.Deserialize<LookupArtist>(Http.Request("http://musicbrainz.org/ws/2/artist/" + musicBrainzId + "?inc=aliases+recordings+isrcs+annotation+tags"));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupArtist(ret.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupLabel Label(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupLabel();

            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "Artist", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret = Xml.Deserialize<LookupLabel>(Http.Request("http://musicbrainz.org/ws/2/label/" + musicBrainzId + "?inc=aliases+annotation+tags+ratings"));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupLabel(ret.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static string Recording(string musicBrainzId)
        {
            Logging.Clear();

            var ret = Http.Request("http://musicbrainz.org/ws/2/recording/" + musicBrainzId + "?inc=aliases+artist-credits+isrcs+annotation+tags+ratings");

       
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupRelease Release(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupRelease();

            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "Release", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret.Data = Xml.Deserialize<LookupRelease>(Http.Request("http://musicbrainz.org/ws/2/release/" + musicBrainzId + "?inc=discids+labels+recordings+media+isrcs+annotation+tags")).Data ?? new List<ReleaseData>();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupRelease(ret.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupReleaseGroup ReleaseGroup(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupReleaseGroup();

            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "ReleaseGroup", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret.Data = Xml.Deserialize<LookupReleaseGroup>(Http.Request("http://musicbrainz.org/ws/2/release-group/" + musicBrainzId + "?inc=aliases+annotation+tags+ratings")).Data ?? new ReleasegroupData();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupReleaseGroup(ret.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupWork Work(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupWork();

            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "Work", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret.Data = Xml.Deserialize<LookupWork>(Http.Request("http://musicbrainz.org/ws/2/work/" + musicBrainzId + "?inc=aliases+annotation+tags+ratings")).Data ?? new LookupWorkresult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupWork(ret.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupUrl Url(string musicBrainzId)
        {
            Logging.Clear();
            var ret = new LookupUrl();
            
            Logging.NewLogEntry(new LogEntry("Sites.MusicBrainz", "Lookup", "Url", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                ret.Data = Xml.Deserialize<LookupUrl>(Http.Request("http://musicbrainz.org/ws/2/url/" + musicBrainzId)).Data  ?? new LookupUrlResult();                
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new LookupUrl(ret.Data);
        }

        // https://musicbrainz.org/doc/Development/XML_Web_Service/Version_2#Lookups
        // /ws/2/area
        // /ws/2/artist recordings, releases, release-groups, works
        // /ws/2/collection user-collections(includes private collections, requires authentication)
        // /ws/2/event
        // /ws/2/instrument
        // /ws/2/label releases
        // /ws/2/place
        // /ws/2/recording artists, releases
        // /ws/2/release artists, collections, labels, recordings, release-groups
        // /ws/2/release-group artists, releases
        // /ws/2/series
        // /ws/2/work
        // /ws/2/url
    }
}
