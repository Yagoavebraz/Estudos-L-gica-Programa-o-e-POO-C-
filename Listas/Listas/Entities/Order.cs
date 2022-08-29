using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities.Enums;
namespace Projeto.Entities {
    internal class Order {

        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

    }
}
