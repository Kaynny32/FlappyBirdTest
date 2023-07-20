using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float force;
    [SerializeField]
    Rigidbody2D _rb2D;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb2D.velocity = Vector2.up * force;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PipeMove>())
        {
            GameManager.instance.Defeat();
        }
        if (collision.gameObject.GetComponent<Triger>())
        {
            GameManager.instance.Defeat();
        }
    }   
}
