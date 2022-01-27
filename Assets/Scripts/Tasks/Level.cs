using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   
    [SerializeField] private GameObject[] emptyStars;
    [SerializeField] private GameObject[] fullStars;
    public int _checkStarsOnLvl;
    void Start()
    {
        foreach (var fullsStar in fullStars)
        {
            fullsStar.SetActive(false);
        }
    }

   public void ActivatorStarsov()
    {
        for (int i = 0; i < _checkStarsOnLvl; i++)
        {
            fullStars[i].SetActive(true);
        }
    }
   
    void Update()
    {
        
    }
}
