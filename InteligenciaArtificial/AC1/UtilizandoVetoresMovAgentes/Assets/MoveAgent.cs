using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgent : MonoBehaviour
{
    //Alvo a ser movido
    public GameObject target;

    void Update()
    {
        //Transfere ao método mover esse game object
        Mover(this.gameObject);
    }

    void Mover(GameObject myGameObject)
    {
        //Move o gameobject recebido até o gameobject alvo
        myGameObject.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, target.transform.position, 0.01f);
    }
}
