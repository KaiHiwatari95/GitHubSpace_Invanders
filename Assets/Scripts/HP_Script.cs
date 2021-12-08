using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Script : MonoBehaviour
{

    public GameObject[] LebensPunkte;
    private int hp;
    private bool GameOver;
    public Rigidbody2D Explosion;

    SceneLoader sceneLoader;


    private void Start()
    {
        hp = LebensPunkte.Length;
    }

    void Update()
    {
       if(GameOver == true)
        {

            sceneLoader.LoadScene("EndScreen");

        }
    }

    public void ApplyDamage(int _damageValue)
    {

        

        if (hp >= 1)
        {

            hp -= _damageValue;

            Destroy(LebensPunkte[hp].gameObject);

            if (hp < 1)
            {
                Instantiate(Explosion, transform.position, transform.rotation);

                GameManager.manager.spawner.Remove(gameObject);

                GameOver = true;

                Destroy(gameObject);
            }

        }


    }


}
