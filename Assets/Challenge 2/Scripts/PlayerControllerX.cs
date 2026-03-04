using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canShootdog = true;
    private const float dogCooldown = 1f;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canShootdog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canShootdog = false;
            Invoke("ResetDog", dogCooldown);
        }
    }

    private void ResetDog()
    {
        canShootdog = true;
    }
}
