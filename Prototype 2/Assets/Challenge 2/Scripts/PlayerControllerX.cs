using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0.75f;
    private float updatedTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog & start cooldown
        if (Input.GetKeyDown(KeyCode.Space) & Time.time - updatedTime > cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            updatedTime = Time.time;
        }
    }
}
