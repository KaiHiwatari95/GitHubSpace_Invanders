using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{

    public Rigidbody2D projectile;

    public float timeBetweenShots;
    public float nextShot = -1;
    public GameObject bullet;





    // Start is called before the first frame update
    void Start()
    {
        nextShot = Random.Range(1, 3.0f);
        timeBetweenShots = Random.Range(3, 6.5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextShot)
        {

            Instantiate(bullet, transform.position, Quaternion.identity);
            nextShot = Time.time + timeBetweenShots;

        }


    }

    public void ShootProjectile(Vector3 _spawnPosition, Vector2 _shootDirection, float _bulletSpeed)
    {

        Rigidbody2D projectileClone = Instantiate(projectile, _spawnPosition, transform.rotation) as Rigidbody2D;
        projectileClone.AddForce(Vector2.up * _bulletSpeed, ForceMode2D.Impulse);

    }
}

