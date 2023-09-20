﻿using Core.Data;
using System.Linq.Expressions;

namespace Models.Extensions
{
    public class SchoolSystem
    {
        public static Func<IQueryable<Models.SchoolSystem>, IOrderedQueryable<Models.SchoolSystem>> GetOrderByFuncion(string ColumnName, string Dir)
        {
            Expression<Func<Models.SchoolSystem, object>> Exp = null;
            switch (ColumnName)
            {
                case "ID": Exp = obj => obj.ID; break;
                case "TitleAr": Exp = obj => obj.TitleAr; break;
                case "TitleEn": Exp = obj => obj.TitleEn; break;
                case "MessageAr": Exp = obj => obj.MessageAr; break;
                case "MessageEn": Exp = obj => obj.MessageEn; break;
            }
            return obj => OrderDirection.Asc == Dir ? obj.OrderBy(Exp) : obj.OrderByDescending(Exp);
        }
    }
}