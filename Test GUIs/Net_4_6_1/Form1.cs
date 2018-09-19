using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using MusicApiCollection.Sites.Discogs;

namespace Net_4_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var d = MusicApiCollection.Sites.MusicBrainz.Search.Artist("Madonna");

            var d1 = MusicApiCollection.Sites.MusicBrainz.Search.Release(arid: "79239441-bfd5-4981-a70c-55c3f15c1287", limit: 100);
            foreach (var i in d1.Data.Data)
            {
                var c = MusicApiCollection.Sites.CoverArtArchive.Search.Release(i.Id);
                foreach (var co in c.Data.Images)
                {
                    if (co.Thumbnails.Large != "" && 
                        co.Thumbnails.Small != "")
                    {
                        Console.WriteLine(c.Data.Release);
                    }
                }
            }

            //e15089a9-6f7f-447d-ae7f-12dc11945ec4
            var dd = MusicApiCollection.Sites.MusicBrainz.Search.Release(artist: "Madonna");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var d = MusicApiCollection.Sites.MusicBrainz.Search.Tag("shoegaze");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var re = MusicApiCollection.Sites.MusicBrainz.Lookup.Label("d2c296e3-10a4-4ba9-97b9-5620ff8a3ce00");

            var d = MusicApiCollection.Sites.MusicBrainz.Search.Artist("Madonna");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var artist = "Nickelback";

            // Find the Discogs ID for the Artist
            var res = MusicApiCollection.Sites.Discogs.Search.Query(Search.Type.ARTIST, artist);
            if (res.ErrorOccurred) return;
            var artistId = res.Data.Results.FirstOrDefault().Id;

            // Artist Infos
            var res2 = MusicApiCollection.Sites.Discogs.Search.Artist(artistId.ToString());
            if (res2.ErrorOccurred) return;

            // Artist Releases
            var res3 = MusicApiCollection.Sites.Discogs.Search.ArtistRelease(artistId.ToString());
            if (res3.ErrorOccurred) return;

            // Release Details for the Last Release
            var res4 = MusicApiCollection.Sites.Discogs.Search.Release(res3.Data.Releases.LastOrDefault().Id.ToString());
            if (res4.ErrorOccurred) return;

            // Infos about the Label
            var res5 = MusicApiCollection.Sites.Discogs.Search.Label(res4.Data.Labels.FirstOrDefault().Id.ToString());
            if (res5.ErrorOccurred) return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // https://www.coverartarchive.org/release/03f9d988-8555-4cdf-afb1-a29c9487bb15/
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
