using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();   
        }
        public Customer(int id)
            : this()//e esse faz voce ir para o construtor vazio a cima
            
        {
            this.Id = id;            
        }

        public Customer(int id, string name)
            : this(id) //isso faz voce ir para o construtor id a cima
                       //e assim ele vai rodar em todos para pegar todas as info.
        {
            this.Name = name;
        }
    }
}
