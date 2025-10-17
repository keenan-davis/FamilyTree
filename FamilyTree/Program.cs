namespace FamilyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var queenElizabeth = new RoyalMember("Elizabeth II", "Queen", new DateTime(1926, 4, 21));
            var familyTree = new FamilyTree(queenElizabeth);

            
            familyTree.AddMember("Elizabeth II", new RoyalMember("Charles", "Prince of Wales", new DateTime(1948, 11, 14)));
            familyTree.AddMember("Elizabeth II", new RoyalMember("Anne", "Princess Royal", new DateTime(1950, 8, 15)));
            familyTree.AddMember("Elizabeth II", new RoyalMember("Andrew", "Duke of York", new DateTime(1960, 2, 19)));
            familyTree.AddMember("Elizabeth II", new RoyalMember("Edward", "Earl of Wessex", new DateTime(1964, 3, 10)));

            
            familyTree.AddMember("Charles", new RoyalMember("William", "Prince of Wales", new DateTime(1982, 6, 21)));
            familyTree.AddMember("Charles", new RoyalMember("Harry", "Duke of Sussex", new DateTime(1984, 9, 15)));

            familyTree.AddMember("William", new RoyalMember("George", "Prince of Wales", new DateTime(2013, 7, 22)));
            familyTree.AddMember("William", new RoyalMember("Charlotte", "Princess of Wales", new DateTime(2015, 5, 2)));
            familyTree.AddMember("William", new RoyalMember("Louis", "Prince of Wales", new DateTime(2018, 4, 23)));

           
            while (true)
            {
                Console.WriteLine("\n--- Royal Family Tree Menu ---");
                Console.WriteLine("1. Display Full Family Tree");
                Console.WriteLine("2. Search for a Member");
                Console.WriteLine("3. Add a New Member");
                Console.WriteLine("4. BFS Traversal");
                Console.WriteLine("5. DFS Traversal");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        familyTree.DisplayTree(familyTree.Root);
                        break;
                    case "2":
                        Console.Write("Enter member name: ");
                        var name = Console.ReadLine();
                        var memberNode = familyTree.Search(name);
                        if (memberNode != null)
                        {
                            Console.WriteLine($"Found: {memberNode.Member}");
                        }
                        else
                        {
                            Console.WriteLine("Member not found.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter parent name: ");
                        var parentName = Console.ReadLine();
                        Console.Write("Enter new member name: ");
                        var newName = Console.ReadLine();
                        Console.Write("Enter title: ");
                        var title = Console.ReadLine();
                        Console.Write("Enter birth date (yyyy-mm-dd): ");
                        var birthDate = DateTime.Parse(Console.ReadLine());
                        var newMember = new RoyalMember(newName, title, birthDate);
                        familyTree.AddMember(parentName, newMember);
                        break;
                    case "4":
                        familyTree.BFS();
                        break;
                    case "5":
                        Console.WriteLine("\n--- DFS Traversal ---");
                        familyTree.DFS(familyTree.Root);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
