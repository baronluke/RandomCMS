using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class clsUnit
    {
        private int unitID;
        private string unitName;
        private int noOfHours;
        private int noOfAssessments;
        private string unitType;

        public clsUnit()
        {
        }

        public clsUnit(int unitID)
        {
            this.unitID = unitID;
        }

        public clsUnit(int unitID, string unitName, int noOfHours, int noOfAssessments, string unitType)
        {
            this.unitID = unitID;
            this.unitName = unitName;
            this.noOfHours = noOfHours;
            this.noOfAssessments = noOfAssessments;
            this.unitType = unitType;
        }

        public int UnitID { get => unitID; set => unitID = value; }
        public string UnitName { get => unitName; set => unitName = value; }
        public int NoOfHours { get => noOfHours; set => noOfHours = value; }
        public int NoOfAssessments { get => noOfAssessments; set => noOfAssessments = value; }
        public string UnitType { get => unitType; set => unitType = value; }
    }
}
