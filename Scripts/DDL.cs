using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDL : MonoBehaviour
{
    private static DDL instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; // In first scene, make us the singleton.
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject); // On reload, singleton already set, so destroy duplicate.

        instance.gameObject.SetActive(true);
        foreach (Transform child in instance.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
