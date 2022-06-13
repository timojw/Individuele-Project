using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction_Layer;
using DAL_Layer;
using DAL_Layer.Model;
using DTO_Layer;

namespace DAL.Model
{
    public class OrderDAL : IOrderCollection, IOrderCreation
    {
        public OrderDAL(DALContext Context)
        {
            _context = Context;
        }
        public readonly DALContext _context;

        public List<OrderDTO> GetAllOrders()
        {
            List<Order> orders = _context.Orders.ToList<Order>();

            List<OrderDTO> orderDTOs = new();
            foreach (Order _order in orders)
            {
                orderDTOs.Add(_order.ToDTO());
            }
            return orderDTOs;
        }
        //public void updateevent(eventdto newevent)
        //{
        //    event? oldevent = _context.events.firstordefault(x => x.id == newevent.id);

        //    if (oldevent == null)
        //        return;


        //    if (newevent.title != "")
        //    {
        //        oldevent.title = newevent.title;
        //    }
        //    if (newevent.description != "")
        //    {
        //        oldevent.description = newevent.description;
        //    }
        //    if (newevent.locationbased != null)
        //    {
        //        oldevent.locationbased = (bool)newevent.locationbased;
        //    }
        //    if (newevent.longitude != -1000)
        //    {
        //        oldevent.longitude = newevent.longitude;
        //    }
        //    if (newevent.latitude != -1000)
        //    {
        //        oldevent.latitude = newevent.latitude;
        //    }
        //    if (newevent.startevent != default(datetime))
        //    {
        //        oldevent.startevent = newevent.startevent;
        //    }
        //    if (newevent.hasstarted != null)
        //    {
        //        oldevent.hasstarted = (bool)newevent.hasstarted;
        //    }
        //    if (newevent.maxpeople != null)
        //    {
        //        oldevent.maxpeople = newevent.maxpeople;
        //    }
        //    if (newevent.minpeople != null)
        //    {
        //        oldevent.minpeople = newevent.minpeople;
        //    }
        //    _context.savechanges();
        //}


        public OrderDTO GetOrderByID(int id)
        {
            Order _order = _context.Orders.FirstOrDefault(x => x.ID == id);

            if (_order == null)
                return null;

            return _order.ToDTO();
        }

        public bool AddOrder(OrderDTO orderDTO)
        {
            _context.Orders.Add(new Order(orderDTO));
            return _context.SaveChanges() > 0;
        }

        public void DeleteOrder(int Id)
        {
            Order? _order = _context.Orders.FirstOrDefault(x => x.ID == Id);

            if (_order == null)
                return;

            _context.Orders.Remove(_order);
            _context.SaveChanges();
        }



    }
}
