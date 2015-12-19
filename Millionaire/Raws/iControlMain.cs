using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    interface iControlMain
    {
        event StringsDlgt AnswersChanged;
        event QuestionDlgt QuestionChanged;

        void NewGame();
        void PlayerExit();
        void AnswerButton(int index);
        void AudienceHelp();
        void FiftyFifty();
        void FriendCall();

        void CreateAdminForm();

        void Die();
    }
}
