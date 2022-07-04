using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    private static Health instance;

    public Image[] hearts;

    private void Start()
    {
        updateHealth();
    }

    public void updateHealth()
    {

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void looseHealth(int hp)
    {
        if (health - hp > 0)
        {
            health -= hp;
            updateHealth();
            SceneManager.LoadScene(2);
        }
        else
        {
            Destroy(GameObject.Find("UI"));
            Destroy(GameObject.Find("Player"));
            SceneManager.LoadScene(3);
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this; // In first scene, make us the singleton.
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject); // On reload, singleton already set, so destroy duplicate.

        updateHealth();

    }

}
