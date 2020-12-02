using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrRoca : MonoBehaviour
{

    [SerializeField]
    GameObject esquerda;
    Vector3 posEsquerda = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            StartCoroutine(DestruccioRoca());
        }

    }
    IEnumerator DestruccioRoca()
    {

        yield return new WaitForSeconds(0.05f);
        Instantiate(esquerda, posEsquerda, Quaternion.identity);
        Destroy(gameObject);
        print("Tudo Bem");

        /*yield return new WaitForSeconds(0.05f);
        Destroy(gameObject);

        yield return new WaitForSeconds(0.05f);
        Instantiate(explosio, posEsquerda, Quaternion.identity);

        yield return new WaitForSeconds(1.0f);
        Destroy(explosio);*/

    }

}
