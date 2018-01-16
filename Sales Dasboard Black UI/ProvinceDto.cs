using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Dasboard_Black_UI
{
    class ProvinceDto
    {
        public int ID { get; set; }
        public string ProvinceTitle { get; set; }

        public string Summary
        {
            get
            {
                return ToString();
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", ProvinceTitle);
        }
    }
}
