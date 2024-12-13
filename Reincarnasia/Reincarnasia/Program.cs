using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        NormalEnemy enemy = null;
        BossEnemy boss = null;
        Battle battle = null;
        string start, name, command, choices;
        bool notvalid = true, validinput = false;

        Console.WriteLine("╔════════════════════╗");
        Console.WriteLine("║ GROUP 7 PRESENTS.. ║");
        Console.WriteLine("╚════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ I was born and died as a Japanese but got reincarnated as a Filipino with a damn Amnesia ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        while (notvalid)
        {
            Console.WriteLine("Are you ready to be thrown in a world full of mystery, thrill, and danger?");
            Console.WriteLine("╔══════╦══════╗");
            Console.Write("║(Y)es ║ (N)o ║: ");
            Console.WriteLine("\n╚══════╩══════╝");
            start = Console.ReadLine().ToUpper();
            Console.Clear();

            if (start == "Y" || start == "YES")
            {
                Console.WriteLine("Great! Now you must first tell me your name, what should I call you?");
                Console.ReadKey();
                Console.Clear();
                notvalid = false;
            }
            else if (start == "N" || start == "NO")
            {
                Console.WriteLine("You must not be ready yet, come back once you've made up your mind.");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That's not a valid answer, try again!\n\n");
            }
        }
        Console.Write("\n\nName: ");
        name = Console.ReadLine();
        Console.Clear();
        while (!validinput)
        {
            Console.Write("\n\nName: ");
            name = Console.ReadLine();
            Console.Clear();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Enter a valid name!\n\n");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Hello, {name}!\n\n");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                validinput = true;
            }
        }
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════╗");
        Console.WriteLine("║ CHAPTER 1: FORGOTTEN MEMORIES ║");
        Console.WriteLine("╚═══════════════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Narrator: You wake up in your dorm room, disoriented.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"What am I doing here? I thought I was in Adamson University? Argh, my head is kinda fuzzy…");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("A pig suddenly jumps onto your bed and starts talking.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Unknown Pig: Well, well, well, you’re finally awake. You’re back at your dorm. What do you think, neat huh?");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        validinput = false;

        while (!validinput)
        {
            Console.WriteLine("You’re shocked. What will you do?");
            Console.WriteLine("\n\nA. Kick the pig.");
            Console.WriteLine("B. Jump out of bed");
            command = Console.ReadLine().ToUpper();
            Console.Clear();

            if (command == "A")
            {
                Console.WriteLine("You kick the pig, and it falls to the ground.");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Unknown Pig: Hey! Where are your manners?! I just saved you, and you kicked me?! How dare you!");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            else if (command == "B")
            {
                Console.WriteLine("You jump out of bed, startled. The pig snorts");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Unknown Pig: Relax! You don’t have to act like I’m a monster. I’m here to help you, okay?");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            else
            {
                Console.WriteLine("Author: Bro that's not even in the choices, choose A or B!");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        Console.WriteLine("Nelly: Anyway, my name’s Nelly. I’m your guide in this crazy mess. You don’t remember much now, but you’ll figure it out soon enough. For now, we have to move. There’s a lot to do, and you’re wasting time sitting around!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You're confused but you reluctantly agree. Nelly jumps off the bed and waddles toward the door.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Good news, your university isn’t far from here. We’ll walk or, better yet, we can take a tricycle. Faster and more fun.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You followed Nelly down the street. The city is alive with activity—students, vendors, and an air of tension.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You've arrived at Adamson University");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: This is where it all begins. Once we step inside, your journey starts. There’s no turning back now.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();


        validinput = false;

        while (!validinput)
        {
            Console.WriteLine("Do you want to enter the university?");
            Console.WriteLine("\n\nA. Yes");
            Console.WriteLine("B. No");
            command = Console.ReadLine().ToUpper();
            Console.Clear();

            if (command == "A")
            {
                Console.WriteLine("You walk through the gates, and an odd sensation washes over you. Memories start to flicker, your head feels clearer, and your instincts sharpen.");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            else if (command == "B")
            {
                Console.WriteLine("Nelly: What are you, scared? Fine, you can stay here, but don’t expect anything exciting to happen in your dorm room.");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Author: Bro that's not even in the choices, choose A or B!");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.Clear();
            }
        }



        Console.WriteLine("Narrator: You step into Adamson University, a place filled with both opportunities and threats. The path to reclaiming your memories begins here.");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Main Quest Unlocked!\n\n");
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║ OBJECTIVE: Find the first virtue, Faith ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Looks like you got your very first quest!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly:  As your your great master, let me show you the requirements you need to complete the quest!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════╗");
        Console.WriteLine("║ REQUIREMENTS ║");
        Console.WriteLine("╚══════════════╝");
        Console.WriteLine("\n - Head to the 1st floor of the dungeon and complete the task that will be given to you.");
        Console.WriteLine(" - You must level up to level 2");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly:  Wait, it also says here that after meeting up all the requirements, you will be getting a secret prize!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Let's stop this nonsense yapping and head on to our destination!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly:  Now now, get ready—the first dungeon isn’t far!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║ You have arrived at your destination! ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly:  This is it! The dungeon where your first challenge lies. But remember, dungeons aren’t straightforward. You’ll need to make choices. Choose wisely, and you might survive!");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.Write("Nelly:  There are 4 paths ahead of us! Which way should we go?: ");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();



        validinput = false;

        while (!validinput)
        {
            Console.WriteLine("Pick a direction!\n\n");

            Console.WriteLine("        ╔═══════╗      ");
            Console.WriteLine("        ║ North ║       ");
            Console.WriteLine("  ╔═════╝       ╚═════╗       ");
            Console.WriteLine("  ║ West    +    East ║");
            Console.WriteLine("  ╚═════╗       ╔═════╝       ");
            Console.WriteLine("        ║ South ║       ");
            Console.WriteLine("        ╚═══════╝      ");
            Console.WriteLine("\n(N)orth");
            Console.WriteLine("(E)ast");
            Console.WriteLine("(W)est");
            Console.WriteLine("(S)outh");
            Console.Write("\nInput: ");
            command = Console.ReadLine().ToUpper();
            Console.Clear();

            if (command == "N" || command == "NORTH")
            {
                Console.WriteLine("As you move forward, you reached a turning point in the path");

                while (true)
                {
                    Console.WriteLine("Go Left or Right?: ");
                    Console.WriteLine("A. Left");
                    Console.WriteLine("B. Right");
                    Console.Write("\nInput: ");
                    choices = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (choices == "A")
                    {
                        Console.WriteLine("Nelly: Oh no, we fell into trap door of enemies, quick defeat them!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════╗");
                        Console.WriteLine("║ New quest unlocked! ║");
                        Console.WriteLine("╚═════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║ QUEST: Defeat the oppossing enemy! ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        enemy = new NormalEnemy("Adamsonian", 100, 10);
                        battle = new Battle(player, enemy);
                        battle.NormalBattle();

                        Console.WriteLine("╔════════════════════════════╗");
                        Console.WriteLine("║ The enemy dropped an item! ║");
                        Console.WriteLine("╚════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("The path you seek lies where the sun sets, \nA trail of shadows, a place to rest. \nThough others call, resist the zest, \nYour prize awaits if you head West.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: That item might be a hint to the correct route! Let's go take a look again at the paths we've come across earlier.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (choices == "B")
                    {
                        Console.WriteLine("Nelly: Look, theres an item!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════════════════════════════╗");
                        Console.WriteLine("║ You obtained a scripture containing a clue! ║");
                        Console.WriteLine("╚═════════════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("The path you seek lies where the sun sets, \nA trail of shadows, a place to rest. \nThough others call, resist the zest, \nYour prize awaits if you head West.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: That item might be a hint to the correct route! Let's go take a look again at the paths we've come across earlier.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            //east
            else if (command == "E" || command == "EAST")
            {
                Console.WriteLine("Nelly: Oh no, an enemy has appeared, quick defeat him!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Enemy: So, you dare enter my territory? Let’s see if you’re strong enough to survive!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine("║ New quest unlocked! ║");
                Console.WriteLine("╚═════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════════════════════╗");
                Console.WriteLine("║ QUEST: Defeat the mysterious enemy! ║");
                Console.WriteLine("╚═════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                enemy = new NormalEnemy("Mysterious Enemy", 100, 20);
                battle = new Battle(player, enemy);
                battle.NormalBattle();

                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║ You obtained MP Potion! ║");
                Console.WriteLine("╚═════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.storingItem("MP Potion");

                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║ MP Potion has been added to your backpack! ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Congratulations on getting that MP Potion! Use it when you ran out of MP to use your skills!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Now let's go back to the entrance and try the other routes to see what we can find.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            else if (command == "S" || command == "SOUTH")
            {
                Console.WriteLine("Nelly: Wait, you seriously want to take a breather outside? Okayy go then, but come back once you're done!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Taking a breather...");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Are you ready to go back to the dungeon?");
                    Console.WriteLine("A. Yes");
                    Console.WriteLine("B. No");
                    Console.Write("Input: ");
                    command = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (command == "A")
                    {
                        Console.WriteLine("Nelly: Alright let's go!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (command == "B")
                    {
                        Console.WriteLine("Nelly: Ah shit, here we go again.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Taking a breather...");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else if (command == "W" || command == "WEST")
            {
                Console.WriteLine("You entered a glowing room with strange light.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("On a pedestal lies a mysterious item.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("║ You obtained the special artifact: Shard of Hope! ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("║ Shard of Hope increased your power exponentially! ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.UpdateDmgnHp(20, 20);
                Console.WriteLine($"Your damage increased by 20 and your hp increased by 10!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Nelly: Wow! Shard of Hope is a special item that is despised by the Apex of Despair, in which you can use to defeat him!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            else
            {
                Console.WriteLine("Author: Hey! That's not even in the choices, get more serious will ya?");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        Console.WriteLine("Nelly: Well done! With that, you can now take on the Apex of Despair!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║ You suddenly feel the ground shaking. ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║ A feeling of unease envelops your body. ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ The sky that once shined, is now looming with darkness. ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Mysterious Voice: You must think that you can defeat me. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Mysterious Voice: A million years that I have lived, and not a single one was able to defeat me. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Mysterious Voice: How dare, a weakling like you have the audacity to challenge me! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Mysterious Voice: How dare, a weakling like you challenge an apex predator  ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Despair: Kneel and witness the power of a God! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════╗");
        Console.WriteLine("║ MAIN QUEST UNLOCKED! ║");
        Console.WriteLine("╚══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║ QUEST: DEFEAT THE BOSS - APEX OF DESPAIR ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        boss = new BossEnemy("Apex of Despair", 200);
        battle = new Battle(player, boss);
        battle.BossBattle();

        Console.WriteLine("Apex of Despair: N-no, this is impossible, h-how could a mortal like you defeat a God?!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Apex of Despair: Don't get cocky just because you defeated me, as I am the weakest out of all the 3 Apex!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Apex of Despair: Don't get cocky just because you defeated me, as I am the weakest out of all the 3 Apex!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("The sky brightens as the Apex of Despair disintigrated into dust");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ CONGRATULATIONS! YOU DEFEATED THE BOSS: APEX OF DESPAIR! ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════╗");
        Console.WriteLine("║ YOU OBTAINED AN ITEM! ║");
        Console.WriteLine("╚═══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ BADGE OF HOPE: This item will allow you to pass through the next gate without difficulty. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Congrats on defeating the first Apex Predator!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Let us now proceed to our next destination, the land of TUP!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════╗");
        Console.WriteLine("║ CHAPTER 2: LAND OF TUP ║");
        Console.WriteLine("╚════════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You arrive at the towering gates of TUP, surrounded by massive mechanical structures.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("The air is thick with the hum of machines working tirelessly, and the atmosphere is industrial and cold.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("As you walk further in, a massive figure suddenly appears in your path.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("As you walk further in, a massive figure suddenly appears in your path.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Iron Sentinel: Intruder detected. State your purpose or be eliminated.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: Oh no, prepare for a battle!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════╗");
        Console.WriteLine("║ NEW QUEST UNLOCKED! ║");
        Console.WriteLine("╚═════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════╗");
        Console.WriteLine("║ QUEST: Defeat the Iron Sentinel ║");
        Console.WriteLine("╚═════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        enemy = new NormalEnemy("Iron Sentinel", 100, 30);
        battle = new Battle(player, enemy);
        battle.NormalBattle();

        Console.WriteLine("╔═════════════════════════════════╗");
        Console.WriteLine("║ YOU DEFEATED THE IRON SENTINEL! ║");
        Console.WriteLine("╚═════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Iron Sentinel: SYSTEM... MALFUNC--ZZT... CORE FAILUR---KZZT... DEFEAT ACKNOWLEDGED... PROCESSING... [ERROR]");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║ YOU OBTAINED THE STEEL CORE! ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ STEEL CORE: This item will allow you to enter the steel dungeon, where the Apex of Hate resides! ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You stand before a massive steel door, rusted at the edges but still imposing. A faint hum of machinery echoes from within.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Wow, a dungeon made of steel and machine!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Let's not waste any more time and head in!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        validinput = false;

        while (!validinput)
        {
            Console.WriteLine("Pick a direction!\n\n");

            Console.WriteLine("        ╔═══════╗      ");
            Console.WriteLine("        ║ North ║       ");
            Console.WriteLine("  ╔═════╝       ╚═════╗       ");
            Console.WriteLine("  ║ West    +    East ║");
            Console.WriteLine("  ╚═════╗       ╔═════╝       ");
            Console.WriteLine("        ║ South ║       ");
            Console.WriteLine("        ╚═══════╝      ");
            Console.WriteLine("\n(N)orth");
            Console.WriteLine("(E)ast");
            Console.WriteLine("(W)est");
            Console.WriteLine("(S)outh");
            Console.Write("\nInput: ");
            command = Console.ReadLine().ToUpper();
            Console.Clear();

            if (command == "N" || command == "NORTH")
            {
                Console.WriteLine("You continue down the path, but soon encounter another fork in the road.");
                Console.WriteLine("Nelly: Be careful, every choice matters here.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Go Left or Right?: ");
                    Console.WriteLine("A. Left");
                    Console.WriteLine("B. Right");
                    Console.Write("\nInput: ");
                    choices = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (choices == "A")
                    {
                        Console.WriteLine("Nelly: Oh no, we fell into trap door of an enemy again, but no worries this should be easy to you by now.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════╗");
                        Console.WriteLine("║ New quest unlocked! ║");
                        Console.WriteLine("╚═════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║ QUEST: Defeat the oppossing enemy! ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        enemy = new NormalEnemy("TUPIAN", 150, 30);
                        battle = new Battle(player, enemy);
                        battle.NormalBattle();

                        Console.WriteLine("╔════════════════════════════╗");
                        Console.WriteLine("║ The enemy dropped an item! ║");
                        Console.WriteLine("╚════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("The setting sun leads to ruin, but the warmth of salvation lies to the South.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: That item might be a hint to our next route! Let's go take a look again at the paths we've come across earlier.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (choices == "B")
                    {
                        Console.WriteLine("Nelly: Look, theres an item!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════════════════════════════╗");
                        Console.WriteLine("║ You obtained a scripture containing a clue! ║");
                        Console.WriteLine("╚═════════════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("The setting sun leads to ruin, but the warmth of salvation lies to the South.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: That item might be a hint to our next route! Let's go take a look again at the paths we've come across earlier.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            //east
            else if (command == "E" || command == "EAST")
            {
                Console.WriteLine("You encounter a Mysterious Opponent blocking the path. He’s tall, wearing a dark cloak, and his eyes glow with a strange energy.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Mysterious Enemy: So, you think you can challenge me? Let’s see if you’re strong enough!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine("║ New quest unlocked! ║");
                Console.WriteLine("╚═════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════════════════════╗");
                Console.WriteLine("║ QUEST: Defeat the mysterious enemy! ║");
                Console.WriteLine("╚═════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                enemy = new NormalEnemy("Mysterious Enemy", 150, 30);
                battle = new Battle(player, enemy);
                battle.NormalBattle();

                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║ You obtained MP Potion! ║");
                Console.WriteLine("╚═════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.storingItem("HP Potion");

                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║ HP Potion has been added to your backpack! ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Congratulations on getting that MP Potion! Use it when you ran out of MP to use your skills!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Now let's go back to the entrance and try the other routes to see what we can find.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            else if (command == "S" || command == "SOUTH")
            {
                Console.WriteLine("You entered a machinery room filled with neon lights.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("On a pedestal lies a mysterious item.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("║ You obtained the special artifact: Shard of Love! ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Shard of Hope increased your power exponentially! ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.UpdateDmgnHp(10, 30);
                Console.WriteLine($"Your damage increased by 10 and your hp increased by 30!");

                Console.WriteLine("Nelly: Incredible! The Shard of Love—this is no ordinary item. Its power is unrivaled against the Apex of Hate!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            else if (command == "W" || command == "WEST")
            {
                Console.WriteLine("Nelly: Wait, you seriously want to take a breather outside? Okayy go then, but come back once you're done!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Taking a breather...");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Are you ready to go back to the dungeon?");
                    Console.WriteLine("A. Yes");
                    Console.WriteLine("B. No");
                    Console.Write("Input: ");
                    command = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (command == "A")
                    {
                        Console.WriteLine("Nelly: Alright let's go!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (command == "B")
                    {
                        Console.WriteLine("Nelly: Ah shit, here we go again.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Taking a breather...");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.WriteLine("Author: Hey! That's not even in the choices, get more serious will ya?");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        Console.WriteLine("Nelly: With this in our hands, we may stand a chance against the darkest forces!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ The ground trembles violently as a dark presence approaches. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ A cold chill spreads through the air, as if the world itself recoils in fear. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ The once bright sky darkens, consumed by an overwhelming   ║");
        Console.WriteLine("║ aura of hatred.                                            ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Mysterious Voice: You dare approach me, weak mortal?       ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Mysterious Voice: You may have battled your way here, but your strength means nothing to me. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Hate: Your foolishness will be your undoing... I am the Apex of Hate! ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════╗");
        Console.WriteLine("║ MAIN QUEST UNLOCKED! ║");
        Console.WriteLine("╚══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║ QUEST: DEFEAT THE BOSS - APEX OF HATE ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        player.UpdateBossDmg(15);
        boss = new BossEnemy("Apex of Hate", 250);
        battle = new Battle(player, boss);
        battle.BossBattle();

        Console.WriteLine("Apex of Hate: No... this can't be! How... how could a mere mortal like you stand against *me*, the embodiment of hate?");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Apex of Hate: You may have defeated me, but you have only scratched the surface of what is to come... You are nothing compared to what lies ahead!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Apex of Hate: Don’t grow too confident, fool! You have no idea the depths of hatred that still remain.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("The ground trembles as the Apex of Hate dissolves into a cloud of dark energy, its power leaving a lingering, oppressive silence.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        Console.WriteLine("║ CONGRATULATIONS! YOU DEFEATED THE BOSS: APEX OF HATE! ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════╗");
        Console.WriteLine("║ YOU OBTAINED AN ITEM! ║");
        Console.WriteLine("╚═══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ BADGE OF LOVE: This item will allow you to pass through the next dungeon without difficulty. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Wow! Congrats on defeating the Apex of Hate!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Although you defeated the boss, I gotta say, you had me on the edge there!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Alright, it’s time to head to the Shadowed Highlands—the most cursed place this side of the realm!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: They say the air there is thick with whispers of betrayal... and honestly, it sounds awful. But hey, no shard, no progress, right?");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║ CHAPTER 3: VEIL OF DECEPTION ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.WriteLine("\n\n\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You and Nelly navigate through an eerie, crumbling castle filled with phantom whispers.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Alright, this place gives me the creeps. The Apex of Unfaithful is lurking somewhere in here. We need the 'Shard of Truth' to face it.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"{name}: Shard of Truth? Where do we even start looking in this maze?");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Oh, leave that to me! I’ve got a sense for these things. Besides, we’re a team, right? I lead, you fight, and together—we win!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"{name}: Let’s hope your ‘sense’ doesn’t get us lost again.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Hey! That only happened once. Now, come on. We’ve got shards to find!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Entering the dungeon of Betrayal...");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Alright, here we are—the Dungeon of Betrayal. Four paths, four chances to mess up. But hey, no pressure! One of these leads to the Shard of Truth, the others... well, they don’t.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Okay, genius, what’s it gonna be? North, East, West, or South?");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        validinput = false;

        while (!validinput)
        {
            Console.WriteLine("Pick a direction!\n\n");

            Console.WriteLine("        ╔═══════╗      ");
            Console.WriteLine("        ║ North ║       ");
            Console.WriteLine("  ╔═════╝       ╚═════╗       ");
            Console.WriteLine("  ║ West    +    East ║");
            Console.WriteLine("  ╚═════╗       ╔═════╝       ");
            Console.WriteLine("        ║ South ║       ");
            Console.WriteLine("        ╚═══════╝      ");
            Console.WriteLine("\n(N)orth");
            Console.WriteLine("(E)ast");
            Console.WriteLine("(W)est");
            Console.WriteLine("(S)outh");
            Console.Write("\nInput: ");
            command = Console.ReadLine().ToUpper();
            Console.Clear();

            if (command == "N" || command == "NORTH")
            {
                Console.WriteLine("Nelly: Wait, the energy in this room feels rather sharp!You entered a glowing room with strange light.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Like it’s cutting through the lies in this place.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: This must be it, the Shard of Truth!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine("║ You obtained the special artifact: Shard of Truth! ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Shard of Truth increased your power exponentially! ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.UpdateDmgnHp(20, 30);
                Console.WriteLine($"Your damage increased by 20 and your hp increased by 30!");

                Console.WriteLine($"{name}: We’ve got what we came for. Time to face the Apex of Unfaithful.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            //east
            else if (command == "E" || command == "EAST")
            {
                Console.WriteLine("Nelly: Oh, no. This doesn’t feel right. No shard here, just more despair. Let’s head back before we get ambushed!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Will you go back to the dungeon?");
                    Console.WriteLine("A. Yes");
                    Console.WriteLine("B. No");
                    Console.Write("Input: ");
                    command = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (command == "A")
                    {
                        Console.WriteLine("Nelly: Alright let's go!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (command == "B")
                    {
                        Console.WriteLine("Nelly: Ah shit, here we go again.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else if (command == "S" || command == "SOUTH")
            {
                Console.WriteLine("Nelly: Are you sure about this path? Something feels... off.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("AN ENEMY APPEARED");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Enemy: You think you can uncover the truth? Prove your strength!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine("║ New quest unlocked! ║");
                Console.WriteLine("╚═════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════════════════════╗");
                Console.WriteLine("║ QUEST: Defeat the mysterious enemy! ║");
                Console.WriteLine("╚═════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                enemy = new NormalEnemy("Mysterious Enemy", 200, 30);
                battle = new Battle(player, enemy);
                battle.NormalBattle();

                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║ You obtained MP Potion! ║");
                Console.WriteLine("╚═════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.storingItem("HP Potion");

                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║ HP Potion has been added to your backpack! ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Now let's go back to the entrance and try the other routes to see what we can find.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            else if (command == "W" || command == "WEST")
            {
                Console.WriteLine("As you move forward, you reached a turning point in the path");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Hold up! There’s a fork ahead—left or right. What’s the plan?");

                while (true)
                {
                    Console.WriteLine("Go Left or Right?: ");
                    Console.WriteLine("A. Left");
                    Console.WriteLine("B. Right");
                    Console.Write("\nInput: ");
                    choices = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (choices == "A")
                    {
                        Console.WriteLine("Nelly: Uh-oh... looks like you picked the harder route. And by harder, I mean, incoming enemy alert! Get ready!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════╗");
                        Console.WriteLine("║ New quest unlocked! ║");
                        Console.WriteLine("╚═════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║ QUEST: Defeat the oppossing enemy! ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        enemy = new NormalEnemy("The Betrayed One", 200, 30);
                        battle = new Battle(player, enemy);
                        battle.NormalBattle();

                        Console.WriteLine("╔════════════════════════════╗");
                        Console.WriteLine("║ The enemy dropped an item! ║");
                        Console.WriteLine("╚════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: Whew, nice work! Hey, what’s this?");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("‘Above all else, where heights are steep, Your path lies where the compass meets..’");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: A clue! It says, ‘Above all else, where heights are steep, Your path lies where the compass meets..’");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: Let’s backtrack and try again.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (choices == "B")
                    {
                        Console.WriteLine("Nelly: No traps? No enemies? Could it be... yep! You found the clue! You’re on a roll!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════════════════════════════╗");
                        Console.WriteLine("║ You obtained a scripture containing a clue! ║");
                        Console.WriteLine("╚═════════════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("‘Above all else, where heights are steep, Your path lies where the compass meets..’");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: That item might be a hint to the correct route! Let's go take a look again at the paths we've come across earlier.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.WriteLine("Author: Hey! That's not even in the choices, get more serious will ya?");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        Console.WriteLine("Nelly: Whoa… did you feel that? The ground just shook. This place is falling apart!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Ugh, I hate this! It’s so dark, I can barely see my own hands. Are those... whispers I hear?");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("A loud crash echoes through the dungeon, and the lights dim further.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("The Apex of Unfaithful emerges—a corrupted knight wielding a shattered blade, their form flickering like a broken reflection.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.WriteLine("║ WARNING: THE APEX OF UNFAITHFUL HAS ARRIVED! ║");
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: Your truth is fragile. You will shatter, just as your past did. ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: Oh, please! You’re just another edgy boss with a big mouth. {name}, show this faker what real strength looks like!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: Your past is a broken mirror. Do you truly want to see what lies within? ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════╗");
        Console.WriteLine("║ MAIN QUEST UNLOCKED! ║");
        Console.WriteLine("╚══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════╗");
        Console.WriteLine("║ QUEST: DEFEAT THE BOSS - APEX OF UNFAITHFUL ║");
        Console.WriteLine("╚═════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        player.UpdateBossDmg(20);
        boss = new BossEnemy("Apex of Unfaithful", 300);
        battle = new Battle(player, boss);
        battle.BossBattle();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: [Voice trembling with rage] No... this can’t be! I...I was the truth! The truth you feared! ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: Foolish mortal! You think you’ve won? This is nothing! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: The truth you sought was never meant for you. You will never defeat the Apex of Misfortune! ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: Misfortune? We’ll see about that. We’re taking you down, one by one.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: You dare? You cannot even begin to comprehend the power of the Apex of Misfortune! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: No matter how far you go, no matter how much you think you’ve regained, you will fall before it! ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Unfaithful: You will never escape the fate that awaits you. Misfortune will crush you, just as I have! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: We’ll see. But for now, enjoy your defeat. It's the only thing left for you.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"The dungeon starts to tremble and crack, then suddenly the oppressive darkness begins to lift.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ CONGRATULATIONS! YOU DEFEATED THE BOSS: APEX OF UNFAITHFUL! ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════╗");
        Console.WriteLine("║ YOU OBTAINED AN ITEM! ║");
        Console.WriteLine("╚═══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ BADGE OF TRUTH: This item will allow you to pass through the next dungeon without difficulty. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Wow! That was intense! The Apex of Unfaithful didn’t stand a chance!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: I swear, you’ve got this whole ‘saving the world’ thing down. But don’t get too cocky just yet...");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Now, it’s time to face the final challenge—the Apex of Misfortune. And trust me, this one’s going to be the hardest yet.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: We’ve got one last shard to find, but I’ve heard the path ahead is... *cursed*. The air’s thick with doom, and the very ground might betray us.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: But hey, no matter what, we’ve come this far. No turning back now. Let’s head to the Desolate Wastes and end this!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════╗");
        Console.WriteLine("║ LAST CHAPTER: 'FINAL' RECKONING ║");
        Console.WriteLine("╚═════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Here we are, the Desolate Wastes. A land where hope goes to die. We’ve got one final dungeon to crawl through.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You and Nelly stand before a towering, eerie tomb—a place that feels like it has been forgotten by time.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("A cold wind sweeps through the air, making the walls of the tomb whisper of ancient sorrows.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Well, here we are—the Tomb of Lost Hope. Dark, dreary, and practically oozing despair. This place... doesn’t feel like the end, but we’re getting close.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"{name}: It’s unsettling... but we have no choice. This is where it all ends, right?");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Yeah, it should be. We’ve got the last shard to find—the Shard of Luck. Once we’ve got it, it’s time for the final showdown. But, uh... I wouldn’t count on it being easy.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Nelly: Now, like usual, we’ve got four paths to choose from: North, East, West, and South. We just need to pick the right one. No biggie.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You entered the final dungeon, the 'Tomb of Lost Hope'");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("The tomb doors creak open, revealing a dark, winding interior...");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You move deeper into the Tomb of Lost Hope, their footsteps echoing through the dark halls. Ahead, four paths stretch out: North, East, West, and South.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        validinput = false;
        while (!validinput)
        {

            Console.WriteLine("Nelly: Here we go again. Which one do you think is the right path? Feeling any strong vibes from one of these?");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nPick a direction!\n\n");

            Console.WriteLine("        ╔═══════╗      ");
            Console.WriteLine("        ║ North ║       ");
            Console.WriteLine("  ╔═════╝       ╚═════╗       ");
            Console.WriteLine("  ║ West    +    East ║");
            Console.WriteLine("  ╚═════╗       ╔═════╝       ");
            Console.WriteLine("        ║ South ║       ");
            Console.WriteLine("        ╚═══════╝      ");
            Console.WriteLine("\n(N)orth");
            Console.WriteLine("(E)ast");
            Console.WriteLine("(W)est");
            Console.WriteLine("(S)outh");
            Console.Write("\nInput: ");
            command = Console.ReadLine().ToUpper();
            Console.Clear();

            if (command == "S" || command == "SOUTH")
            {
                Console.WriteLine("Nelly: Wait, the energy in this room is overwhelming!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: It’s pulsing with energy, as if it’s granting us a glimmer of hope in this bleak place.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: This must be it, the Shard of Luck!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("║ You obtained the special artifact: Shard of Luck! ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Shard of Truth increased your power exponentially! ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.UpdateDmgnHp(20, 30);
                Console.WriteLine($"Your damage increased by 20 and your hp increased by 30!");

                Console.WriteLine($"{name}: We’ve got what we came for. Time to face the Apex of Misfortune.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                validinput = true;
            }
            //east
            else if (command == "W" || command == "WEST")
            {
                Console.WriteLine("Nelly: Oh, no. This doesn’t feel right. No shard here, just more despair. Let’s head back before we get ambushed!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Will you go back to the dungeon?");
                    Console.WriteLine("A. Yes");
                    Console.WriteLine("B. No");
                    Console.Write("Input: ");
                    command = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (command == "A")
                    {
                        Console.WriteLine("Nelly: Alright let's go!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (command == "B")
                    {
                        Console.WriteLine("Nelly: Ah shit, here we go again.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else if (command == "N" || command == "NORTH")
            {
                Console.WriteLine("Nelly: Are you sure about this path? Something feels... off.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("AN ENEMY APPEARED");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Enemy: You think you can uncover the truth? Prove your strength!");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine("║ New quest unlocked! ║");
                Console.WriteLine("╚═════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("╔═════════════════════════════════════╗");
                Console.WriteLine("║ QUEST: Defeat the mysterious enemy! ║");
                Console.WriteLine("╚═════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                enemy = new NormalEnemy("Mysterious Enemy", 300, 45);
                battle = new Battle(player, enemy);
                battle.NormalBattle();

                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║ You obtained MP Potion! ║");
                Console.WriteLine("╚═════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                player.storingItem("MP Potion");

                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║ MP Potion has been added to your backpack! ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Now let's go back to the entrance and try the other routes to see what we can find.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            else if (command == "E" || command == "EAST")
            {
                Console.WriteLine("As you move forward, you reached a turning point in the path");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Nelly: Hold up! There’s a fork ahead—left or right. What’s the plan?");

                while (true)
                {
                    Console.WriteLine("Go Left or Right?: ");
                    Console.WriteLine("A. Left");
                    Console.WriteLine("B. Right");
                    Console.Write("\nInput: ");
                    choices = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (choices == "A")
                    {
                        Console.WriteLine("Nelly: Uh-oh, looks like we’re going left... Not the vibe I’m getting, but you lead, I follow.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Enemy: You think you’ll find fortune here? The only thing waiting for you is ruin!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════╗");
                        Console.WriteLine("║ New quest unlocked! ║");
                        Console.WriteLine("╚═════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║ QUEST: Defeat the oppossing enemy! ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        enemy = new NormalEnemy("Guard of Luck", 300, 50);
                        battle = new Battle(player, enemy);
                        battle.NormalBattle();

                        Console.WriteLine("╔════════════════════════════╗");
                        Console.WriteLine("║ The enemy dropped an item! ║");
                        Console.WriteLine("╚════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: Nice! But hey, look at this... a clue!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("‘The path to your fortune lies to the South at the fork.’");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: A clue!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: Well, looks like we were right to turn around and try again!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (choices == "B")
                    {
                        Console.WriteLine("Nelly: Hmm, no enemies this time? And look, there's an item on the floor!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════════════════════════════╗");
                        Console.WriteLine("║ You obtained a scripture containing a clue! ║");
                        Console.WriteLine("╚═════════════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("‘The path to your fortune lies to the South at the fork.’");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Nelly: That item might be a hint to the correct route! Let's go take a look again at the paths we've come across earlier.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Author: Hey! That's not even in the choices!");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.WriteLine("Author: Hey! That's not even in the choices, get more serious will ya?");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        Console.WriteLine("The Apex of Misfortune stands before you—a towering, ominous figure cloaked in shadow. Its presence distorts the very air, as if it controls the fate of all things.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: So, you found the shard. How quaint. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: It will do nothing to save you. You’ve been chasing false hopes all this time. ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: Misfortune is inevitable, and I will be your end ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: You don’t even understand. Your fate was sealed the moment you stepped into this place. ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: Even if you defeat me, it will be of no use—Misfortune will find you, always. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════╗");
        Console.WriteLine("║ MAIN QUEST UNLOCKED! ║");
        Console.WriteLine("╚══════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════╗");
        Console.WriteLine("║ QUEST: DEFEAT THE BOSS - APEX OF MISFORTUNE ║");
        Console.WriteLine("╚═════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        player.UpdateBossDmg(25);
        boss = new BossEnemy("Apex of Misfortune", 350);
        battle = new Battle(player, boss);
        battle.BossBattle();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: [Voice cracking with disbelief] No... this can't be! I... I was the end! I was the final test! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: Foolish, naive souls! You think this is over? You think you’ve won? You were destined to fall! ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Apex of Misfortune: You’ll regret this. All your victories—each shard you’ve obtained—were but illusions! ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: {name}, we’ve come this far, we’ve fought through everything—now we finish it! You’ve beaten despair, hate, unfaithfulness... and now, Misfortune.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("The dungeon shakes as the last remnants of the Apex of Misfortune's power dissipate, and the oppressive darkness begins to lift.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║ CONGRATULATIONS! YOU DEFEATED THE APEX OF MISFORTUNE ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You stand in the center of the dark dungeon, the three Shards of Hope glowing softly in your hands.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("You feel their energy, their power, but also their weight. This is the moment you’ve been waiting for.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: You’ve done it, {name}. The shards are complete. You’ve gathered the strength you need to face what’s ahead.");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: Now that we're done, what should w---");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("*THRUST*");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"Nelly: [Groans in pain] {name}, b-behind you!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Unknown: Did you really think defeating these self-proclaimed Gods will bring back your memory? You’re a fool. ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Unknown: You’ve always run from your fears. You’ve hidden behind false hope, thinking you can fix everything. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine($"{name}: W-who are you, how d you know me!");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Unknown: I am the darkness inside you, the doubt, the weakness you’ve tried to bury.. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║ Alter Ego: And I am not weak, YOU ARE. ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Alter Ego: Though you are weak, I am a generous man who helps those who are in need. ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Alter: I'm offerinng you a chance to change your destiny, face your darkness {name}, and join me. ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("What will you do?: ");
        Console.WriteLine("\n\nA. Stand firm against the enemy \nB.Join him \nC. ???");
        Console.Write("Input: ");
        command = Console.ReadLine().ToUpper();

        if (command == "A")
        {
            Console.Clear();
            Console.WriteLine($"{name}: No. I've already made up my mind, I'm going to kill you for what you've done.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║ Alter Ego: So be it. ║");
            Console.WriteLine("╚══════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            player.UpdateBossDmg(25);
            boss = new BossEnemy($"Alter Ego", 400);
            battle = new Battle(player, boss);
            battle.BossBattle();

            Console.WriteLine($"{name}: It’s over. I’ve won.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Alter: Perhaps you have... but defeating me doesn’t erase me. ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Alter: I’ll always be here, a part of you. Learn from your past, or I’ll return. ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"The battle was over, but its lessons would endure. {name} was no longer running from the darkness—they had become whole, and their journey, now truly their own, could finally begin.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("GOOD ENDING.");
            Console.ReadKey();
        }
        else if (command == "B")
        {
            Console.Clear();
            Console.WriteLine($"{name}: You’re right... I’ve been running. I’ve been hiding from the truth. If I can’t defeat you, maybe it’s because you’re what I need.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Alter: A wise choice. Together, we’ll accomplish what you could never do alone. ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"You step forward, merging with your alter, and memories flood back.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"As the two become one, a transformation occurs—{name} gains immense power but feels a lingering darkness within.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("BAD ENDING.");
            Console.ReadKey();
        }
        else if (command == "C")
        {
            Console.Clear();
            Console.WriteLine($"{name}: I feel someone is watching me, are you the one?");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║ Author: Hey, that's not even in the options! ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{name}: I'm done playing this stupid turn based type of game you created, let's finish this!");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Author: This dude is breaking the 4th wall, I cannot believe it! ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Author: I increased your power so that you can atleast keep up with me, good luck! ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            player.UpdateBossDmg(40);
            boss = new BossEnemy($"Author", 5000);
            battle = new Battle(player, boss);
            battle.IllegalBattle();

            Console.WriteLine("SECRET ENDING.");
            Console.ReadKey();
        }
    }
}


