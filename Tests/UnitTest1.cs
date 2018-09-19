using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicApiCollection.Sites.Discogs;

namespace Tests
{
    [TestClass]
    public class CoverartArchive
    {
        [TestMethod]
        public void Release()
        {
            //http://musicbrainz.org/release/c6c1b7af-9bdc-45f8-944b-5472441f543b
            //https://musicbrainz.org/release/4117e0be-2d04-4969-abf5-f92316602580
            //http://musicbrainz.org/release/26fb22a7-b673-47f4-8b58-97d2a8211aaf
            //http://musicbrainz.org/release/b69d729a-8a45-439d-98be-d5cb5cfbacc6
            //http://musicbrainz.org/release/608d0b8b-bee9-42ad-809e-9d22147d55c3
            //http://musicbrainz.org/release/03bad8bd-d1fd-4c95-9744-e0aedc4d4df5
            //https://musicbrainz.org/release/c611aa09-a713-47c3-a4a3-896c6902341e


            var ret = MusicApiCollection.Sites.CoverArtArchive.Search.Release("572785a2-aad3-4d72-a7c9-508a2e7e6e4c");


            ret = MusicApiCollection.Sites.CoverArtArchive.Search.Release("572785a2-aad3-4d72-a7c9-508a2e7e6e4c", MusicApiCollection.Sites.CoverArtArchive.Search.Typ.FRONT);
        }
    }

    [TestClass]
    public class MusicBrainz
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    [TestClass]
    public class TheAudioDb
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    [TestClass]
    public class GraceNote
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }

    [TestClass]
    public class Discogs
    {
        [TestMethod]
        public void Query()
        {
            // Nickelback
            var ret = MusicApiCollection.Sites.Discogs.Search.Query(Search.Type.ARTIST, "Nickelback");
        }

        [TestMethod]
        public void QueryFull()
        {
            // Nickelback
            var ret = MusicApiCollection.Sites.Discogs.Search.Query(artist:"Nickelback",label:"roadrunner");
        }

        [TestMethod]
        public void Artist()
        {
            // Nickelback
            var ret = MusicApiCollection.Sites.Discogs.Search.Artist("108713");
        }

        [TestMethod]
        public void ArtistRelease()
        {
            // Nickelback
            var ret = MusicApiCollection.Sites.Discogs.Search.ArtistRelease("108713");
        }

        [TestMethod]
        public void Release()
        {
            // Nickelback 4299404
            var ret = MusicApiCollection.Sites.Discogs.Search.Release("4299404");
        }

        [TestMethod]
        public void MasterRelease()
        {
            // Nickelback 624764
            var ret = MusicApiCollection.Sites.Discogs.Search.MasterRelease("108713");
        }

        [TestMethod]
        public void MasterReleaseVersion()
        {
            // Nickelback
            var ret = MusicApiCollection.Sites.Discogs.Search.MasterReleaseVersion("108713");
        }

        [TestMethod]
        public void Label()
        {
            // Nickelback 1148109
            var ret = MusicApiCollection.Sites.Discogs.Search.Label("1148109");
        }

        [TestMethod]
        public void AllLabels()
        {
            // Nickelback
            var ret = MusicApiCollection.Sites.Discogs.Search.AllLabelReleases("108713");
        }
    }

    [TestClass]
    public class FreeDb
    {
        [TestMethod]
        public void Version()
        {
            var ret = MusicApiCollection.Sites.FreeDB.Search.Version();
        }

        [TestMethod]
        public void Sites()
        {
            var ret = MusicApiCollection.Sites.FreeDB.Search.Sites();
        }

        [TestMethod]
        public void Categories()
        {
            var ret = MusicApiCollection.Sites.FreeDB.Search.Categories();
        }

        [TestMethod]
        public void Help()
        {
            var ret = MusicApiCollection.Sites.FreeDB.Search.Help();
        }
    }

    [TestClass]
    public class FanartTv
    {
        [TestMethod]
        public void Movie()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.Movie("10195");
        }

        [TestMethod]
        public void LatestMovies()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.LatestMovie();
        }

        [TestMethod]
        public void Show()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.TvShow("75682");
        }

        [TestMethod]
        public void LatestShows()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.LatestTvShow();
        }

        [TestMethod]
        public void Album()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.Album("9ba659df-5814-32f6-b95f-02b738698e7c");
        }

        [TestMethod]
        public void Artist()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.Artist("f4a31f0a-51dd-4fa7-986d-3095c40c5ed9");
        }

        [TestMethod]
        public void Label()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.Label("e832b688-546b-45e3-83e5-9f8db5dcde1d");
        }

        [TestMethod]
        public void LatestArtists()
        {
            var ret = MusicApiCollection.Sites.FanartTv.Search.LatestArtist();
        }
    }
}
