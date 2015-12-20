namespace Millionaire
{
    interface iControlManage
    {
        void AddQuestion(string q, string ar, string a1, string a2, string a3);
        void Import(string path);
        string OpenBrowseDialog();
    }
}
