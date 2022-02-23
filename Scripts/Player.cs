using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Left;
    public GameObject Center;
    public GameObject Right;
    public GameObject Bullet;

    Rigidbody2D Rigid;
    SpriteRenderer spriteRenderer;

    public float speed;
    public float maxShotDelay;
    public float currentShotDelay;

    // Start is called before the first frame update
    void Start()
    {
        Left.gameObject.SetActive(false);
        Right.gameObject.SetActive(false);
        Center.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Anim();
        WeaponReload();
        Fire();
    }

    void Fire()
    {
        

        if (currentShotDelay <= maxShotDelay)
            return;

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject bullet = Instantiate(Bullet, this.transform.position, this.transform.rotation);
            Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
            rigid.AddForce(Vector2.right * 10, ForceMode2D.Impulse);

            currentShotDelay = 0;

        }

    }

    void WeaponReload()
    {
        currentShotDelay += Time.deltaTime;
    }

    void Move()
    {
        float v = Input.GetAxisRaw("Vertical");

        Vector3 currentPosition = transform.position;
        Vector3 nextPosition = new Vector3(0, v, 0) * speed * Time.deltaTime;

        transform.position = currentPosition + nextPosition;
    }

    void Anim()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Right.gameObject.SetActive(false);
            Center.gameObject.SetActive(false);
            Left.gameObject.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Left.gameObject.SetActive(false);
            Center.gameObject.SetActive(false);
            Right.gameObject.SetActive(true);
        }
        else
        {
            Left.gameObject.SetActive(false);
            Right.gameObject.SetActive(false);
            Center.gameObject.SetActive(true);
        }
    }
}

