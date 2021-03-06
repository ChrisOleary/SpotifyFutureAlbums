﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpotifyFutureAlbums.Models;
using SpotifyFutureAlbums.Models.OpenWeatherApi;

namespace SpotifyFutureAlbums.ViewModels
{
    public class AllAPIDetails
    {

        public AlwaysSunnyObject AlwaysSunny { get; set; }

        public FootballObject Football { get; set; }

        public MyTeamRootObject MyTeamRootObject { get; set; }

        public TrackInfoObject Spotify { get; set; }

        //public WeatherRootObject Weather { get; set; }

        public ResultViewModel Weather { get; set; }

    }
}