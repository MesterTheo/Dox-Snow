using UnityEngine;

public class Player : MonoBehaviour
{
    // Variabler
    public float Speed = 55;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        Vector2 retning = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            retning += new Vector2(-1, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            retning += new Vector2(1, 0);
        }
        rb.linearVelocity = retning * Speed;
    }

}

