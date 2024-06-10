using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klikerdluigori
{
    internal class XER
    {
        private int chet = 0;
        private int time = 0;
        private Action action;
        private System.Windows.Forms.Timer timer;
        public void Start(System.Windows.Forms.Timer timer, int time, Action action)
        {
            timer.Start();
            this.time = time;
            this.action = action;
            this.timer = timer;
        }
        public void Tick()
        {
            chet++;
            if (chet > time)
            {
                action();
                timer.Stop();
                chet = 0;
            }
        }
    }
}
