using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    bool open = false;
    public GameObject link;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (open)
            {
                this.transform.Translate(0, -5f, 0);
                link.SetActive(false);
            }
            else
            {
                this.transform.Translate(0, 5f, 0);
                link.SetActive(true);
            }

            open = !open;
        }
    }
}
