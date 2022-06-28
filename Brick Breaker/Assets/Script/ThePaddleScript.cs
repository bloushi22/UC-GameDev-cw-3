using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThePaddleScript : MonoBehaviour
{
    Rigidbody2D PaddleRB;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        PaddleRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        PaddleRB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,0f);
    }
}
