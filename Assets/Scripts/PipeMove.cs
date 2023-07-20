using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime,0,0);
    }
}
