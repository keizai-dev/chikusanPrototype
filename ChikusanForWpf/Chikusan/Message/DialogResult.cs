using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    public class DialogResult
    {
        public bool Result { get; set; }
        public string InputText {get;set;}


        public DialogResult()
        {

        }

        public DialogResult(bool result , string text)
        {
            this.Result = result;
            this.InputText = text;
        }


    }
}
