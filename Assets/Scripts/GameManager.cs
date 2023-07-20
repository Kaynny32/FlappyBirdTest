using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Spawner spawner;
    [SerializeField]
    Anim _anim;
    [SerializeField]
    List<GameObject> _panel = new List<GameObject>();

    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        StartCoroutine(spawner.PipeSpawner(3f));
    }

    public void Defeat()
    {
        _panel[0].SetActive(true);
        _anim.AnimPanelLose();
    }
}
