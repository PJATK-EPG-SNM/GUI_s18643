using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{

    //private Animator anim;
    //private float animationTime = 0;
    private ScoreManager scoreManager;
    private bool collected;
    public int points = 1;
    void Start(){
        scoreManager = GameObject.Find("ScoreManagerObject").GetComponent<ScoreManager>(); //kropka tzn że druga metoda tyczy się wyniku pierwszej metody
        collected = false;

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player") && !collected)
        {   //! sprawdza, czy wartosc connected jest false
            collected = true;
            scoreManager.IncrementScore(points);
           // anim.SetTrigger("collected");                                  ANIMACJA
           Invoke("CollectCoin", 1.5f);

        }
    }



    private void CollectCoin()
    {
        Destroy(gameObject);
    }
}
