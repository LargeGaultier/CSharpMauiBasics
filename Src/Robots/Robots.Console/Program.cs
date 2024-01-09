 // See https://aka.ms/new-console-template for more information
using Robots;
using Robots.CustomExceptions;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Dynamic;

Console.WriteLine("Hello, World!");

List<int> list = new List<int>();


List<NewRobot> robots = new List<NewRobot>()
{ 
new NewRobot { Id = 5, Name = "R2D5", Status = "En marche" },
};

robots.Add(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
robots.Add(new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" });
robots.Add(new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" });
robots.Add(new NewRobot { Id = 4, Name = "R2D5", Status = "En marche" });

Dictionary<int, NewRobot> DictionnaryRobot = new Dictionary<int, NewRobot>();
DictionnaryRobot.Add(1, new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });

var DictionnaryRobot2 = new Dictionary<int, NewRobot>
{
    { 1, new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" } },
    { 2, new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" } },
    { 3, new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" } },
    { 4, new NewRobot { Id = 4, Name = "R2D5", Status = "En marche" } }
};

var DictionnaryRobot3 = robots.ToDictionary(r => r.Id, r => r);

var QueueRobot = new Queue<NewRobot>();
QueueRobot.Enqueue(new NewRobot { Id = 3, Name = "R2D4", Status = "Arret" });
QueueRobot.Enqueue(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
QueueRobot.Enqueue(new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" });


var StackRobot = new Stack<NewRobot>();
StackRobot.Push(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
StackRobot.Push(new NewRobot { Id = 2, Name = "R2D3", Status = "Arret" });
StackRobot.Push(new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" });

var LinkedListRobot = new LinkedList<NewRobot>();
LinkedListRobot.AddFirst(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
LinkedListRobot.AddLast(new NewRobot { Id = 2, Name = "R2D3", Status = "Arret" });
LinkedListRobot.AddLast(new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" });

var observableCollectionRobot = new System.Collections.ObjectModel.ObservableCollection<NewRobot>();
observableCollectionRobot.Add(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
observableCollectionRobot.Add(new NewRobot { Id = 2, Name = "R2D3", Status = "Arret" });

var sortedListRobot = new SortedList<int, NewRobot>();
sortedListRobot.Add(2, new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" });
sortedListRobot.Add(1, new NewRobot { Id = 1, Name = "R2D2", Status = "Arret" });


Console.WriteLine("List");
foreach (var robot in robots)
{
    Console.WriteLine(robot.ToString());
}
Console.WriteLine("Dictionnary");
foreach (var robot in DictionnaryRobot)
{
    Console.WriteLine(robot.Value.ToString());
}
Console.WriteLine("Dictionnary2");
foreach (var robot in DictionnaryRobot2)
{
    Console.WriteLine(robot.Value.ToString());
}
Console.WriteLine("Dictionnary3");
foreach (var robot in DictionnaryRobot3)
{
    Console.WriteLine(robot.Value.ToString());
}   
Console.WriteLine("Queue");
foreach (var robot in QueueRobot)
{
    Console.WriteLine(robot.ToString());
}
Console.WriteLine("Stack");
foreach (var robot in StackRobot)
{
    Console.WriteLine(robot.ToString());
}
Console.WriteLine("LinkedList");
foreach (var robot in LinkedListRobot)
{
    Console.WriteLine(robot.ToString());
}
Console.WriteLine("ObservableCollection");
foreach (var robot in observableCollectionRobot)
{
    Console.WriteLine(robot.ToString());
}
Console.WriteLine("SortedList");
foreach (var robot in sortedListRobot)
{
    Console.WriteLine(robot.Value.ToString());
}

//supprimer un element de chaque type de liste
robots.RemoveAt(0);
robots.Remove(robots[1]);
DictionnaryRobot.Remove(1);
DictionnaryRobot2.Remove(1);
DictionnaryRobot3.Remove(1);
QueueRobot.Dequeue();
StackRobot.Pop();
LinkedListRobot.RemoveFirst();
observableCollectionRobot.RemoveAt(0);
sortedListRobot.Remove(1);

foreach (var robot in robots)
{
    robot.Status = "Arret"; 
}

bool isArret = robots.All(x=> x.Status == "Arret");
bool  isArret2 = robots.Any(x => x.Status == "Arret");



try
{
    if (isArret)
    {
        Console.WriteLine("Tous les robots sont à l'arret");
        throw new StatusRobotException("Tous les robots ne sont pas à l'arret");

    }
}
catch (StatusRobotException e)
{
    Console.Write("exception Custom :");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.Write("exception :");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Fin du programme");
}




//const int MAX_ROBOTS = 5;

//Robot[] robots = new Robot[MAX_ROBOTS];

//for (int i = 0; i < 3; i++)
//{
//    robots[i] = new Robot($"R2D{i}", (decimal)i);
//}

//decimal vitesseMoyenne = 0;
//for (int i = 0; i < 2; i++)
//{
//    vitesseMoyenne +=  robots[i].Vitesse;
//}

//vitesseMoyenne = vitesseMoyenne / 3;

//var VitesseMoyenne = robots.Average(r=> r.Vitesse);

//Console.WriteLine($"La vitesse moyenne est de {vitesseMoyenne}");

//var robot = robots[0];
//double test = (double)robot.Vitesse;

//int[,] tableau = new int[2, 3];
//tableau[0, 0] = 1;
//tableau[0, 1] = 2;


//Robot robot = new Robot("R2D2", new Point(0, 0));

//Console.WriteLine(robot.AfficherPosition());
//RobotMobile robotMobile = new RobotMobile("R2D2", new Point(0, 0), 10);
//robotMobile.Avancer(10, 10);
//Console.WriteLine($"ma vitesse est de {robotMobile.CalculerDuréeDeDéplacement(20, 20)}");
//Console.WriteLine(robotMobile.AfficherPosition());
//Console.WriteLine(robotMobile.Arrêter());
//Console.WriteLine(robot.Démarrer());
//robotMobile.Nettoyer();
//robotMobile.Déplacer(new Point { X = 30, Y = 30 });


//Robot AfficherNomRobot(Robot robot, string nouveauNom)
//{
//    robot.Name = nouveauNom;
//    return robot;    
//}

