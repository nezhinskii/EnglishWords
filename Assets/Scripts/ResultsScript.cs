using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResultsScript : MonoBehaviour
{
    public DataScript data;
    public DialogScript dialog;
    void Start()
    {
        if (data.ResultCount == 0) return;

        for (int i = 0; i < data.WordCount; i++)
        {
            var b = Instantiate(data.mainButton);
            b.GetComponentInChildren<Text>().text = data.Word(i);
            b.transform.SetParent(transform);
            b.transform.localScale = Vector2.one;
            SetItemHandler(b, i);
        }
        var es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        es.SetSelectedGameObject(transform.GetChild(0).gameObject);

        var child0 = transform.GetChild(0).GetComponent<Button>();
        data.SetNavigationDown(GameObject.Find("HRButton").GetComponent<Button>(), child0);
        data.SetNavigationDown(GameObject.Find("HLButton").GetComponent<Button>(), child0);
    }

    void SetItemHandler(Button b, int i)
    {
        b.onClick.AddListener(() => dialog.ShowDialog("Информация о тесте",
        data.CompleteResultInfo(i)));
    }
}

