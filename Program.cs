using System;
using System.Collections.Generic;

void Main()
{

    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");

}

bool MooseAsks(string question)
{
    Console.Write($"{question} Y/N: ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.WriteLine("Please input Y or N.");
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

void questionFunc(string question, string correct, string incorrect)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(correct);
    }
    else
    {
        MooseSays(incorrect);
    }
}

void runQuestion()
{
    List<string> questions = new List<string>()
{
    "Is Canada real?", "Are you enthusiastic?", "Do you love C# yet?", "Do you want to know a secret?"
};

    List<string> correct = new List<string>()
{
    "Really? It seems very unlikely.", "Yay!", "Good job sucking up to your instructor!", "ME TOO!!!! I love secrets...tell me one!"
};

    List<string> incorrect = new List<string>()
{
    "I  K N E W  I T !!!", "You should try it!", "You will...oh, yes, you will...", "Oh, no...secrets are the best, I love to share them!"
};

    for (int i = 0; i < questions.Count; i++)
    {
        questionFunc(questions[i], correct[i], incorrect[i]);
    }
};

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

Main();

runQuestion();


