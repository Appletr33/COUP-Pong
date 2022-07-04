using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int goal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            if (goal == 1)
            {
                GameObject.Find("UI").gameObject.transform.Find("Canvas").gameObject.SetActive(false);
                Debug.Log("Damaged");
                GameObject.Find("Player").GetComponent<Health>().looseHealth(1);
                Time.timeScale = 0;
            }
            else
            {
                Destroy(GameObject.Find("UI"));
                Destroy(GameObject.Find("Player"));
                SceneManager.LoadScene(4);
            }
        }
    }
}
