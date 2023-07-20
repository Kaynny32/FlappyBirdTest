using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _prefabsPipes = new List<GameObject>(); 
    public IEnumerator PipeSpawner(float time)
    {
        while (true) 
        {
            yield return new WaitForSeconds(time);
            float rand = Random.Range(-2f, 4f);
            int randI = Random.Range(0, 1);
            GameObject clone = Instantiate(_prefabsPipes[randI], new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(clone, 5f);
        }
    }
}
