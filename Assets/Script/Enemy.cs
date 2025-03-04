using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody2D enemyrb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //enemyrb.AddForce((player.transform.position - transform.position).normalized * speed);
        transform.Translate((player.transform.position - transform.position).normalized * speed* Time.deltaTime);
    }
}
