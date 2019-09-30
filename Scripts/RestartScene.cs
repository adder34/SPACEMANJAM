using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    public int playerHealth;
    private void OnCollisionEnter2D(Collision2D other)
    {


       

        if (other.gameObject.name == "Deathbox")
        {

            transform.position = new Vector2(-5.549f, -4.04f);
            transform.eulerAngles = new Vector2(0f, 0f); 
            playerHealth = playerHealth - 1;
            if (playerHealth == 0)
            {
                SceneManager.LoadScene("Dead");
            }
        }
        if (other.gameObject.name == "Enemy")
        {

            transform.position = new Vector2(-5.549f, -4.04f);
            transform.eulerAngles = new Vector2(0f, 0f);
            playerHealth = playerHealth - 1;
            if (playerHealth == 0)
            {
                SceneManager.LoadScene("Dead");
            }
        }


    }

}
