using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scene_Controller_Script : MonoBehaviour
{
    public Text[] txtBoxes;

    public GameObject mainIntoScene;
    public GameObject createPasswordScene;
    public GameObject createSecurityQuestionScene;
    public GameObject enterPasswordScene;
    public GameObject menuScene;
    public GameObject questionScene;
    public GameObject donsMessageScene;
    public GameObject gaugeScene;

    //public GameObject standardAnswerPanelGo;    

    public GameObject creepsNamePanelGo;
    public GameObject standardQuestionsPanelGo;

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

    public RectTransform gaugeNeedleRectTrans;

    private bool userProfileComplete;
    private bool creepProfileComplete;
    private bool questionnaireComplete;

    void Start()
    {
        ResetPlayerPrefs();

        if (!PlayerPrefs.HasKey("Password"))
        {
            mainIntoScene.SetActive(true);
            createPasswordScene.SetActive(false);
            createSecurityQuestionScene.SetActive(false);
            enterPasswordScene.SetActive(false);
            questionScene.SetActive(false);
            donsMessageScene.SetActive(false);
            gaugeScene.SetActive(false);
        }

        if (PlayerPrefs.HasKey("Password"))
        {
            mainIntoScene.SetActive(false);
            createPasswordScene.SetActive(false);
            createSecurityQuestionScene.SetActive(false);
            enterPasswordScene.SetActive(true);
            questionScene.SetActive(false);
            donsMessageScene.SetActive(false);
            gaugeScene.SetActive(false);
        }

        // If the user hasn't created their profile set profile question to 1
        if (!PlayerPrefs.HasKey("userProfileComplete"))
        {
            PlayerPrefs.SetInt("userProfileQuestion", 1);
        }

        SetQuestions();
    }

    void ResetPlayerPrefs()
    {
        PlayerPrefs.GetString("Password");
        PlayerPrefs.GetString("SecurityQuestion");
        PlayerPrefs.GetString("SecurityAnswer");

        PlayerPrefs.SetString("userProfileAnswer1", "null");
        PlayerPrefs.SetString("userProfileAnswer2", "null");
        PlayerPrefs.SetString("userProfileAnswer3", "null");
        PlayerPrefs.SetString("userProfileAnswer4", "null");

        PlayerPrefs.SetString("creepProfileAnswer1", "null");
        PlayerPrefs.SetString("creepProfileAnswer2", "null");
        PlayerPrefs.SetString("creepProfileAnswer3", "null");
        PlayerPrefs.SetString("creepProfileAnswer4", "null");
        PlayerPrefs.SetString("creepProfileAnswer5", "null");
        PlayerPrefs.SetString("creepProfileAnswer6", "null");
        PlayerPrefs.SetString("creepProfileAnswer7", "null");

        PlayerPrefs.SetInt("creepTotalScore", 0);

        PlayerPrefs.SetInt("userProfileComplete", 0);
        PlayerPrefs.SetInt("creepProfileComplete", 0);

        PlayerPrefs.SetInt("userProfileQuestion", 0);
        PlayerPrefs.SetInt("creepProfileQuestion", 0);
        PlayerPrefs.SetInt("creepPersonalityQuestion", 0);
        PlayerPrefs.SetInt("creepPhysicalHealthQuestion", 0);
        PlayerPrefs.SetInt("creepMentalHealthQuestion", 0);
        PlayerPrefs.SetInt("creepHistoryQuestion", 0);

        PlayerPrefs.SetInt("userVulnerabilityScore", 0);
        PlayerPrefs.SetInt("creepProfileScore", 0);

        PlayerPrefs.SetString("creepsName", "null");
        PlayerPrefs.GetInt("creepsSex");

        PlayerPrefs.DeleteAll();
    }

    private string CreepName()
    {
        return (PlayerPrefs.GetString("creepsName"));
    }

    private string hisher()
    {
        if (PlayerPrefs.GetInt("creepsSex") == 1)
        {
            return ("his");
        }
        else
        {
            return ("her");
        }
    }

    void SwitchToGaugeScene()
    {
        SetGaugeNeedlePosition();
        gaugeScene.SetActive(true);
        questionScene.SetActive(false);
    }

    void SetNumberOfAnswerTo2()
    {
        answer3Go.SetActive(false);
        answer4Go.SetActive(false);

        answer1BtnRecTrans.anchorMin = new Vector2(0, 0.525f);
        answer1BtnRecTrans.anchorMax = new Vector2(1, 0.975f);

        answer2BtnRecTrans.anchorMin = new Vector2(0, 0.025f);
        answer2BtnRecTrans.anchorMax = new Vector2(1, 0.475f);
    }

    void SetNumberOfAnswerTo3()
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

    void SetNumberOfAnswerTo4()
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

    void SwitchToCreepsNameInput()
    {
        creepsNamePanelGo.SetActive(true);
        standardQuestionsPanelGo.SetActive(false);
    }

    public void SetQuestions()
    {
        #region userProfile
        if (PlayerPrefs.GetInt("userProfileComplete") != 1)
        {
            Debug.Log("User profile question: " + PlayerPrefs.GetInt("userProfileQuestion"));
            switch (PlayerPrefs.GetInt("userProfileQuestion"))
            {
                case 1:
                    questionText.text = "Your age";

                    SetNumberOfAnswerTo3();

                    answer1Text.text = "15-40 years";
                    answer2Text.text = "41-60 years";
                    answer3Text.text = "61 plus years";
                    break;
                case 2:
                    questionText.text = "Your children?";

                    SetNumberOfAnswerTo4();

                    answer1Text.text = "No kids";
                    answer2Text.text = "My current partner and I have child(ren)";
                    answer3Text.text = "I have child(ren) from a previous relationship";
                    answer4Text.text = "I have child(ren) from past and present relationships";
                    break;
                case 3:
                    questionText.text = "Financhially, I am...";

                    answer1Text.text = "Independent";
                    answer2Text.text = "Dependent on partner";
                    answer3Text.text = "On social assistance";
                    answer4Text.text = "He is dependent on me";
                    break;
                case 4:
                    questionText.text = "How many people are you romantically seeing?";

                    answer1Text.text = "Zero";
                    answer2Text.text = "One";
                    answer3Text.text = "Two";
                    answer4Text.text = "Three or more";
                    break;
                case 5:                             
                    PlayerPrefs.SetInt("userProfileComplete", 1);
                    Debug.Log("User profile complete: " + PlayerPrefs.GetInt("userProfileComplete"));
                    donsMessageScene.SetActive(true);
                    questionScene.SetActive(false);
                    donsMessageText.text = PlayerPrefs.GetString("userProfileAnswer1") + "\n"
                                            + PlayerPrefs.GetString("userProfileAnswer2") + "\n"
                                            + PlayerPrefs.GetString("userProfileAnswer3") + "\n"
                                            + PlayerPrefs.GetString("userProfileAnswer4");
                    break;
                case 6:
                    menuScene.SetActive(true);
                    questionScene.SetActive(false);                    
                    break;
            }
        }
        #endregion

        #region creepProfile
        if (PlayerPrefs.GetInt("userProfileComplete") == 1 && PlayerPrefs.GetInt("creepProfileComplete") != 1)
        {
            Debug.Log("Creep profile question: " + PlayerPrefs.GetInt("creepProfileQuestion"));
            if (!PlayerPrefs.HasKey("creepsName"))
            {
                SwitchToCreepsNameInput();
            }
            else
            {
                switch (PlayerPrefs.GetInt("creepProfileQuestion"))
                {
                    case 0:
                        questionText.text = CreepName() + "'s" + " age is";

                        SetNumberOfAnswerTo3();

                        answer1Text.text = "Within 5 years of my age";
                        answer2Text.text = "15 years or more older";
                        answer3Text.text = "10 years or more younger";

                        IncreaseCreepsTotalScore(60);
                        break;
                    case 1:
                        questionText.text = CreepName() + "...";

                        SetNumberOfAnswerTo4();

                        answer1Text.text = "has " + hisher() + " own place";
                        answer2Text.text = "lives with me";
                        answer3Text.text = "in Jail/Prison";
                        answer4Text.text = "shelter/Homeless";

                        IncreaseCreepsTotalScore(50);
                        break;
                    case 2:
                        questionText.text = CreepName() + " and you are...";

                        answer1Text.text = "dating - live apart";
                        answer2Text.text = "live together / married";
                        answer3Text.text = "breaking up";
                        answer4Text.text = "seperated a long time ago";

                        IncreaseCreepsTotalScore(60);
                        break;
                    case 3:
                        //Only ask if married
                        questionText.text = "Are you married";

                        answer1Text.text = "Yes";
                        answer2Text.text = "No";
                        answer3Text.text = "Engaged to be married";
                        answer4Text.text = "I hope to be married some day";

                        IncreaseCreepsTotalScore(40);
                        break;
                    case 4:
                        questionText.text = "I met " + CreepName() + "...";

                        answer1Text.text = "through friends";
                        answer2Text.text = "common interest, work / school";
                        answer3Text.text = "online / bar / party";
                        answer4Text.text = "arranged by family";

                        IncreaseCreepsTotalScore(60);
                        break;
                    case 5:
                        questionText.text = CreepName() + " is...";

                        answer1Text.text = "stably employed";
                        answer2Text.text = "recently unemployed";
                        answer3Text.text = "works for cash / short term";
                        answer4Text.text = "unemployed, welfare, illegal";

                        IncreaseCreepsTotalScore(50);
                        break;
                    case 6:
                        questionText.text = CreepName() + " has access to...";

                        answer1Text.text = "guns that " + CreepName() + " owns";
                        answer2Text.text = "has access to guns";
                        answer3Text.text = "no access to guns";
                        answer4Text.text = "don't know, maybe";

                        IncreaseCreepsTotalScore(120);
                        break;
                    case 7:
                        PlayerPrefs.SetInt("creepProfileComplete", 1);
                        SwitchToGaugeScene();
                        Debug.Log("Creep profile complete: " + PlayerPrefs.GetInt("creepProfileComplete"));
                        break;
                }
            }
        }
        #endregion

        #region creepPersonality
        if (PlayerPrefs.GetInt("userProfileComplete") == 1 && PlayerPrefs.GetInt("creepProfileComplete") == 1)
        {
            Debug.Log("Creep Personality Question: " + PlayerPrefs.GetInt("creepPersonalityQuestion"));
            switch (PlayerPrefs.GetInt("creepPersonalityQuestion"))
            {
                case 0:
                    questionText.text = "My family/friends think my partner is...";

                    SetNumberOfAnswerTo4();

                    answer1Text.text = "awesome";
                    answer2Text.text = "agree to not talk about it";
                    answer3Text.text = "don't like him";
                    answer4Text.text = "don't know";
                    break;
                case 1:
                    questionText.text = "When I'm along with my partner I feel...";

                    SetNumberOfAnswerTo4();

                    answer1Text.text = "Safe, at home, warm";
                    answer2Text.text = "Depends on their mood";
                    answer3Text.text = "like I'm walking on eggshells, afriad";
                    answer4Text.text = "Terrified what they might do next";
                    break;
                case 2:
                    questionText.text = "Does your partner get along with partners?";

                    SetNumberOfAnswerTo4();

                    answer1Text.text = "Good, loving, respectful";
                    answer2Text.text = "Co-exist, but no love";
                    answer3Text.text = "Hates them, fight, argue";
                    answer4Text.text = "Doesn't know mother";
                    break;
            }
        }
        #endregion
    }

    public void Answer1Selected()
    {
        #region userProfile
        if (PlayerPrefs.GetInt("userProfileComplete") != 1)
        {
            switch (PlayerPrefs.GetInt("userProfileQuestion"))
            {
                case 1:
                    // If user is between the age of 15-40 
                    // Increase their vulnerability by 50 pts
                    SetUserVulnerabilityScore(50);
                    PlayerPrefs.SetString("userProfileAnswer1", "Statistically you are at a greatest risk due to your age.");
                    break;
                case 2:
                    // If user doesn't have kids
                    // No increased vulnerability
                    PlayerPrefs.SetString("userProfileAnswer2", "No children reduces your risk.");
                    break;
                case 3:
                    // If user is independent
                    // No increased vulnerability
                    PlayerPrefs.SetString("userProfileAnswer3", "Being independent does not increase risk. ");
                    break;
                case 4:
                    // If user isn't see anyone
                    // No increased vulnerability
                    PlayerPrefs.SetString("userProfileAnswer4", "There little risk if you are not seeing anyone ");
                    break;
            }
            UserProfileNextQuestion();
        }
        #endregion

        #region creepProfile
        switch (PlayerPrefs.GetInt("creepProfileQuestion"))
        {
            case 0:
                // If users partner is within 5 years of age
                // No increase in creepProfileScore
                break;
            case 1:
                // If users partner has his own place
                // No increase in creepProfileScore
                break;
            case 2:
                // If the user and the partner live together apart
                // Increase creepProfileScore by 20pts
                SetCreepProfileScore(20);
                break;
            case 3:
                // If the user and partner are married
                // No increase in creepProfileScore
                break;
            case 4:
                // If the user and partner met through friends
                // No increase in creepProfileScore
                break;
            case 5:
                // If the users partner is stably employed
                // No increase in creepProfileScore
                break;
            case 6:
                // If the users partner owns guns
                // Increase creepProfileScore by 120pts
                SetCreepProfileScore(120);
                break;
        }
        CreepProfileNextQuestion();
        #endregion

        SetQuestions();
    }

    public void Answer2Selected()
    {
        #region userProfile
        if (PlayerPrefs.GetInt("userProfileComplete") != 1)
        {
            switch (PlayerPrefs.GetInt("userProfileQuestion"))
            {
                case 1:
                    // If user is between the age of 41-60
                    // Increase vulnerability by 10 pts
                    SetUserVulnerabilityScore(10);
                    PlayerPrefs.SetString("userProfileAnswer1", "You are at your lowest risk of being abused during your age. ");
                    break;
                case 2:
                    // If user has children with current partner
                    // Increase vulnerability by 30
                    SetUserVulnerabilityScore(30);
                    PlayerPrefs.SetString("userProfileAnswer2", "Having children can increase risk. ");
                    break;
                case 3:
                    // If user is dependent on partner
                    // Increase vulnerability by 30
                    SetUserVulnerabilityScore(30);
                    PlayerPrefs.SetString("userProfileAnswer3", "Being dependent on your partner increases risk. ");
                    break;
                case 4:
                    // If user is seeing 1 person
                    // Increase vulnerability by 15
                    SetUserVulnerabilityScore(15);
                    PlayerPrefs.SetString("userProfileAnswer4", "There is less risk if you are only seeing one person. ");
                    break;
            }
            UserProfileNextQuestion();
        }
        #endregion

        #region creepProfile
        switch (PlayerPrefs.GetInt("creepProfileQuestion"))
        {
            case 0:
                // If users partner is 15 or more years older
                // Increase in creepProfileScore by 40pts
                SetCreepProfileScore(60);
                break;
            case 1:
                // If users partner lives with user
                // Increase in creepProfileScore by 30pts
                SetCreepProfileScore(20);
                break;
            case 2:
                // If the user and the partner live together
                // Increase creepProfileScore by 30pts
                SetCreepProfileScore(60);
                break;
            case 3:
                // If the user and partner are not married
                // Increase in creepProfileScore by 40pts
                SetCreepProfileScore(40);
                break;
            case 4:
                // If the user and partner met through common interests
                // Increase in creepProfileScore by 10pts
                SetCreepProfileScore(10);
                break;
            case 5:
                // If the users partner is recently unemployed
                // Increase in creepProfileScore by 20 pts
                SetCreepProfileScore(20);
                break;
            case 6:
                // If the users partner has access to firearms
                // Increase creepProfileScore by 60pts
                SetCreepProfileScore(60);
                break;
        }
        CreepProfileNextQuestion();
        #endregion

        SetQuestions();
    }

    public void Answer3Selected()
    {
        #region userProfile
        if (PlayerPrefs.GetInt("userProfileComplete") != 1)
        {
            switch (PlayerPrefs.GetInt("userProfileQuestion"))
            {
                case 1:
                    // If user is over than 61 
                    // Increase vulnerability by 40 pts
                    SetUserVulnerabilityScore(40);
                    PlayerPrefs.SetString("userProfileAnswer1", "Statistically you are at a greater risk due to your age. ");
                    break;
                case 2:
                    // If user has children from previous relationship
                    // Increase vulnerability by 60
                    SetUserVulnerabilityScore(60);
                    PlayerPrefs.SetString("userProfileAnswer2", "Having children from a previous relationship greatly increase risk. ");
                    break;
                case 3:
                    // If user is on social assistance
                    // Increase vulnerability by 40
                    SetUserVulnerabilityScore(40);
                    PlayerPrefs.SetString("userProfileAnswer3", "Having " + CreepName() + " dependent on you increases risk. ");
                    break;
                case 4:
                    // If user has 2 children
                    // Increase vulnerability by 35
                    SetUserVulnerabilityScore(35);
                    PlayerPrefs.SetString("userProfileAnswer4", "There is increased risk if you are seeing two people. ");
                    break;
            }
            UserProfileNextQuestion();
        }
        #endregion

        #region creepProfile
        switch (PlayerPrefs.GetInt("creepProfileQuestion"))
        {
            case 0:
                // If users partner is 10 or more years younger
                // Increase in creepProfileScore by 40pts
                SetCreepProfileScore(40);
                break;
            case 1:
                // If users partner lives in jail
                // Increase in creepProfileScore by 40pts
                SetCreepProfileScore(50);
                break;
            case 2:
                // If the user and the partner about to split
                // Increase creepProfileScore by 45pts
                SetCreepProfileScore(25);
                break;
            case 3:
                // If the user and partner hope to be married
                // Increase in creepProfileScore by 20pts
                SetCreepProfileScore(20);
                break;
            case 4:
                // If the user and partner met through bar party online
                // Increase in creepProfileScore by 60pts
                SetCreepProfileScore(60);
                break;
            case 5:
                // If the users partner works for cash
                // Increase in creepProfileScore by 30 pts
                SetCreepProfileScore(30);
                break;
            case 6:
                // If the users partner has no access to firearms
                // No increase in creepProfileScore
                break;
        }
        CreepProfileNextQuestion();
        #endregion

        SetQuestions();
    }

    public void Answer4Selected()
    {
        #region userProfile
        if (PlayerPrefs.GetInt("userProfileComplete") != 1)
        {
            switch (PlayerPrefs.GetInt("userProfileQuestion"))
            {
                case 1:
                    // No Answer
                    break;
                case 2:
                    // No Answer
                    break;
                case 3:
                    // If user is dependent on partner
                    // Increase vulnerability by 30
                    SetUserVulnerabilityScore(30);
                    break;
                case 4:
                    // If user has 3 or more children
                    // Increase vulnerability by 45
                    SetUserVulnerabilityScore(45);
                    PlayerPrefs.SetString("userProfileAnswer4", "There is a high risk if you are seeing 3 or more people. ");
                    break;
            }
            UserProfileNextQuestion();
        }
        #endregion

        #region creepProfile
        switch (PlayerPrefs.GetInt("creepProfileQuestion"))
        {
            case 0:
                // No answer available
                break;
            case 1:
                // If users partner lives shelter/homeless
                // Increase in creepProfileScore by 30pts
                SetCreepProfileScore(30);
                break;
            case 2:
                // If the user and the partner left along time ago
                // Increase creepProfileScore by 5pts
                SetCreepProfileScore(5);
                break;
            case 3:
                // If the user and partner hope to be married
                // Increase in creepProfileScore by 40pts
                SetCreepProfileScore(40);
                break;
            case 4:
                // If the user and partner arranged through family
                // Increase in creepProfileScore by 30pts
                SetCreepProfileScore(30);
                break;
            case 5:
                // If the users partner is unemployed, welfare, illegal
                // Increase in creepProfileScore by 50 pts
                SetCreepProfileScore(50);
                break;
            case 6:
                // If the users partner may have access to weapons
                // Increase creepProfileScore by 20pts
                SetCreepProfileScore(20);
                break;
        }
        CreepProfileNextQuestion();
        #endregion

        SetQuestions();
    }

    private void UserProfileNextQuestion()
    {
        Debug.Log("User Vulnerability Score: " + PlayerPrefs.GetInt("userVulnerabilityScore"));
        if (PlayerPrefs.GetInt("userProfileComplete")  != 1)
        {
            PlayerPrefs.SetInt("userProfileQuestion", PlayerPrefs.GetInt("userProfileQuestion") + 1);
        }
    }

    private void CreepProfileNextQuestion()
    {
        if (PlayerPrefs.GetInt("creepProfileQuestion") < 7 && PlayerPrefs.GetInt("userProfileComplete") == 1)
        {
            Debug.Log("Creep Profile Score: " + PlayerPrefs.GetInt("creepProfileScore"));
            if (PlayerPrefs.GetInt("creepProfileQuestion") == 5)
            {
                if (PlayerPrefs.GetInt("creepProfileScore") < 100)
                {
                    PlayerPrefs.SetInt("creepProfileQuestion", PlayerPrefs.GetInt("creepProfileQuestion") + 2);
                }
                else
                {
                    PlayerPrefs.SetInt("creepProfileQuestion", PlayerPrefs.GetInt("creepProfileQuestion") + 1);
                }

            }
            else
            {
                PlayerPrefs.SetInt("creepProfileQuestion", PlayerPrefs.GetInt("creepProfileQuestion") + 1);
            }

        }
    }

    private void IncreaseCreepsTotalScore(int score)
    {
        PlayerPrefs.SetInt("creepTotalScore", PlayerPrefs.GetInt("creepTotalScore") + score);
    }

    private void SetGaugeNeedlePosition()
    {
        float percent;
        float rotation;

        int totalScore = PlayerPrefs.GetInt("creepTotalScore");
        int currentScore = PlayerPrefs.GetInt("creepProfileScore");

        percent = (float)currentScore / (float)totalScore;
        rotation = (180 * percent) - 180;


        Debug.Log("Creep Total Score: " + totalScore);
        Debug.Log("Creep Current Score: " + currentScore);
        Debug.Log("Percent: " + percent);
        Debug.Log("Rotation: " + rotation);

        gaugeNeedleRectTrans.rotation = Quaternion.Euler(0, 0, Mathf.Abs(rotation));
    }

    private void SetUserVulnerabilityScore(int userVul)
    {
        PlayerPrefs.SetInt("userVulnerabilityScore", PlayerPrefs.GetInt("userVulnerabilityScore") + userVul);
    }

    private void SetCreepProfileScore(int creepVul)
    {
        PlayerPrefs.SetInt("creepProfileScore", PlayerPrefs.GetInt("creepProfileScore") + creepVul);
    }
}
