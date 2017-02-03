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
            for (int i = 0; i < qustionButtons_Ary.Length; i++)
            {
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetStrings(herQuestions_Str_Ary[i], herAnswer1_Str_Ary[i], herAnswer2_Str_Ary[i], herAnswer3_Str_Ary[i], herAnswer4_Str_Ary[i]);
                qustionButtons_Ary[i].GetComponent<QUESTIONS_BUTTON_SCRIPT>().SetButtonText();
            }                
        }
    }

}