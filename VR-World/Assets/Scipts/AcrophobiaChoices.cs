using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcrophobiaChoices : MonoBehaviour
{
    public GameObject Score;
    public GameObject Question;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;
    public bool finalchoice;
    private int total = 0;
    public void ChoiceOption1()
    {
        AcrophobiaChoices sc = new AcrophobiaChoices();
        Question.GetComponent<Text>().text = "";
        Question.GetComponent<Text>().text ="How did looking over the edge make you feel?";
        finalchoice = false;
        if (ChoiceMade >= 1)
        {
            Question.GetComponent<Text>().text = "How did walking out onto the bridges make you feel?";
            ChoiceMade = ChoiceMade + 1;
            finalchoice = true;
            total++;
        }
        if (ChoiceMade == 0)
        {
            ChoiceMade = ChoiceMade + 1;
            total++;
        }
       FinalV();
    }
    public void ChoiceOption2()
    {
        Question.GetComponent<Text>().text = "How did looking over the edge make you feel?";
        if (ChoiceMade >= 1)
        {
            Question.GetComponent<Text>().text = "How did walking out onto the bridges make you feel?";
            ChoiceMade = ChoiceMade + 2;
            finalchoice = true;
            total++;
        }
  
        if (ChoiceMade == 0)
        {
            ChoiceMade = ChoiceMade + 2;
            total++;
        }

        FinalV();
    }
    public void ChoiceOption3()
    {
        Question.GetComponent<Text>().text = "How did looking over the edge make you feel?";
        if (ChoiceMade >= 1)
        {
            Question.GetComponent<Text>().text = "How did walking out onto the bridges make you feel?";
            ChoiceMade = ChoiceMade + 3;
            finalchoice = true;
            total++;
        }

        if (ChoiceMade == 0)
        {
            ChoiceMade = ChoiceMade + 3;
            total++;
        }

        FinalV();
    }
    public void FinalV()
    {
        if (total == 3 && ChoiceMade >=6)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a strong possibility that you may have Acrophobia";
        }
        if (total == 3 && ChoiceMade <= 5 && ChoiceMade >= 4)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a medium possibility that you may have Acrophobia";
        }
        if (total == 3 && ChoiceMade <= 3)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a low possibility that you may have Acrophobia";
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
