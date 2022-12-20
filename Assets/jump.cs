using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private float horizontal;
    private bool kijken = true;
    public float jumpPower = 0;

    public Rigidbody2D myRigidbody;

    public float links = 3;
    public float rechts = 3;

    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && Isonground())
        {
            myRigidbody.velocity = Vector2.up * jumpPower;
        }
        if (Input.GetKeyDown(KeyCode.Space) && myRigidbody.velocity.y > 0f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y * 0.5f);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-Vector3.right * links * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * rechts * Time.deltaTime);
        }
        flip();

    }
    private bool Isonground()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundLayer);
    }

    private void flip()
    {
        if (kijken && horizontal < 0f || !kijken && horizontal > 0f)
        {
            kijken = !kijken;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}

