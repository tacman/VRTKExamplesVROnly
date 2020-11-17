using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // [RequireComponent(typeof(RigidBody))]
    public GameObject prefabObject;

    public int numberToGenerate = 10;
    public int frequency = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallSpawner());

    }

    private IEnumerator BallSpawner()
    {
        while (true)
        {
            Vector3 startPosition = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f));
            GameObject go = Instantiate(
                prefabObject, startPosition,
                Quaternion.identity);

            go.GetComponent<Rigidbody>().velocity = new Vector3(
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f));

            yield return new WaitForSeconds(frequency);
        }
    }
}
