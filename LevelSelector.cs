using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] Button lvl1;
    [SerializeField] Button lvl2;
    [SerializeField] Button lvl3;
    [SerializeField] Button mainmenu;


    void Start()
    {
      


        lvl1.onClick.AddListener(GameManager.Instance.GoToLevel1);

        lvl2.onClick.AddListener(GameManager.Instance.GoToLevel2);

        lvl3.onClick.AddListener(GameManager.Instance.GoToLevel3);


        mainmenu.onClick.AddListener(GameManager.Instance.GoToMenu);


    }

}
