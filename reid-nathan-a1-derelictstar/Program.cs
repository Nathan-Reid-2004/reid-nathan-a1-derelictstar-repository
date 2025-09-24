using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

//game start!
Console.WriteLine("Please press the ENTER key to boot up cyber interface.");

//defining variables (player battle input, health, strings, integers)
string playerInputBattle = Console.ReadLine();

int playerHealth = 10;

string bullets = ("AMMO");

string gunPre = ("PRECISION RIFLE");
int gunPreDmg = 4;

string meleeBone = ("BONE SHARD");
int meleeBoneDmg = 1;

string heal = ("MEDICAL PATCH");

string strength = ("STRENGTH BOOSTER");


string reanimated = ("REANIMATED ROBOT");
int reanimatedDmg = 3;
int reanimatedHealth = 8;

int playerAmmo = 0;

//intro!
    Console.WriteLine("Celestial Voyage Cyber Interface... Ver. 3.1. © PentaCorp, 2189\nWelcome to the Celestial Voyage experience. You are currently subscribed" +
    " to our premium plan for 7,400 credits a month.\nERROR 40176... Vision Module 9.5 boot-up failed!\nERROR 40198... Memory Restore failed to load!" +
    "\nPlease input user information...");
    Console.WriteLine();
    Console.WriteLine("State your NAME.");
    string name = Console.ReadLine();
    Console.WriteLine($"Welcome back, {name}. What is your position onboard the Lunar Shield?\nA. PASSENGER\nB. NAVIGATOR\nC. ENGINEER\nD. ADMIN \nF. OTHER (if OTHER, please be specific and type your own answer.)");
    string position = Console.ReadLine();
    Console.WriteLine("Please enter your TICKET NUMBER. This is any length and combination of numbers, depending on what is displayed on the ID you submitted to PentaCorp.");
    string ticket = Console.ReadLine();
    Console.WriteLine("State your intentions for being aboard the Lunar Shield.\nA. RELOCATION\nB. SCIENTIFIC ADVANCES \nC. HYDROPONICS\nD. EXPLORATION\nF. COLONY CONSTRUCTION \nG. OTHER (if OTHER, please be specific and type your own answer.)");
    string intent = Console.ReadLine();
    Console.WriteLine("Why did you purchase a cyber interface?\nA. MAPPING SYSTEMS\nB. BIOLOGICAL MONITORING\nC. WORK ASSISTANCE \nD. OTHER (if OTHER, please be specific and type your own answer.)");
    string cyber = Console.ReadLine();
    Console.WriteLine($"\nRegistering user info...\nName: {name}\nPosition: {position}\nTicket: {ticket}\nReasoning: {intent}\nInterface Purchase: {cyber}");
    Console.WriteLine();
    Console.WriteLine("WARNING: Vision Module not responding! Defaulting to text-based environment scans...\nUnlocking cryo chamber... Cryo chamber unlocked.");
    Console.WriteLine();
    Console.WriteLine("Stepping out of the cryo chamber, you lay your eyes upon a ruined hospital.\nBland grey tiled floors, white metal walls, and pipes lining the ceiling along with the occasional fluorescent light casting a sickly green shade across the whole room. \nStrewn across the room are gurneys in disarray and IV stands tipped over onto the floor.");
    Console.WriteLine();
    Console.WriteLine("1. The floor has a trail of dried, splattered blood going in the direction of the NORTH DOOR.\n2. To the EAST is a WINDOW.\n3. To the WEST is a large metal filing CABINET.");
    Console.WriteLine();
    Console.WriteLine("Using your interface, you may either WALK in any of the three directions given, EXAMINE an object, or PICK UP an item." +
        "\n\nWhat would you like to do? Please provide sufficicent details for your cyber inferface to use- ensure you are typing in all caps. \nEx. WALK EAST TO WINDOW or EXAMINE WINDOW or PICK UP AMMO.\n\n*PentaCorp is not liable for any interface-related mishaps, including injuries or deaths.\nIt is the user's responsibility to use the software properly and in a safe manner (as per the Consumer Restraint Agreement of 2177)*");
    string playerInputExplore = Console.ReadLine();

//player has options here- the WEST pathway is the correct one, but there are other endings depending on what the player chooses. the WEST pathway
//will send the player into the rest of the game.
    if (playerInputExplore == "WALK EAST TO WINDOW")
    {
     Console.WriteLine("\nYou stumble your way towards the WINDOW");
        string playerInputExamineWindow = Console.ReadLine();
        if (playerInputExamineWindow == "EXAMINE WINDOW")
        {
            Console.WriteLine("\n\nThe window has a few scrapes and small dents, but nothing serious. Gazing through the window, all you see is the vast emptiness of space.\n\nA walking skeleton limps towards you- bits of its are flesh still present in some areas. Attatched to it are small robotic nodes that are visibly vibrating its bones. \n\nThe skeleton lunges forward at you, slicing you multiple times with a sharpened bone. With no weapons to defend yourself, your biological systems begin to wane.");
            Console.WriteLine("\n\nBiological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\n\nInitiating user data archiving for PentaCorp's research purposes...\n\nDone. System shutting down...");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
    else if (playerInputExplore == "WALK WEST TO CABINET")
    {
        Console.WriteLine("\nYou groggily head over to the filing CABINET");
        string playerInputExploreExamineCabinet = Console.ReadLine();

    //this will begin a 'suiting up' sequence.
        if (playerInputExploreExamineCabinet == "EXAMINE CABINET")
        {
            Console.WriteLine("\n\nYou open each metal drawer, sifting through the various documents within. You eventually feel a box with heavy objects rolling around inside. \nPulling the box out of the stacks of papers, it is revealed to be a box of AMMO.");

            string playerInputAddAmmo = Console.ReadLine();
            if (playerInputAddAmmo == $"PICK UP {bullets}")
            {
                playerAmmo += 5;
                Console.WriteLine("\nItem added: 5 counts of ammunition");
                Console.WriteLine("\n\nYou notice there is a hole torn open at the back of the drawer. Reaching your hand through, you feel a few fairly large items. \n\nYou pull out the first one- a sliver handgun (known as a PRECISION RIFLE) with a bulky square scope (includes a digital display) and a medium-sized magazine.");

                string playerInputAddGun = Console.ReadLine();
                if (playerInputAddGun == $"PICK UP {gunPre}")
                {
                    Console.WriteLine($"\nItems added to inventory: {gunPre}.");
                    Console.WriteLine("\n\nYou reach your hand back into the hole- your hand re-emerges with a large metal syringe with a shiny red stripe. A MEDICAL PATCH.");
                    string playerInputAddMeds = Console.ReadLine();
                    if (playerInputAddMeds == $"PICK UP {heal}")
                    {
                        Console.WriteLine($"\nItems added to inventory: {heal}.");
                        Console.WriteLine("\n\nYou retrive the final item from behind the drawer- an identical looking syringe, but this time with a purple stripe. A STRENGTH BOOSTER.");
                        string playerInputAddStrength = Console.ReadLine();
                        if (playerInputAddStrength == $"PICK UP {strength}")
                        {
                            Console.WriteLine($"\nItems added to inventory: {strength}.");
                            Console.WriteLine("\n\nYou walk away from the cabinet, satisfied with your findings.\nAs you walk towards the centre of the room, you notice a bone on the floor- the bone has an extremely sharp tip.\nBONE SHARD added to PentaCorp's list of unregistered weapons database.");
                            string playerInputAddBone = Console.ReadLine();
                            if (playerInputAddBone == $"PICK UP {meleeBone}")
                            {
                                Console.WriteLine($"\nItems added to inventory: {meleeBone}.");

                            //this begins the game's combat sequence. players can choose between a few different options, but only
                            //one combination of options is the correct path- the player must figure out which path is the most optimal. 
                                Console.WriteLine("\n\nA walking skeleton limps towards you- bits of its are flesh still present in some areas. Attatched to it are small robotic nodes that are visibly vibrating its bones.\n\nThe skeleton lunges forward at you, slicing you multiple times with a sharpened bone.");
                                playerHealth -= reanimatedDmg;
                                Console.WriteLine($"\n\nBiological systems impaired. -3 health. {playerHealth} remaining.");
                                Console.WriteLine("\n\nCalculating hostile intentions...\nThe hostile will kill you if you allow it to.\n\nCalculating potential opnions for user...\nYou have [1] unregistered weapon and [1] military registered firearm at your disposal.\nAdditionally, you have two military-grade augmentation syringes.");
                                Console.WriteLine("\n\nYour cyber inferface includes combat command support.\nYou may choose from the following:\n\n1. USE [WEAPON]\n2. USE [MEDICAL PATCH]\n3. USE [STRENGTH BOOSTER] ON [WEAPON]\n4. DO NOTHING\n\nPlease input a valid command. \n\n*PentaCorp is contractually obligated to state the following: Option 4 is not recommended. Only use if you are out of all other options.*");

                                bool healInventory = true;
                                bool strengthInventory = true;

                                playerInputBattle = Console.ReadLine();
                                if (playerInputBattle == $"USE STRENGTH BOOSTER ON {gunPre}")
                                {
                                    gunPreDmg += 3;
                                    Console.WriteLine("\nSTRENGTH BOOSTER applied. +3 damage.");
                                    Console.WriteLine($"\nItem used: {strength}");
                                    strengthInventory = false;
                                    if (strengthInventory == false)
                                    {
                                        Console.WriteLine("\nSTRENGTH BOOSTER has been expended- item no longer available.");
                                    }
                                }
                                else if (playerInputBattle == $"USE {gunPre}")
                                {
                                    playerAmmo -= 1;
                                    reanimatedHealth -= gunPreDmg;
                                    Console.WriteLine($"\nAmmunition spent! {playerAmmo} remaining.");
                                    Console.WriteLine($"\n{gunPreDmg} Damage inflicted onto hostile. {reanimatedHealth} hostile health remaining.");
                                    Console.WriteLine("\n\nYou aim carefully, viewing the horrific skeleton cyborg through the green of the digital scope.\nA couple shots land, breaking two of the robotic nodes. The skeleton quivers and rattles, clearly weakened. \nIt's movements have slowed and its is visibly losing control of its body.");
                                }
                                else if (playerInputBattle == $"USE STRENGTH BOOSTER ON {meleeBone}")
                                {
                                    meleeBoneDmg += 3;
                                    Console.WriteLine("\nSTRENGTH BOOSTER applied. +3 damage.");
                                    Console.WriteLine($"\nItem used: {strength}");
                                    strengthInventory = false;
                                    if (strengthInventory == false)
                                    {
                                        Console.WriteLine("\nSTRENGTH BOOSTER has been expended- item must recharge.");
                                    }
                                }
                                else if (playerInputBattle == $"USE {meleeBone}")
                                {
                                    reanimatedHealth -= meleeBoneDmg;
                                    Console.WriteLine($"\n{meleeBoneDmg} Damage inflicted onto hostile. {reanimatedHealth} hostile health remaining.");
                                    Console.WriteLine("\n\nYou clumsily swing the sharpened bone at your foe- you manage to slice only one robotic node in your hasty movements. \nThe skeleton shudders slightly, evidently losing control of its body.");
                                }
                                else if (playerInputBattle == $"USE {heal}")
                                {
                                    healInventory = false;
                                    playerHealth += 3;
                                    Console.WriteLine($"\nVital biological systems maintained. +3 health. Current user health: {playerHealth}");
                                Console.WriteLine($"\nItem used: {heal}.");
                                    Console.WriteLine("\n\nYour hand shakes slightly as you pull back a small spring-loaded button. The button stops with a click.\nYou slowly push the syringe into your elbow- once it is fully in, the button suddenly clicks and you feel your elbow pulsing. \nA green light at the top of the syringe flashes with a beep- you take the syringe out and put it in your pocket.");
                                    if (healInventory == false)
                                    {
                                        Console.WriteLine("\nMEDICAL PATCH has been expended- item must recharge.");
                                    }
                               
                               

                                }
                                else
                                {
                                    Console.WriteLine("Invalid input.");
                                }
                            }
                            Console.WriteLine("\n\nThe skeleton gets another hit on you with it's blade-like bone.");
                            playerHealth -= reanimatedDmg;
                            if (playerHealth <= 0)
                            {
                                Console.WriteLine("\n\nBiological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\n\nInitiating user data archiving for PentaCorp's research purposes...\n\nDone. System shutting down...");
                            }
                            else
                            {
                                Console.WriteLine($"\n\nBiological systems impaired. -3 health. {playerHealth} remaining.");
                                Console.WriteLine("\n\n*MEDICAL PATCH and STRENTH BOOSTER replenished!*\n\nYour cyber inferface includes combat command support.\n You may choose from the following:\n\n1. USE [WEAPON]\n2. USE [MEDICAL PATCH]\n3. USE [STRENGTH BOOSTER] ON [WEAPON]\n\n4. DO NOTHING\n\nPlease input a valid command. \n\n*PentaCorp is contractually obligated to state the following: Option 4 is not recommended and could be fatal. \nThus, the Corporation has not programmed this as a valid option.*");

                                bool healInventory2 = true;
                                bool strengthInventory2 = true;

                                string playerInputBattle2 = Console.ReadLine();
                                if (playerInputBattle2 == $"USE STRENGTH BOOSTER ON {gunPre}")
                                {
                                    gunPreDmg += 3;
                                    Console.WriteLine("\nSTRENGTH BOOSTER applied. +3 damage.");
                                    Console.WriteLine($"\nItem used: {strength}");
                                    strengthInventory2 = false;
                                    if (strengthInventory2 == false)
                                    {
                                        Console.WriteLine("\nSTRENGTH BOOSTER has been expended- item no longer available.");
                                    }
                                }
                                else if (playerInputBattle2 == $"USE {gunPre}")
                                {
                                    playerAmmo -= 1;
                                    reanimatedHealth -= gunPreDmg;
                                    Console.WriteLine($"\nAmmunition spent! {playerAmmo} remaining.");
                                    Console.WriteLine($"\n{gunPreDmg} Damage inflicted onto hostile. {reanimatedHealth} hostile health remaining.");
                                    Console.WriteLine("\n\nYou aim carefully, viewing the horrific skeleton cyborg through the green of the digital scope.\nA couple shots land, breaking two of the robotic nodes. The skeleton quivers and rattles, clearly weakened. \nIt's movements have slowed and its is visibly losing control of its body.");
                                }
                                else if (playerInputBattle2 == $"USE STRENGTH BOOSTER ON {meleeBone}")
                                {
                                    meleeBoneDmg += 3;
                                    Console.WriteLine("\nSTRENGTH BOOSTER applied. +3 damage.");
                                    Console.WriteLine($"\nItem used: {strength}");
                                    strengthInventory2 = false;
                                    if (strengthInventory2 == false)
                                    {
                                        Console.WriteLine("\nSTRENGTH BOOSTER has been expended- item no longer available.");
                                    }
                                }
                                else if (playerInputBattle2 == $"USE {meleeBone}")
                                {
                                    reanimatedHealth -= meleeBoneDmg;
                                    Console.WriteLine($"\n{meleeBoneDmg} Damage inflicted onto hostile. {reanimatedHealth} hostile health remaining.");
                                    Console.WriteLine("\n\nYou clumsily swing the sharpened bone at your foe- you manage to slice only one robotic node in your hasty movements. \nThe skeleton shudders slightly, evidently losing control of its body.");
                                }
                                else if (playerInputBattle2 == $"USE {heal}")
                                {
                                    healInventory2 = false;
                                playerHealth += 3;
                                Console.WriteLine($"\nVital biological systems maintained. +3 health. Current user health: {playerHealth}");
                                Console.WriteLine($"\nItem used: {heal}.");
                                    Console.WriteLine("\n\nYour hand shakes slightly as you pull back a small spring-loaded button. The button stops with a click.\nYou slowly push the syringe into your elbow- once it is fully in, the button suddenly clicks and you feel your elbow pulsing. \nA green light at the top of the syringe flashes with a beep- you take the syringe out and discard it.");
                                    if (healInventory2 == false)
                                    {
                                        Console.WriteLine("\nMEDICAL PATCH has been expended- item no longer available.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input.");
                                }

                            //at the end of the battle, the player will either die (if their health has reached 0 or if the enemy has not
                            //died yet) or they will be able to proceed.
                            }
                            if (reanimatedHealth >= 1)
                            {
                                Console.WriteLine("\n\nThe skeleton suddenly and swiftly rushes you- with little time to react, you are impaled by the sharpened bone.");
                                Console.WriteLine("\n\nBiological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\n\nInitiating user data archiving for PentaCorp's research purposes...\n\nDone. System shutting down...");
                            }
                            else if (playerHealth <= 0)
                            {
                                Console.WriteLine("\n\nBiological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\n\nInitiating user data archiving for PentaCorp's research purposes...\n\nDone. System shutting down...");
                            }
                            else if (reanimatedHealth == 0)
                            {

                                //the player must input the correct code to win the game (this is very straightforward, however I wanted to use this
                                //as a chance to incorporate parsing into my code).
                                Console.WriteLine("\n\nThe skeleton lets out a robotic wail before collapsing to the ground. \nSearching the remains, you discover a bloodied piece of paper. It reads, '2004'");
                                Console.WriteLine("\n\nYou approach the DOOR to the NORTH.\n\nAnalyzing lock mechanism...\nPlease input code. \nYour cyber interface comes bundled with an encryption reader, which will manage the rest of the work for you.");
                                string playerInputCode = Console.ReadLine();
                                int playerCodeValue = int.Parse(playerInputCode);
                                int codeValue = 47104 - playerCodeValue;
                                bool docuDoorNorthLock = true;
                                if (codeValue != 45100)
                                {
                                    Console.WriteLine("\n\nDOOR to Escape Pod Garage locked. Incorrect code entered. Activating security turret.");
                                    Console.WriteLine("\n\nBiological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\n\nInitiating user data archiving for PentaCorp's research purposes...\n\nDone. System shutting down...");
                            }
                                else if (codeValue == 45100)
                                {
                                    docuDoorNorthLock = false;
                                    Console.WriteLine("\n\nDOOR to Escape Pod Garage unlocked. Proceeding...");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input.");
                                }

                            }
                        }

                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    else if (playerInputExplore == "WALK NORTH TO DOOR")
    {
        Console.WriteLine("\nYou steadily approach the door.");
        string playerInputExamineDoor = Console.ReadLine();
        if (playerInputExamineDoor == "EXAMINE DOOR")
        {
            Console.WriteLine("\n\nThe cold metal door is clearly battered and has seen better days. Dents and scrapes run along the surface, with dried bits of blood spattered around a keycode terminal.\n\nBefore you have any time to react, you are impaled by something sharp. You drop to the ground.");
            Console.WriteLine("\n\nBiological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\n\nInitiating user data archiving for PentaCorp's research purposes...\n\nDone. System shutting down...");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
