using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANSWER_BUTTON_SCRIPT : MonoBehaviour
{
    public int value;

    public void AnswerSelected()
    {
        if (GAME_MANAGER_SCRIPT.instance.herProfile_bool)
            GAME_MANAGER_SCRIPT.instance.herProfileScore += value;
        else if (GAME_MANAGER_SCRIPT.instance.hisProfile_bool)
            GAME_MANAGER_SCRIPT.instance.hisProfileScore += value;
        else if (GAME_MANAGER_SCRIPT.instance.hisCharacter_bool)
            GAME_MANAGER_SCRIPT.instance.hisCharacterScore += value;
        else if (GAME_MANAGER_SCRIPT.instance.hisPhysicalHealth_bool)
            GAME_MANAGER_SCRIPT.instance.hisPhysicalHealthScore += value;
        else if (GAME_MANAGER_SCRIPT.instance.hisMentalHealth_bool)
            GAME_MANAGER_SCRIPT.instance.hisMentalHealthScore += value;
        else if (GAME_MANAGER_SCRIPT.instance.hisHistory_bool)
            GAME_MANAGER_SCRIPT.instance.hisHistoryScore += value;

        GAME_MANAGER_SCRIPT.instance.UpdateMeters();
    }
}
