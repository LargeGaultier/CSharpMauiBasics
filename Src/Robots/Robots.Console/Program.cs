 // See https://aka.ms/new-console-template for more information
using Robots;

Console.WriteLine("Hello, World!");


Robot robot = new Robot("R2D2", 0,0);
Console.WriteLine(robot.AfficherPosition());

RobotMobile robotMobile = new RobotMobile("R2D2", 0, 0, 10);
robotMobile.Avancer(10, 10);
Console.WriteLine($"ma vitesse est de {robotMobile.CalculerDuréeDeDéplacement(20, 20)}");
Console.WriteLine(robotMobile.AfficherPosition());
Console.ReadLine();

