using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private void FixedUpdate()
    {
        rb2d.AddForce(new Vector2(5f, 0f));
    }
}
