using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float jump_height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_movement = Input.GetAxis("Horizontal");
        float check_for_jump = Input.GetAxis("Jump");
        transform.Translate(Vector3.right * horizontal_movement * Time.deltaTime * speed);
        transform.Translate(Vector3.up * check_for_jump * Time.deltaTime * jump_height);
    }
}
