﻿using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic
{
    public class Node
    {
        public Entity Entity { get; set; }
        public Node(Entity en)
        {
            Entity = en;
        }

        public bool IsEmpty()
        {
            return Entity == null;
        }

    }
}
