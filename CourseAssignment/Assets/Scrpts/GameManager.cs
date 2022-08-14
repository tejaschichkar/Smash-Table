using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pscore = 0;
    public int cscore = 0;
    public bool win = false;
    public bool loose = false;

    public void PScoreIncrease()
    {
        pscore++;
        if(pscore == 5)
        {
            win = true;
        }
    }
    public void CScoreIncrease()
    {
        cscore++;
        if(cscore == 5)
        {
            loose = true;
        }
    }
}
