using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text coinsText;
    public int coins;
    private int totalCoins;

    public int targets;
    private int totalTargets;

    public static GameController instance;

    void Start()
    {
        instance = this;
        totalCoins = PlayerPrefs.GetInt("coins");
        totalTargets = PlayerPrefs.GetInt("targets");
        coinsText.text = "Coins: " + totalCoins.ToString();

    }

    public void UpdateCoins()
    {
        coins++; 
        totalCoins++;
        coinsText.text = "Coins: "+totalCoins.ToString();
        PlayerPrefs.SetInt("coins", totalCoins);
    }

    public void UpdateTargets()
    {
        
        if (targets == totalTargets) 
        {
            targets++;
            totalTargets++;
        }
        else
        {
            targets++;
        }
        PlayerPrefs.SetInt("targets", totalTargets);

        

        
    }

    public int getTotalTargets()
    {
        totalTargets = PlayerPrefs.GetInt("targets");
        return totalTargets;
    }
}
