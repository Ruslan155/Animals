using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonManager : MonoBehaviour
{

    [SerializeField] private Button openForestButton;
    [SerializeField] private Button openPetButton;
    [SerializeField] private Button openWaterButton;
    

    private void Start()
    {
        Initialization();
    }

    void Initialization()
    {
        if (openForestButton != null)
        {
            openForestButton.onClick.RemoveAllListeners();
            openForestButton.onClick.AddListener(()=>
            {
                SceneManager.LoadScene(1);
            });
        }

        if (openPetButton != null)
        {
            openPetButton.onClick.RemoveAllListeners();
            openPetButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(2);
            });
        }

        if (openWaterButton != null)
        {
            openWaterButton.onClick.RemoveAllListeners();
            openWaterButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(3);
            });
        }
    }
}
