namespace MultipleChoiceQuiz;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private void StartQuizButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the quiz page
        Navigation.PushAsync(new QuizPage());
    }
}