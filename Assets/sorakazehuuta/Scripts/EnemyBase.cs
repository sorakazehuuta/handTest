using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    //MaxHP
    [SerializeField]
    int maxHp = 3;

    //HP
    int hp = 0;
    //attack flag
    bool canHit = true; 

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Init()
    {
        hp = maxHp;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Bullet" && canHit == true)
        {
            var bullet = collider.gameObject.GetComponent<Bullet>();
            bullet.OnEnemyHit();
            hp -= bullet.Attack;

            if(hp<=0)
            {
                OnDead();
            }
            else
            {
                Debug.Log(gameObject.name+"に攻撃がヒット。残りHP"+hp);
                StartCoroutine(HitWait());
            }
        }
    }

    void OnDead()
    {
        Debug.Log(gameObject.name+"を倒しました");
        Destroy(gameObject);
    }

    IEnumerator HitWait()
    {
        canHit = false;
        yield return new WaitForSeconds(0.5f);
        canHit = true;
    }


}
