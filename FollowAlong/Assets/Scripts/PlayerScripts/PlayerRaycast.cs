using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit result;
            bool thereWasHit = Physics.Raycast(transform.position, transform.forward, out result, Mathf.Infinity);

            Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0);

            if (thereWasHit)
            {
                CharacterController otherCharacter = result.collider.GetComponent<CharacterController>();
                if (otherCharacter != null)
                {
                    Destroy(result.collider.gameObject);
                }

                //Example PickupManager.GetInstance();
            }
        }
    }
}
