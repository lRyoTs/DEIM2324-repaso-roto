using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UIManagerMainMenu : MonoBehaviour
{
    public static UIManagerMainMenu sharedInstance;
    
    [SerializeField] private GameObject instructionsPanel;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Nos aseguramos de que al empezar el panel de instrucciones está oculto
        HideInstructionsPanel();
    }

    public void ShowInstructionsPanel()
    {
        instructionsPanel.SetActive(true);
    }

    public void HideInstructionsPanel()
    {
        instructionsPanel.SetActive(false);
    }

}
