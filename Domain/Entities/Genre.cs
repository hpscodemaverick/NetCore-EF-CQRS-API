﻿namespace Domain.Entities
{
    using Domain.Common;
    using System;
    using System.Collections.Generic;
    public class Genre : AuditableEntity
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }
        public Guid Id { get; set; }
        public string GenreName { get; set; }
        public string? Description { get; set; }

        /*Collection Navigation property */
        public ICollection<Album> Albums { get; private set; }
    }
}
