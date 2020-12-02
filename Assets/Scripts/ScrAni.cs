using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrAni : MonoBehaviour
{
    [SerializeField]
    GameObject explosio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScrControlJoc.controlAni)
        {
            StartCoroutine(Esquerda());
        }
        else
            StartCoroutine(Explosio());
    }


    IEnumerator Esquerda()
    {
        ScrControlJoc.controlAni = false;
        yield return new WaitForSeconds(0.7f);
        Instantiate(explosio, new Vector3(0, 0, 0), Quaternion.identity);

        Destroy(gameObject);
    }

    IEnumerator Explosio()
    {
        ScrControlJoc.controlAni = true;
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }
}
