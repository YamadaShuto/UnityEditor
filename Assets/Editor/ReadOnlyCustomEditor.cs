using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CustomEditorTest))]
public class ReadOnlyCustomEditor : Editor
{
    private CustomEditorTest editor_test;

    void OnEnable()
    {
        editor_test = (CustomEditorTest)target;
    }

        public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.LabelField("Rank", editor_test.rank.ToString());
    }
}