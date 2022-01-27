using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StarsCheck : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private GameObject[] emptyStars;
    [SerializeField] private GameObject[] fullStars;
    private bool _levelIsActive = false;
    
   private Level level;


    void Start()
    {
        
        scorePanel.SetActive(false);
        menuPanel.SetActive(true);
    }
    
    
    void Update()
    {
        if (_levelIsActive == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ActivateStars(1);
                level._checkStarsOnLvl++;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ActivateStars(2);
                level._checkStarsOnLvl++;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                level._checkStarsOnLvl++;
              ActivateStars(3);
            }
            
        }
    }

    public void ThisLevel(Level thislevel)
    {
        level = thislevel;
    }
    public void StartLevel()
    {
        menuPanel.SetActive(false);
        _levelIsActive = true;
        ShowScore();
    }

    public void ShowScore()
    {
        foreach (var fullsStar in fullStars)
        {
            fullsStar.SetActive(false);
        }
        scorePanel.SetActive(true);
       
    }

    public void ShowMenu()
    {
       
        scorePanel.SetActive(false);
        menuPanel.SetActive(true);
        level.ActivatorStarsov();
    }

    private void ActivateStars(int amount)
    {
        for (var i = 0; i < emptyStars.Length; i++)
        {
            fullStars[i].SetActive(i < amount);
        }
        
    }
}
