using UnityEngine;

public class RedBox : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChoiceSelector.choiceMade?.Invoke("Red");
    }
}
