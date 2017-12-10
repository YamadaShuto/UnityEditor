using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnlyAttributeTest : MonoBehaviour
{
    [SerializeField]
    private int m_attack;
    [SerializeField]
    private int m_deffence;
    // It is not display but can be edite
    [ReadOnlyAttribute]
    public int m_rank;
	
	// Update is called once per frame
	void Update ()
    {
        m_rank = m_attack * m_deffence;
	}
}
