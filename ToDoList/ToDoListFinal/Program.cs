using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello !");

string Choice = string.Empty;
string[] AuthorizedChoices = new string[] { "S", "A", "R", "E" };
List<string> ToDoList = new List<string>();

//-----------------------------------------------------------------------------//
// Main Program.
//-----------------------------------------------------------------------------//
while (!AuthorizedChoices.Contains(Choice))
{
    Choice = DisplayOptions();

    if (string.IsNullOrEmpty(Choice) || !AuthorizedChoices.Contains(Choice))
        Console.WriteLine("Incorrect input");

    switch (Choice)
    {
        // Exit Option => Quit app.
        case "E":
            return;

        // See all TODOs.
        case "S":
            bool emptylist = SeeAllTODOs();
            Choice = string.Empty;
            break;

        // Add a new TODO.
        case "A":
            AddaTODO();
            Choice = string.Empty;
            break;

        // Remove a TODO.
        case "R":
            if (!SeeAllTODOs())
            {
                RemoveaTODO();
            }
            Choice = string.Empty;
            break;
    }
}



//-----------------------------------------------------------------------------//
// DisplayOptions Function : Display the mail form of ToDoList.
//-----------------------------------------------------------------------------//
string DisplayOptions()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("What do you want to do ?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    return Console.ReadLine().ToUpper();
}


//-----------------------------------------------------------------------------//
// SeeAllTODOs Function : Display le list of TODOs.
//-----------------------------------------------------------------------------//
bool SeeAllTODOs()
{
    if (!ToDoList.Any())
    {
        Console.WriteLine("No TODOs have been added yet.");
        return true;
    }

    for (int i = 0; i < ToDoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {ToDoList[i]}");
    }

    return false;
}


//-----------------------------------------------------------------------------//
// AddaTODO Function : Add a new Todo in TodoList.
//-----------------------------------------------------------------------------//
void AddaTODO()
{
    bool added = false;

    while (!added)
    {
        Console.WriteLine("Enter the TODO description: ");
        string todo = Console.ReadLine();

        if (string.IsNullOrEmpty(todo))
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (ToDoList.Contains(todo))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            ToDoList.Add(todo);
            Console.WriteLine($"TODO successfully added: {todo}");
            added = true;
        }
    }
}


//-----------------------------------------------------------------------------//
// RemoveaTODO Function : Remove a Todo from the list.
//-----------------------------------------------------------------------------//
void RemoveaTODO()
{
    bool deleted = false;
    int index = 0;

    while (!deleted)
    {
        Console.WriteLine("Select the index of the TODO you want to remove: ");
        string userSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(userSelection))
        {
            Console.WriteLine("Selected index cannot be empty.");
        }
        else if (int.TryParse(userSelection, out index) || !(ToDoList.Count() < index))
        {
            deleted = ToDoList.Remove(ToDoList[index - 1]);
        }
        else
        {
            Console.WriteLine("The given index is not valid.");
        }
    }
}