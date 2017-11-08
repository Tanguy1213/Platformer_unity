using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletManager : MonoBehaviour {
    private int damage = 1;

    private GameManager gameManager;
	// Use this for initialization
	void Start () {
        gameManager = GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemy" && gameObject.tag == "bullets")
        {
            gameManager.Attack(damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Enemy" && gameObject.tag == "EnemyBullet")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Player" && gameObject.tag == "EnemyBullet")
        {
            gameManager.TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && gameObject.tag == "bullets")
        {
            Destroy(gameObject);
        }
    }
}
