using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

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


//player input options- dependant on what scenario the player is in (combat, code input, or exploration). These different inputs are used to separate
// 'if' statements from one another, so that exploration/code 'if' statements do not get mixed up with combat 'if' statements.
string playerInputExplore = Console.ReadLine();

string playerInputBattle = Console.ReadLine();

string playerInputCode = Console.ReadLine();
int codeValue = int.Parse(playerInputCode);


//checkpoint system
string checkpoint = ("CRYO REJUVINATION TERMINAL");
bool cryoCheckpoint = false;
if (playerInputExplore == $"ACTIVATE {checkpoint}")
{
    cryoCheckpoint = true;
    Console.WriteLine("Cyber conciousness uploaded to rejuvination terminal.");
}

string checkpoint1 = ("APARTMENTS REJUVINATION TERMINAL");
bool apartmentsCheckpoint = false;
if (playerInputExplore == $"ACTIVATE {checkpoint1}")
{
    apartmentsCheckpoint = true;
    cryoCheckpoint = false;
    Console.WriteLine("Cyber conciousness uploaded to rejuvination terminal. Previous terminal deactivated to help preserve emergency power.");
}

//code/door lock systems.
bool CryoDoorNorthLock = true;
if (codeValue == 9000)
{
    CryoDoorNorthLock = false;
    Console.WriteLine("DOOR to Documentation Offices unlocked. Proceeding...");
}

//player health systems (also relates back to checkpoint system if a checkpoint is active). 
int playerHealth = 5;
if (playerInputBattle == "USE MEDICAL PATCH")
{
    playerHealth += 5;
}
else if (playerHealth <= 10)
{
    Console.WriteLine("WARNING! User medical status is critical.\nIf you do not currently have a MEDICAL PATCH, please find the nearest one and follow the intructions on how to properly inject biological cleanser (instructions located on back of syringe).");
}
else if (playerHealth == 0)
{
    Console.WriteLine("Biological monitoring indicates a lack of brain activity and/or blood circulation. Vital signs reading 0%. User has expired...\nInitiating user data archiving for PentaCorp's research purposes...\nDone. System shutting down...");
}
else if (cryoCheckpoint == true & playerHealth == 0) ;
{
    playerHealth += 5;
    Console.WriteLine("Rejuvinating user body...\nRejuvination completed. Please be cautious during your first couple steps, as your biological systems may still be catching up with your cyber conciousness");
}

//inventory system- heavy items take up 2 slots, while light items take up 1 slot. different items will be displayed on different inventory
//displays in order to avoid overlap. 
int heavyItem = 2;

int lightItem = 1;

string inventoryDisplay =  ("");
string inventoryDisplay1 = ("");
string inventoryDisplay2 = ("");
string inventoryDisplay3 = ("");
string inventoryDisplay4 = ("");
string inventoryDisplay5 = ("");
string inventoryDisplay6 = ("");
string inventoryDisplay7 = ("");
string inventoryDisplay8 = ("");
string inventoryDisplay9 = ("");
string inventoryDisplay10 = ("");
string inventoryDisplay11 = ("");

int playerInv = 0;
if (playerInv >= 12)
{
    Console.WriteLine("INVENTORY full! Please drop items to make room in cyber interface's digital storage.");
}
else if (playerInputExplore == "DISPLAY INVENTORY")
{
    Console.WriteLine($"1. {inventoryDisplay}\n2. {inventoryDisplay1}\n3. {inventoryDisplay2}\n4. {inventoryDisplay3}\n5. {inventoryDisplay4}\n6. {inventoryDisplay5}\n7. {inventoryDisplay6}\n8. {inventoryDisplay7}\n9. {inventoryDisplay8}\n10. {inventoryDisplay9}\n10. {inventoryDisplay10}\n10. {inventoryDisplay11}");
}

//player ammo system and weapon stats.
int playerAmmo = 0;

//precision rifle.
    string gunPre = ("PRECISION RIFLE");
int gunPreDmg = 1;
if (playerInputExplore == $"DROP {gunPre}")
{
    playerInv -= heavyItem;
    inventoryDisplay = ("");
    inventoryDisplay1 = ("");
}
else if (playerInputExplore == $"PICK UP {gunPre}")
{
    playerInv += heavyItem;
    inventoryDisplay = ($"{gunPre}");
    inventoryDisplay1 = ($"{gunPre} Magazines");
}
else if (playerInputBattle == "USE STRENGTH BOOSTER")
{
    gunPreDmg += 3;
}
else if (playerInputBattle == $"USE {gunPre}")
{
    playerAmmo -= 1;
}

//assualt rifle.
string gunAR = ("BURST FIRE ASSUALT RIFLE");
int gunARDmg = 3;
if (playerInputExplore == $"DROP {gunAR}")
{
    playerInv -= heavyItem;
    inventoryDisplay3 = ("");
    inventoryDisplay4 = ("");
}
else if (playerInputExplore == $"PICK UP {gunAR}")
{
    playerInv += heavyItem;
    inventoryDisplay3 = ($"{gunAR}");
    inventoryDisplay4 = ($"{gunAR} Magazines");
}
else if (playerInputBattle == "USE STRENGTH BOOSTER")
{
    gunARDmg += 3;
}
else if (playerInputBattle == $"USE {gunAR}")
{
    playerAmmo -= 9;
}

//shotgun.
string gunShot = ("SHOTGUN");
int gunShotDmg = 5;
if (playerInputExplore == $"DROP {gunShot}")
{
    playerInv -= heavyItem;
    inventoryDisplay5 = ("");
    inventoryDisplay6 = ("");
}
else if (playerInputExplore == $"PICK UP {gunShot}")
{
    playerInv += heavyItem;
    inventoryDisplay5 = ($"{gunShot}");
    inventoryDisplay6 = ($"{gunShot} Slugs");
}
else if (playerInputBattle == "USE STRENGTH BOOSTER")
{
    gunShotDmg = 3;
}
else if (playerInputBattle == $"USE {gunShot}")
{
    playerAmmo -= 7;
}

//grenade.
string grenade = ("GRENADE");
int grenadeDmg = 8;
if (playerInputExplore == $"DROP {grenade}")
{
    playerInv -= heavyItem;
    inventoryDisplay7 = ("");
    inventoryDisplay8 = ("");
}
else if (playerInputExplore == $"PICK UP {grenade}")
{
    playerInv += heavyItem;
    inventoryDisplay7 = ($"{grenade}");
    inventoryDisplay8 = ($"{grenade} Gunpowder Packs");
}

//bone shard.
string meleeBone = ("BONE SHARD");
int meleeBoneDmg = 1;
if (playerInputExplore == $"DROP {meleeBone}")
{
    playerInv -= lightItem;
    inventoryDisplay2 = ("");
}
else if (playerInputExplore == $"PICK UP {meleeBone}")
{
    playerInv += lightItem;
    inventoryDisplay2 = ($"{meleeBone}");
}
else if (playerInputBattle == "USE STRENGTH BOOSTER")
{
    meleeBoneDmg += 3;
}

//bullets.
string bullets = ("AMMO");
if (playerInputExplore == $"PICK UP {bullets}")
{
    playerAmmo += 5;
}

//medical patch.
string heal = ("MEDICAL PATCH");
if (playerInputExplore == $"DROP {heal}")
{
    playerInv -= lightItem;
    inventoryDisplay9 = ("");
}
else if (playerInputExplore == $"PICK UP {heal}")
{
    playerInv += lightItem;
    inventoryDisplay9 = ($"{heal}");
}

//strength booster.
string strength = ("STRENGTH BOOSTER");
if (playerInputExplore == $"DROP {strength}")
{
    playerInv -= lightItem;
    inventoryDisplay10 = ("");
}
else if (playerInputExplore == $"PICK UP {strength}")
{
    playerInv += lightItem;
    inventoryDisplay10 = ($"{strength}");
}

//speed booster.
bool speedIsActivate = false;
string speed = ("SPEED BOOSTER");
if (playerInputBattle == "USE SPEED BOOSTER")
{
    bool speedIsActive = true;
    Console.WriteLine("SPEED BOOSTER is now active. Combine it with battle tactics for varying results.");
}

//enemies and damage systems. 

//reanimated robot.
string reanimated = ("REANIMATED ROBOT");
int reanimatedDmg = 2;
int reanimatedHealth = 3;
if (playerInputBattle == $"USE {gunPre} ON {reanimated}")
{
    gunPreDmg += 2;
}
else if (reanimatedHealth == 0)
{
    Console.WriteLine("Confirming scan results...\nPotential threat deceased. You may now continue normal operations.");
}

//service bot.
string service = ("SERVICE BOTS");
int serviceDmg = 3;
int serviceHealth = 5;
if (playerInputBattle == $"USE {meleeBone} ON {service}")
{
    meleeBoneDmg += 2;
}
else if (serviceHealth == 0)
{
    Console.WriteLine("Confirming scan results...\nPotential threat deceased. You may now continue normal operations.");
}

//electric angel.
string angels = ("ELECTRIC ANGELS");
int angelsDmg = 5;
int angelsHealth = 10;
if (playerInputBattle == $"USE {gunAR} ON {angels}")
{
    gunARDmg += 2;
}
else if (angelsHealth == 0)
{
    Console.WriteLine("Confirming scan results...\nPotential threat deceased. You may now continue normal operations.");
}

//crane.
string crane = ("CRANE");
int craneDmg = 9;
int craneHealth = 15;
if (playerInputBattle == $"USE {grenade} ON {crane}")
{
    grenadeDmg += 2;
}
else if (craneHealth == 0)
{
    Console.WriteLine("Confirming scan results...\nPotential threat deceased. You may now continue normal operations.");
}

//turret.
string turret = ("MILITARY TURRET");
int turretDmg = 15;
int turretHealth = 20;
if (playerInputBattle == $"USE {gunShot} ON {turret}")
{
    if (speedIsActivate == true)
    {
        gunShotDmg = 7;
    }
    else if (speedIsActivate == false)
    {
        Console.WriteLine("You peak out from behind the corner, but the turret detects you too quickly- you have no time to react. You cannot get any hits in on the turret.");
        gunShotDmg = 0;
        playerHealth -= 15;
    }

}
else if (turretHealth == 0)
{
    Console.WriteLine("Confirming scan results...\nPotential threat deceased. You may now continue normal operations.");
}
else
{
    Console.WriteLine("The weapon you have selected barely penetrates the thick armor of the turret. More firepower recommended.");
}

string pipes = ("STEAM PIPES");
int pipesDmg = 2;
int pipesHealth = 1;
if (playerInputExplore == $"USE PLASMA TAPE ON {pipes}")
{
    pipesHealth -= 1;
    Console.WriteLine("As you wrap the plasma tape around the tear in the pipes, the plasma coarses through the pipe's exterior, flashing before retreating into the hole and sealing it with a bright, tangled ball of electricity.");
}
else
{
    Console.WriteLine("A specific type of tape is needed to repair these pipes- this tape is usually used to repair communication systems, but it can also be applied to mechanical systems such as these steam-filled pipes. As you stand examining a particular torn pipe, hot steam comes rushing out of the tear and burns you.");
    playerHealth -= 2;
}

string coolant = ("ACIDIC COOLANT");
int coolantDmg = 2;
int coolantHealth = 1;
if (playerInputExplore == $"USE STEEL BOOTS ON {coolant}")
{
    pipesHealth -= 1;
    Console.WriteLine("Plunging your steel boots into the coolant, a hissing sound emerges as the liquid around your boots begins to fizz and bubble. The inside of your boots feel warm from the coolant, but you are protected.");
}
else
{
    Console.WriteLine("STEEL BOOTS are often worn by maintenence workers on starfaring vessels. If you require a pair, most of these workers can be found on the lower decks of the ship. Out of nowhere, some of the corrosive coolant spews up and a few drops of spray land on your skin, dissolving the affected skin into fleshy mush and burns.");
    playerHealth -= 2;
}


//story/objective-specific items.
string airlock = ("AIRLOCK OVERRIDE KEY");

string steelBoots = ("STEEL BOOTS");

string encoder = ("KEYCODE ENCODER");

string escape = ("ESCAPE POD ACCESS CARD");

string tape = ("PLASMA TAPE");



