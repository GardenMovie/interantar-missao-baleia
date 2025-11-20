using UnityEngine;

public class incrementTargetIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnBtnClicked()
    {
        GameManager.Instance.incrementIndex();
    }

}
