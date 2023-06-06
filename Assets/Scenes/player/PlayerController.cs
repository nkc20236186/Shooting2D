using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 dir = Vector3.zero;//ˆÚ“®•ûŒü‚ğ•Û‘¶‚·‚é•Ï”
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9, 9f);
        pos.y = Mathf.Clamp(pos.y, -5, 5f);
        transform.position = pos;
    }
}
