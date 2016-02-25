# MusicApiCollection **BETA**

This project is a Collection of any older projects.

Project | Status | Key | Description
------------ | ------------- | ------------- | -------------
[AcoustID](https://acoustid.org/) | 20 % | :key:[ ]() | AcoustID is a project providing complete audio identification service, based entirely on open source software.
[CoverArtArchive](https://coverartarchive.org/) | 100 % | | The Cover Art Archive is a joint project between the Internet Archive and MusicBrainz
[Discogs](https://www.discogs.com/) | 90 % | :key:[ ]() | Discogs, short for discographies, is a website and crowdsourced database of information about audio recordings.
[FanartTv](https://fanart.tv/) | 100 % | :key:[ ]() | The site is divided in three sections with over 300.000 Images
[FreeDB](http://www.freedb.org/) | 80 % | | FreeDb is a free CD and music data base service to look up textual metadata about music, audio or data CDs.
[GraceNote](http://www.gracenote.com/) | 50 % | :key:[ ]() | Gracenote helps people connect to the music, TV shows, movies and sports they love across the world’s most popular entertainment platforms and devices.
[MusicBrainz](http://musicbrainz.org/) | 80 % | :key:[ ]() | MusicBrainz is an open music encyclopedia that collects music metadata and makes it available to the public. 
[TheAudioDB](http://www.theaudiodb.com/) | 100 % | :key:[ ]() | TheAudioDB is a community driven database of music metadata with a free data API.
Lyrics | 1 Site | | Get lyrics from any Websites
Global Search | 5 % | | Multithreading Search over all Sites

### Use your own Keys
```c#

Settings.FanartTv.ApiKey = "xxxxxxxxxxxxxx";
Settings.TheAudioDb.ApiKey = "xxxxxxxxxxxx";
...
```
### Use the Sites
```c#

var ret1 = MusicApiCollection.Sites.CoverArtArchive.Search.Release("03f9d988-8555-4cdf-afb1-a29c9487bb15");
var ret2 = MusicApiCollection.Sites.Discogs.Search.ArtistRelease("108713");
var ret3 = MusicApiCollection.Sites.MusicBrainz.Search.Area("germany", type: "Country");
var ret4 = MusicApiCollection.Sites.TheAudioDB.Search.Artist("Depeche Mode");
var ret5 = MusicApiCollection.Sites.FanartTv.Search.Album("1dc4c347-a1db-32aa-b14f-bc9cc507b843");
var ret6 = MusicApiCollection.Sites.FreeDB.Search.Read("rock", "05120411");
var ret7 = MusicApiCollection.Sites.GraceNote.Search.Album("Fountains of Wayne", "", "Stacy's Mom");

// needs a calculated Cromaprintkey
var ret8 = MusicApiCollection.Sites.AcoustID.Search.Lookup("VpSn30ms", runtime, Cromaprintkey);
```
### Use the Global Search
```c#

var ret = MusicApiCollection.Search.Lyric("Coldplay", "In My Place");
```
