﻿using System.Collections.Generic;

namespace QueryInterceptor.Core.UnitTests.Helpers.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
