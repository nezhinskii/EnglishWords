using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonScript : MonoBehaviour
{
    public DataScript data;
    public void OnClickHandler()
    {
        data.CurrentTopicIndex = transform.GetSiblingIndex();
        SceneManager.LoadScene(6);
    }
}
