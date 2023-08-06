using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismBasicExam.Models
{
    public class German: Cars
    {
        Random random = new Random();
        public override int Hizlan()
        {
            return random.Next(15,20);
        }
    }
}
