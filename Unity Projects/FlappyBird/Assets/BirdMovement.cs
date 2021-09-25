using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private float hspeed = 5f;
    
    [SerializeField]
    private float vspeed = 5f;

    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(new Vector2(hspeed, 0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
