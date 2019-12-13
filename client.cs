using System;
namespace TextNameSpace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter level: ");
            int difficulty = int.Parse(Console.ReadLine());
            Text text = new Text(playerName,difficulty);
            string room;
            int input;
            Random random = new Random();
            int roomNumber = random.Next(0, 3);
            int roomNumber1 = random.Next(0, 4);
            int roomNumber2 = random.Next(0, 5);
            if(difficulty==1)
            {
                do
                {
                    Console.WriteLine("Please Enter 0 to look in Living Room: ");  
                    Console.WriteLine("Please Enter 1 to look in Kitchen: ");
                    Console.WriteLine("Please Enter 2 to look in Badroom: ");
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("Random: "+roomNumber);
                    room = text.GetRoom(input);
                    Console.WriteLine("You've chosen: "+room+" based on given number. "+input);
                    if (input==roomNumber)
                    {
                        text.AddPoints(1);
                        Console.WriteLine("You are gaining the points: "+text.ReturnPoint());
                        if (text.ReturnPoint()>=10)
                        {
                            Console.WriteLine("YOU WIN!"+"Total points: "+text.ReturnPoint());
                            input = 4;
                        }
                        else if (text.ReturnPoint()<0)
                        {
                            Console.WriteLine("YOU LOSE!"+"Total points: "+text.ReturnPoint());
                            input = 4;
                        }
                        
                    }
                    else
                    {
                        text.SubPoints(1);
                        Console.WriteLine("You are loosing the points: "+text.ReturnPoint());
                        if (text.ReturnPoint()>=10)
                        {
                            Console.WriteLine("YOU WIN!"+"Total points: "+text.ReturnPoint());
                            input = 4;
                        }
                        else if (text.ReturnPoint()<0)
                        {
                            Console.WriteLine("YOU LOSE!"+"Total points: "+text.ReturnPoint());
                            input = 4;
                        }
                        

                    }
                    Console.WriteLine("Total points: "+text.ReturnPoint());
                    
                    roomNumber = random.Next(1, 4);

                }while(input!=4);
            }
            else if(difficulty==2)
            {
                 do
                {
                    Console.WriteLine("Please Enter 0 to look in Living Room:: ");  
                    Console.WriteLine("Please Enter 1 to look in Kitchen: ");
                    Console.WriteLine("Please Enter 2 to look in Badroom: ");
                    Console.WriteLine("Please enter 3 to look in Bathroom: ");
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("Random: "+roomNumber1);
                    room = text.GetRoom(input);
                    Console.WriteLine("You've chosen: "+room+" based on given number. "+input);
                    if (input==roomNumber1)
                    {
                        text.AddPoints(1);
                        Console.WriteLine("You are gaining the points: "+text.ReturnPoint());
                        if (text.ReturnPoint()>=10)
                        {
                            Console.WriteLine("YOU WIN!"+"Total points: "+text.ReturnPoint());
                            input = 5;
                        }
                        else if (text.ReturnPoint()<0)
                        {
                            Console.WriteLine("YOU LOSE!"+"Total points: "+text.ReturnPoint());
                            input = 5;
                        }
                        
                    }
                    else
                    {
                        text.SubPoints(1);
                        Console.WriteLine("You are loosing the points: "+text.ReturnPoint());
                        if (text.ReturnPoint()>=10)
                        {
                            Console.WriteLine("YOU WIN!"+"Total points: "+text.ReturnPoint());
                            input = 5;
                        }
                        else if (text.ReturnPoint()<0)
                        {
                            Console.WriteLine("YOU LOSE!"+"Total points: "+text.ReturnPoint());
                            input = 5;
                        }
                        

                    }
                    Console.WriteLine("Total points: "+text.ReturnPoint());
                    
                    roomNumber1 = random.Next(0, 4);

                }while(input!=5);

            }
            
            else if(difficulty==3)
            {
                 do
                {
                    Console.WriteLine("Please Enter 0 to look in Living Room:: ");  
                    Console.WriteLine("Please Enter 1 to look in Kitchen: ");
                    Console.WriteLine("Please Enter 2 to look in Badroom: ");
                    Console.WriteLine("Please enter 3 to look in Bathroom: ");
                    Console.WriteLine("Please enter 4 to look in Garage: ");
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("Random: "+roomNumber2);
                    room = text.GetRoom(input);
                    Console.WriteLine("You've chosen: "+room+" based on given number. "+input);
                    if (input==roomNumber2)
                    {
                        text.AddPoints(1);
                        Console.WriteLine("You are gaining the points: "+text.ReturnPoint());
                        if (text.ReturnPoint()>=10)
                        {
                            Console.WriteLine("YOU WIN!"+"Total points: "+text.ReturnPoint());
                            input = 6;
                        }
                        else if (text.ReturnPoint()<0)
                        {
                            Console.WriteLine("YOU LOSE!"+"Total points: "+text.ReturnPoint());
                            input = 6;
                        }
                        
                    }
                    else
                    {
                        text.SubPoints(1);
                        Console.WriteLine("You are loosing the points: "+text.ReturnPoint());
                        if (text.ReturnPoint()>=10)
                        {
                            Console.WriteLine("YOU WIN!"+"Total points: "+text.ReturnPoint());
                            input = 6;
                        }
                        else if (text.ReturnPoint()<0)
                        {
                            Console.WriteLine("YOU LOSE!"+"Total points: "+text.ReturnPoint());
                            input = 6;
                        }
                        

                    }
                    Console.WriteLine("Total points: "+text.ReturnPoint());
                    
                    roomNumber2 = random.Next(0, 5);

                }while(input!=6);

            }
            else
            {
                Console.WriteLine("Please choose 1 up to 5:");
            }


        }
    }
}