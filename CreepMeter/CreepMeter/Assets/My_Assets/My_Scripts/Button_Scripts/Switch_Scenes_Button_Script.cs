using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Scenes_Button_Script : MonoBehaviour {

    public GameObject openObject;
    public GameObject closeObject;

    public void SwitchScenes()
    {
        openObject.SetActive(true);
        closeObject.SetActive(false);
    }
}
