﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthenticator
{
    public interface INotificationService
    {
        public bool Send();
    }
}
