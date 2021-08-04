using System;
using System.Collections.Generic;
Main();

void Main()
{
    // Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    // Console.WriteLine("--------------------------------------------");
    // Console.WriteLine();

    // CanadaQuestion();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();
    // MagicMoose();
    RockPaperScissors();
}
void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real");
    if (isTrue)
    {
        MooseSays("Hmmm... Seems unlikely");
    }
    else
    {
        MooseSays("I knew IT!!!!");
    }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.WriteLine($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.WriteLine("Please answer with Y or N only.");
        Console.WriteLine($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MagicMoose()
{
    Console.WriteLine("Ask the magic-moose a question... : ");
    string question = Console.ReadLine();
    List<string> responses = new List<string>()
    {
        "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.",
    "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.",
"Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it."
    };

    bool playing = !(String.IsNullOrWhiteSpace(question));
    while (playing)
    {
        Random randomInt = new Random();
        int responsePosition = randomInt.Next(0, (responses.Count - 1));
        Console.WriteLine($" Magic moose says: {responses[responsePosition]}");
        Console.WriteLine("Ask the magic-moose another question... : ");
        question = Console.ReadLine();
        playing = !(String.IsNullOrWhiteSpace(question));
    }
}

void RockPaperScissors()
{
    string rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
    ";

    string paper = @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
    ";

    string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
    ";

    int playerScore = 0;
    int computerScore = 0;
    string playerChoice = "1";
    void scoreAndOptions()
    {

        Console.WriteLine("---------------------------");
        Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
        Console.WriteLine("---------------------------");
        Console.WriteLine("What would you like to throw");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");
        playerChoice = Console.ReadLine();
    }
    scoreAndOptions();

    while (playerScore < 3 && computerScore < 3)
    {
        while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
        {
            Console.WriteLine("Please choose a valid choice");
            playerChoice = Console.ReadLine();
        }
        Random randomInt = new Random();
        int responsePosition = randomInt.Next(1, (3));

        scoreAndOptions();
    }

}