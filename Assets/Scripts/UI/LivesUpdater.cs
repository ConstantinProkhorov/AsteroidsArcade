using UnityEngine;
/// <summary>
/// Displays how many lives player has.
/// </summary>
public class LivesUpdater : MonoBehaviour
{
    [SerializeField] private GameObject LivesDisplay = null;
    [SerializeField] private IntegerVariable PlayerLives = null;
    private GameObject[] LivesImageArray;
    private int LivesIndex;
    public void Start()
    {
        //идея всего кода ниже - это согласование размеров массива с картинками жизней и количества самих жизней.
        //теперь, они согласованы и возможно менять дефолтное значение для IntegerVariable PlayerLives не меняя код и получая корректное отображение. 
        //меня смущает однако, что для такой простой задачи выполняется так много операций. 
        LivesImageArray = new GameObject[PlayerLives];
        int LivesDisplayChildCount = LivesDisplay.transform.childCount;
        for (int i = 0; i < LivesImageArray.Length; i++)
        {
            if (i < LivesDisplayChildCount)
            {
                GameObject child = LivesDisplay.transform.GetChild(i).gameObject;
                LivesImageArray[i] = child;
                child.SetActive(true);
            }
        }
        PlayerLives.Decreased += RemoveOneLife;
        LivesIndex = LivesImageArray.Length - 1;
    }
    //Disables one of images in the array
    private void RemoveOneLife()
    {
        LivesImageArray[LivesIndex].SetActive(false);
        LivesIndex--;
    }
}
