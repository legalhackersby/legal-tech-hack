﻿using System;
using System.Security.AccessControl;

namespace src.Models
{
    public class ChapterEntity : BaseEntity
    {
        public string Source { get; set; }

        public string PageTitle { get; set; }

        public string ChapterTitle { get; set; }

        public string Body { get; set; }

        public DateTime CreatedTime { get; set; }

        public Paragraph JsonContent { get; set; }
    }
}
