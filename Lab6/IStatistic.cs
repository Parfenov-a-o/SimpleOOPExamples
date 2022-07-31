using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal interface IStatistic
    {
        //Количество просмотров
        int ViewsCount { get; set; }
        //Плата за просмотр
        double PayPerView { get; set; }
        //Рассчитать итоговый доход
        double TotalIncome();
        //Добавить просмотры
        int AddViews(int viewsCount);

    }
}
