using System.Collections.Generic;
using System.Linq;

namespace Quiz1.Mass
{
    public class MassController
    {
        private readonly IEnumerable<IMass> _masses;

        public MassController(IEnumerable<IMass> masses)
        {
            _masses = masses;
        }

        public double UniversalMass()
        {
            return _masses.Sum(i => i.Mass());
        }
    }
}
