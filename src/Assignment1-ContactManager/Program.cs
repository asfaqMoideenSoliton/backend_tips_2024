using System.ComponentModel.Design;
/// <summary>
/// fjdsklc
/// </summary>
internal class Program
{
  private  static List<Dictionary<string, string>> contacts;

  private static void Main(string[] args)
    {
        contacts = new List<Dictionary<string, string>>();
        Console.WriteLine("Welcome to Conatact Manager");
        Console.WriteLine("[M]enu ");
        Console.WriteLine("[E]xit");

        string option = Console.ReadLine();

        if (option != null)
        {
            if (option == "M")
            {
                Menu();
            }
            else if (option == "E")
            {
                Exit();
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }
        }
        else
        {
            Console.WriteLine("Enter a non null option");
        }
        Console.ReadKey();
    }

  private static void Menu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("Please Enter a Option");
        Console.WriteLine("[V]iew all conatacts");
        Console.WriteLine("[A]dd a conatact");
        Console.WriteLine("[E]dit a conatact");
        Console.WriteLine("[D]elete a conatact");
        Console.WriteLine("[S]earch conatact");
        Console.WriteLine("[B]ack");
        string option = Console.ReadLine();

        if (option != null)
        {
            if (option == "V")
            {
                ViewAllContacts();
            }
            else if (option == "A")
            {
                AddContact();
            }
            else if (option == "E")
            {
                EditContact();
            }
            else if (option == "D")
            {
                DeleteContact();
            }
            else if (option == "S")
            {
                SearchContact();
            }
            else
            {
                Console.WriteLine("Enter a valid option");
                Menu();
            }
        }
    }
    /// <summary>
    /// ioj
    /// </summary>
  private static void AddContact()
    {
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Phone Number");
        string phone = Console.ReadLine();
        Console.WriteLine("Enter Mail");
        string mail = Console.ReadLine();
        Console.WriteLine("Enter City");
        string city = Console.ReadLine();

        contacts.Add(new Dictionary<string, string>
        {
            {"name", name },
            {"phone", phone },
            {"mail", mail },
            {"city", city  }
        });
        Console.WriteLine("[A]dd new Contact ? or [B]ack");
        string option = Console.ReadLine();

        if (option != null)
        {
            if (option == "A")
            {
                AddContact();
            }
            else if (option == "B")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Enter a valid option");
                Menu();
            }
        }
        else
        {
            Console.WriteLine("Enter a non null option");
        }
    }

  private static void ViewAllContacts()
    {
        if (contacts != null)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                foreach (KeyValuePair<string, string> pair in contacts[i])
                {
                    Console.WriteLine(pair.Key + ": " + pair.Value);
                }
            }
        }
        else
        {
            Console.WriteLine("No Conatcts yet");
            Menu();
        }
        Menu();
    }

  private static void SearchContact()
    {
        Console.WriteLine("Enter the name");
        string searchName = Console.ReadLine();

        if (contacts != null)
        {
            bool isContact = false;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (searchName == contacts[i]["name"])
                    {
                        isContact = true;
                        foreach (KeyValuePair<string, string> pair in contacts[i])
                        {
                        Console.WriteLine(pair.Key + pair.Value);
                            }
                    }
            }
            if (isContact == false) 
            {
                Console.WriteLine("Not Found");
            }
        } 

        else
        {
            Console.WriteLine("No Conatcts yet");
            Menu();
        }
        Menu();
    }

  private static void DeleteContact()
    {
        Console.WriteLine("Enter the name");
        string searchName = Console.ReadLine();

        if (contacts != null)
        {
            int index = -1 ;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (searchName == contacts[i]["name"])
                    {
                    index = i;
                }
            }

            if (index >= 0)
            {
                contacts.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Contact not found ");
            }
        }
        else
        {
            Console.WriteLine("No Conatcts yet");
            Menu();
        }
        Menu();
    } 
  private static void EditContact()
    {
        Console.WriteLine("Enter the name");
        string searchName = Console.ReadLine();
        Console.WriteLine("Enter new name");
        string newName = Console.ReadLine();
        if (contacts != null)
        {
            int index = -1 ;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (searchName == contacts[i]["name"])
                    {
                    index = i;
                }
            }
            if (index>=0)
            {
                int i = 0;
                foreach (KeyValuePair<string, string> pair in contacts[i])
                {
                    contacts[i]["name"] = newName;
                }
            }
            else
            {
                Console.WriteLine("Contact not found ");
            }
        }
        else
        {
            Console.WriteLine("No Conatcts yet");
            Menu();
        }

        Menu();
    }
  private static void Exit()
    {
        Console.ReadKey();
    }
}