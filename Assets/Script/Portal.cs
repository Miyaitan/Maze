using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField] private string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Circle>() is not null)
        {
            Next();
        }
    }

    private void Next()
    {
        if (nextScene.Equals(""))
        {
            Debug.LogWarning("Next scene is empty");
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
