﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CControl : MonoBehaviour
{
    public Text answer;
    private bool correctanswer;

    // Start is called before the first frame update
    void Start()
    {
        answer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //Set text and whether or not it's the right answer depending on which question is loaded.
        if (PlayerPrefs.GetInt("Question") == 0)
        {
            answer.text = "Fish";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Mud";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Africa and South America";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "C3";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "C4";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "C5";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "C6";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "C7";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "C8";
            correctanswer = false;
        }
    }
    public void ChangeToScene(int changeTheScene)
    {
        //When clicked, send to the "Correct" scene if it's right, "Incorrect" scene if it's wrong
        if (correctanswer == true)
        {
            changeTheScene = 4;
        }
        if (correctanswer == false)
        {
            changeTheScene = 5;
        }
        SceneManager.LoadScene(changeTheScene);
    }
}