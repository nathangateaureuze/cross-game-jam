using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_cylinder : MonoBehaviour
{
    [SerializeField] GameObject line;

    private int boubouboubouboub;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void fortnitesauverlemondepasbattleroyal()
    {
        DOTween.KillAll();

        transform.position = new Vector3(0, 2, -4);
        transform.rotation.Set(90, 0, 0, 0);

        boubouboubouboub = Random.Range(1, 101);
        if (0 < boubouboubouboub && boubouboubouboub < (line.GetComponent<Script_trace>().nscore > 90 ? 90: line.GetComponent<Script_trace>().nscore))
        {
            transform.DOMoveX(transform.position.x + Random.Range(-3,3), Random.Range(2f , 4.5f)).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        }
        boubouboubouboub = Random.Range(1, 101);
        if (0 < boubouboubouboub && boubouboubouboub < (line.GetComponent<Script_trace>().nscore > 90 ? 90 : line.GetComponent<Script_trace>().nscore))
        {
            transform.DOMoveY(transform.position.y + Random.Range(-3, 3), Random.Range(2f , 4.5f)).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        }
    }
}