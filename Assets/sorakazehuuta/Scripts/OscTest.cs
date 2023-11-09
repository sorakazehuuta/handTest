using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OscJack;

public class OscTest : MonoBehaviour
{

    public GameObject ringCon;
    public int shapeKeyIndex;
    public float shapeKeyWeight;
    private SkinnedMeshRenderer skinnedMeshRenderer;
    public GameObject bulletPrefab;
    public Transform firepoint;
    public float value;

    private bool fireFlag = false;//フラグ追加

    void Start()
    {
        
        skinnedMeshRenderer = ringCon.GetComponent<SkinnedMeshRenderer>();
    }

    public void Update()
    {
        if(shapeKeyWeight>30)
        {
            if(fireFlag == false)
            {
                fireFlag = true;
                Fire();
            }
            
        }
        else
        {
            fireFlag = false;
        }
    }

    public void OnMessage(float value)
    {

        //Debug.Log("�ł��������");
        shapeKeyWeight = 100 - value*700+value*80+520;
        Debug.Log(shapeKeyWeight);
        skinnedMeshRenderer.SetBlendShapeWeight(shapeKeyIndex, shapeKeyWeight);
    }

    public void Fire()
    {

            Debug.Log("弾発射");
            Instantiate(bulletPrefab,firepoint);
    
    }
 
}
