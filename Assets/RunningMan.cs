using UnityEngine;

public class RunningMan : MonoBehaviour
{
    public float speed = 0.5f;

    private Rigidbody2D rb;
    //public Animation animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")>0)
        {
            rb.linearVelocity = new Vector2(speed, 0f);
            //animator.SetBool
        }
        
    }
}
