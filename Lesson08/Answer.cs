public class Answer{
    public string answer;
    public bool correct;

    public Answer(string answer, bool correct)
    {
        this.answer = answer;
        this.correct = correct;
    }

    public bool IsCorrect(string enteredAnswer)
    {
        if (enteredAnswer == answer)
            return true;
        return false;
    }
}