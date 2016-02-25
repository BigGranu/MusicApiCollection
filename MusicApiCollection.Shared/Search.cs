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
using System.Diagnostics;
using System.Linq;
using MusicApiCollection.Data;
using MusicApiCollection.Sites.Lyrics;
using MusicApiCollection.Sites.MusicBrainz.Data;
using Artist = MusicApiCollection.Data.Artist;
using Disc = MusicApiCollection.Data.Disc;

namespace MusicApiCollection
{
    /// <summary>
    /// Global Search over all Sites
    /// </summary>
    public class Search
    {

        /// <summary>
        /// Search Album
        /// </summary>
        /// <param name="artist">Artist</param>
        /// <param name="album">Album</param>
        /// <returns></returns>
        public static Disc Disc(string artist, string album)
        {
            var rel = Sites.MusicBrainz.Search.ReleaseGroup(release:album, artist:artist);

            var lu = Sites.MusicBrainz.Lookup.Release(rel.Data.Data[0].Releaselist.Release[0].Id);

            return new Disc();
        }
    }
}
