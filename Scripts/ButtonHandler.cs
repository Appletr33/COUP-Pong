using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public string buttonLetter;

    public void Press()
    {
        Debug.Log("BUTTON: " + buttonLetter + " CLICKED!");
        GameObject.Find("QuestionManager").GetComponent<QuestionManager>().userAnswered(buttonLetter);
    }
}
