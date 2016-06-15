using FirstFloor.ModernUI.Presentation;
using System;
using System.ComponentModel;

namespace FirstFloor.ModernUI.App.Content
{
    public class BaGuaViewModel
        : NotifyPropertyChanged, IDataErrorInfo
    {
        private string qianGua = "乾";
        private string kunGua  = "坤";
        private string liGua   = "离";
        private string kanGua  = "坎";
        private string xunGua  = "巽";
        private string zhengGua = "震";
        private string duiGua  = "兑";
        private string genGua  = "艮";
    

        public string QianGua
        {
            get { return qianGua;  }
        }

        public string KunGua
        {
            get { return this.kunGua;  }
        }

        public string LiGua
        {
            get { return this.liGua;  }
        }

        public string KanGua
        {
            get { return this.kanGua;  }
        }

        public string XunGua
        {
            get { return this.xunGua;  }
        }

        public string ZhengGua
        {
            get { return this.zhengGua;  }
        }

        public string DuiGua
        {
            get { return this.duiGua;  }
        }

        public string GenGua
        {
            get { return this.genGua;  }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string columnName]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
