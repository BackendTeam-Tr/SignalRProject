﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Icon { get; set; }
    }
}
