using System;
using System.Collections.Generic;
using Repository.Core;

namespace Repository.Core
{
    public abstract class Entity
    {
        public string Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
