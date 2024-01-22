using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    //clicker
    public TMP_Text scoretext;
    public float CurrentScore;
    public float hitPower;
    public float ScoreIncreasedPerSecond;
    public float x;

    //SHOP
    public int shop1prize;
    public TMP_Text shop1text;

    public int shop2prize;
    public TMP_Text shop2text;

    //AMMOUNT
    public int ammount1;
    public TMP_Text ammount1text;
    public float ammount1profit;

    public int ammount2;
    public TMP_Text ammount2text;
    public float ammount2profit;

    //UPGRADE
    public int upgradePrize;
    public TMP_Text upgradeText;

    //NEW
    public int allUpgradePrize;
    public TMP_Text allUpgradeText;

    //ACHIEVEMENT
    public bool achievementScore;
    public bool achievementShop;

    public Image image1;
    public Image image2;

    //LEVEL SYSTEM
    public int level;
    public int exp;
    public int expToNextLevel;
    public TMP_Text levelText;

    // HIGHEST SCORE
    public int bestScore;
    public TMP_Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //CLICKER
        CurrentScore = 0;
        hitPower = 1;
        ScoreIncreasedPerSecond = 1;
        x = 0f;

        // set all default variables before load 
        shop1prize = 25;
        shop2prize = 125;
        ammount1 = 0;
        ammount1profit = 1;
        ammount2 = 0;
        ammount2profit = 5;

        //RESET LINE
        PlayerPrefs.DeleteAll();

        //LOAD
        CurrentScore = PlayerPrefs.GetInt("CurrentScore", 0);  
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        x = PlayerPrefs.GetInt("x", 0);

        shop1prize = PlayerPrefs.GetInt("shop1prize", 25);
        shop2prize = PlayerPrefs.GetInt("shop2prize", 125);
        ammount1 = PlayerPrefs.GetInt("ammount1", 0);
        ammount1profit = PlayerPrefs.GetInt("ammount1profit", 0);
        ammount2 = PlayerPrefs.GetInt("ammount2", 0);
        ammount2profit = PlayerPrefs.GetInt("ammount2profit", 0);
        upgradePrize = PlayerPrefs.GetInt("upgradePrize", 50);

        allUpgradePrize = 500;

        //NEW
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //CLICKER
        scoretext.text = (int)CurrentScore + " $";
        ScoreIncreasedPerSecond = x * Time.deltaTime;
        CurrentScore = CurrentScore + ScoreIncreasedPerSecond;

        //SHOP
        shop1text.text = "Tier 1: " + shop1prize + " $";
        shop2text.text = "Tier 2: " + shop2prize + " $";

        //AMMOUNT
        ammount1text.text = "Tier 1: " + ammount1 + " arts $: "+ammount1profit+"/s";
        ammount2text.text = "Tier 2: " + ammount2 + " arts $: "+ammount2profit+"/s";

        //UPGRADE
        upgradeText.text = "Cost: " + upgradePrize + " $";

        //SAVE
        PlayerPrefs.SetInt("CurrentScore",(int)CurrentScore);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);
        PlayerPrefs.SetInt("x", (int)x);

        PlayerPrefs.SetInt("shop1prize", (int)shop1prize);
        PlayerPrefs.SetInt("shop2prize", (int)shop2prize);
        PlayerPrefs.SetInt("ammount1", (int)ammount1);
        PlayerPrefs.SetInt("ammount1profit", (int)ammount1profit);
        PlayerPrefs.SetInt("ammount2", (int)ammount2);
        PlayerPrefs.SetInt("ammount2profit", (int)ammount2profit);
        PlayerPrefs.SetInt("upgradePrize", (int)upgradePrize);

        allUpgradeText.text = "Cost: " + allUpgradePrize + " $";

        //NEW
        PlayerPrefs.SetInt("bestScore", bestScore);

        //ACHIEVEMENT
        if (CurrentScore>=50)
        {
            achievementScore = true;
        }

        if(ammount1 >= 2)
        {
            achievementShop = true;
        }

        if(achievementScore == true)
        {
            image1.color = new Color(1f,1f, 1f, 1f);
        }
        else
        {
            image1.color = new Color(0.2f, 0.2f, 0.2f, 0.2f);
        }

        if (achievementShop == true)
        {
            image2.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            image2.color = new Color(0.2f, 0.2f, 0.2f, 0.2f);
        }

        // LEVEL
        if(exp >= expToNextLevel)
        {
            level++;
            exp = 0;
            expToNextLevel *= 2;

        }
        levelText.text = level + " level";

        //HIGHEST SCORE
        if(CurrentScore > bestScore)
        {
            bestScore = (int)CurrentScore;
        }
        bestScoreText.text = bestScore + " Best Score";

    }

    //HIT
    public void Hit()
    {
        CurrentScore += hitPower;
        exp++;
    }

    //SHOP
    public void Shop1()
    {
        if(CurrentScore >= shop1prize)
        {
            CurrentScore -= shop1prize;
            ammount1 += 1;
            ammount1profit += 1;
            x += 1;
            shop1prize += 25;
        }
    }

    public void Shop2()
    {
        if (CurrentScore >= shop2prize)
        {
            CurrentScore -= shop2prize;
            ammount2 += 1;
            ammount2profit += 5;
            x += 5;
            shop2prize += 25;
        }
    }

    //UPGRADE
    public void Upgrade()
    {
        if(CurrentScore>=upgradePrize)
        {
            CurrentScore-=upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;
        }
    }

    //NEW
    public void AllProfitsUpgrade()
    {
        if(CurrentScore >= allUpgradePrize)
        {
            CurrentScore-=allUpgradePrize;
            x*=2;
            allUpgradePrize*=3;
            ammount1profit*=2;
            ammount2profit*=2;

        }
    }
}
