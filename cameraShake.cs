using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    Transform camTrans;

    public float shakeTime;
    public float shakerange;
    Vector3 orignalPosition;
    // Start is called before the first frame update
    void Start()
    {
        camTrans = Camera.main.transform;
        orignalPosition = camTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(ShakeCamera());
        }
    }

    IEnumerator ShakeCamera()
    {
        float elapsedTime = 0;
        while (elapsedTime < shakeTime)
        {
            Vector3 pos = orignalPosition + Random.insideUnitSphere * shakerange;
            pos.z = camTrans.position.z;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        camTrans.position = orignalPosition;
    }
}
