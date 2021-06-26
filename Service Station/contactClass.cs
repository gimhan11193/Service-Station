using System;
using System.Data;

namespace Service_Station
{
    internal class contactClass
    {
        public object VehicleModel { get; internal set; }
        public object CompanyName { get; internal set; }
        public object OwnerName { get; internal set; }
        public object Amount { get; internal set; }
        public object ContactNo { get; internal set; }
        public object ServiceType { get; internal set; }
        public object VehicleNo { get; internal set; }

        internal bool Insert(contactClass c)
        {
            throw new NotImplementedException();
        }

        internal DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}