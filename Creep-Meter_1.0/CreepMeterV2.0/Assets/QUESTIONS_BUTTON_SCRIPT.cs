using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QUESTIONS_BUTTON_SCRIPT : MonoBehaviour
{
    public int questionNum_Int;

    public GameObject myRoot_GO;
    public GameObject questionRoot_GO;

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
    private Text mAnswer_2_Text = null ;
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
        
        Debug.Log(GAME_MANAGER_SCRIPT.instance.questions_Dic[questionNum_Int]);
        questionRoot_GO.SetActive(true);
        myRoot_GO.SetActive(false);
    }
}