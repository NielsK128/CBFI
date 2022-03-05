using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrades : MonoBehaviour
{
    public TMP_Text healthText;
    public int healthCost;
    public TMP_Text speedText;
    public int speedCost;
    public TMP_Text strengthText;
    public int strengthCost;
    public TMP_Text jumpText;
    public int jumpCost;
    public TMP_Text multiJumpText;
    public int multiJumpCost;
    public TMP_Text healthBoosterText;
    public int healthBoosterCost;
    public TMP_Text spikeWeaknessText;
    public int spikeWeaknessCost;
    public TMP_Text enemyGlowText;
    public int enemyGlowCost;
    public TMP_Text bulletSpeedText;
    public int bulletSpeedCost;
    public TMP_Text pistolLifetimeText;
    public int pistolLifetimeCost;


    public int cost = 2;
    private void Update()
    {
        healthText.text = "Current maxHP: " + PlayerPrefs.GetInt("health").ToString();
        speedText.text = "Current speed: " + PlayerPrefs.GetInt("speed").ToString();
        strengthText.text = "Current strength: " + PlayerPrefs.GetInt("strength").ToString();
        jumpText.text = "Current jump force: " + PlayerPrefs.GetInt("jump").ToString();
        multiJumpText.text = "Current multijumps: " + PlayerPrefs.GetInt("multijump").ToString();
        healthBoosterText.text = "Current health booster strength: 20 " + PlayerPrefs.GetInt("healthbooster").ToString();
        spikeWeaknessText.text = "Current damage dealt by spikes: " + PlayerPrefs.GetInt("spikedamage").ToString();
        if(PlayerPrefs.GetInt("enemyGlow") == 1) { enemyGlowText.text = "Enemy glow: enabled"; } else { enemyGlowText.text = "Enemy glow: disabled"; }
        bulletSpeedText.text = "Current bullet speed: " + PlayerPrefs.GetFloat("bulletspeed").ToString();
        pistolLifetimeText.text = "Current pistol bullet lifetime: " + PlayerPrefs.GetFloat("pistollifetime").ToString();
    }
    public void increaseHealth(int i)
    {
        if(GlobalClay.getClay() >= healthCost) {
        GlobalClay.removeClay(healthCost);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + i);
        } else {
        NotEnoughClay();
        }
    }

    public void increaseSpeed(int i)
    {
        if(GlobalClay.getClay() >= speedCost) {
        GlobalClay.removeClay(speedCost);
        PlayerPrefs.SetInt("speed", PlayerPrefs.GetInt("speed") + i); }
        else {
        NotEnoughClay();
        }
    }

    public void increaseStrength(int i)
    {
        if(GlobalClay.getClay() >= strengthCost) {
        GlobalClay.removeClay(strengthCost);
        PlayerPrefs.SetInt("strength", PlayerPrefs.GetInt("strength") + i); }
        else {
        NotEnoughClay();
        }
    }

    public void increaseJump(int i)
    {
        if(GlobalClay.getClay() >= jumpCost) {
        GlobalClay.removeClay(jumpCost);
        PlayerPrefs.SetInt("jump", PlayerPrefs.GetInt("jump") + i); }
        else {
        NotEnoughClay();
        }
    }
    public void increaseMultiJump(int i)
    {
        if(GlobalClay.getClay() >= multiJumpCost) {
        GlobalClay.removeClay(multiJumpCost);
        PlayerPrefs.SetInt("multijump", PlayerPrefs.GetInt("multijump") + i); }
        else {
        NotEnoughClay();
        }
    }
    public void increaseHealthBoosterStrength(int i)
    {
        if(GlobalClay.getClay() >= healthBoosterCost) {
        GlobalClay.removeClay(healthBoosterCost);
        PlayerPrefs.SetInt("healthbooster", PlayerPrefs.GetInt("healthbooster") + i); }
        else {
        NotEnoughClay();
        }
    }
    public void increaseSpikeWeakness(int i)
    {
        if(GlobalClay.getClay() >= spikeWeaknessCost) {
        GlobalClay.removeClay(spikeWeaknessCost);
        PlayerPrefs.SetInt("spikedamage", PlayerPrefs.GetInt("spikedamage") - i); }
        else {
        NotEnoughClay();
        }
    }
    public void enemyGlow() {
        if(GlobalClay.getClay() >= enemyGlowCost) {
        GlobalClay.removeClay(enemyGlowCost);
        PlayerPrefs.SetFloat("enemyGlow", 1); }
        else {
        NotEnoughClay();
        }
    }
    public void increaseBulletSpeed(int i)
    {
        if(GlobalClay.getClay() >= bulletSpeedCost) {
        GlobalClay.removeClay(bulletSpeedCost);
        PlayerPrefs.SetFloat("bulletspeed", PlayerPrefs.GetInt("bulletspeed") + i); }
        else {
        NotEnoughClay();
        }
    }
    public void increasePistolLifetime(int i)
    {
        if(GlobalClay.getClay() >= pistolLifetimeCost) {
        GlobalClay.removeClay(pistolLifetimeCost);
        PlayerPrefs.SetFloat("pistollifetime", PlayerPrefs.GetInt("pistollifetime") + i); }
        else {
        NotEnoughClay();
        }
    }



    public void deletePlayerprefs()
    {
        PlayerPrefs.DeleteKey("health");
        PlayerPrefs.DeleteKey("speed");
        PlayerPrefs.DeleteKey("strength");
        PlayerPrefs.DeleteKey("jump");
        PlayerPrefs.DeleteKey("multijump");
        PlayerPrefs.DeleteKey("healthbooster");
        PlayerPrefs.DeleteKey("spikedamage");
        PlayerPrefs.DeleteKey("bulletspeed");
        PlayerPrefs.DeleteKey("pistollifetime");
        PlayerPrefs.DeleteKey("enemyGlow");
        PlayerPrefs.DeleteKey("clay");
    }

    public void NotEnoughClay() {
        Debug.Log("Not enough clay :(");
    }
}
