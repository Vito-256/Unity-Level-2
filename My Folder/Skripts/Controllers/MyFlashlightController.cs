using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class MyFlashlightController : MyBaseController
    {
        //в кооментариях код, которым я пытался реализовать, что "при выключении фонарика заряд батареи восстанавливается"
        private MyFlashlightModel _model;
        private float Time_of_work = 10f;
        private float work_time;
        //private float charging_time;
        //private float Time_of_MINcharging = 5f;
        //private float Time_of_MAXcharging = 10f;

        private void Awake()
        {
            _model = FindObjectOfType<MyFlashlightModel>();
            Off();
        }
        private void Update()
        {
            if (Time.time - work_time >= Time_of_work)
            {
                Off();
                //if (Time.time - charging_time <= Time_of_MAXcharging || Time.time - charging_time >= Time_of_MINcharging)
                //{
                //    Switch();
                //}
            }
        }
        public override void Off()
        {
            base.Off();
            _model.Off();
        }

        public override void On()
        {
            base.On();
            _model.On();
        }

        public void Switch()
        {
            if (IsEnabled)
            {
                Off();
                //charging_time = Time.time;
            }

            else
            {
                On();
                work_time = Time.time;
            }
        }
    }
}