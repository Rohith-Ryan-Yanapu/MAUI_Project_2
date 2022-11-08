namespace Calculator;

public partial class MathQuiz : ContentPage
{
    int Score = 0;
    Random random = new Random();
    int var1, var2, opt1 = 0, opt2 = 0, opt3 = 0, exp = -1;
    String expression;
    public MathQuiz()
    {
        InitializeComponent();
    }

    void Started(object sender, EventArgs e)
    {
        visibleGame(1);
        generateQuestion();
        this.ScoreValue.Text = Score.ToString();
    }

    void restart(object sender, EventArgs e)
    {
        Score = 0;
        visibleGame(0);
        this.ScoreValue.Text = Score.ToString();
    }


    void generateQuestion()
    {
        expression = getExpression();
        giveOptions();
    }

    void clickedTryAgain(object sender, EventArgs e)
    {
        
    }

    void clickedNext(object sender, EventArgs e)
    {
        

    }
    
    String getExpression()
    {
        var1 = 1; var2 = 100;
        String allExpressions = "+-/*";
        exp = random.Next(0, 4);
        if (exp == 2)
        {
            while (!(var1 % var2 == 0 && var1 > var2))
            {
                var1 = random.Next(1, 10);
                var2 = random.Next(1, 10);
            }
        }
        else if (exp == 3)
        {
            while (!(var1 < 5 && var2 < 5))
            {
                var1 = random.Next(1, 10);
                var2 = random.Next(1, 10);
            }
        }
        else
        {
            while (var1 < var2)
            {
                var1 = random.Next(1, 10);
                var2 = random.Next(1, 10);
            }
        }

        this.QuizVar1.Text = var1.ToString();
        this.QuizVar2.Text = var2.ToString();
        this.QuizExpression.Text = allExpressions[exp].ToString();

        return var1 + allExpressions[exp].ToString() + var2;
    }

    void giveOptions()
    {
        this.opt1 = random.Next(1, 20);
        this.opt2 = random.Next(1, 20);
        this.opt3 = random.Next(1, 20);

        this.Option1.Text = opt1.ToString();
        this.Option2.Text = opt2.ToString();
        this.Option3.Text = opt3.ToString();
        return;

    }

    int evaluateExpression(String str)
    {
        int i = 0;
        if (exp == 0)
        {
            i = var1 + var2;
            return i;
        }
        else if (exp == 1)
        {
            i = var1 - var2;
            return i;
        }
        else if (exp == 2)
        {
            i = var1 / var2;
            return i;
        }
        else if (exp == 3)
        {
            i = var1 * var2; ;
            return i;
        }
        return i;
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
    
}