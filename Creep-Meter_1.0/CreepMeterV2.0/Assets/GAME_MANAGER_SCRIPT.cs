using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GAME_MANAGER_SCRIPT : MonoBehaviour
{
    public static GAME_MANAGER_SCRIPT instance;
    
    public bool herProfile_bool;
    public string[] herQuestions_Str_Ary;
    public string[] herAnswer1_Str_Ary;
    public string[] herAnswer2_Str_Ary;
    public string[] herAnswer3_Str_Ary;
    public string[] herAnswer4_Str_Ary;

    public bool hisProfile_bool;
    public string[] hisProfileQuestions_Str_Ary;
    public string[] hisProfileAnswer1_Str_Ary;
    public string[] hisProfileAnswer2_Str_Ary;
    public string[] hisProfileAnswer3_Str_Ary;
    public string[] hisProfileAnswer4_Str_Ary;

    public bool hisCharacter_bool;
    public string[] hisCharacterQuestions_Str_Ary;
    public string[] hisCharacterAnswer1_Str_Ary;
    public string[] hisCharacterAnswer2_Str_Ary;
    public string[] hisCharacterAnswer3_Str_Ary;
    public string[] hisCharacterAnswer4_Str_Ary;

    public bool hisPhysicalHealth_bool;
    public string[] hisPhysicalHealthQuestions_Str_Ary;
    public string[] hisPhysicalHealthAnswer1_Str_Ary;
    public string[] hisPhysicalHealthAnswer2_Str_Ary;
    public string[] hisPhysicalHealthAnswer3_Str_Ary;
    public string[] hisPhysicalHealthAnswer4_Str_Ary;

    public bool hisMentalHealth_bool;
    public string[] hisMentalHealthQuestions_Str_Ary;
    public string[] hisMentalHealthAnswer1_Str_Ary;
    public string[] hisMentalHealthAnswer2_Str_Ary;
    public string[] hisMentalHealthAnswer3_Str_Ary;
    public string[] hisMentalHealthAnswer4_Str_Ary;

    public bool hisHistory_bool;
    public string[] hisHistoryQuestions_Str_Ary;
    public string[] hisHistoryAnswer1_Str_Ary;
    public string[] hisHistoryAnswer2_Str_Ary;
    public string[] hisHistoryAnswer3_Str_Ary;
    public string[] hisHistoryAnswer4_Str_Ary;

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

    void Start(){
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
            for (int i = 0; i < hisPhysicalHealthQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisMentalHealthQuestions_Str_Ary[i], hisMentalHealthAnswer1_Str_Ary[i], hisMentalHealthAnswer2_Str_Ary[i], hisMentalHealthAnswer3_Str_Ary[i], hisMentalHealthAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
        if (hisHistory_bool)
        {
            for (int i = 0; i < hisPhysicalHealthQuestions_Str_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(hisHistoryQuestions_Str_Ary[i], hisHistoryAnswer1_Str_Ary[i], hisHistoryAnswer2_Str_Ary[i], hisHistoryAnswer3_Str_Ary[i], hisHistoryAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }
        }
    }
}