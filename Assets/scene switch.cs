using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagment;
public class sceneswitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.DelayedCall(10,GoToNextScene);
    }

    // Update is called once per frame
    void Update()
    {
        SceneManger.LoadScene("mika scene floor 2");
    }
}
