﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifyFutureAlbums.Models
{
    public class Pick
    {
        public int element { get; set; }
        public int position { get; set; }
        public int selling_price { get; set; }
        public int multiplier { get; set; }
        public int purchase_price { get; set; }
        public bool is_captain { get; set; }
        public bool is_vice_captain { get; set; }
    }
}