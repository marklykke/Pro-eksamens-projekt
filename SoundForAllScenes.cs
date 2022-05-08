using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundForAllScenes : MonoBehaviour
{
    public static SoundForAllScenes SoundInstance;

    private void awake()
    {
        if(SoundInstance != null && SoundInstance != this)
        {
            Destroy(this.gameObject);
            return;

        }

        SoundInstance = this;
        DontDestroyOnLoad(this);

    }


}
