using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    public class CheckResult
    {
        public bool IsSuccess { get; private set; } = true;
        public string Message { get; set; }
        public TypeNumbers TypeNumber { get; set; }

        public enum TypeNumbers{
            None = 0,
            Success = 1,
            Info = 2,
            Warning = 3,
            Error = 4
        }

        public void SetNoneType()
        {
            SetSuccessStatus();
            this.TypeNumber = TypeNumbers.None;
        }
        public void SetSuccessType()
        {
            SetSuccessStatus();
            this.TypeNumber = TypeNumbers.Success;
        }
        public void SetInfoType()
        {
            SetSuccessStatus();
            this.TypeNumber = TypeNumbers.Info;
        }
        public void SetWarningType()
        {
            SetErrorStatus();
            this.TypeNumber = TypeNumbers.Warning;
        }
        public void SetErrorType()
        {
            SetErrorStatus();
            this.TypeNumber = TypeNumbers.Error;
        }
        public bool IsNoneType()
        {
            if(this.TypeNumber == TypeNumbers.None) { return true; }
            return false;
        }
        public bool IsSuccessType()
        {
            if (this.TypeNumber == TypeNumbers.Success) { return true; }
            return false;
        }
        public bool IsInfoType()
        {
            if (this.TypeNumber == TypeNumbers.Info) { return true; }
            return false;
        }
        public bool isWarningType()
        {
            if (this.TypeNumber == TypeNumbers.Warning) { return true; }
            return false;
        }
        public bool isErrorType()
        {
            if (this.TypeNumber == TypeNumbers.Error) { return true; }
            return false;
        }

        private void SetSuccessStatus()
        {
            this.IsSuccess = true;
        }

        private void SetErrorStatus()
        {
            this.IsSuccess = false;
        }
    }
}
