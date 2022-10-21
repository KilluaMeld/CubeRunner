using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera _camera;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Vector3 newPos = new Vector3(this.gameObject.transform.position.x, 0.5f, hit.point.z);
                if (newPos.z >= 3.5f)
                {
                    newPos.z = 3.5f;
                }
                else if (newPos.z <= -3.5f)
                {
                    newPos.z = -3.5f;
                }
                this.gameObject.transform.position = newPos;
            }
        }
    }
}
