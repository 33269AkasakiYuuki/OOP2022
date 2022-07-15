using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
    [Serializable]
    public class Person {
        [System.ComponentModel.DisplayName("名前")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("日付")]
        public string MailAddress { get; set; }
        [System.ComponentModel.DisplayName("車名")]
        public string Address { get; set; }
        [System.ComponentModel.DisplayName("レポート")]
        public string Company { get; set; }
        [System.ComponentModel.DisplayName("メーカー")]
        public string Group {
            get {
                string groups = "";
                foreach (GroupType group in listGroup) {
                    groups += "[" + group + "]";
                }
                return groups;
            }
        }

        public List<GroupType> listGroup { get; set; }

        [System.ComponentModel.DisplayName("登録日")]
        public DateTime Registration { get; set; }
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }

        public enum GroupType {
        トヨタ,
        日産,
        ホンダ,
        外国車,
        その他,
        }
    }
}
