using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D col;
    public float moveHorizontal;
    public float moveVertical;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      moveHorizontal = Input.GetAxis("Horizontal");
      moveVertical = Input.GetAxis("Vertical");
    }
}
