using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{    
    private void Update()
    {
        transform.Translate(-GameManager.instance._pipeSpeed * Time.deltaTime,0,0);
    }
}
