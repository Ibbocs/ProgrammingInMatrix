using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Phone
    {
        string Company, Model, ReleaseDay;
        public Phone()
        {
            Company = "unkown";
            Model = "unkown";
            ReleaseDay = "unkown";
        }

        public Phone(string _company, string _model)
        {
            Company = _company;
            Model = _model;

        }

        public Phone(string _company, string _model, string _releaseDay)
        {
            Company = _company;
            Model = _model;
            ReleaseDay = _releaseDay;

        }

        

    }
}
