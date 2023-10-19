using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotMobile : Robot, IRobotNettoyage
    {
        public int Vitesse { get; set; }
        public Point Position { get; set; }
        public RobotMobile(string name, int posX, int posY, int vitesse) : base(name, posX, posY)
        {
            Vitesse = vitesse;
            Position = new Point { X = posX, Y = posY };
        }

        private int CalculerDistance(int posX, int posY)
        {
            return Math.Abs(posX - _positionX) + Math.Abs(posY - _positionY);
        }

        public int CalculerDuréeDeDéplacement(int posX, int posY)
        {
            return CalculerDistance(posX, posY) / Vitesse;
        }

        public override string AfficherPosition()
        {
            return $"Je suis un robot mobile à la position {_positionX}, {_positionY}";
        }

        public void Nettoyer()
        {
            Console.WriteLine($"{Name} nettoie");
        }

        public void Déplacer(Point PointDestination)
        {

            Console.WriteLine($"les robot {Name}, c'est déplacer de {Utils.CalculerDistance(Position, PointDestination)}");

                Position = PointDestination;
            _positionX = PointDestination.X;
            _positionY = PointDestination.Y;
        }
    }
}
