using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 2.5f * horizontal * Time.deltaTime;
        position.y = position.y + 2.5f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
