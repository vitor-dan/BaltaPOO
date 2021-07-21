﻿using BaltaClasses.ContentContext.Enums;
using System.Collections.Generic;

namespace BaltaClasses.ContentContext
{
    public class Course : Content
    {

        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public List<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}
