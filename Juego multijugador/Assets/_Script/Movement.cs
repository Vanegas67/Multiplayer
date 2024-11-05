using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviourPunCallbacks
{

    public float velPlayer = 5;
   
    void Start()
    {
        
    }

 
    void Update()
    {
      if (photonView.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 displacement = new Vector3(moveHorizontal, 0, moveVertical) * velPlayer * Time.deltaTime;
            transform.Translate(displacement);
        }
    }
}
