﻿using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public class PersonManager
{
    private readonly DatabaseBroker db;

    public PersonManager()
    {
        db = new DatabaseBroker();
    }
}
