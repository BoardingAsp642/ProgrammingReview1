using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{


    public BoxCollider2D bc;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Activate()
    {

    }

    IEnumerator DelayedDestroy()
    {
        bc.enabled = false;
        sr.enabled = false;
        yield return new WaitForSeconds(5);
    }

     public void OnTriggerEnter2D()
    {
        Activate();
        StartCoroutine(DelayedDestroy());
    }























}





