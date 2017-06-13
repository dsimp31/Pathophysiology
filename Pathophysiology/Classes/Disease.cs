using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Pathophysiology.Classes
{
    public class Disease
    {
        public Guid ID;         
        public List<string> DiseaseNames;
        public List<string> Specialties;        // pulmonary, infectious, etc.
        public List<string> Relations;          // related diseases
        public List<string> Symptoms;
        public List<string> Causes;
        public List<string> RiskFactors;
        public List<string> Diagnostics;
        public List<string> Treatments;
    }
}
