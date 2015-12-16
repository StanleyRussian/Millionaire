using System;
using System.Collections.Generic;

namespace Millionaire
{
    class Backbone : iModel
    {
        public List<Question> QuestionList
        {
            get;
            private set;
        }
    }
}
