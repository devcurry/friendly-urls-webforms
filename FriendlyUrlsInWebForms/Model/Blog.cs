﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FriendlyUrlsInWebForms.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Author { get; set; }
    }
}