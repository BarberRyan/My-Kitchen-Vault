﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{
    /// <summary>
    /// Enumerable to represent login status of the user
    /// </summary>
    public enum RecipeStatus
    {
        BadName,
        BadDesc,
        BadInst,
        BadIngr,
        BadCook,
        BadPrep,
        BadTags,
        OK
    }
}
