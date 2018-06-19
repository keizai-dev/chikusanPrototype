using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// ダイアログパラメータクラス
    /// </summary>
    public class DialogParameter
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public IconTypes IconType { get; set; } = IconTypes.Info;
        public enum IconTypes
        {
            Info,
            Warning,
            Error,
            Question
        }
        public ButtonTypes ButtonType { get; set; } = ButtonTypes.YesOnly;
        public enum ButtonTypes
        {
            YesOnly,
            YesNo,
            NoYes
        }
        public void SetTypeYesNo()
        {
            this.ButtonType = ButtonTypes.YesNo;
        }
        public void SetTypeYesOnly()
        {
            this.ButtonType = ButtonTypes.YesOnly;
        }
        public void SetTypeNoYes()
        {
            this.ButtonType = ButtonTypes.NoYes;
        }

        public void SetIconInfo()
        {
            this.IconType = IconTypes.Info;
        }
        public void SetIconWarning()
        {
            this.IconType = IconTypes.Warning;
        }
        public void SetIconError()
        {
            this.IconType = IconTypes.Error;
        }
        public void SetIconQuestion()
        {
            this.IconType = IconTypes.Question;
        }

        public bool IsYesNo()
        {
            if(ButtonTypes.YesNo == this.ButtonType) { return true; }
            return false;
        }
        public bool IsYesOnly()
        {
            if (ButtonTypes.YesOnly == this.ButtonType) { return true; }
            return false;
        }
        public bool IsNoYes()
        {
            if (ButtonTypes.NoYes == this.ButtonType) { return true; }
            return false;
        }

        public bool IsInfoIcon()
        {
            if (IconTypes.Info == this.IconType) { return true; }
            return false;
        }
        public bool IsWaningIcon()
        {
            if (IconTypes.Warning == this.IconType) { return true; }
            return false;
        }
        public bool IsQuestionIcon()
        {
            if (IconTypes.Question == this.IconType) { return true; }
            return false;
        }
        public bool IsErrorIcon()
        {
            if (IconTypes.Error == this.IconType) { return true; }
            return false;
        }
    }
}
