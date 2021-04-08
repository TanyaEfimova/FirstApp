using System;

namespace FirstApp
{
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            throw new NotImplementedException();
        }
    }
}
