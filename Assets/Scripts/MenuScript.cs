using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public GameObject WallMenu;
    public GameObject GameMarcer;
    void Start(){
        GameMarcer.SetActive(false);
    }
    public void Play()
    {
      WallMenu.SetActive(false);
      GameMarcer.SetActive(true);
    }
    public void Menu()
    {
       WallMenu.SetActive(true);
       GameMarcer.SetActive(false);       
    }
    public void Exit()
    {
        Application.Quit();
    }

}
