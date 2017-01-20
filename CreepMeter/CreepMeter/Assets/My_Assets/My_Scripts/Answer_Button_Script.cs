using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer_Button_Script : MonoBehaviour {

    public int weight;

    public bool herProfile;

    public void AnswerButtonPushed()
    {
        if (herProfile)
        {
            PlayerPrefs.SetInt("herProfileScore", PlayerPrefs.GetInt("herProfileScore") + weight);

            float percent;
            float rotation;

            int totalScore = PlayerPrefs.GetInt("herProfileTotalScore");
            int currentScore = PlayerPrefs.GetInt("herProfileScore");

            percent = (float)currentScore / (float)totalScore;
            rotation = (180 * percent) - 180;

            New_Scene_Controller_Script.instance.herProfileGaugeNeedleRectTrans.rotation = Quaternion.Euler(0, 0, Mathf.Abs(rotation));

            New_Scene_Controller_Script.instance.herProfile.SetActive(true);
            New_Scene_Controller_Script.instance.questionScene.SetActive(false);
            Debug.Log("Her Profile Score: " + PlayerPrefs.GetInt("herProfileScore"));
        }
    }
}
