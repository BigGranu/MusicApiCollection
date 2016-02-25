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

namespace MusicApiCollection.Sites.MusicBrainz
{
    internal class Help
    {
        public static string SearchToString(List<Para> args)
        {
            var result = string.Empty;

            for (var i = 0; i < args.Count; i++)
            {
                if (args[i].Value != "" & args[i].Value != null)
                {
                    if (args[i].Name == "query")
                    {
                        result += CheckValue(args[i].Value) + "%20AND%20";
                    }
                    else
                    {
                        result += args[i].Name.ToLower() + ":" + CheckValue(args[i].Value) + "%20AND%20";
                    }

                   // result += args[i].Name.ToLower() + ":" + CheckValue(args[i].Value) + "%20AND%20";
                }
            }

            if (result.LastIndexOf("%20AND%20", StringComparison.Ordinal) > 0)
                return result.Substring(0, result.LastIndexOf("%20AND%20", StringComparison.Ordinal));
            else return result;
        }

        public static string LimitOffsetToString(int limit, int offset)
        {
            var result = string.Empty;

            if (limit != 25)
                result += "&limit=" + limit;

            if (offset != 0)
                result += "&offset=" + offset;

            return result;
        }

        public static T Find<T>(string query, int limit, int offset, string part)
        {
            try
            {
                var o = Http.Request("http://musicbrainz.org/ws/2/" + part + "/?query=" + query + LimitOffsetToString(limit, offset));

                return Xml.Deserialize<T>(o);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        private static string CheckValue(string value)
        {
            if (value.IndexOf(" ", StringComparison.Ordinal) > 1)
            {
                return "\"" + value.Replace(" ", "%20") + "\"";
            }
            return value.Replace(" ", "%20");
        }
    }
}
