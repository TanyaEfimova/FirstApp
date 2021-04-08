using System;

namespace FirstApp
{
    class Car<T1> where T1 : Engine
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
        {
        }
    }
}
