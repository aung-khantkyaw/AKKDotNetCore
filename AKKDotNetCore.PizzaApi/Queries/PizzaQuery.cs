using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKKDotNetCore.WinFormsApp.Queries
{
    internal class PizzaQuery
    {
        public static string PizzaOrderQuery { get; } =
            @"select po.*, p.Pizza, p.Price from [dbo].[Tbl_PizzaOrders] po
            inner join Tbl_Pizza p on p.PizzaId = po.PizzaId
            where PizzaOrderInvoiceNo = @PizzaOrderInvoiceNo;
            ";

        public static string PizzaOrderDetailQuery { get; } =
            @"select pod.*, pe.PizzaExtraName, pe.Price from [dbo].[Tbl_PizzaOrderDetails] pod
            inner join Tbl_PizzaExtra pe on pod.PizzaExtraId = pe.PizzaExtraId
            where PizzaOrderInvoiceNo = @PizzaOrderInvoiceNo;";
    }
}
