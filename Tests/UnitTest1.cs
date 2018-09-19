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
            var ret = MusicApiCollection.Sites.CoverArtArchive.Search.Release("03f9d988-8555-4cdf-afb1-a29c9487bb15m");
        }

        [TestMethod]
        public void ReleaseGroup()
        {
            var ret = MusicApiCollection.Sites.CoverArtArchive.Search.ReleaseGroup("c31a5e2b-0bf8-32e0-8aeb-ef4ba9973932");
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
