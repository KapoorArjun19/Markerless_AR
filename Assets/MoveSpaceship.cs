using System.Collections;
using UnityEngine;

public class MoveSpaceship : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("Move");
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * 3f * Time.deltaTime);
    }

    private IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.5f);
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }
    }
}
