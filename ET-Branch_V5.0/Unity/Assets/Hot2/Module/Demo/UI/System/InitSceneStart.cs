using ETModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hot2
{
    [Event(EventIdType.InitSceneStart)]
    public class InitSceneStart : AEvent
    {
        public override void Run()
        {
            UI ui = UILoginFactory.Create();
            Game.Scene.GetComponent<UIComponent>().Add(ui);
        }
    }
}
