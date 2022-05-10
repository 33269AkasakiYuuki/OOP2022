using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    public class SelesCounter {
        private List<Sale> _sales; //csvファイルから読み込んだデータ

        //コンストラクタ
        public SelesCounter(List<Sale> sales) {
            _sales = sales;
        }

        //店舗別売り上げを求める
        public IDictionary<string, int> GetValuePairs() {
            var dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                    else
                        dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }

}

