using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public abstract class RobotAbstrait
    {
        public abstract string Démarrer();
        public string Arrêter()
        {
            return "Arrêt du robot";
        }
    }
}
