using System;
using Challenge.Logic;

namespace Challenge.Shapes
{
    public interface IShape
    {
        String Name { get;  }
        DecisionResult Versus(IShape other);
    }
}