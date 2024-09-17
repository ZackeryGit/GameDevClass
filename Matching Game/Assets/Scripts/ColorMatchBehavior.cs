
using UnityEngine;

public class ColorMatchBehavior : MatchBehvior {
    public ColorIDList colorIDListObj;

    private void Awake(){
        idObj = colorIDListObj.currentColor;
    }
}

