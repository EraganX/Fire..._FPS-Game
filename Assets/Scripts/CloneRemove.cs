using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneRemove : MonoBehaviour
{
    [SerializeField] GameObject info;
    private Score scoreScript;

    private void Start()
    {
        scoreScript = info.GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Civil"))
        {
            scoreScript.civilSaved++;
            Destroy(obj.gameObject);
            
        }

        if (obj.gameObject.CompareTag("Targets"))
        {
            scoreScript.enemyMissed++;
            Destroy(obj.gameObject);

        }
    }
}
