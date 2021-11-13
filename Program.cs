using System;
using System.Collections.Generic;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            void MainTaco()
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

            void MooseQuestionFunc(string question, string correct, string incorrect)
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

            void RunMooseQuestion()
            {
                Dictionary<string, string> CanadaQuest = new Dictionary<string, string>()
{
    { "q", "Is Canada real?" },
    { "c", "Really? It seems very unlikely." },
    { "i", "I  K N E W  I T !!!" }
};

                Dictionary<string, string> EnthusQuest = new Dictionary<string, string>()
{
    { "q", "Are you enthusiastic?" },
    { "c", "Yay!" },
    { "i", "You should try it!" }
};

                Dictionary<string, string> LoveQuest = new Dictionary<string, string>()
{
    { "q", "Do you love C# yet?" },
    { "c", "Good job sucking up to your instructor!" },
    { "i", "You will...oh, yes, you will..." }
};

                Dictionary<string, string> SecretQuest = new Dictionary<string, string>()
{
    { "q", "Do you want to know a secret?" },
    { "c", "ME TOO!!!! I love secrets...tell me one!" },
    { "i", "Oh, no...secrets are the best, I love to share them!" }
};



                List<Dictionary<string, string>> questions = new List<Dictionary<string, string>>()
{
    CanadaQuest, EnthusQuest, LoveQuest, SecretQuest
};

                foreach (Dictionary<string, string> taco in questions)
                {
                    MooseQuestionFunc(taco["q"], taco["c"], taco["i"]);
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

            MainTaco();

            RunMooseQuestion();
        }
    }
}


