using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static GameObject mInstance;

    public static GameObject Instance
    {
        get
        {
            return mInstance;
        }
    }

    protected virtual void Awake()
    {
        if (mInstance == null)
        {
            DontDestroyOnLoad(gameObject);
            mInstance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
