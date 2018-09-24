using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class MyMain : MonoBehaviour
    {
        public static MyMain Instance { get; private set; }

        public MyInputController InputController { get; private set; }
        public MyFlashlightController FlashlightController { get; private set; }

        private void Awake()
        {
            if (Instance)
                DestroyImmediate(this);
            else
                Instance = this;
        }

        private void Start()
        {
            InputController = gameObject.AddComponent<MyInputController>();
            FlashlightController = gameObject.AddComponent<MyFlashlightController>();
        }

    }
}