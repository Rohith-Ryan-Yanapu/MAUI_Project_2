using System.Text.Json;
using Calculator.Models;
using Calculator.Services;
namespace Calculator;
using System.Diagnostics;


public partial class MathQuiz : ContentPage
{
    int Score = 0;
    int totalQuestions;
    RestService _quizService;
    List<QuizItem> quizItems;

    public MathQuiz()
    {
        Debug.WriteLine("In MathQuiz");
        _quizService = new RestService();
        InitializeComponent();
        totalQuestions = 0;
    }

    void Started(object sender, EventArgs e)
    {
        getDatafromAPI();
        visibleGame(1);
        this.ScoreValue.Text = Score.ToString();
        this.TotalValue.Text = totalQuestions.ToString();
    }

    void restart(object sender, EventArgs e)
    {
        Score = 0;
        totalQuestions = 0;
        visibleGame(0);
        this.ScoreValue.Text = Score.ToString();
    }

    void generateQuestion()
    {
        giveOptions();
        ++totalQuestions;
        this.TotalValue.Text = totalQuestions.ToString();

        if (totalQuestions == 10)
        {
            visibleSkip(0);
        }
    }

    async void getDatafromAPI()
    {
        Debug.WriteLine("In Get Data From API");
        this.quizItems = await _quizService.RefreshDataAsync();
        Debug.WriteLine(this.quizItems.Count);
        for (var i = 0; i < quizItems.Count; i++)
        {
            Debug.WriteLine("ID is {0}, Expression is {1} and AnswerIndex is {2}", quizItems[i].ID, quizItems[i].Expression, quizItems[i].AnswerIndex);

        }
        generateQuestion();
    }

    void clickedTryAgain(object sender, EventArgs e)
    {
        visibleCorrect(0);
        visibleIncorrect(0);
        visibleOptionsLayout(1);
        visibleQuestionLayout(1);
    }

    void clickedNext(object sender, EventArgs e)
    {
        generateQuestion();
        visibleCorrect(0);
        visibleIncorrect(0);
        visibleOptionsLayout(1);
        visibleQuestionLayout(1);
        visibleTryAgain(1);
        this.Skip.Text = "Skip";

    }
    void checkAnswer1(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var classId = button.ClassId;
        if (this.quizItems[totalQuestions - 1].AnswerIndex == 1)
        {
            visibleCorrect(1);
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
            visibleTryAgain(0);
            Score++;
            this.ScoreValue.Text = Score.ToString();
            this.Skip.Text = "Next";
        }
        else
        {
            visibleIncorrect(1);
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
        }
    }

    void checkAnswer2(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var classId = button.ClassId;
        if (this.quizItems[totalQuestions - 1].AnswerIndex == 2)
        {
            visibleCorrect(1);
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
            visibleTryAgain(0);
            Score++;
            this.ScoreValue.Text = Score.ToString();
            this.Skip.Text = "Next";
        }
        else
        {
            visibleIncorrect(1);
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
        }
    }

    void checkAnswer3(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var classId = button.ClassId;
        if (this.quizItems[totalQuestions - 1].AnswerIndex == 3)
        {
            visibleCorrect(1);
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
            visibleTryAgain(0);
            Score++;
            this.ScoreValue.Text = Score.ToString();
            this.Skip.Text = "Next";
        }
        else
        {
            visibleIncorrect(1);
            visibleOptionsLayout(0);
            visibleQuestionLayout(0);
        }
    }

    void giveOptions()
    {
        this.QuizExpression.Text = this.quizItems[totalQuestions].Expression;
        this.Option1.Text = this.quizItems[totalQuestions].Options[0];
        this.Option2.Text = this.quizItems[totalQuestions].Options[1];
        this.Option3.Text = this.quizItems[totalQuestions].Options[2];
        return;

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