using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Left;
    public GameObject Center;
    public GameObject Right;

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
        
    }
}
