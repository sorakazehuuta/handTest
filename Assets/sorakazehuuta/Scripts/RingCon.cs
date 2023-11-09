using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCon : MonoBehaviour
{
    public GameObject ringCon;
    public GameObject oscTestObject;

    public int shapeKeyIndex;

    public float shapeKeyWeight;

    private SkinnedMeshRenderer skinnedMeshRenderer;

    public OscTest oscTest;


    // Start is called before the first frame update
    void Start()
    {
        oscTest = oscTestObject.GetComponent<OscTest>();
        skinnedMeshRenderer = ringCon.GetComponent<SkinnedMeshRenderer>();
    }

    public void RingConAnimation()
    {
        shapeKeyWeight = oscTest.value;
        Debug.Log(oscTest.value);
        //skinnedMeshRenderer.SetBlendShapeWeight(shapeKeyIndex, shapeKeyWeight);
    }
 
}
