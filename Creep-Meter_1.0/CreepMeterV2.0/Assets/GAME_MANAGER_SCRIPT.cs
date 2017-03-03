using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GAME_MANAGER_SCRIPT : MonoBehaviour
{
    public static GAME_MANAGER_SCRIPT instance;

    public RectTransform herMeterRect;
    public RectTransform hisMeterRect;

    public bool herProfile_bool;
    public int herProfileScore;
    int herMaxScore = 0;
    public string[] herQuestions_Str_Ary;
    public string[] herAnswer1_Str_Ary;
    public int[] herAnswer1Score_Ary;
    public string[] herAnswer2_Str_Ary;
    public int[] herAnswer2Score_Ary;
    public string[] herAnswer3_Str_Ary;
    public int[] herAnswer3Score_Ary;
    public string[] herAnswer4_Str_Ary;
    public int[] herAnswer4Score_Ary;

    public bool hisProfile_bool;
    public int hisProfileScore;
    int hisMaxScore = 0;
    public string[] hisProfileQuestions_Str_Ary;
    public string[] hisProfileAnswer1_Str_Ary;
    public int[] hisProfileAnswer1Score_Ary;
    public string[] hisProfileAnswer2_Str_Ary;
    public int[] hisProfileAnswer2Score_Ary;
    public string[] hisProfileAnswer3_Str_Ary;
    public int[] hisProfileAnswer3Score_Ary;
    public string[] hisProfileAnswer4_Str_Ary;
    public int[] hisProfileAnswer4Score_Ary;

    public bool hisCharacter_bool;
    public int hisCharacterScore;
    public string[] hisCharacterQuestions_Str_Ary;
    public string[] hisCharacterAnswer1_Str_Ary;
    public int[] hisCharacterAnswer1Score_Ary;
    public string[] hisCharacterAnswer2_Str_Ary;
    public int[] hisCharacterAnswer2Score_Ary;
    public string[] hisCharacterAnswer3_Str_Ary;
    public int[] hisCharacterAnswer3Score_Ary;
    public string[] hisCharacterAnswer4_Str_Ary;
    public int[] hisCharacterAnswer4Score_Ary;

    public bool hisPhysicalHealth_bool;
    public int hisPhysicalHealthScore;
    public string[] hisPhysicalHealthQuestions_Str_Ary;
    public string[] hisPhysicalHealthAnswer1_Str_Ary;
    public int[] hisPhysicalHealthAnswer1Score_Ary;
    public string[] hisPhysicalHealthAnswer2_Str_Ary;
    public int[] hisPhysicalHealthAnswer2Score_Ary;
    public string[] hisPhysicalHealthAnswer3_Str_Ary;
    public int[] hisPhysicalHealthAnswer3Score_Ary;
    public string[] hisPhysicalHealthAnswer4_Str_Ary;
    public int[] hisPhysicalHealthAnswer4Score_Ary;

    public bool hisMentalHealth_bool;
    public int hisMentalHealthScore;
    public string[] hisMentalHealthQuestions_Str_Ary;
    public string[] hisMentalHealthAnswer1_Str_Ary;
    public int[] hisMentalHealthAnswer1Score_Ary;
    public string[] hisMentalHealthAnswer2_Str_Ary;
    public int[] hisMentalHealthAnswer2Score_Ary;
    public string[] hisMentalHealthAnswer3_Str_Ary;
    public int[] hisMentalHealthAnswer3Score_Ary;
    public string[] hisMentalHealthAnswer4_Str_Ary;
    public int[] hisMentalHealthAnswer4Score_Ary;

    public bool hisHistory_bool;
    public int hisHistoryScore;
    public string[] hisHistoryQuestions_Str_Ary;
    public string[] hisHistoryAnswer1_Str_Ary;
    public int[] hisHistoryAnswer1Score_Ary;
    public string[] hisHistoryAnswer2_Str_Ary;
    public int[] hisHistoryAnswer2Score_Ary;
    public string[] hisHistoryAnswer3_Str_Ary;
    public int[] hisHistoryAnswer3Score_Ary;
    public string[] hisHistoryAnswer4_Str_Ary;
    public int[] hisHistoryAnswer4Score_Ary;

    public GameObject[] qustionButtons_Ary;  

    // Create a new dictionary of strings, with string keys.
    public Dictionary<int, string> questions_Dic =
    new Dictionary<int, string>();

    public Dictionary<int, string> answer1_Dic =
    new Dictionary<int, string>();
    public Dictionary<int, string> answer2_Dic =
    new Dictionary<int, string>();
    public Dictionary<int, string> answer3_Dic =
    new Dictionary<int, string>();
    public Dictionary<int, string> answer4_Dic =
    new Dictionary<int, string>();

    void Awake()
    {
        instance = this;
    }  

    void Start()
    {
        for (int i = 0; i < herQuestions_Str_Ary.Length; i++)
        {
            herMaxScore += herAnswer1Score_Ary[i];
            herMaxScore += herAnswer2Score_Ary[i];
            herMaxScore += herAnswer3Score_Ary[i];
            herMaxScore += herAnswer4Score_Ary[i];
            //Debug.Log("Her Max Score: " + herMaxScore);
        }

        for (int i = 0; i < hisProfileQuestions_Str_Ary.Length; i++)
        {
            hisMaxScore += hisProfileAnswer1Score_Ary[i];
            hisMaxScore += hisProfileAnswer2Score_Ary[i];
            hisMaxScore += hisProfileAnswer3Score_Ary[i];
            hisMaxScore += hisProfileAnswer4Score_Ary[i];
            //Debug.Log("Her Max Score: " + hisMaxScore);
        }
    }

    public void SetMenuQuestions()
    {
        if (herProfile_bool)
        {
            for (int i = 0; i < herQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(herQuestions_Str_Ary[i], herAnswer1_Str_Ary[i], herAnswer2_Str_Ary[i], herAnswer3_Str_Ary[i], herAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
        if (hisProfile_bool)
        {
            for (int i = 0; i < hisCharacterQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisProfileQuestions_Str_Ary[i], hisProfileAnswer1_Str_Ary[i], hisProfileAnswer2_Str_Ary[i], hisProfileAnswer3_Str_Ary[i], hisProfileAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
        if (hisCharacter_bool)
        {
            for (int i = 0; i < hisCharacterQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisCharacterQuestions_Str_Ary[i], hisCharacterAnswer1_Str_Ary[i], hisCharacterAnswer2_Str_Ary[i], hisCharacterAnswer3_Str_Ary[i], hisCharacterAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
        if (hisPhysicalHealth_bool)
        {
            for (int i = 0; i < hisPhysicalHealthQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisPhysicalHealthQuestions_Str_Ary[i], hisPhysicalHealthAnswer1_Str_Ary[i], hisPhysicalHealthAnswer2_Str_Ary[i], hisPhysicalHealthAnswer3_Str_Ary[i], hisPhysicalHealthAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
        if (hisMentalHealth_bool)
        {
            for (int i = 0; i < hisMentalHealthQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisMentalHealthQuestions_Str_Ary[i], hisMentalHealthAnswer1_Str_Ary[i], hisMentalHealthAnswer2_Str_Ary[i], hisMentalHealthAnswer3_Str_Ary[i], hisMentalHealthAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
        if (hisHistory_bool)
        {
            for (int i = 0; i < hisHistoryQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisHistoryQuestions_Str_Ary[i], hisHistoryAnswer1_Str_Ary[i], hisHistoryAnswer2_Str_Ary[i], hisHistoryAnswer3_Str_Ary[i], hisHistoryAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
    }

    public void UpdateMeters()
    {
        if (herProfile_bool)
        {
            float percent = (float)herProfileScore / (float)herMaxScore;
            Debug.Log("Percent: " + percent);
            float rotation = -180 * (float)percent;
            Debug.Log("Rotation: " + rotation);
            herMeterRect.localRotation = Quaternion.Euler(0, 0, rotation);
        }
        else if (hisProfile_bool)
        {
            float percent = (float)hisProfileScore / (float)hisMaxScore;
            float rotation = -180 * (float)percent;

            hisMeterRect.localRotation = Quaternion.Euler(0, 0, rotation);
        }
    }
}