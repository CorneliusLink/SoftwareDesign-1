using System;

namespace Lesson07
{
    class Program
    {
        static int score;
        private List<Quizelement> questionPool;

        void GenerateDefaultQuesions(){ //Die Methode hat keinen Inhalt
            
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

        void PlayTheGame(){ //Der Methodenname ist evtl. etwas zu unspezifisch
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

        GetUserInteraction(){ //Auch hier ist der Methodenname noch etwas zu unklar, bzw. die Frage ist eher, was die Funktion hier genau macht, falls sie die nachfolgende Methode nicht wrappen soll -> kein Inhalt

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Player, please choose/np for play, a to add a new quiz, q to quit the game");
            string choise = Console.ReadLine(); //Hier ist vermutlich "choice" gemeint. "choise" ist laut Google zwar eine alternative Schreibweise für "choice" aber weder im Oxford, noch im Merriam-Webster Dictionary gibt es einen Eintrag dafür. Ich würde also eher sagen, dass man hier die korrekte Schreibweise verwendet, um beim Review niemanden zu verwirren.
            
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
                //switch cases sollten m.W. immer einen default case haben, falls es z.B. zu unerwarteten Eingaben kommt.
            }

            Console.WriteLine("Thanks for playing" + score);
        }
    }
}
