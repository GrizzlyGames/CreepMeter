using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class New_Scene_Controller_Script : MonoBehaviour {

    public static New_Scene_Controller_Script instance;

    public GameObject mainIntoScene;
    public GameObject createPasswordScene;
    public GameObject createSecurityQuestionScene;
    public GameObject enterPasswordScene;
    public GameObject menuScene;
    public GameObject herProfile;
    public GameObject questionScene;
    public GameObject donsMessageScene;
    public GameObject standardQuestionsPanelGo;

    public GameObject answer1Go;
    public GameObject answer2Go;
    public GameObject answer3Go;
    public GameObject answer4Go;

    public RectTransform answer1BtnRecTrans;
    public RectTransform answer2BtnRecTrans;
    public RectTransform answer3BtnRecTrans;
    public RectTransform answer4BtnRecTrans;

    public Text questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;
    public Text answer4Text;
    public Text donsMessageText;
    public Text herProfileCompletionPercent;
    public Text hisProfileCompletionPercent;

    public RectTransform herProfileGaugeNeedleRectTrans;

    public RectTransform gaugeNeedleRectTrans;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    public void SetNumberOfAnswerTo2()
    {
        answer3Go.SetActive(false);
        answer4Go.SetActive(false);

        answer1BtnRecTrans.anchorMin = new Vector2(0, 0.525f);
        answer1BtnRecTrans.anchorMax = new Vector2(1, 0.975f);

        answer2BtnRecTrans.anchorMin = new Vector2(0, 0.025f);
        answer2BtnRecTrans.anchorMax = new Vector2(1, 0.475f);
    }
    public void SetNumberOfAnswerTo3()
    {
        answer3Go.SetActive(true);
        answer4Go.SetActive(false);

        answer1BtnRecTrans.anchorMin = new Vector2(0, 0.7f);
        answer1BtnRecTrans.anchorMax = new Vector2(1, 1);

        answer2BtnRecTrans.anchorMin = new Vector2(0, 0.34f);
        answer2BtnRecTrans.anchorMax = new Vector2(1, 0.63f);

        answer3BtnRecTrans.anchorMin = new Vector2(0, 0f);
        answer3BtnRecTrans.anchorMax = new Vector2(1, 0.3f);
    }
    public void SetNumberOfAnswerTo4()
    {
        answer3Go.SetActive(true);
        answer4Go.SetActive(true);

        answer1BtnRecTrans.anchorMin = new Vector2(0, 0.775f);
        answer1BtnRecTrans.anchorMax = new Vector2(1, 1);

        answer2BtnRecTrans.anchorMin = new Vector2(0, 0.525f);
        answer2BtnRecTrans.anchorMax = new Vector2(1, 0.725f);

        answer3BtnRecTrans.anchorMin = new Vector2(0, 0.275f);
        answer3BtnRecTrans.anchorMax = new Vector2(1, 0.5f);

        answer4BtnRecTrans.anchorMin = new Vector2(0, 0.025f);
        answer4BtnRecTrans.anchorMax = new Vector2(1, 0.25f);
    }
}
