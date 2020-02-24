﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SystemManagement.Dto
{
    public class UserSearchModel : BaseSearchModel
    {
        public string Name
        { 
            get;
            set;
        }

        public string Account
        {
            get;
            set;
        }
    }
}
