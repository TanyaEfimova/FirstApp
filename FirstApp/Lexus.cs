using System;

namespace FirstApp
{
    class Lexus : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            throw new NotImplementedException();
        }
    }
}
