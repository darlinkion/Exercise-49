using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{

    [SerializeField] private GameObject _tempMob;
    [SerializeField] private int _numberMobs;
    [SerializeField] private Transform[] _points;

    private void Start()
    {
        StartCoroutine(SpawnMob());
    }

    private IEnumerator SpawnMob()
    {
        var waitForTwoSeconds = new WaitForSeconds(2);

        for (int i = 0; i < _numberMobs; i++)
        {
            GameObject newObject = Instantiate(_tempMob, new Vector3(0, 0, 0), Quaternion.identity);

            Transform tempObjectTransform = newObject.GetComponent<Transform>();

            tempObjectTransform.position = _points[Random.Range(0, _points.Length)].position;

            yield return waitForTwoSeconds;
        }
    }
}
