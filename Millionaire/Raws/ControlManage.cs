using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class ControlManage : iControlManage
    {
        iModel _model;

        public ControlManage(iModel model)
        {
            _model = model;
        }

        public void AddQuestion(string q, string ar, string a1, string a2, string a3)
        {
            Question NewQ = new Question(q, ar, a1, a2, a3);
            _model.AddQuestion(NewQ);
        }
    }
}
