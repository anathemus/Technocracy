using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BonusTypeUtilities
{
    public static bool ContainsDestroyWholeRowColumn(BonusType bt)
    {
        return ((bt & BonusType.DestroyWholeRowColumn) == BonusType.DestroyWholeRowColumn);
    }
}
