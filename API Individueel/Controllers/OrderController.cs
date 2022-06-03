using Microsoft.AspNetCore.Mvc;
using Abstraction_Layer;
using DAL_Layer;
using DTO_Layer;

namespace API_Individueel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private IOrderCollection orderCollection;
        private IOrderCreation orderCreation;
        public OrderController(DALContext context, IOrderCollection? _orderCollection = null, IOrderCreation? _orderCreation = null)
        {
            orderCollection = _orderCollection;
            orderCreation = _orderCreation;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("GetOrderByID")]
        public IActionResult GetEvent(int Id)
        {
            OrderDTO? orderDTO = orderCollection.GetOrderByID(Id);

            if (orderDTO == null)
            {
                return BadRequest("A Order with this ID does not exist");
            }
            return Ok(orderDTO);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OrderDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("GetAllOrders")]
        public IActionResult GetAllEvents()
        {
            List<OrderDTO>? Orders = new List<OrderDTO>();
            Orders = orderCollection.GetAllOrders();

            return Ok(Orders);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(void))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("DeleteOrder")]
        public IActionResult DeleteEvent(int Id)
        {
            OrderDTO? orderDTO = orderCollection.GetOrderByID(Id);
            if (orderDTO == null)
            {
                return BadRequest("A Event with this ID does not exist");
            }
            orderCreation.DeleteOrder(Id);
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("CreateOrder")]
        //List<int> interests, List<int> members, 
        public IActionResult AddEvent(OrderDTO _order)
        {

            bool state = orderCreation.AddOrder(_order);
            if (state)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Invalid Input");
            }
        }
    }

}

