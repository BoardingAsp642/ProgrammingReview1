using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Pickup
{
    public bool isPowered;
    public override void Activate()
    {

        StartCoroutine(Time());

    }


    IEnumerator Time()
    {
        player.isPowered = true;
   
        yield return new WaitForSeconds(5);
        player.isPowered = false;
    }

    



}
