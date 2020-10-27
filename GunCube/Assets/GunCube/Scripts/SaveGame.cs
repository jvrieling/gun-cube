﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveGame
{
    public string name;

    public float difficulty;
    public float recordDifficulty;

    public int score;
    public int highScore;

    public int kills;
    public int highKills;

    public int gold;
    public int totalGold;

    public ShooterData gun1;
    public ShooterData gun2;
    public ShooterData gun3;
    public ShooterData gun4;

    public SaveGame()
    {
        gun1 = new ShooterData();
        gun2 = new ShooterData();
        gun3 = new ShooterData();
        gun4 = new ShooterData();
    }

    public void CompleteRound(float diff, int shipsSunk, int goldEarned)
    {
        difficulty = diff;
        if (diff > recordDifficulty) recordDifficulty = diff;
        kills = shipsSunk;
        if (kills > highKills) highKills = kills;
        gold = goldEarned;
        totalGold += goldEarned;
    }
    public void CheckHighScore(int score)
    {
        this.score = score;
        if (score > highScore) highScore = score;
    }
    public void UpgradeGun(int index, Upgrade data)
    {
        switch (index)
        {
            case 1:
                gun1.UpgradeGun(data);
                break;
            case 2:
                gun2.UpgradeGun(data);
                break;
            case 3:
                gun3.UpgradeGun(data);
                break;
            case 4:
                gun4.UpgradeGun(data);
                break;
        }

    }
}
