using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Left;
    public GameObject Center;
    public GameObject Right;

    public float speed;

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
        float v = Input.GetAxisRaw("Vertical");

        Vector3 currentPosition = transform.position;
        Vector3 nextPosition = new Vector3(0, v, 0) * speed * Time.deltaTime;

        transform.position = currentPosition + nextPosition;

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
