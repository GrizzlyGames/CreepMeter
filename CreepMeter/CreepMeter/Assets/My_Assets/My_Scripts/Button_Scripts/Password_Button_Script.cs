using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Password_Button_Script : MonoBehaviour
{
    public Switch_Scenes_Button_Script switchScenesScript;

    public Text messageText;

    public InputField questionInput;

    public InputField input1;
    public InputField input2;

    private bool stringcomparison()
    {
        if (input1.text.ToString().Equals(input2.text.ToString()))
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }

    private void switchObjects()
    {
        switchScenesScript.SwitchScenes();
    }

    public void CreatePassword()
    {
        if (stringcomparison() == true)
        {
            if (input1.text.ToString().Length > 3 && input1.text.ToString().Length <= 12)
            {
                PlayerPrefs.SetString("Password", input1.text.ToString());
                switchObjects();
            }
            else if (input1.text.ToString().Length <= 3)
            {
                messageText.text = "Password must be more than 3 characters.";
            }
            else if (input1.text.ToString().Length > 12)
            {
                messageText.text = "Password must be less than 13 characters.";
            }
        }
        else if (!input1.text.ToString().Equals(input2.text.ToString()))
        {
            messageText.text = "Password does not match.";
        }
    }

    public void CreateSecurityQuestion()
    {
        if (stringcomparison() == true)
        {
            if (input1.text.ToString().Length > 3)
            {
                if (questionInput.text.ToString().Length >= 8)
                {
                    PlayerPrefs.SetString("SecurityQuestion", questionInput.text.ToString());
                    PlayerPrefs.SetString("SecurityAnswer", input1.text.ToString());
                    switchObjects();
                }
                else if (questionInput.text.ToString().Length < 8)
                {
                    messageText.text = "Question must be longer than 7 characters";
                }
            }
            else if (input1.text.ToString().Length <= 3)
            {
                messageText.text = "Answer must be more than 3 characters.";
            }
        }
        else if (!input1.text.ToString().Equals(input2.text.ToString()))
        {
            messageText.text = "Answer does not match.";
        }
    }

    public void CheckPassword()
    {
        if (input1.text.ToString().Equals(PlayerPrefs.GetString("Password")))
        {
            switchObjects();
        }
        else
        {
            messageText.text = "Password incorrect, try again.";
        }
    }
}
