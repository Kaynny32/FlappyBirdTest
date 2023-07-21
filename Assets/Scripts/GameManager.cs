using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Spawner spawner;
    [SerializeField]
    Anim _anim;
    [SerializeField]
    List<GameObject> _panel = new List<GameObject>();
    [SerializeField]
    TextMeshProUGUI _textScore;

    float _spawnTimer = 2f;

    float _timer = 15f;
    public static GameManager instance = null;
    public float _pipeSpeed;
    public int _score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
        }
        else
        {
            _pipeSpeed++;
             _timer = 15f;          
        }
        _textScore.text = "" + _score;
    }

    void Start()
    {
        StartCoroutine(spawner.PipeSpawner(_spawnTimer));
    }

    public void Defeat()
    {
        _panel[0].SetActive(true);
        _anim.AnimPanelLose();
    }
}
