using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int score;
    public int bonus;
    private int autoclickbonus;

    [SerializeField]

    public int[] ShopBonuses;
    public int[] ShopPrices;
    public Text[] ShopBtnTexts;

 /*   private void Awake()
    {
        SavingData savingdata = new SavingData
        {
            ShopPrices = new int[10] ///ДОДЕЛАТЬ 
        };
        string json = JsonUtility.ToJson(savingdata);
        Debug.Log(json);
    }
 */
    void Start()
    {
        //saves
        score = PlayerPrefs.GetInt("Score", 0);
        bonus = PlayerPrefs.GetInt("Bonus", 1);
        autoclickbonus = PlayerPrefs.GetInt("AutoClickBonuses", 0);
        //bonuses
        StartCoroutine(BonusPerSec());
        //
        //scores show
        ShowScore();
        //
    }
    void Update()
    {
        ShowScore();
    }

    public void ChangeScore()
    {
        score += bonus;
        ShowScore();
    }
    void ShowScore()
    {
        ScoreText.text = Convert();
    }
    public void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Bonus", bonus);
        PlayerPrefs.SetInt("AutoClickBonuses", autoclickbonus);
        // PlayerPrefs.SetInt("ShopPrices", ShopPrices) = new int[]
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public string Convert()
    {
        if (score < 1000) return "$" + score;
        if (score < 1000000) return ("$" + score / 1000f) + "k";
        if (score < 1000000000) return ("$" + score / 1000000f) + "m";
        return (score / 1000000000f) + "g";
    }
    public void ClearScore()
    {
        PlayerPrefs.DeleteAll();
    }
    /*=================================Saving JSON ====================================*/
   /* private class SavingData{
        public int[] ShopPrices;

    }
    /*================================= Shop Section ==================================*/
    public void AddBonus(int index)
    {
        if (score >= ShopPrices[index])
        {
            bonus += ShopBonuses[index];
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Присутствие на Работе \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно:" + ShopPrices[index]);
        }
    }
    /*==============================AutoClick=======================================*/
    public void BonusClickSec(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus++;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Нанять Рабочего \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecTwo(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 5;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Маленькое Предприятие \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecThree(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 10;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Среднее Предприятие \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecFour(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 20;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Крупное Предприятие \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecFive(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 25;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Ферму \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecSix(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 40;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Небольшую Фабрику \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecSeven(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 80;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Фабрику по производству красок \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecEight(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 110;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Купить Завод \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecNine(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 160;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Создать Компанию для слежки за бизнесами \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    public void BonusClickSecTen(int index)
    {
        if (score >= ShopPrices[index])
        {
            autoclickbonus += 250;
            score -= ShopPrices[index];
            ShopPrices[index] *= 2;
            ShopBtnTexts[index].text = "Сделать Сеть Магазинов \n" + ShopPrices[index] + "$";
        }
        else
        {
            Debug.Log("Недостаточно денег. Нужно: " + ShopPrices[index]);
        }
    }
    IEnumerator BonusPerSec()
    {
        while (true)
        {
            score += autoclickbonus;
            yield return new WaitForSeconds(1);
        }
    }
}
