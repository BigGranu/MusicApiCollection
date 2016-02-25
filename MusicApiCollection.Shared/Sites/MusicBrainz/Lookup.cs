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
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupArea Area(string musicBrainzId)
        {
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
        public static string Artist(string musicBrainzId)
        {
            //

            var ret = Http.Request("http://musicbrainz.org/ws/2/artist/" + musicBrainzId + "?inc=aliases+recordings+isrcs+annotation+tags");

            return "";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static string Label(string musicBrainzId)
        {
            //?inc=aliases+annotation+tags+ratings

            var ret = Http.Request("http://musicbrainz.org/ws/2/label/" + musicBrainzId + "?inc=aliases+annotation+tags+ratings");

   
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static string Recording(string musicBrainzId)
        {

            var ret = Http.Request("http://musicbrainz.org/ws/2/recording/" + musicBrainzId + "?inc=aliases+artist-credits+isrcs+annotation+tags+ratings");

       
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        public static LookupRelease Release(string musicBrainzId)
        {           
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
    }
}
