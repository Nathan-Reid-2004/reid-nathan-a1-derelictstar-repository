using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
string gunPre = ("Precision Rifle");
int gunPreDmg = 1;
int gunPreAmmoCap = 7;

string gunAR = ("Assault Rifle");
int gunARDmg = 1;
int gunARAmmoCap = 15;

string gunShot = ("Shotgun");
int gunShotDmg = 7;
int gunShotAmmoCap = 3;

string grenade = ("Grenade");
int grenadeDmg = 1000;
int grenadeAmmoCap = 9;

string meleeBone = ("Bone Shard");
int meleeBoneDmg = 3;

string heal = ("Medical Patch");
int healBoost = 5;

string strength = ("Strength Booster");
int strengthBoost = 3;

string plasma = ("Plasma Tape");

string airlock = ("Airlock Override Key");

string steelBoots = ("Steel Boots");

string encoder = ("Keycode Encoder");

string goggles = ("Night Goggles");

string escape = ("Escape Pod Access Card");

string speed = ("Speed Booster");



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
string cyber =  Console.ReadLine();
Console.WriteLine($"Registering user info...\nName: {name}\nPosition: {position}\nTicket: {ticket}\nReasoning: {intent}\nInterface Purchase: {cyber}");
Console.WriteLine();
Console.WriteLine("WARNING: Vision Module not responding! Defaulting to text-based environment scans...\nUnlocking cryo chamber... Cryo chamber unlocked.");
Console.WriteLine();
