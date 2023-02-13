using System;
using System.Collections.Generic;
using System.Text;

namespace _14022023home
{
    internal interface ICourse
    {

        void AddGroup(Group group);
        Group GetGroupByNo(string no);
        Group[] Search(string search);

    }
}
