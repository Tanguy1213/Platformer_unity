using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private int lifes = 3;
    private int enemyLife = 3;
    
    [SerializeField]
    private Text textLifes;
    private const string TEXT_LIFES = "Lifes : ";


	// Use this for initialization
	void Start () {
        textLifes.text = TEXT_LIFES + lifes;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Attack(int damage)
    {
        enemyLife -= damage;
        if (enemyLife <= 0)
        {
            SceneManager.LoadScene("WinMenu");
        }
      
    }

    public void TakeDamage(int damage)
    {
        lifes -= damage;
        if (lifes <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            textLifes.text = TEXT_LIFES + lifes;
        }

    }


    public void PlayerDie()
    {
        lifes--;
        if (lifes <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            textLifes.text = TEXT_LIFES + lifes;
        }
    }
    public void AddLifePoints()
    {
        lifes++;
        textLifes.text = TEXT_LIFES + lifes;
        Destroy(GameObject.FindGameObjectWithTag("Lifes"));
        
    }
}
