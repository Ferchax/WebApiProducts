using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsQR.Helpers
{
    public class PagedListHelper<T> : List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }

        private bool HasPrevious { get => (CurrentPage > 1); }

        private bool HasNext { get => (CurrentPage < TotalPages); }

        public PagedListHelper(List<T> items, int totalCount, int pageNumber, int pageSize)
        {
            TotalCount = totalCount;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            AddRange(items);
        }

        public static PagedListHelper<T> Create(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var totalCount = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedListHelper<T>(items, totalCount, pageNumber, pageSize);
        }
    }
}
