using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismBasicExam.Models
{
    public class Turkish: Cars
    {
        public override int Hizlan()
        {
            return 21;
        }
    }
}
