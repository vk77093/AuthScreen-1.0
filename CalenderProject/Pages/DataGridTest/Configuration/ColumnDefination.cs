namespace CalenderProject.Pages.DataGridTest.Configuration
{
    public class ColumnDefination
    {
        public ColumnDefination()
        {
            this.DataType = DataType.NotSet;
            this.Aligment=Aligment.NotSet;
            this.SortDirection = SortDirection.NotSet;
        }
        public string? DataFiled { get; set; }
        public string? Caption { get; set; }
        public DataType DataType { get; set; }
        public string Format { get; set; }
        public Aligment Aligment { get; set; }

        //Adding for the sorting
        public SortDirection SortDirection { get; set; }
    }
}
