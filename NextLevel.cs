using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameManager.Instance.LoadNextScene();
  
    }
}
