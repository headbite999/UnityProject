using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject loseMenu;
    
    public UnitStatus T1baseHP;
    public UnitStatus T2baseHP;

    public Animator T1animator;
    public Animator T2animator;

    public float T1coin = 0;
    public float T2coin = 0;
    public float maxDelay;
    public float curDelay;

    public Text textCoin;

    void Start()
    {
        
    }

    void Update()
    {
        coinUp();
        delayTime();
        textCoin.text = T1coin.ToString();

        if (T1baseHP.HP < 0)
        {
            LoseGame();
            
        }
        else if (T2baseHP.HP < 0)
        {
            WinGame();
        }
    }

    void coinUp()
    {
        if (curDelay < maxDelay)
        {
            return;
        }
        curDelay = 0;
        if (T1coin < 1000)
        {
            T1coin++;
        }
        if (T2coin < 1000)
        {
            T2coin++;
        }
        
    }

    void delayTime()
    {
        curDelay += Time.deltaTime;
    }

    void LoseGame()
    {
        T1animator.SetTrigger("loseTrigger");
        loseMenu.SetActive(true);
    }

    void WinGame()
    {
        T2animator.SetTrigger("loseTrigger");
        winMenu.SetActive(true);
    }
}
