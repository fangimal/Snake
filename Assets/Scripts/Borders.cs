﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class Borders : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
                SceneManager.LoadScene(0);
    }
}
