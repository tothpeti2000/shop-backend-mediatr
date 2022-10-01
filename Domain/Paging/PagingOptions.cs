using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Paging
{
    public class PagingOptions
    {
        private int page = 1;
        public int Page {
            get => page;
            set => page = value < 1 ? 1 : value;
        }

        private int count = 10;
        public int Count {
            get => count;
            set => count = value < 1 ? 10 : value;
        }
    }
}
