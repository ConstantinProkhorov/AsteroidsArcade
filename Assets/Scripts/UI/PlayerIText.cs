using System.Collections;
using UnityEngine;

public class PlayerIText : MonoBehaviour
{
    public void TurnOn(object delay)
    {
        StartCoroutine(HidePlayerIText((float)delay));
    }
    private IEnumerator HidePlayerIText(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        gameObject.SetActive(false);
    }
}
