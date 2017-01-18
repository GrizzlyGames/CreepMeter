using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creep_Name_Button_Script : MonoBehaviour {

    public Creep_Name_Panel_Controller_Script script;

    public void maleButton()
    {
        script.maleButtonPressed();
    }

    public void femaleButton()
    {
        script.femaleButtonPressed();
    }

    public void continueButton()
    {
        script.continueButtonPressed();
    }
}
