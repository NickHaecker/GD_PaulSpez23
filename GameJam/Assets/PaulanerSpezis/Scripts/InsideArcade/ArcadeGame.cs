
using System.Collections;
using UnityEngine;

public class ArcadeGame : Riddle
{
    public override event CallSolved CS;

    public override void Solved()
    {
        CS();
    }
}
