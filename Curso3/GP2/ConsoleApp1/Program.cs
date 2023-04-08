// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
int petCount = 0;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
  switch (i)
  {
    case 0:
      animalSpecies = "dog";
      animalID = "d1";
      animalAge = "2";
      animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
      animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
      animalNickname = "lola";
      break;
    case 1:
      animalSpecies = "dog";
      animalID = "d2";
      animalAge = "9";
      animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
      animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
      animalNickname = "loki";
      break;
    case 2:
      animalSpecies = "cat";
      animalID = "c3";
      animalAge = "1";
      animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
      animalPersonalityDescription = "friendly";
      animalNickname = "Puss";
      break;
    case 3:
      animalSpecies = "cat";
      animalID = "c4";
      animalAge = "?";
      animalPhysicalDescription = "";
      animalPersonalityDescription = "";
      animalNickname = "";
      break;
    default:
      animalSpecies = "";
      animalID = "";
      animalAge = "";
      animalPhysicalDescription = "";
      animalPersonalityDescription = "";
      animalNickname = "";
      break;
  }

  if (animalID != "") petCount++;

  ourAnimals[i, 0] = "ID #: " + animalID;
  ourAnimals[i, 1] = "Species: " + animalSpecies;
  ourAnimals[i, 2] = "Age: " + animalAge;
  ourAnimals[i, 3] = "Nickname: " + animalNickname;
  ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
  ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{
  Console.Clear();
  #region MenuOptions
  Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
  Console.WriteLine(" 1. List all of our current pet information");
  Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
  Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
  Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
  Console.WriteLine(" 5. Edit an animal’s age");
  Console.WriteLine(" 6. Edit an animal’s personality description");
  Console.WriteLine(" 7. Display all cats with a specified characteristic");
  Console.WriteLine(" 8. Display all dogs with a specified characteristic");
  Console.WriteLine();
  Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
  #endregion
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    menuSelection = readResult.ToLower();
  }

  Console.WriteLine($"You selected menu option {menuSelection}.");
  Console.WriteLine("Press the Enter key to continue");

  // pause code execution
  readResult = Console.ReadLine();

  switch (menuSelection)
  {
    #region Case1
    case "1":
      // List all current pets
      Console.Clear();
      Console.WriteLine("Current Pets:");

      // Animals Loop
      for (int i = 0; i < maxPets; i++)
      {
        // i es la fila actual, 0 representa el ID
        if (ourAnimals[i, 0] == "ID #: ") break;
        Console.WriteLine();
        // Characteristics loop
        for (int j = 0; j < 6; j++)
        {
          Console.WriteLine(ourAnimals[i, j]);
        }
      }

      Console.Write("Press Enter to Continue");
      readResult = Console.ReadLine();
      break;
    #endregion
    #region Case2
    case "2":
      // Add new animals
      Console.Clear();
      string anotherPet = "";
      do
      {
        // Check if we're maxed out
        if (petCount == maxPets)
        {
          Console.WriteLine("We currently are full. We cannot manage more pets...");
          break;
        };

        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

        // another pet?
        Console.WriteLine("Do you want to enter info for another pet (y/n)");
        do
        {
          readResult = Console.ReadLine();
          if (readResult != null)
          {
            anotherPet = readResult.ToLower();
          }

        } while (anotherPet != "y" && anotherPet != "n");

        if (anotherPet == "y")
        {
          // Check where to insert new pet in matrix
          int insertPos = 0;
          for (int i = 0; i < maxPets; i++)
          {
            if (ourAnimals[i, 0] == "ID #: ") { insertPos = i; break; }
          }

          Console.WriteLine("Please, input the data");
          for (int i = 1; i < 6; i++)
          {
            switch (i)
            {
              case 1:
                do
                {
                  Console.WriteLine("Enter 'dog' or 'cat':");
                  readResult = Console.ReadLine();
                  if (readResult != null) readResult.ToLower();
                }
                while (readResult != "cat" && readResult != "dog");

                ourAnimals[insertPos, 1] = ourAnimals[insertPos, 1] + readResult;
                ourAnimals[insertPos, 0] = ourAnimals[insertPos, 0] + (readResult.Substring(0, 1) + (petCount + 1).ToString());
                break;
              case 2:
                do
                {
                  Console.WriteLine("Enter the pet's age or enter ? if unknown");
                  readResult = Console.ReadLine();
                  if (readResult != null) readResult.ToLower();
                }
                while (readResult != "?" && !int.TryParse(readResult, out _));
                ourAnimals[insertPos, 2] = ourAnimals[insertPos, 2] + readResult;
                break;

              case 3:
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if (readResult != null) readResult.ToLower();
                if (readResult == "") readResult = "tbd";
                ourAnimals[insertPos, 3] = ourAnimals[insertPos, 3] + readResult;
                break;

              case 4:
                Console.WriteLine("Enter a physical description of the pet");
                readResult = Console.ReadLine();
                if (readResult != null) readResult.ToLower();
                if (readResult == "") readResult = "tbd";
                ourAnimals[insertPos, 4] = ourAnimals[insertPos, 4] + readResult;
                break;

              case 5:
                Console.WriteLine("Enter a personality description of the pet");
                readResult = Console.ReadLine();
                if (readResult != null) readResult.ToLower();
                if (readResult == "") readResult = "tbd";
                ourAnimals[insertPos, 5] = ourAnimals[insertPos, 5] + readResult;
                break;
            }
          }
          Console.WriteLine("Animal added succesfully!");
          petCount++;
        }
      }
      while (anotherPet == "y" && petCount < maxPets);

      Console.Write("Press Enter to Continue");
      readResult = Console.ReadLine();
      break;
    #endregion
    case "3":
            int animal = -1;
            Console.Clear();
            //Ensure ages and physical are complete
            Console.WriteLine("Ensure Ages & Physical descriptions are complete: ");

            Console.WriteLine("Insert the ID# of the animal you are looking for: ");
            readResult = "ID #: " + Console.ReadLine();
            if (readResult!= null) readResult.ToLower();

            for(int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] == readResult)
                {
                    animal = i;
                    break;
                }
            }

            if (animal == -1) 
            { 
                Console.WriteLine("The animal you are looking for was not found..."); 
                break; 
            };




      break;
    case "4":
      //Ensure nicknames and personality are complete
      Console.Clear();
      break;
    case "5":
      // Edit an animal’s age
      Console.Clear();
      break;
    case "6":
      // Edit an animal’s personality
      Console.Clear();
      break;
    case "7":
      // Display all cats with a specified characteristic
      Console.Clear();
      break;
    case "8":
      // Display all dogs with a specified characteristic
      Console.Clear();
      break;
  }
}
while (menuSelection != "exit");
