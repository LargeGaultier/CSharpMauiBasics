namespace Robots
{
    public class Robot
    {
        public string Name { get; set; } = "R2D2"; 
        public int PositionX { get; set; }
        public int PositionY { get; set; }


        public Robot(string name, int posX, int posY)
        {
            Name = name;
            PositionX = posX;
            PositionY = posY;
        }

        public string AfficherPosition()
        {
            return $"Je suis à la position {PositionX}, {PositionY}";
        }

        public void Avancer(int posX,int posY)
        {
            PositionX += posX;
            PositionY += posY;
        }
    }
}