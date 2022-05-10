using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloProperty
{
    class BankCustomer
    {
        //TOAN : 05/10/2022. Auto Property를 사용했을 때는
        //DataMember선언도 필요가 없다.
        //private int customer1Assets;
        //private int customer2Assets;

        //TOAN : 05/10/2022. 기존 멤버 펑션으로 구현하던 방법
        //public void setCustomer1Assets(int money)
        //{
        //    customer1Assets = money;

        //}

        //public int getCustomer1Assets()
        //{
        //    return customer1Assets;
        //}

        //public void setCustomer2Assets(int money)
        //{
        //    customer1Assets = money;
        //}

        //public int getCustomer2Assets()
        //{
        //    return customer1Assets;
        //}

        //TOAN : 05/10/2022. Property를 사용한 방법
        //public int Custmer1Asset
        //{
        //    get { return customer1Assets; }
        //    set { customer1Assets = value; }
        //}

        //public int Custmer2Asset
        //{
        //    get { return customer2Assets; }
        //    set { customer2Assets = value; }
        //}

        //TOAN : 05/10/2022. 자동구현 프로퍼티(Auto Property)를 사용한 방식
        public int Custmer1Asset
        {
            get;
            set;
        }

        public int Custmer2Asset
        {
            get;
            set;
        } = 44;

        public BankCustomer()
        {
            Custmer2Asset = 22;
            Debug.WriteLine(string.Format("Default Constructor(BankCustomer)" ));
        }

    }
}
