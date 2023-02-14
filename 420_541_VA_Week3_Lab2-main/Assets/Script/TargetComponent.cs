using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    // Start is called before the first frame update
 public GameObject game;
    private int score;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            GameManager.Instance.IncrementScore();
            game.SetActive(false);
            Invoke("show_target", 5);
        }
    }

void show_target(){
    game.SetActive(true);
        
    }


 


}