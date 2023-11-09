using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int attack = 1;

    float speed = 10f;

    float lifeTime = 100f;

    public Rigidbody rb;

    public int Attack
    {
        get{return attack;}
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        Destroy(gameObject,lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward*speed*Time.deltaTime;
    }
    public void OnEnemyHit()
    {
        Debug.Log(gameObject.name+"に攻撃がヒット。残りHP");
        //Destroy(gameObject);

        Destroy(this.gameObject,10);
    }
}
