using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Question_Button_Script : MonoBehaviour
{

    public bool herProfile;

    public string question;

    public string answer1;
    public int answer1Weight;
    public string answer2;
    public int answer2Weight;
    public string answer3;
    public int answer3Weight;
    public string answer4;
    public int answer4Weight;

    public void SetNumAnswers2()
    {
        New_Scene_Controller_Script.instance.SetNumberOfAnswerTo2();
    }

    public void SetNumAnswers3()
    {
        New_Scene_Controller_Script.instance.SetNumberOfAnswerTo3();
    }

    public void SetNumAnswers4()
    {
        New_Scene_Controller_Script.instance.SetNumberOfAnswerTo4();
    }

    public void SetQuestionnaire()
    {
        GetComponent<Button>().image.color = Color.green;

        New_Scene_Controller_Script.instance.questionText.text = question;

        New_Scene_Controller_Script.instance.answer1Text.text = answer1;
        New_Scene_Controller_Script.instance.answer1Go.GetComponent<Answer_Button_Script>().weight = answer1Weight;
        New_Scene_Controller_Script.instance.answer1Go.GetComponent<Answer_Button_Script>().herProfile = herProfile;

        New_Scene_Controller_Script.instance.answer2Text.text = answer2;
        New_Scene_Controller_Script.instance.answer2Go.GetComponent<Answer_Button_Script>().weight = answer2Weight;
        New_Scene_Controller_Script.instance.answer2Go.GetComponent<Answer_Button_Script>().herProfile = herProfile;

        New_Scene_Controller_Script.instance.answer3Text.text = answer3;
        New_Scene_Controller_Script.instance.answer3Go.GetComponent<Answer_Button_Script>().weight = answer3Weight;
        New_Scene_Controller_Script.instance.answer3Go.GetComponent<Answer_Button_Script>().herProfile = herProfile;

        New_Scene_Controller_Script.instance.answer4Text.text = answer4;
        New_Scene_Controller_Script.instance.answer4Go.GetComponent<Answer_Button_Script>().weight = answer4Weight;
        New_Scene_Controller_Script.instance.answer4Go.GetComponent<Answer_Button_Script>().herProfile = herProfile;

        New_Scene_Controller_Script.instance.questionScene.SetActive(true);

        if (herProfile)
        {
            int[] array = new int[] { answer1Weight, answer2Weight, answer3Weight, answer4Weight };
            Array.Sort(array);
            PlayerPrefs.SetInt("herProfileTotalScore", PlayerPrefs.GetInt("herProfileTotalScore") + array[3]);
            Debug.Log("Her Profile Total Score: " + PlayerPrefs.GetInt("herProfileTotalScore"));
            New_Scene_Controller_Script.instance.herProfile.SetActive(false);
        }
    }
}
