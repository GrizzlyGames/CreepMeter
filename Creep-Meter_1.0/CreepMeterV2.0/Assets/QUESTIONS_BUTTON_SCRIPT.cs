using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QUESTIONS_BUTTON_SCRIPT : MonoBehaviour
{
    public int questionNum_Int;

    public GameObject mQuestion_GO;

    public GameObject mAnswer_1_GO;
    public GameObject mAnswer_2_GO;
    public GameObject mAnswer_3_GO;
    public GameObject mAnswer_4_GO;

    private string question_Str;
    private string answer_1_Str;
    private string answer_2_Str;
    private string answer_3_Str;
    private string answer_4_Str;

    private Text mButton_Text = null;
    private Text mQuestion_Text = null;
    private Text mAnswer_1_Text = null;
    private Text mAnswer_2_Text = null;
    private Text mAnswer_3_Text = null;
    private Text mAnswer_4_Text = null;

    void Start()
    {
        mQuestion_Text = mQuestion_GO.GetComponentInChildren<Text>();
        mAnswer_1_Text = mAnswer_1_GO.GetComponentInChildren<Text>();
        mAnswer_2_Text = mAnswer_2_GO.GetComponentInChildren<Text>();
        mAnswer_3_Text = mAnswer_3_GO.GetComponentInChildren<Text>();
        mAnswer_4_Text = mAnswer_4_GO.GetComponentInChildren<Text>();
    }

    public void SetStrings(string question, string answer1, string answer2, string answer3, string answer4)
    {
        question_Str = question;
        answer_1_Str = answer1;
        answer_2_Str = answer2;
        answer_3_Str = answer3;
        answer_4_Str = answer4;
    }

    public void SetButtonText()
    {
        mButton_Text = this.transform.GetChild(0).GetComponent<Text>();
        mButton_Text.text = question_Str;
    }

    public void SetQuestion()
    {
        mQuestion_Text.text = question_Str;
        mAnswer_1_Text.text = answer_1_Str;
        mAnswer_2_Text.text = answer_2_Str;
        mAnswer_3_Text.text = answer_3_Str;
        mAnswer_4_Text.text = answer_4_Str;

        if (!GAME_MANAGER_SCRIPT.instance.questions_Dic.ContainsKey(questionNum_Int))
            GAME_MANAGER_SCRIPT.instance.questions_Dic.Add(questionNum_Int, question_Str);

        //Debug.Log(GAME_MANAGER_SCRIPT.instance.questions_Dic[questionNum_Int]);

        SetAnswerValue();
    }

    void SetAnswerValue()
    {
        if (GAME_MANAGER_SCRIPT.instance.herProfile_bool)
        {
            mAnswer_1_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.herAnswer1Score_Ary[questionNum_Int - 1];
            mAnswer_2_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.herAnswer2Score_Ary[questionNum_Int - 1];
            mAnswer_3_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.herAnswer3Score_Ary[questionNum_Int - 1];
            mAnswer_4_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.herAnswer4Score_Ary[questionNum_Int - 1];
        }
        else if (GAME_MANAGER_SCRIPT.instance.hisProfile_bool)
        {
            mAnswer_1_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisProfileAnswer1Score_Ary[questionNum_Int - 1];
            mAnswer_2_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisProfileAnswer2Score_Ary[questionNum_Int - 1];
            mAnswer_3_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisProfileAnswer3Score_Ary[questionNum_Int - 1];
            mAnswer_4_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisProfileAnswer4Score_Ary[questionNum_Int - 1];
        }
        else if (GAME_MANAGER_SCRIPT.instance.hisCharacter_bool)
        {
            mAnswer_1_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisCharacterAnswer1Score_Ary[questionNum_Int - 1];
            mAnswer_2_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisCharacterAnswer2Score_Ary[questionNum_Int - 1];
            mAnswer_3_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisCharacterAnswer3Score_Ary[questionNum_Int - 1];
            mAnswer_4_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisCharacterAnswer4Score_Ary[questionNum_Int - 1];
        }
        else if (GAME_MANAGER_SCRIPT.instance.hisPhysicalHealth_bool)
        {
            mAnswer_1_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisPhysicalHealthAnswer1Score_Ary[questionNum_Int - 1];
            mAnswer_2_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisPhysicalHealthAnswer2Score_Ary[questionNum_Int - 1];
            mAnswer_3_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisPhysicalHealthAnswer3Score_Ary[questionNum_Int - 1];
            mAnswer_4_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisPhysicalHealthAnswer4Score_Ary[questionNum_Int - 1];
        }
        else if (GAME_MANAGER_SCRIPT.instance.hisMentalHealth_bool)
        {
            mAnswer_1_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisMentalHealthAnswer1Score_Ary[questionNum_Int - 1];
            mAnswer_2_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisMentalHealthAnswer2Score_Ary[questionNum_Int - 1];
            mAnswer_3_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisMentalHealthAnswer3Score_Ary[questionNum_Int - 1];
            mAnswer_4_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisMentalHealthAnswer4Score_Ary[questionNum_Int - 1];
        }
        else if (GAME_MANAGER_SCRIPT.instance.hisHistory_bool)
        {
            mAnswer_1_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisHistoryAnswer1Score_Ary[questionNum_Int - 1];
            mAnswer_2_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisHistoryAnswer2Score_Ary[questionNum_Int - 1];
            mAnswer_3_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisHistoryAnswer3Score_Ary[questionNum_Int - 1];
            mAnswer_4_GO.GetComponent<ANSWER_BUTTON_SCRIPT>().value = GAME_MANAGER_SCRIPT.instance.hisHistoryAnswer4Score_Ary[questionNum_Int - 1];
        }
    }
}