using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : Pickup
{
    public GameObject[] snakes;
    public override void Activate()
    {
        snakes = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject snake in snakes)
        {
            snake.GetComponent<Enemy>().speed = 0;
        }
        StartCoroutine(STOP());


    }

    IEnumerator STOP()
    {
        

        yield return new WaitForSeconds(3);

        foreach (GameObject snake in snakes)
        {
            snake.GetComponent<Enemy>().speed = 2;
        }
        //1.) Wait

        //2.) Foreach
    }



}
