using System;

namespace Lesson07
{
    class Program
    {
        static int score;
        private List<Quizelement> questionPool;

        void GenerateDefaultQuesions(){
            
        }

        void AddQuestionToPool(){
            Console.WriteLine("please enter Question");
            
            string question = Console.ReadLine();
            questionPool.add(question);
            
            Console.WriteLine("set question count");
            int answerCount = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("please write your first and right answer:");
            string answer = Console.ReadLine();

            for(int i = 0; i<answerCount; i++){
                Console.WriteLine("please next answer");
                string nextAnswer = Console.ReadLine();
                question.add(nextAnswer);
            }
        }

        void PlayTheGame(){
            Quizelement.ShowQuestion();

            Console.WriteLine("Enter the Answer");
            string answer = Console.ReadLine();
            
            if(Answer.IsCorrect(answer) == true)
            {
                score += 10;
                Console.WriteLine("+10 Score");
                PlayTheGame();
            }
            else
            {
                Console.WriteLine("you shall not pass");
            }
                
        }

        GetUserInteraction(){

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Player, please choose/np for play, a to add a new quiz, q to quit the game");
            string choise = Console.ReadLine();
            
            switch(choise){
                case "p":
                    PlayTheGame();
                    break;
                case "a":
                    AddQuestionToPool();
                    break;
                case "q":
                    Environment.Exit(-1);
                    break;
            }

            Console.WriteLine("Thanks for playing" + score);
        }
    }
}
