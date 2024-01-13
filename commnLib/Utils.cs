using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commnLib
{
    //internal class Utils
    public class Utils
    {

        static public Screen outScrn()
        {
            // 모든 모니터의 정보를 배열로 가져옵니다.
            Screen[] screens = Screen.AllScreens;

            // 첫 번째 모니터를 선택합니다. 인덱스를 바꾸어 다른 모니터를 선택할 수 있습니다.
            Screen screen = screens[screens.Length - 1];
            // 폼의 위치를 해당 모니터의 위치로 변경합니다.
            return screen;
        }
    }
}
