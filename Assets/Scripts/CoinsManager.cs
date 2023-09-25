using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public static CoinsManager sharedInstance;
    
    private int coins;
    private int totalCoins;
    private AudioSource audioSource;

    [SerializeField] private GameObject winPlatform;
    
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

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        winPlatform.SetActive(false);
        GetTotalCoins();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            coins = totalCoins;
            if (coins >= totalCoins)
            {
                winPlatform.SetActive(true);
            }
        }
    }

    public void UpdateCoins()
    {
        coins++;
        UIManager.sharedInstance.SetCoinsText(coins);
        audioSource.PlayOneShot(audioSource.clip);

        if (coins >= totalCoins)
        {
            winPlatform.SetActive(false);
        }
    }
    
    private void GetTotalCoins()
    {
        totalCoins = FindObjectsOfType<Coin>().Length;
        UIManager.sharedInstance.SetTotalCoinsText(totalCoins);
    }
}
