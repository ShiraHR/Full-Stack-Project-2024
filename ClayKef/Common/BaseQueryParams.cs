namespace Common
{
    public class BaseQueryParams
    {
        const int MAX_PAGE_SIZE = 50;
        public int PageNumber { get; set; } = 1;

        private int pageSize = 15;
        public int PageSize
        {
            get { return pageSize; }
            set { if (value > 0 && value < MAX_PAGE_SIZE) pageSize = value; }
        }

    }
}