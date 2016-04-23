﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeManager.ThemeManager
{
    public class ThemeEnums
    {
        public enum ThemeEnum
        {
            KM_THEME_MISTYROSE=0,
            KM_THEME_ALICEBLUE=1,
            KM_THEME_HONEYDEW=2,
            KM_THEME_LEMONCHIFFON=3
        }

        public enum ColorTable
        {
            //蓝色焦点状态
            KM_C_A2C3E7=0,//Out
            KM_C_2F85B8=1,//In
            KM_C_EADDE2=2,//四角颜色

            //普通状态
            KM_C_9AB6C7=3,//边
            KM_C_E6EDF1=4,//角
        }
    }
}
