namespace Robots
{
    public class Robot
    {
        protected int _positionX;
        protected int _positionY;

        public string Name { get; set; } = "R2D2";

        #region constructeurs
        public Robot(string name, int posX, int posY)
        {
            Name = name;
            _positionX = posX;
            _positionY = posY;
        }
        #endregion

        #region Méthodes
        public virtual string AfficherPosition()
        {
            return $"Je suis à la position {_positionX}, {_positionY}";
        }

        public void Avancer(int posX,int posY)
        {
            _positionX += posX;
            _positionY += posY;
        }
        #endregion
    }
}