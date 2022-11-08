
namespace Calculator;

public partial class MathQuiz : ContentPage
{
    int opt1, opt2, opt3;

    Random random = new Random();
    public MathQuiz()
	{
		InitializeComponent();
	}

    void Started(object sender, EventArgs e)
    {
        visibleGame(1);
        generateQuestion();
    }

    void restart(object sender, EventArgs e)
    {
        visibleGame(0);
    }

    void generateQuestion()
    {
        getExpression(); 
        giveOptions();
    }

    void getExpression()
    {
        int var1,var2;
        String allExpressions = "+-/*";
        var1 = random.Next(1, 10);
        var2 = random.Next(1, 10);
        this.QuizVar1.Text = var1.ToString();
        this.QuizVar2.Text = var2.ToString();
        this.QuizExpression.Text = allExpressions[0].ToString();

    }

    void giveOptions()
    {
        this.opt1 = random.Next(1, 20);
        this.opt2 = random.Next(1, 20);
        this.opt3 = random.Next(1, 20);
        this.Option1.Text = opt1.ToString();
        this.Option2.Text = opt2.ToString();
        this.Option3.Text = opt3.ToString();
    }
    void visibleGame(int a)
    {
        if (a == 1)
        {
            visibleOptionsLayout(1);
            visibleQuestionLayout(1);
            visibleRestart(1);
            visibleScoreLayout(1);
            visibleSkip(1);
            visibleStartButton(0);
            visibleTryAgain(1);
            visibleCorrect(0);
            visibleIncorrect(0);
        }
        else
        {
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
            visibleRestart(0);
            visibleScoreLayout(0);
            visibleSkip(0);
            visibleStartButton(1);
            visibleTryAgain(0);
            visibleCorrect(0);
            visibleIncorrect(0);
        }

    }
    void visibleStartButton(int a)
    {
        if (a == 1)
        {
            this.StartButton.IsVisible = true;
        }
        else
        {
            this.StartButton.IsVisible = false;
        }
    }
    void visibleScoreLayout(int a)
    {
        if (a == 1)
        {
            this.ScoreLayout.IsVisible = true;
        }
        else
        {
            this.ScoreLayout.IsVisible = false;
        }
    }
    void visibleOptionsLayout(int a)
    {
        if (a == 1)
        {
            this.OptionsLayout.IsVisible = true;
        }
        else
        {
            this.OptionsLayout.IsVisible = false;
        }
    }
    void visibleQuestionLayout(int a)
    {
        if (a == 1)
        {
            this.QuestionLayout.IsVisible = true;
        }
        else
        {
            this.QuestionLayout.IsVisible = false;
        }
    }
    void visibleRestart(int a)
    {
        if (a == 1)
        {
            this.Restart.IsVisible = true;
        }
        else
        {
            this.Restart.IsVisible = false;
        }
    }
    void visibleTryAgain(int a)
    {
        if (a == 1)
        {
            this.TryAgain.IsVisible = true;
        }
        else
        {
            this.TryAgain.IsVisible = false;
        }
    }
    void visibleSkip(int a)
    {
        if (a == 1)
        {
            this.Skip.IsVisible = true;
        }
        else
        {
            this.Skip.IsVisible = false;
        }
    }
    void visibleCorrect(int a)
    {
        if (a == 1)
        {
            this.CorrectAnswer.IsVisible = true;
        }
        else
        {
            this.CorrectAnswer.IsVisible = false;
        }
    }
    void visibleIncorrect(int a)
    {
        if (a == 1)
        {
            this.IncorrectAnswer.IsVisible = true;
        }
        else
        {
            this.IncorrectAnswer.IsVisible = false;
        }
    }
}