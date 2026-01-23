using System.Drawing;
using System.Threading.Channels;

namespace Poject_1_WhoWants20K_Console
{
    internal class Program
    {
        static List<Question> questions = new List<Question>()
        {

            new Question("What is the capital of France?", new List<(string, bool)>
            {
                ("Berlin", false),
                ("Madrid", false),
                ("Paris", true),
                ("Rome", false)
            }),
            new Question("Which planet is known as the Red Planet?", new List<(string, bool)>
            {
                ("Earth", false),
                ("Mars", true),
                ("Jupiter", false),
                ("Venus", false)
            }),
            new Question("What is the largest ocean on Earth?", new List<(string, bool)>
            {
                ("Atlantic Ocean", false),
                ("Indian Ocean", false),
                ("Arctic Ocean", false),
                ("Pacific Ocean", true)
            }),
            new Question("Who wrote 'Romeo and Juliet'?", new List<(string, bool)>
            {
                ("Charles Dickens", false),
                ("William Shakespeare", true),
                ("Mark Twain", false),
                ("Jane Austen", false)
            }),
            new Question("What is the chemical symbol for gold?", new List<(string, bool)>
            {
                ("Ag", false),
                ("Au", true),
                ("Gd", false),
                ("Pb", false)
            }),
            new Question("Which country hosted the 2016 Summer Olympics?", new List<(string, bool)>
            {
                ("China", false),
                ("Brazil", true),
                ("United Kingdom", false),
                ("Russia", false)
            }),
            new Question("What is the smallest prime number?", new List<(string, bool)>
            {
                ("0", false),
                ("1", false),
                ("2", true),
                ("3", false)
            }),
            new Question("Who painted the Mona Lisa?", new List<(string, bool)>
            {
                ("Vincent van Gogh", false),
                ("Pablo Picasso", false),
                ("Leonardo da Vinci", true),
                ("Claude Monet", false)
            }),
            new Question("What is the hardest natural substance on Earth?", new List<(string, bool)>
            {
                ("Gold", false),
                ("Iron", false),
                ("Diamond", true),
                ("Silver", false)
            }),
            new Question("Which gas do plants absorb from the atmosphere?", new List<(string, bool)>
            {
                ("Oxygen", false),
                ("Nitrogen", false),
                ("Carbon Dioxide", true),
                ("Hydrogen", false)
            }),
            new Question("What is the capital of Japan?", new List<(string, bool)>
            {
                ("Seoul", false),
                ("Tokyo", true),
                ("Beijing", false),
                ("Bangkok", false)
            }),
            new Question("Who is known as the 'Father of Computers'?", new List<(string, bool)>
            {
                ("Alan Turing", false),
                ("Charles Babbage", true),
                ("John von Neumann", false),
                ("Steve Jobs", false)
            }),
            new Question("What is the largest mammal in the world?", new List<(string, bool)>
            {
                ("Elephant", false),
                ("Blue Whale", true),
                ("Giraffe", false),
                ("Hippopotamus", false)
            }),
            new Question("What is the currency of the United Kingdom?", new List<(string, bool)>
            {
                ("Euro", false),
                ("Dollar", false),
                ("Pound Sterling", true),
                ("Yen", false)
            }),
            new Question("Which element has the atomic number 1?", new List<(string, bool)>
            {
                ("Oxygen", false),
                ("Hydrogen", true),
                ("Helium", false),
                ("Carbon", false)
            }),
            new Question("What is the tallest mountain in the world?", new List<(string, bool)>
            {
                ("K2", false),
                ("Mount Everest", true),
                ("Kangchenjunga", false),
                ("Lhotse", false)
            }),
            new Question("What is the largest desert in the world?", new List<(string, bool)>
            {
                ("Sahara Desert", false),
                ("Gobi Desert", false),
                ("Antarctic Desert", true),
                ("Kalahari Desert", false)
            }),

            new Question("Which country won the FIFA World Cup in 2018?", new List<(string, bool)>
            {
                ("Brazil", false),
                ("Germany", false),
                ("France", true),
                ("Argentina", false)
            }),
            new Question("Who is the all-time leading goal scorer in world?", new List<(string, bool)>
            {
                 ("Pele", false),
                ("Cristiano Ronaldo", true),
                ("Lionel Messi", false),
                ("Diego Maradona", false)
            }),
            new Question("What is the maximum number of players allowed on the field for one team during a standard football match?", new List<(string, bool)>
            {
                ("9", false),
                ("10", false),
                ("11", true),
                ("12", false)
            }),
            new Question("Which football club has won the most UEFA Champions League titles?", new List<(string, bool)>
            {
                ("AC Milan", false),
                ("Liverpool", false),
                ("Real Madrid", true),
                ("Bayern Munich", false)
            }),
            new Question("In which year did World War II end?", new List<(string, bool)>
            {
                ("1944", false),
                ("1945", true),
                ("1946", false),
                ("1947", false)
            }),
            new Question("Who was the Prime Minister of the United Kingdom during most of World War II?", new List<(string, bool)>
            {
                ("Winston Churchill", true),
                ("Neville Chamberlain", false),
                ("Clement Attlee", false),
                ("Stanley Baldwin", false)
            }),
            new Question("Which country was NOT part of the Axis Powers during World War II?", new List<(string, bool)>
            {
                ("Germany", false),
                ("Italy", false),
                ("Japan", false),
                ("Soviet Union", true)
            }),
            new Question("In which year did Napoleon Bonaparte crown himself Emperor of the French?", new List<(string, bool)>
            {
                ("1802", false),
                ("1804", true),
                ("1806", false),
                ("1808", false)
            }),
            new Question("Which battle is considered Napoleon's final defeat?", new List<(string, bool)>
            {
                ("Battle of Austerlitz", false),
                ("Battle of Leipzig", false),
                ("Battle of Waterloo", true),
                ("Battle of Borodino", false)
            }),
            new Question("Which island was Napoleon exiled to after his defeat at the Battle of Waterloo?", new List<(string, bool)>
            {
                ("Elba", false),
                ("Corsica", false),
                ("Saint Helena", true),
                ("Sardinia", false)
            }),

        };

        static Random random = new Random();
        static string[] rewards =
        {
            "50 lari",
            "100 lari",
            "250 lari",
            "500 lari",
            "1,000 lari",
            "2,500 lari",
            "5,000 lari",
            "10,000 lari",
            "15,000 lari",
            "20,000 lari"
        };
        static void printintroForQuestion(int index)
        {
            string[] introForQuestion = {
                $"Now its time for question #{index + 1}",
                $"Let’s move on to question #{index + 1}",
                $"Up next is question #{index + 1}",
                $"Here comes question #{index + 1}",
                $"Get ready for question #{index + 1}",
                $"Question #{index + 1}, here we go!",
                $"You’re now on question #{index + 1}",
                $"Next up—question #{index + 1}"
            };
            Console.WriteLine(introForQuestion[random.Next(introForQuestion.Count())]);
        }

        static string[] greetings = {
                "Great job!",
                "Well done!",
                "You're doing fantastic!",
                "Keep it up!",
                "Excellent work!",
                "You're on fire!",
                "Brilliant answer!",
                "You're acing this!"
            };
        static string[] wrongAnswers = {
                "Oops, that's not correct.",
                "Sorry, that's the wrong answer.",
                "Unfortunately, that's incorrect.",
                "That's not the right choice.",
                "Wrong answer, better luck next time.",
                "That's not it, try again next time.",
                "Incorrect, but don't give up!",
                "That's not correct, keep trying!"
            };




        static void Main(string[] args)
        {
            int answeredQuestions = 0;
            string userAnswer;
            int userAnswerInt;
            string exitOrContinue;
            bool isAnswerCorrect;
            int currentIndex = random.Next(questions.Count);

            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine("                  Welcome to WHO WANTS 20K:                 ");
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine("You will have to answer 10 questions if you want to get 20 k.");
            for (int i = 0; i < rewards.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {rewards[i]}");
            }
            Console.WriteLine("You can stop playing at any moment. ");
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("There are 3 different helps you can use during game.");
            Console.WriteLine("1. 50/50 - removes two wrong answers.");
            Console.WriteLine("2. Phone a Friend - you can ask your friend for help.");
            Console.WriteLine("3. Ask the Audience - audience will vote for the answer they think is correct.");
            Console.WriteLine("You can use theese helps by typing in (Help)");
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("Let's start!");
            Console.Write("What's your name?: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Good luck {userName}: ");
            Helps helps = new Helps();
            int usingHelp;
            while (answeredQuestions < 10)
            {
                printintroForQuestion(answeredQuestions);
                questions[currentIndex].DisplayQuestion();
                Console.Write("Your answer (1, 2, 3, 4) or (Help): ");
                while (true)
                {

                    userAnswer = Console.ReadLine();

                    if (userAnswer.ToLower() == "help")
                    {
                        Console.WriteLine();
                        helps.returnRemainingHelps();
                        Console.Write("Which help are you willing to use: ");
                        while (!int.TryParse(Console.ReadLine(), out usingHelp))
                        {
                            Console.Write("Wrong input. Try again: ");
                        }
                        Console.WriteLine();
                        if (usingHelp == 1)
                        {
                            if (helps.remainingHelps["50/50"] == false)
                            {
                                Console.WriteLine("You have already used 50/50 help.");
                                Console.Write("Your answer (1, 2, 3, 4) or (Help): ");
                                continue;
                            }
                            helps.useFiftyFiftyHelp(questions[currentIndex]);
                            helps.remainingHelps.Remove("50/50");
                            helps.remainingHelps.Add("50/50. Already used.", false);
                            questions[currentIndex].DisplayQuestion();
                            Console.Write("Your answer (1, 2, 3, 4): ");
                        }
                        else if (usingHelp == 2)
                        {
                            if (helps.remainingHelps["phone a friend"] == false)
                            {
                                Console.WriteLine("You have already used Phone a Friend help.");
                                Console.Write("Your answer (1, 2, 3, 4) or (Help): ");
                                continue;
                            }
                            helps.usePhoneAFriendHelp(questions[currentIndex]);
                            helps.remainingHelps.Remove("phone a friend");
                            helps.remainingHelps.Add("phone a friend. Already used.", false);
                            Console.Write("Your answer (1, 2, 3, 4): ");
                        }
                        else if (usingHelp == 3)
                        {
                            if (helps.remainingHelps["ask the audience"] == false)
                            {
                                Console.WriteLine("You have already used Ask the Audience help.");
                                Console.Write("Your answer (1, 2, 3, 4) or (Help): ");
                                continue;
                            }
                            helps.useAskTheAudienceHelp(questions[currentIndex]);
                            helps.remainingHelps.Remove("ask the audience");
                            helps.remainingHelps.Add("ask the audience. Already used.", false);
                            Console.Write("Your answer (1, 2, 3, 4): ");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for help choice.");
                            Console.Write("Your answer (1, 2, 3, 4) or (Help): ");
                        }

                    }
                    else if (int.TryParse(userAnswer, out userAnswerInt) && userAnswerInt > 0 && userAnswerInt < 5)
                    {
                        isAnswerCorrect = questions[currentIndex].checkAnswer(userAnswerInt, out string errorMessage);
                        if (isAnswerCorrect == true)
                        {
                            Console.WriteLine(greetings[random.Next(greetings.Count())]);
                            Console.WriteLine();
                            Console.WriteLine("============================================================");
                            questions.RemoveAt(currentIndex);
                            currentIndex = random.Next(questions.Count);
                            Console.WriteLine($"You have answered {answeredQuestions + 1} question: ");
                            for (int i = 0; i <= answeredQuestions; i++)
                            {
                                Console.WriteLine($"{i + 1}. {rewards[i]}");
                            }
                            Console.WriteLine("============================================================");
                            Console.WriteLine();
                            if (answeredQuestions == 10)
                            {
                                Console.WriteLine("Congratulations! You've answered all questions correctly and won 20,000 lari!");
                                return;
                            }
                            Console.Write("Do you wish to continue? (Yes) or (No): ");
                            exitOrContinue = Console.ReadLine().ToLower();
                            if (exitOrContinue == "yes")
                            {
                                Console.WriteLine("Great! Let's continue.");
                            }
                            else
                            {
                                Console.WriteLine("Thank you for playing! See you next time.");
                                Console.WriteLine($"You have won {rewards[answeredQuestions]}");
                                return;
                            }
                            Console.WriteLine("============================================================");
                            Console.WriteLine();
                            answeredQuestions++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(errorMessage);
                            Console.WriteLine(wrongAnswers[random.Next(wrongAnswers.Count())]);
                            Console.WriteLine("You have lost!");
                            return;

                        }

                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter (1, 2, 3, 4) or (Help): ");
                    }
                }
                
            }
        }
    }
}