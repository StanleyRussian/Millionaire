namespace Millionaire
{
    interface iControlMain
    {
        event StringsDlgt AnswersChanged;
        event QuestionDlgt QuestionChanged;
        event IntDlgt IndexChanged;

        int[] SumList
        { get; }

        void NewGame();
        void PlayerExit();
        bool AnswerButton(string answer);
        void AudienceHelp();
        void FiftyFifty();
        string FriendCall();
        void NextQuestion();

        void CreateAdminForm();

        void Die();
    }
}
