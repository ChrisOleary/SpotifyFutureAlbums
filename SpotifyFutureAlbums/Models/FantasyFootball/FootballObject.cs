﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpotifyFutureAlbums.Models
{
    public class FootballObject
    {
        public int id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime joined_time { get; set; }
        public int started_event { get; set; }
        public object favourite_team { get; set; }
        public string player_first_name { get; set; }
        public string player_last_name { get; set; }
        public int player_region_id { get; set; }
        public string player_region_name { get; set; }
        public string player_region_iso_code_short { get; set; }
        public string player_region_iso_code_long { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int summary_overall_points { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int summary_overall_rank { get; set; }
        public int summary_event_points { get; set; }
        public int summary_event_rank { get; set; }
        public int current_event { get; set; }
        public Leagues leagues { get; set; }
        public string name { get; set; }
        public string kit { get; set; }
        public int last_deadline_bank { get; set; }
        public int last_deadline_value { get; set; }
        public int last_deadline_total_transfers { get; set; }
    }
}