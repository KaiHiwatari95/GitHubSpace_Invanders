using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{

    public Transform bulletSpawnPosition;
    public CreateBullet createBullet;
    public float bulletSpeed = 1.0f;

    public float fireRate = 0.1f;
    public int burstRate = 1;

    bool isShooting = false;

    SpriteRenderer spriteRenderer;
    public int damage = 1;
    bool CoRoutineHasStarted = false;
    public Vector2 shootDirection;

    Countdown countdown;

    // Start is called before the first frame update
    void Start()
    {

        countdown = GameObject.FindObjectOfType<Countdown>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        

        //DestroyMeAfterSomeSeconds(); // SOFORT
        //Invoke("DestroyMeAfterSomeSeconds", 1.0f); // NACH EINER SEK
        //Destroy(gameObject, 1.0f); // NACH EINER SEK
        //StartCoroutine("FlickerAndDie"); //CoRoutine!!!!


    }

    // Update is called once per frame
    void Update()
    {

        if (CoRoutineHasStarted == false)
        {
            StartCoroutine("FlickerAndDie"); // Wird gestarted; ABKAPSELUNG; 2 STRANGE - Aufgabelung
            CoRoutineHasStarted = true;
        }


        if (createBullet != null)
        {

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {

                Vector2 shootDirection = new Vector2(Input.GetAxis("Horizontal"), 1);

                createBullet.ShootProjectile(bulletSpawnPosition.position, shootDirection, bulletSpeed);

            }



            if (Input.GetKeyDown(KeyCode.W))
            {

                Vector2 shootDirection = new Vector2(Input.GetAxis("Horizontal"), 1);

                createBullet.ShootProjectile(bulletSpawnPosition.position, shootDirection, bulletSpeed);

            }



            if (Input.GetKeyDown(KeyCode.Space))
            {

                Vector2 shootDirection = new Vector2(Input.GetAxis("Horizontal"), 1);

                createBullet.ShootProjectile(bulletSpawnPosition.position, shootDirection, bulletSpeed);

            }

        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            
            countdown.AddTime(4);

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
            createBullet.ShootProjectile(bulletSpawnPosition.position, shootDirection, bulletSpeed);

        }
        isShooting = false;


    }

    private void DestroyMeAfterSomeSeconds()
    {

        Destroy(gameObject);

    }



}

