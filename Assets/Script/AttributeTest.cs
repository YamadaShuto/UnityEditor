using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeTest : MonoBehaviour
{
    // Draw and edit private member as Inspector
    [SerializeField]
    private int private_pram_show;
    private int private_pram;

    // Do not Draw and edit public member as Inspector
    [HideInInspector]
    public int public_parm_hide;
    public int public_parm;

    // Draw public class as Inspector
    [System.Serializable]
    public class PublicClassShow
    {
        public int param;
    }
    public PublicClassShow public_class;
    public class NormalClass
    {
        public int param;
    }
    public NormalClass normal_class;

    [ReadOnly]
    private int param;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
