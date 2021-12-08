using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens_Bullet : MonoBehaviour
{

    public Transform spawnPosition;
    public Vector2 shootDirection;
    public float bulletSpeed;


    public float fireRate = 0.1f;
    public int burstRate = 1;


    public CreateBullet createBullet;
    bool isShooting = false;

    SpriteRenderer spriteRenderer;
    public int damage = 1;
    bool CoRoutineHasStarted = false;

    private bool damageSent;


    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (CoRoutineHasStarted == false)
        {
            StartCoroutine("FlickerAndDie"); // Wird gestarted; ABKAPSELUNG; 2 STRANGE - Aufgabelung
            CoRoutineHasStarted = true;
        }




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            collision.SendMessage("ApplyDamage", damage);

        }

        if (collision.CompareTag("AttackTriggerZone"))
        {

            if (isShooting == false)
            {
                StartCoroutine("FirePatternOne");
                isShooting = true;
            }

        }


    }



    IEnumerator FlickerAndDie()
    {

        /*spriteRenderer.color = Color.black;
        
        yield return new WaitForSeconds(0.5f);

        spriteRenderer.color = Color.green;

        yield return new WaitForSeconds(0.5f);

        //Destroy(gameObject);
        */

        for (int i = 0; i < burstRate; i++)
        {


            yield return new WaitForSeconds(fireRate);
            createBullet.ShootProjectile(spawnPosition.position, shootDirection, bulletSpeed);

        }
        isShooting = false;


    }

    private void DestroyMeAfterSomeSeconds()
    {

        Destroy(gameObject);

    }


}
