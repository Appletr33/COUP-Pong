using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionManager : MonoBehaviour
{
    public Color wrong;
    public Color right;

    public GameObject[] buttons;
    public TextMeshProUGUI question;
    public int correctAnswer;
    private bool answered = false;


    private void SetText(GameObject button, string text)
    {
        TextMeshProUGUI txt = button.GetComponentInChildren<TextMeshProUGUI>();
        txt.text = text;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        string[] Q1 = new string[] {"After WWII Why did Britain feel it could not maintain its presence in the Middle East?", "They were nearly bankrupt and the cost of defending against the ever-growing local resistance in the Middle East was too great.", "The British could no longer divide and conquer as it had done before.", "The British didn’t have the technology to compete in the Middle East.", "Britain was worried that they would provoke the Soviet military while trying to dominate local resistant forces."};
        string[] Q2 = new string[] { "Was the coup against Mossadegh successful? If so, who replaced him?", "Yes, General Fazollah Zahedi", "Yes, Supreme Islamic Jurist Mohammad Kashani", "Yes, Ayatollah Khomeini", "No"};
        string[] Q3 = new string[] { "How did the US involvement in the coup against Mossadegh affect Iran?", "It turned Iran into a hotbed of instability, rioting, and chaos.", "The Iranian economy stabilized.", "The shah was expelled and Iranian oil fell back into the hands of the British.", "Iran allied with the Soviet Union"};
        string[] Q4 = new string[] { "Who traveled to New York to argue Iran’s case against the complaint filed by the British that tried to intervene in the nationalization of the AIOC?", "Mohammad Mossadegh", "Mohammad Reza (the shah)", "Ayatollah Khomeini", "US President Truman"};
        string[] Q5 = new string[] { "How did the British respond after the National Front called for an end of the oil concession to the British and to nationalize the AIOC?", "The British refused to accept the nationalization of the AIOC and considered invading Iran.", "The British agreed to the nationalization on the terms that the British were granted priority to Iranian oil production.", "Britain decreased its military forces in the region and accepted the request to nationalize the AIOC.", "The British refused and tried to get the United States to force Iran’s hand to keep the AIOC in their control." };
        string[] Q6 = new string[] { "What form of government did the National Front want to establish?", "A Democracy", "A Communist Government", "An Islamic Republic", "A Monarchy"};
        string[] Q7 = new string[] { "Mossadegh was a strong nationalist and wanted to free Iran most from what?", "Foreign influence", "Christianity", "slavery", "The brutal military"};
        string[] Q8 = new string[] { "Why was there public dissatisfaction with the Mossadegh-led government?", "Economic hardships due to high prices", "Mossadegh's emphasis on other religions than Islam", "Mossadegh worked to increase the power of the shah", "Mossadegh advocated for greater military control military under the shah" };
        string[] Q9 = new string[] { "What were the two agencies that developed the plan to overthrow Mossadegh government?", "The CIA and British SIS", "The CIA and British MI6", "The FBI and ATF", "The FDA and EPA" };
        string[] Q10 = new string[] { "Under President Truman’s administration, the United States’ role in Iran was to put emphasis on a compromise between Great Britain and Iran, this took a turn with what major event in the United States?", "The election of President Dwight D. Eisenhower", "The completion of the Manhattan project", "The end of the Cold War", "The end of the Korean War" };
        string[] Q11 = new string[] { "How did the CIA and British SIS plan to overthrow Mossadegh without British Diplomats and spies in Iran?", "They planned to use the well-established network of people who worked for them and saw Mossadegh as a threat to their ideas and power.", "They planned to use propaganda attacks to convince the Iranian people that Mossadegh was actually a high ranking member of the AIOC and taint his public image", "They planned to use sophisticated and strategic bombings to attack Mossadegh.", "They were going to attempt to convince the shah to kill Mossadegh and convince the clergy that he was against Islam" };
        string[] Q12 = new string[] { "Why did the Shah approve of the American and British coup?", "He wanted to increase his power", "The US and Britain agreed to pay him large sums of money", "He didn’t", "He hated Mossadegh" };
        string[] Q13 = new string[] { "What kind of Iran did the American’s and British want?", "They wanted an Oil-producing Iran firmly aligned against the Soviet Union", "They wanted an Oil-producing Iran firmly aligned with the Soviet Union", "They wanted a weak Iran that could be colonized", "They wanted a Christian Iran" };
        string[] Q14 = new string[] { "Why did the United States, which was deep in the cold war, urge Britain and Iran to come to an agreement over the AIOC that would not lead to a further crisis?", "The US worried conflict would lead to Soviet influence or Soviet control of Iran", "The US feared that conflict with Britain might cause Iran’s nuclear program to progress and potentially get foreign funding from the Soviets", "The US believed the conflict with Britain would destabilize the US economy", "A war in Iran might begin a global conflict"};
        string[] Q15 = new string[] { " What year was William D’Arcy granted a concession for oil that marks the beginning of Britain’s role in Iran’s oil industry?", "1901", "1953", "1890", "1932" };
        string[] Q16 = new string[] { "Why was Mohammed Reza Shah showing favoritism towards the British by supporting the Supplemental Agreement with Britain?", "The Shah owed his status to the British AND could strengthen is power through them", "The British were the ones who allowed Mohammed Reza Shah to succeed his father.", "He figured he could strengthen his power through the British", "Reza Shah would greatly benefit financially from this Agreement" };
        string[] Q17 = new string[] { "What is one reason why Iranians united against foreign powers?", "Iranians were tired of foreign involvement and concessions to foreigners", "All of the above", "Iranians united against western ideas and religions", "Iranians were upset that their communities were being destroyed to create new oil wells" };
        string[] Q18 = new string[] { "During 1949, basic economic issues were a concern for the lower classes. What percentage of Iranians who lived in towns and cities lived in slums?", "60%", "30%", "20%", "50%" };
        string[] Q19 = new string[] { "Why was there such great Iranian resentment of the AIOC (British Oil Company)", "All of the Above", "The AIOC excluded Iranians from skilled jobs", "The Iranians had no way of telling whether or not they were being treated fairly", "Working conditions were very poor and there was little pay" };
        string[] Q20 = new string[] { "Why was Britain reluctant to renegotiate its oil agreement with Iran?", "Britain was in the midst of post-war financial hardship and did not seek to renegotiate the extremely favorable deal with Iran who was producing 90% of Europe’s oil.", "Many British would lose their jobs", "Britain was in the midst of post-war financial hardship and didn’t want to renegotiate because of the strategic location of the Oil", "They just didn’t want to" };

        List<string[]> questionList = new List<string[]> { Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20 };


        int question1 = Random.Range(0, questionList.Count);
        int question2 = Random.Range(0, questionList.Count);
        int question3 = Random.Range(0, questionList.Count);

        int questionNum = Random.Range(0, 3);
        if (questionNum == 0)
        {
            questionNum = question1;
        }
        else if (questionNum == 1)
        {
            questionNum = question2;
        }
        else
        {
            questionNum = question3;
        }


        string[] question = questionList[questionNum];

        correctAnswer = Random.Range(0, 4);

        SetQuestionText(question[0]);

        List<int> assignedAnswers = new List<int>();
        //assignedAnswers.Add(correctAnswer);
        Debug.Log(correctAnswer);


        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == correctAnswer)
            {
                SetText(buttons[i], question[1]);
            }

            else
            {
                int answer;
                while(true)
                {
                    answer = Random.Range(0, 3);
                    Debug.Log(answer);
                    if (assignedAnswers.Contains(answer))
                    {

                    }
                    else
                    {
                        SetText(buttons[i], question[answer + 2]);
                        assignedAnswers.Add(answer);
                        break;
                    }
                }
            }
        }
    }

    private void SetQuestionText(string questionText)
    {
        question.text = questionText;
    }

    public void userAnswered(string button)
    {
        if (!answered)
        {
            answered = true;
            displayAnswers();

            if (button == "A")
            {
                if (correctAnswer == 0)
                {
                    Win();
                }

                else
                {
                    Loose();
                }
            }
            if (button == "B")
            {
                if (correctAnswer == 1)
                {
                    Win();
                }

                else
                {
                    Loose();
                }
            }
            if (button == "C")
            {
                if (correctAnswer == 2)
                {
                    Win();
                }

                else
                {
                    Loose();
                }
            }
            if (button == "D")
            {
                if (correctAnswer == 3)
                {
                    Win();
                }

                else
                {
                    Loose();
                }
            }
        }
    }

    private void displayAnswers()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            Debug.Log("Displayed!");
            if (i == correctAnswer)
            {

                buttons[i].GetComponent<Image>().color = right;

            }
                

            else
            {

                buttons[i].GetComponent<Image>().color = wrong;
            }
        }
    }


    private void Win()
    {
        SetQuestionText("Good Job!");
        StartCoroutine(LoadLevelAfterDelay(1, 3.0f));
    }

    private void Loose()
    {
        SetQuestionText("Try Again Next Time!");
        Destroy(GameObject.Find("UI"));
        Destroy(GameObject.Find("Player"));
        StartCoroutine(LoadRetryAfterDelay(3, 3.0f));
    }

    IEnumerator LoadLevelAfterDelay(int level, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(level);
    }

    IEnumerator LoadRetryAfterDelay(int level, float delay)
    {
        Debug.Log("RETRY");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(level);
    }
    



}
