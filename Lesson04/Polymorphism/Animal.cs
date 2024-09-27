using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal interface Animal
    { 
        /*trong interface chỉ khai báo
        hàm chứ không định nghĩa hàm (nội dung bên trong). Chúng ta cần định nghĩa hàm
        ở các class kế thừa interface này */
        public void chao() { }
        public void keu() { }
    }
}
