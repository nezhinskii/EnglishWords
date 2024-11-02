using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Learn2Script : MonoBehaviour
{
    public DataScript data;
    public Button mainButton;
    void Start()
    {
        data.GetWords(data.CurrentTopicIndex);
        var hText = GameObject.Find("HText").GetComponent<Text>();
        hText.text = data.Topic(data.CurrentTopicIndex);
        for (int i = 0; i < data.WordCount; i++)
        {
            var b = Instantiate(mainButton);
            b.GetComponentInChildren<Text>().text = data.Word(i);
            b.transform.SetParent(transform);
            b.transform.localScale = Vector2.one;
        }
        var es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        es.SetSelectedGameObject(transform.GetChild(0).gameObject);
    }
}

