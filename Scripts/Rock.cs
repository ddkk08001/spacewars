using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float waitTime;
    private float currentTime;
    private float random;

    Rigidbody2D Rigid;

    public GameObject rock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= waitTime)
        {
            GameObject Rock = Instantiate(rock, new Vector3(7, random, 0), this.transform.rotation);
            Rigidbody2D rigid = Rock.GetComponent<Rigidbody2D>();
            rigid.AddForce(Vector2.left * 7, ForceMode2D.Impulse);

            currentTime = 0;
        }

        random = Random.Range(-4, 4);
    }

}
