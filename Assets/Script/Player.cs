using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public GameManager gm;
    public BoxCollider2D c2D;
    public Rigidbody2D rb;
    public Sprite living;
    public Sprite dead;
    public bool isPowered;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

    }






    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            gm.TakeDamage();
            StartCoroutine(StopYouHaveViolatedTheLawPayTheCourtAFineOrServeYourSenctence());
        }
    }

    IEnumerator StopYouHaveViolatedTheLawPayTheCourtAFineOrServeYourSenctence()
    {
        float curSpeed = speed;
        speed = 0;
        GetComponent<SpriteRenderer>().sprite = dead;

        yield return new WaitForSeconds(3);
        speed = curSpeed;
        transform.position = new Vector2(Random.Range(-11, 11), Random.Range(-6, 6));
        GetComponent<SpriteRenderer>().sprite = living;
    }





}
