using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Commons
{
    /// <summary>
    /// 画面の状態に関わるクラスです
    /// </summary>
    public class DisplayMode
    {
        private modeEnum _mode;

        public enum modeEnum
        {
            entry = 0,
            update = 1,
            copy = 2,
        }

        public void SetEntryMode()
        {
            this._mode = modeEnum.entry;
        }

        public void SetUpdateMode()
        {
            this._mode = modeEnum.update;
        }

        public void SetCopyMode()
        {
            this._mode = modeEnum.copy;
        }

        public bool IsEntryMode()
        {
            if (this._mode == modeEnum.entry) { return true; }
            return false;
        }

        public bool IsUpdateMode()
        {
            if(this._mode == modeEnum.update) { return true; }
            return false;
        }

        public bool IsCopyMode()
        {
            if (this._mode == modeEnum.copy) { return true; }
            return false;
        }

    }
}
