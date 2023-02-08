using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LatestLevel", menuName = "LatestLevel")]
public class LatestLev : ScriptableObject
{
    public int l = 1;
    public void TakeValue(int a)
    {
        l = a;
    }
}
