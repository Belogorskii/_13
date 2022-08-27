using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    sealed class MultiBuilding : Bilding
    {
        string floors { get; set; }

        public MultiBuilding(string buildingAddress, string buildingLongh, string buildingWidth, string buildingHeight, string floors)
         : base(buildingAddress, buildingLongh, buildingWidth, buildingHeight)
        {
            this.floors = floors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"{floors}";
            return result;
        }
    }
}
