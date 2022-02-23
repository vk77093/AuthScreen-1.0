namespace CalenderProject.Pages.DataGridTest.Configuration
{
    public class PagingConfiguration
    {
        public bool Enabled { get; set; }
        public int PageSize { get; set; }
        public bool CustomPager { get; set; }

        public int NumberOfItemsToSkip(int PageNumber)
        {
            if (Enabled)
            {
                return(PageNumber -1)* PageSize;
            }
            return 0;
        }
        public int NumberOfItemsToTake(int TotalItemsCount)
        {
            if (Enabled)
            {
                return PageSize;
            }
            return TotalItemsCount;
        }
        public int MaxPageNumber(int TotalItemsCount)
        {
            int MaxNumber = 0;
            double NumberOfPage=(double)TotalItemsCount/(double)PageSize;
            if(NumberOfPage==Math.Floor(NumberOfPage))
                MaxNumber = (int)NumberOfPage;
            else
                MaxNumber = (int)NumberOfPage+1;
            return MaxNumber;
        }
        public int PreviousPageNumber(int CurrentPageNumber)
        {
            if(CurrentPageNumber > 1)
            {
                return CurrentPageNumber - 1;
            }
            else
            {
                return 1;
            }
        }
        public int NextPageNumber(int CurrentPageNumber, int TotalItemCount)
        {
            if(CurrentPageNumber < MaxPageNumber(TotalItemCount))
            {
                return CurrentPageNumber + 1;
            }
            else
            {
                return CurrentPageNumber;
            }
        }
    }
}
