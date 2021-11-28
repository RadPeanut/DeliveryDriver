using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300.0f;
    [SerializeField] float moveSpeed = 20;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    [SerializeField] float timeToDestroyBooster = 0.5f;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Booster")
        {
            moveSpeed = boostSpeed;
            Destroy(collision.gameObject, timeToDestroyBooster);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        moveSpeed = slowSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
