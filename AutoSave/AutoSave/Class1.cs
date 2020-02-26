using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoSave
{
    public class ASaveReminder : IUserMod
    {
        //private static bool installed = false;
        //private static string locale_name = "zh-cn";
        //private static string version = "(For 1.12.0-f5)";

        public string Description
        {
            get
            {
                return "这下不用担心出问题而没保存了（You don't  worry about something error before save）";
            }
        }


        public string Name
        {
            get
            {
                return "保存提醒器（Save Reminder）";
            }
        }
        public void OnEnabled()
        {

        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            /*UIHelperBase group = helper.AddGroup("My Own Group");
            group.AddCheckbox("My Checkbox", false, (checked) => Debug.Log(checked));
            group.AddSlider("My Slider", 0, 1, 0.01f, 0.5f, (value) => Debug.Log(value));
            group.AddDropdown("My Dropdown", new string[] { "First Entry", "Second Entry", "Third Entry" }, -1, (index) => Debug.Log(index));
            group.AddSpace(250);
            group.AddButton("My Button", () => { Debug.Log("Button clicked!"); });
            group.AddTextfield("My Textfield", "Default value", (value) => Debug.Log("text changed: " + value), (value) => Debug.Log("text submitted: " + value));*/
        }
    }
}
