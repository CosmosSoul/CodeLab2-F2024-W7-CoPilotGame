using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 5.0f;
        float rotateSpeed = 100.0f;

        float move = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * rotate * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * move * moveSpeed * Time.deltaTime);
    }
}