using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour {
    [SerializeField]
    private Transform[] gunsTransformList;
    [SerializeField]
    private float timeToFire = 2;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float bulletVelocity = 10;
    // Use this for initialization
    void Start () {
        StartCoroutine(Fire());
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private IEnumerator Fire()
    {
        while(true)
        {
            yield return new WaitForSeconds(timeToFire);
            foreach (Transform t in gunsTransformList) {
                GameObject bullet = Instantiate(bulletPrefab, t.position, t.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = t.right * bulletVelocity;
                Destroy(bullet, 5);

                    }
        }
    }
}
