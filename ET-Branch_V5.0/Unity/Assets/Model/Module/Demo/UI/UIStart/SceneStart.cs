using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETModel
{
    [Event(EventIdType.SceneStart)]
    public class SceneStart : AEvent
    {
        public override void Run()
        {
            UI ui = UILoadingFactory.Create();
            Game.Scene.GetComponent<UIComponent>().Add(ui);
        }
    }
}
