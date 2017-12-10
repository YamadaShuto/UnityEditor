using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEditorTest : MonoBehaviour
{
    [SerializeField]
    private int m_attack;
    [SerializeField]
    private int m_deffence;
	public int rank
    {
        get { return m_attack * m_deffence; }
    }
}
