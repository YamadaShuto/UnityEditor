using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

public class TitleStarter : Editor
{
    private const string m_start_scene = "Assets/Scene/Title.unity";
    private const string m_save_key = "SaveScene";

    [MenuItem("Tools/Play From Title %@")]
    public static void PalyFromTitle()
    {
        if(EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            // Save editoring scene
            PlayerPrefs.SetString(m_save_key, SceneManager.GetActiveScene().path);
            // Transition scene
            EditorSceneManager.OpenScene(m_start_scene);
            // Auto playing
            EditorApplication.isPlaying = true;
        }
    }

    [InitializeOnLoadMethod]
    private static void gameEnd()
    {
        var scene = PlayerPrefs.GetString(m_save_key, "");
        if(string.IsNullOrEmpty(scene))
        {
            return;
        }
        EditorApplication.playmodeStateChanged = onPlayModeStateChanged;
    }

    private static void onPlayModeStateChanged()
    {
        //ending
        if(!EditorApplication.isPlaying)
        {
            EditorApplication.playmodeStateChanged = null;
            //back
            var scene = PlayerPrefs.GetString(m_save_key, "");
            PlayerPrefs.DeleteKey(m_save_key);
            EditorSceneManager.OpenScene(scene);
        }
    }
}
