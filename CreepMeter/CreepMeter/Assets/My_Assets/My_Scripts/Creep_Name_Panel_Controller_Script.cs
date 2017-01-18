using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Creep_Name_Panel_Controller_Script : MonoBehaviour {

    public Scene_Controller_Script script;

    public Text messageText;
    public Text subMessageText;

    public InputField nameInput;

    public Button maleButton;
    public Button femaleButton;

    public GameObject creepNamePanelGo;
    public GameObject standardAnswerPanelGo;

    void Start()
    {
        messageText.text = "Enter your date's name and sex";
        subMessageText.text = "Name can be between 3 and 8 characters";
    }

    void SwitchToStandardQuestionsPanel()
    {
        standardAnswerPanelGo.SetActive(true);
        creepNamePanelGo.SetActive(false);  
    }

    public void maleButtonPressed()
    {
        Debug.Log("Male");
        maleButton.image.color = new Color(0, 1, 1, 0.5f);
        femaleButton.image.color = new Color(1, 1, 1, 1);
        PlayerPrefs.SetInt("creepsSex", 1);
    }

    public void femaleButtonPressed()
    {
        Debug.Log("Female");
        maleButton.image.color = new Color(1, 1, 1, 1);
        femaleButton.image.color = new Color(0, 1, 1, 0.5f);
        PlayerPrefs.SetInt("creepsSex", 0);
    }

    public void continueButtonPressed()
    {
        if (nameInput.text.ToString().Length > 2 && PlayerPrefs.HasKey("creepsSex"))
        {            
            PlayerPrefs.SetString("creepsName", nameInput.text.ToString());
            SwitchToStandardQuestionsPanel();
            script.SetQuestions();
            Debug.Log("Date's name is: " + PlayerPrefs.GetString("creepsName"));
            Debug.Log("Date's sex is: " + PlayerPrefs.GetInt("creepsSex"));
        }
        else if (!PlayerPrefs.HasKey("creepsSex"))
        {
            subMessageText.text = "Choose a sex to continue";
        }
        else if (nameInput.text.ToString().Length < 3)
        {
            subMessageText.text = "Name must be longer than 2 characters";
        }
        else if (nameInput.text == null)
        {
            subMessageText.text = "Enter date's name to continue";
        }
    }
}
