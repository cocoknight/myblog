using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TOAN : 05/10/2022. Explain of Class Hierarchy and Access Modifier
namespace HelloProperty
{
    class ClassTree
    {
        private int branch; //가지
        private int leaf;   //잎

        protected int root; //뿌리
        public int trunk;   //몸통
    }


    class FineTree:ClassTree
    {
        private int finecone;
    }

    class AppleTree:ClassTree
    {
        private int apple;
    }

}
