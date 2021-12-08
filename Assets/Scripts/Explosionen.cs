using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosionen : MonoBehaviour
{
    public Rigidbody2D Explosion;
    public float hp;



    public void ApplyDamage(int _damageValue)
    {

        hp -= _damageValue;

        if (hp <= 0)
        {
            Instantiate(Explosion, transform.position, transform.rotation);
           
            GameManager.manager.spawner.Remove(gameObject);
         
            Destroy(gameObject);


        }


    }
}
