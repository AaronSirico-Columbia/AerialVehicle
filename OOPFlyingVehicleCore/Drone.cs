using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Drone : AerialVehicle, IHasBatteries
    {
        public Drone(IEngine engine) : base(engine)
        {
            this.MaxAltitude = 500;
            this.CurrentAltitude = 0;
        }

        public bool HasBatteries { get; set; }
        public bool IsCharged { get; set; }
        public int ChargeLeft { get; set; }

        public int ReturnCharge()
        {
            return ChargeLeft;
        }
    }
}
