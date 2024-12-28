using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Lava")
        {
            Debug.Log("Game Over");
            gameOver.SetActive(true);
        }
    }
}
