using System;

namespace FirstApp
{
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            throw new NotImplementedException();
        }
    }
}
