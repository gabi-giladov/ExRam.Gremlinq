﻿using NullGuard;

namespace ExRam.Gremlinq.Core
{
    public abstract class ChooseStep : Step
    {
        protected ChooseStep(Traversal thenTraversal, Traversal? elseTraversal = default)
        {
            ThenTraversal = thenTraversal;
            ElseTraversal = elseTraversal;
        }

        public Traversal ThenTraversal { get; }

        [AllowNull]
        public Traversal? ElseTraversal { get; }
    }
}
