﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerButtons : MonoBehaviour
{
    public void LoadScene(string scenName)
    {
        SceneManager.LoadScene(scenName);
    }

}
