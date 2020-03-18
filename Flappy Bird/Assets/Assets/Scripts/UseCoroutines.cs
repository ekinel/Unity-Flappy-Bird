using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCoroutines : MonoBehaviour
{
    public GameObject columnPrefab;

    void Start()
    {
        StartCoroutine(CloneColumnPrefab());
    }


    IEnumerator CloneColumnPrefab()
    {
        while (true)
        {
            Instantiate(columnPrefab, new Vector3(2.0f, Random.Range(-3.57f, 0.95f), -1.06f), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
    }
}
