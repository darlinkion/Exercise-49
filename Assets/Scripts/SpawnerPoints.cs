using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{

    [SerializeField] private GameObject _tempMob;
    [SerializeField] private int _count;
    [SerializeField] private float _radius;

    private void Start()
    {
        StartCoroutine(SpawnMob());
    }


    private IEnumerator SpawnMob()
    {
        int stepAngly = 360 / _count;
        var waitForTwoSeconds = new WaitForSeconds(2);

        for (int i = 0; i < _count; i++)
        {
            GameObject newObject = Instantiate(_tempMob, new Vector3(0, 0, 0), Quaternion.identity);

            Transform tempObjectTransform = newObject.GetComponent<Transform>();

            tempObjectTransform.position = new Vector3(_radius * (Mathf.Cos(stepAngly * i * Mathf.Deg2Rad)), 0, _radius * (Mathf.Sin(stepAngly * i * Mathf.Deg2Rad)));

            yield return waitForTwoSeconds;
        }
    }
}
