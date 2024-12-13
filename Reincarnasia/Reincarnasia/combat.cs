using System;
using System.Linq;

class Player
{
    public int hp;
    public int attackboost = 0;
    public bool postmortem = false;
    public int mp;
    public int swordxp;
    public int level;
    public int characterXp;
    public int swordIndex;
    public string sword;
    public int xpRequired;
    public int mpPotion = 30;
    public int hpPotion = 100;
    public int initialdmg;
    public int initialhp;
    public int bossDmg;

    public string[] inventory = new string[5];
    private string[] swordEvo = { "Katana", "Meito", "Sandai Kitetsu", "Enma", "Ame no Habakiri" };

    public Player()
    {
        hp = 100 + initialhp;
        mp = 200;
        swordxp = 0;
        level = 1;
        characterXp = 0;
        swordIndex = 0;
        sword = swordEvo[swordIndex];
        xpRequired = 50;
    }

    public void UpdateDmgnHp(int dmgInc, int hpInc)
    {
        initialdmg += dmgInc;
        hp += hpInc;
    }

    public void UpdateBossDmg(int bossdmgInc)
    {
        bossDmg += bossdmgInc;
    }

    public void storingItem(string item)
    {
        bool stored = false;

        for (int x = 0; x < inventory.Length; x++)
        {
            if (string.IsNullOrEmpty(inventory[x]))
            {
                inventory[x] = item;
                stored = true;
                break;
            }
        }

        if (!stored)
        {
            Console.WriteLine("Author: Hey! Your inventory is already full!");
        }
    }

    public void ShiftItemsLeft(int index)
    {
        if (index < 0 || index >= inventory.Length)
        {
            Console.WriteLine("Author: Hey! your number is out of bounds!");
            return;
        }
        for (int i = index; i < inventory.Length - 1; i++)
        {
            inventory[i] = inventory[i + 1];
        }
        inventory[inventory.Length - 1] = null;
    }

    public void showItem()
    {
        bool hasItems = false;
        for (int x = 0; x < inventory.Length; x++)
        {
            if (!string.IsNullOrEmpty(inventory[x]))
            {
                Console.WriteLine($"{x + 1}. {inventory[x]}");
                hasItems = true;
            }
        }

        if (!hasItems)
        {
            Console.WriteLine("Author: Your inventory is empty!");
        }
    }

    public void LevelUp()
    {
        if (characterXp >= xpRequired)
        {
            level++;
            Console.WriteLine($"Congratulations, you are now level {level}!");
            xpRequired += 10;
            characterXp = 0;
            initialdmg += 5;
            initialhp += 10;
        }
    }

    public void SwordLevelUp()
    {
        if (level >= 2 && swordxp >= 50 && swordIndex == 0)
        {
            swordIndex = 1;
            sword = swordEvo[swordIndex];
            Console.WriteLine("Your weapon evolved to Meito!");
            initialdmg += 5;

        }
        else if (level >= 4 && swordxp >= 50 && swordIndex == 1)
        {
            swordIndex = 2;
            sword = swordEvo[swordIndex];
            Console.WriteLine("Your weapon evolved to Sandai Kitetsu!");
            initialdmg += 15;
        }
        else if (level >= 6 && swordxp >= 50 && swordIndex == 2)
        {
            swordIndex = 3;
            sword = swordEvo[swordIndex];
            Console.WriteLine("Your weapon evolved to Enma!");
            initialdmg += 20;
        }
        else if (level >= 8 && swordxp >= 50 && swordIndex == 3)
        {
            swordIndex = 4;
            sword = swordEvo[swordIndex];
            Console.WriteLine("Your weapon has evolved to Ame no Habakiri!");
            initialdmg += 30;
        }
    }
}

class NormalEnemy
{
    public string Name;
    public int Hp;
    public int Damage;

    public NormalEnemy(string name, int hp, int damage)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
    }
}

class BossEnemy
{
    public string Name;
    public int BossHp;

    public BossEnemy(string name, int hp)
    {
        Name = name;
        BossHp = hp;
    }
}

class Battle
{
    private Player playerside;
    private NormalEnemy enemyside;
    private BossEnemy bossSide;

    public Battle(Player player, NormalEnemy enemy)
    {
        playerside = player;
        enemyside = enemy;
        bossSide = null;
    }
    public Battle(Player player, BossEnemy boss)
    {
        playerside = player;
        bossSide = boss;
        enemyside = null;
    }

    public void NormalBattle()
    {
        string moveInput, skillInput;
        int basehp = playerside.hp;
        int basemp = playerside.mp;
        int enemybasehp = enemyside.Hp;
        bool continuebattle = true;

        Console.WriteLine($"A enemy named {enemyside.Name} appeared!");
        Console.ReadKey();
        do
        {
            enemyside.Hp = enemybasehp;

            while (playerside.hp + playerside.initialhp > 0 && enemyside.Hp > 0)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════╦════════════════════════════════════════╗");
                Console.WriteLine($"║ Your HP: {playerside.hp}    Enemy: {enemyside.Name} HP: {enemyside.Hp}");
                Console.WriteLine("╠═════════╦════╩═══════╦════════════════════════════════╣");
                Console.WriteLine($"║ MP: {playerside.mp}     XP: {playerside.characterXp}/{playerside.xpRequired}     Level: {playerside.level}");
                Console.WriteLine("╚═════════╩════════════╩════════════════════════════════╝");
                Console.WriteLine("Choose an action!\nA. Attack\tB. Skills\nC. Items\tD. Run");

                moveInput = Console.ReadLine().ToUpper();
                Console.Clear();

                if (moveInput == "A")
                {
                    playerside.hp -= enemyside.Damage;
                    enemyside.Hp -= 10 + playerside.initialdmg;
                    Console.WriteLine($"You dealt {10 + playerside.initialdmg} DMG, but took {enemyside.Damage} damage in retaliation.");
                    Console.ReadKey();
                }
                else if (moveInput == "B")
                {
                    Console.WriteLine($"Skills: \nA. Dimensional Slash (Deals {30 + playerside.initialdmg} DMG)\nB. Sword Overdrive (Deals {60 + playerside.initialdmg} DMG but damages yourself for 40 DMG)\nC. Normal Slashes (Deals {25 + playerside.initialdmg} DMG\nD. Heal (Heals 40 HP)");

                    skillInput = Console.ReadLine().ToUpper();
                    Console.Clear();

                    // skills input
                    if (skillInput == "A" && playerside.mp >= 20)
                    {
                        playerside.mp -= 20;
                        enemyside.Hp -= 30 + playerside.initialdmg;
                        playerside.hp -= enemyside.Damage;
                        Console.WriteLine($"You used Dimensional Slash! You dealt {30 + playerside.initialdmg} DMG, but took {enemyside.Damage} damage in return.");
                    }
                    else if (skillInput == "B" && playerside.mp >= 25)
                    {
                        playerside.mp -= 25;
                        enemyside.Hp -= 60 + playerside.initialdmg;
                        playerside.hp -= enemyside.Damage;
                        Console.WriteLine($"You used Sword Overdrive! You dealt {60 + playerside.initialdmg} DMG, but took {enemyside.Damage} damage in return.");
                    }
                    else if (skillInput == "C" && playerside.mp >= 20)
                    {
                        playerside.mp -= 20;
                        enemyside.Hp -= 25 + playerside.initialdmg;
                        Console.WriteLine($"You used Normal Slashes! You dealt {25 + playerside.initialdmg} DMG, but took {enemyside.Damage} damage in return.");
                    }
                    else if (skillInput == "D" && playerside.mp >= 30)
                    {
                        playerside.mp -= 30;
                        playerside.hp = Math.Min(playerside.hp + 30, 100);
                        Console.WriteLine($"You used Heal! Your HP is now {playerside.hp}!");
                    }
                    else
                    {
                        Console.WriteLine("Not enough MP or invalid skill choice.");
                    }
                    Console.ReadKey();
                }
                else if (moveInput == "C")
                {
                    if (playerside.inventory.Length == 0)
                    {
                        Console.WriteLine("No items available yet.");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Select an item to use:");

                        var uniqueItems = playerside.inventory.Distinct().ToArray();
                        for (int i = 0; i < uniqueItems.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {uniqueItems[i]}");
                        }

                        string itemChoice = Console.ReadLine();
                        if (playerside.mp < basemp || playerside.hp < basehp)
                        {
                            try
                            {
                                int selectedIndex = int.Parse(itemChoice) - 1;

                                if (selectedIndex >= 0 && selectedIndex < uniqueItems.Length)
                                {
                                    string selectedItem = uniqueItems[selectedIndex];

                                    if (selectedItem == "MP Potion")
                                    {
                                        playerside.mp = Math.Min(playerside.mp + playerside.mpPotion, basemp);
                                        Console.WriteLine("You recovered 30 MP!");
                                    }
                                    else if (selectedItem == "HP Potion")
                                    {
                                        playerside.mp = Math.Min(playerside.hp + playerside.hpPotion, basehp);
                                        Console.WriteLine("You recovered 30 MP!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid or unsupported item.");
                                    }


                                    playerside.ShiftItemsLeft(selectedIndex);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid item choice.");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Invalid item choice. Index out of range.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have sufficient MP!");
                        }
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                else if (moveInput == "D")
                {
                    Console.WriteLine("You can't run away from battle!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid action. Please choose again.");
                }

                //if u won
                if (enemyside.Hp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"You won! You gained 50 XP!");
                    playerside.characterXp += 50;
                    playerside.swordxp += 50;
                    playerside.LevelUp();
                    playerside.SwordLevelUp();
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continuebattle = false;
                    break;
                }

                //if u lose
                else if (playerside.hp <= 0)
                {
                    Console.WriteLine("You have died in battle...");
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
            playerside.hp = basehp;
            playerside.mp = basemp;
        } while (continuebattle);
    }

    public void BossBattle()
    {
        int damage = 0;
        string moveInput, skillInput;
        int basehp = playerside.hp;
        int basemp = playerside.mp;
        int bossbasehp = bossSide.BossHp;
        bool continuebattle = true;
        bool playerturn = true;

        Console.WriteLine($"A enemy named {bossSide.Name} appeared!");
        Console.ReadKey();
        Random random = new Random();
        do
        {
            bossSide.BossHp = bossbasehp;


            while (playerside.hp > 0 && bossSide.BossHp > 0)
            {

                if (playerturn)
                {
                    Console.Clear();
                    Console.WriteLine("╔══════════════╦════════════════════════════════════════╗");
                    Console.WriteLine($"║ Your HP: {playerside.hp}    {bossSide.Name} HP: {bossSide.BossHp}");
                    Console.WriteLine("╠═════════╦════╩═══════╦════════════════════════════════╣");
                    Console.WriteLine($"║ MP: {playerside.mp}     XP: {playerside.characterXp}/{playerside.xpRequired}     Level: {playerside.level}");
                    Console.WriteLine("╚═════════╩════════════╩════════════════════════════════╝");
                    Console.WriteLine("\nChoose an action!\nA. Attack\tB. Skills\nC. Items\tD. Run");
                    Console.Write("Input: ");
                    moveInput = Console.ReadLine().ToUpper();
                    Console.Clear();

                    bool validmove = false;
                    if (moveInput == "A")
                    {
                        damage = 10 + playerside.initialdmg;
                        if (playerside.postmortem)
                        {
                            damage += playerside.attackboost;
                            Console.WriteLine($"You dealt {damage} DMG with the post mortem buff!");
                        }
                        else
                        {
                            Console.WriteLine($"You dealt {damage} DMG!");
                        }
                        bossSide.BossHp -= damage;
                        Console.ReadKey();
                        Console.Clear();
                        damage = 0;
                        validmove = true;
                    }
                    else if (moveInput == "B")
                    {
                        Console.WriteLine($"Skills: \nA. Dimensional Slash (Deals {damage} DMG)\nB. Sword Overdrive (Deals {damage} DMG but damages yourself for 20 DMG)\nC. Normal Slashes (Deals {damage} DMG\nD. Heal (Heals 50 HP)");
                        skillInput = Console.ReadLine().ToUpper();
                        Console.Clear();

                        // skills input
                        if (skillInput == "A" && playerside.mp >= 20)
                        {
                            playerside.mp -= 20;
                            damage = 30 + playerside.initialdmg;
                            if (playerside.postmortem)
                            {
                                damage += playerside.attackboost;
                                Console.WriteLine($"You used Dimensional Slash! You dealt {damage} DMG with post mortem buff!");
                            }
                            else
                            {
                                Console.WriteLine($"You used Dimensional Slash! You dealt {damage} DMG!");
                            }
                            bossSide.BossHp -= damage;
                            Console.ReadLine();
                            Console.Clear();
                            damage = 0;
                            validmove = true;
                        }
                        else if (skillInput == "B" && playerside.mp >= 25)
                        {

                            playerside.mp -= 25;
                            playerside.hp -= 20;
                            damage = 60 + playerside.initialdmg;
                            if (playerside.postmortem)
                            {
                                damage += playerside.attackboost;
                                Console.WriteLine($"You used Sword Overdrive! You dealt {damage} DMG with post mortem buff, but received 20 DMG as drawback!");
                            }
                            else
                            {
                                Console.WriteLine($"You used Sword Overdrive! You dealt {damage} DMG, but received 20 DMG as drawback!");
                            }
                            bossSide.BossHp -= damage;
                            Console.ReadLine();
                            Console.Clear();
                            damage = 0;
                            validmove = true;
                        }
                        else if (skillInput == "C" && playerside.mp >= 20)
                        {
                            playerside.mp -= 20;
                            damage = 20 + playerside.initialdmg;
                            if (playerside.postmortem)
                            {
                                damage += playerside.attackboost;
                                Console.WriteLine($"You used Normal Slashes! You dealt {damage} DMG with post mortem buff!");
                            }
                            else
                            {
                                Console.WriteLine($"You used Normal Slashes! You dealt {damage} DMG!");
                            }
                            bossSide.BossHp -= damage;
                            Console.ReadLine();
                            Console.Clear();
                            damage = 0;
                            validmove = true;
                        }
                        else if (skillInput == "D" && playerside.mp >= 30)
                        {
                            playerside.mp -= 30;
                            playerside.hp = Math.Min(playerside.hp + 50, 200);
                            Console.WriteLine($"You used Heal! Your HP is now {playerside.hp}!");
                            Console.ReadLine();
                            Console.Clear();
                            validmove = true;
                        }
                        else
                        {
                            Console.WriteLine("Not enough MP or invalid skill choice.");
                            Console.ReadKey();
                        }
                    }
                    else if (moveInput == "C")
                    {
                        if (playerside.inventory.Length == 0)
                        {
                            Console.WriteLine("No items available yet.");
                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Select an item to use:");

                            var uniqueItems = playerside.inventory.Distinct().ToArray();
                            for (int i = 0; i < uniqueItems.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {uniqueItems[i]}");
                            }

                            string itemChoice = Console.ReadLine();
                            if (playerside.mp < basemp || playerside.hp < basehp)
                            {
                                try
                                {
                                    int selectedIndex = int.Parse(itemChoice) - 1;

                                    if (selectedIndex >= 0 && selectedIndex < uniqueItems.Length)
                                    {
                                        string selectedItem = uniqueItems[selectedIndex];

                                        if (selectedItem == "MP Potion")
                                        {
                                            playerside.mp = Math.Min(playerside.mp + playerside.mpPotion, basemp);
                                            Console.WriteLine("You recovered 30 MP!");
                                        }
                                        else if (selectedItem == "HP Potion")
                                        {
                                            playerside.mp = Math.Min(playerside.hp + playerside.hpPotion, basehp);
                                            Console.WriteLine("You recovered 30 MP!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Author: There's no such item in your inventory!");
                                        }


                                        playerside.ShiftItemsLeft(selectedIndex);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid item choice.");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a number.");
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    Console.WriteLine("Invalid item choice. Index out of range.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You have sufficient MP!");
                            }
                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (moveInput == "D")
                    {
                        Console.WriteLine($"{bossSide.Name}: You can't run away from battle you coward!");
                        Console.ReadKey();
                        validmove = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid action. Please choose again.");
                        validmove = false;
                        Console.Clear();
                    }
                    if (validmove)
                    {
                        playerturn = false;
                    }
                }
                else
                {
                    int bossAttack = random.Next(1, 5);
                    switch (bossAttack)
                    {
                        case 1:
                            playerside.hp -= 30 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Giga Pounce!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {30 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            playerside.hp -= 30 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Fireball!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {30 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            playerside.hp -= 45 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Earthquake!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {45 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            bossSide.BossHp = Math.Min(bossSide.BossHp + 70, bossSide.BossHp);
                            Console.WriteLine($"{bossSide.Name} used Giga Heal!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("It restored 70 HP!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    Console.Clear();
                    playerturn = true;
                }

                //if u won
                if (bossSide.BossHp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"You won! You gained 100 XP!");
                    playerside.characterXp += 100;
                    playerside.swordxp += 100;
                    playerside.LevelUp();
                    playerside.SwordLevelUp();
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    playerside.postmortem = false;
                    continuebattle = false;
                }

                //if u lose
                else if (playerside.hp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have died in battle...");
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    if (!playerside.postmortem)
                    {
                        Console.WriteLine("╔════════════════════════════╗");
                        Console.WriteLine("║ POST MORTEM BUFF ACTIVATED ║");
                        Console.WriteLine("╚════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ Your damage has increased by 20 temporarily to make the boss easier! ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("╔════════════════════════════════════════╗");
                        Console.WriteLine("║ POST MORTEM BUFF IS ALREADY IN EFFECT! ║");
                        Console.WriteLine("╚════════════════════════════════════════╝");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    playerside.attackboost = 10;
                    playerside.postmortem = true;
                    break;
                }
            }
            playerside.hp = basehp;
            playerside.mp = basemp;
        } while (continuebattle);
    }

    public void IllegalBattle()
    {
        int damage = 0;
        string moveInput, skillInput;
        int basehp = playerside.hp;
        int basemp = playerside.mp;
        int bossbasehp = bossSide.BossHp;
        bool continuebattle = true;
        bool playerturn = true;

        Console.WriteLine($"A enemy named {bossSide.Name} appeared!");
        Console.ReadKey();
        Random random = new Random();
        do
        {
            bossSide.BossHp = bossbasehp;

            playerside.hp += 1000;
            while (playerside.hp > 0 && bossSide.BossHp > 0)
            {

                if (playerturn)
                {
                    Console.Clear();
                    Console.WriteLine("╔══════════════╦════════════════════════════════════════╗");
                    Console.WriteLine($"║ Your HP: {playerside.hp}    {bossSide.Name} HP: {bossSide.BossHp}");
                    Console.WriteLine("╠═════════╦════╩═══════╦════════════════════════════════╣");
                    Console.WriteLine($"║ MP: INFINITE     XP: {playerside.characterXp}/{playerside.xpRequired}     Level: {playerside.level}");
                    Console.WriteLine("╚═════════╩════════════╩════════════════════════════════╝");
                    Console.WriteLine("\nChoose an action!\nA. Attack\tB. Skills\nC. Items\tD. Run");
                    Console.Write("Input: ");
                    moveInput = Console.ReadLine().ToUpper();
                    Console.Clear();

                    bool validmove = false;
                    if (moveInput == "A")
                    {
                        damage = 10 + playerside.initialdmg;
                        if (playerside.postmortem)
                        {
                            damage += playerside.attackboost;
                            Console.WriteLine($"You dealt {damage} DMG with the post mortem buff!");
                        }
                        else
                        {
                            Console.WriteLine($"You dealt {damage} DMG!");
                        }
                        bossSide.BossHp -= damage;
                        Console.ReadKey();
                        Console.Clear();
                        damage = 0;
                        validmove = true;
                    }
                    else if (moveInput == "B")
                    {
                        Console.WriteLine($"Skills: \nA. Dimensional Slash (Deals {damage} DMG)\nB. Sword Overdrive (Deals {60 + playerside.initialdmg} DMG but damages yourself for 40 DMG)\nC. Normal Slashes (Deals {25 + playerside.initialdmg} DMG\nD. Heal (Heals 40 HP)");
                        skillInput = Console.ReadLine().ToUpper();
                        Console.Clear();

                        // skills input
                        if (skillInput == "A" && playerside.mp >= 20)
                        {
                            damage = 30 + playerside.initialdmg;
                            if (playerside.postmortem)
                            {
                                damage += playerside.attackboost;
                                Console.WriteLine($"You used Dimensional Slash! You dealt {damage} DMG with post mortem buff!");
                            }
                            else
                            {
                                Console.WriteLine($"You used Dimensional Slash! You dealt {damage} DMG!");
                            }
                            bossSide.BossHp -= damage;
                            Console.ReadLine();
                            Console.Clear();
                            damage = 0;
                            validmove = true;
                        }
                        else if (skillInput == "B" && playerside.mp >= 25)
                        {
                            playerside.hp -= 20;
                            damage = 60 + playerside.initialdmg;
                            if (playerside.postmortem)
                            {
                                damage += playerside.attackboost;
                                Console.WriteLine($"You used Sword Overdrive! You dealt {damage} DMG with post mortem buff, but received 20 DMG as drawback!");
                            }
                            else
                            {
                                Console.WriteLine($"You used Sword Overdrive! You dealt {damage} DMG, but received 20 DMG as drawback!");
                            }
                            bossSide.BossHp -= damage;
                            Console.ReadLine();
                            Console.Clear();
                            damage = 0;
                            validmove = true;
                        }
                        else if (skillInput == "C" && playerside.mp >= 20)
                        {
                            damage = 20 + playerside.initialdmg;
                            if (playerside.postmortem)
                            {
                                damage += playerside.attackboost;
                                Console.WriteLine($"You used Normal Slashes! You dealt {damage} DMG with post mortem buff!");
                            }
                            else
                            {
                                Console.WriteLine($"You used Normal Slashes! You dealt {damage} DMG!");
                            }
                            bossSide.BossHp -= damage;
                            Console.ReadLine();
                            Console.Clear();
                            damage = 0;
                            validmove = true;
                        }
                        else if (skillInput == "D" && playerside.mp >= 30)
                        {
                            playerside.hp = Math.Min(playerside.hp + 200, 1000);
                            Console.WriteLine($"You used Heal! Your HP is now {playerside.hp}!");
                            Console.ReadLine();
                            Console.Clear();
                            validmove = true;
                        }
                        else
                        {
                            Console.WriteLine("Author: Invalid skill choice!");
                            Console.ReadKey();
                        }
                    }
                    else if (moveInput == "C")
                    {
                        if (playerside.inventory.Length == 0)
                        {
                            Console.WriteLine("No items available yet.");
                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Select an item to use:");

                            var uniqueItems = playerside.inventory.Distinct().ToArray();
                            for (int i = 0; i < uniqueItems.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {uniqueItems[i]}");
                            }

                            string itemChoice = Console.ReadLine();
                            if (playerside.mp < basemp || playerside.hp < basehp)
                            {
                                try
                                {
                                    int selectedIndex = int.Parse(itemChoice) - 1;

                                    if (selectedIndex >= 0 && selectedIndex < uniqueItems.Length)
                                    {
                                        string selectedItem = uniqueItems[selectedIndex];

                                        if (selectedItem == "MP Potion")
                                        {
                                            playerside.mp = Math.Min(playerside.mp + playerside.mpPotion, basemp);
                                            Console.WriteLine("You recovered 30 MP!");
                                        }
                                        else if (selectedItem == "HP Potion")
                                        {
                                            playerside.mp = Math.Min(playerside.hp + playerside.hpPotion, basehp);
                                            Console.WriteLine("You recovered 30 MP!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid or unsupported item.");
                                        }


                                        playerside.ShiftItemsLeft(selectedIndex);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid item choice.");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a number.");
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    Console.WriteLine("Invalid item choice. Index out of range.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Author: You already have infinite MP or full HP!");
                            }
                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (moveInput == "D")
                    {
                        Console.WriteLine($"Author: You can't run away from battle you mortal!");
                        Console.ReadKey();
                        validmove = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Author: Invalid action. Please choose again.");
                        validmove = false;
                        Console.Clear();
                    }
                    if (validmove)
                    {
                        playerturn = false;
                    }
                }
                else
                {
                    int bossAttack = random.Next(1, 7);
                    switch (bossAttack)
                    {
                        case 1:
                            playerside.hp -= 30 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Justin Trinibonk!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {30 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            playerside.hp -= 35 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Rome Macatackle!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {35 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            playerside.hp -= 45 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Sevillena's Radiant Waltz!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {45 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            playerside.hp -= 45 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Sorry Raph!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {45 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                            playerside.hp -= 60 + playerside.bossDmg;
                            Console.WriteLine($"{bossSide.Name} used Joaquin Minoration Deliberation!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"It dealt {60 + playerside.bossDmg} Damage!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 6:
                            bossSide.BossHp = Math.Min(bossSide.BossHp + 100, 5000);
                            Console.WriteLine($"{bossSide.Name} used Giga Ryan!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("It restored 100 HP!");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                    }
                    Console.Clear();
                    playerturn = true;
                }

                //if u won
                if (bossSide.BossHp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"You won! Wait you really won?");
                    playerside.characterXp += 1000000;
                    playerside.swordxp += 1000000;
                    playerside.LevelUp();
                    playerside.SwordLevelUp();
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔════════════════════════════════════════════════╗");
                    Console.WriteLine("║ Author: HAHAHAHA, WOW YOU ARE INDEED POWERFUL! ║");
                    Console.WriteLine("╚════════════════════════════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║ Author: For such a feat like yours, you deserve the spot of the Author, or me basically. ║");
                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔═══════════════════════════════════════════════╗");
                    Console.WriteLine("║ YOU HAVE BEEN GRANTED ACCESS TO AUTHOR'S MENU ║");
                    Console.WriteLine("╚═══════════════════════════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║ Author: Now that you're the author of this game, idk of anything else to say well goodbye! ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    continuebattle = false;
                }

                //if u lose
                else if (playerside.hp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have died in battle...");
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine($"║ Author: HAHAHAHA, YOU REALLY THINK YOU CAN BEAT THE AUTHOR OF THIS GAME? ║");
                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine($"║ Author: AND FOR THAT, I SHALL DELETE YOU IN THIS GAME, BEGONE! ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("╔════════════════════════╗");
                    Console.WriteLine("║ YOU HAVE BEEN DELETED! ║");
                    Console.WriteLine("╚════════════════════════╝");
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    continuebattle = false;
                }
            }
            playerside.hp = basehp;
            playerside.mp = basemp;
        } while (continuebattle);
    }
}


