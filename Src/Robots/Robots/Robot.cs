namespace Robots
{
    public class Robot : RobotAbstrait
    {
       public Point Position { get; set; }

        public string Name { get; set; } = "R2D2";

        #region constructeurs
        public Robot(string name,Point position)
        {
            Name = name;
            Position = position;
        }
        #endregion

        #region Méthodes
        public virtual string AfficherPosition()
        {
            return $"Je suis à la position {Position.X}, {Position.Y}";
        }

        public void Avancer(int posX,int posY)
        {
            Position.X += posX;
            Position.Y += posY;
        }

        public override string Démarrer()
        {
           return "Démarrage du robot";
        }
        #endregion
    }
}