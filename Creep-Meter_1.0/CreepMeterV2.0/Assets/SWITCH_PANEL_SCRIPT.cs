using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWITCH_PANEL_SCRIPT : MonoBehaviour {

    public GameObject openPanel;
    public GameObject closePanel;

    public bool herProfile;
    public bool hisProfile;
    public bool hisCharacter;
    public bool hisPhysicalHealth;
    public bool hisMentalHealth;
    public bool hisHistory;

    public void SetAnswerPanel()
    {
        GAME_MANAGER_SCRIPT.instance.herProfile_bool = herProfile;
        GAME_MANAGER_SCRIPT.instance.hisProfile_bool = hisProfile;
        GAME_MANAGER_SCRIPT.instance.hisCharacter_bool = hisCharacter;
        GAME_MANAGER_SCRIPT.instance.hisPhysicalHealth_bool = hisPhysicalHealth;
        GAME_MANAGER_SCRIPT.instance.hisMentalHealth_bool = hisMentalHealth;
        GAME_MANAGER_SCRIPT.instance.hisHistory_bool = hisHistory;
        GAME_MANAGER_SCRIPT.instance.SetMenuQuestions();
        SwitchPanel();
    }

    public void SwitchPanel()
    {
        openPanel.SetActive(true);
        closePanel.SetActive(false);
        //Debug.Log("Panels Switched.");
    }
}