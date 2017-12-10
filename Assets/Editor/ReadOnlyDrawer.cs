using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Inspector display setting
[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
// PropertyDrawer -> 
public class ReadOnlyDrawer : PropertyDrawer
{
    // Update display processing
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // not editor for Insoctor
        GUI.enabled = false;
        // 指定した領域に指定した変数を描画
        EditorGUI.PropertyField(position, property, label, true);
       GUI.enabled = true;
    }
}
