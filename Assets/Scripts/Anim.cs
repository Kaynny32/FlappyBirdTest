using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField]
    GameObject animtext;
    [SerializeField]
    GameObject _button;

    [SerializeField]
    GameObject _backGround;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimBackGround(50));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimPanelLose()
    {
        animtext.transform.DOScale(new Vector3(1,1,1), 2f);
        _button.transform.DOScale(new Vector3(1, 1, 1), 3.5f);
    }

    /*private void AnimBackGround()
    {
        _backGround.transform.DOMoveX(-5.9f, 100f).Loops();
    }*/
    IEnumerator AnimBackGround(int time)
    {
        while (true)
        {
            _backGround.transform.DOMoveX(-5.9f, 50f);
            yield return new WaitForSeconds(time);
            _backGround.transform.position = new Vector3(5.9f, 0.0934f,10f);
        }
    }
}
