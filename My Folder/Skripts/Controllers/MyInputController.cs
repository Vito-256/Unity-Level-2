using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class MyInputController : MyBaseController
    {
        private void Update()
        {
            if (Input.GetButtonDown("SwitchFlashlight"))
                MyMain.Instance.FlashlightController.Switch();
        }
    }
}