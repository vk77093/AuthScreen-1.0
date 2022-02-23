using AuthScreen.Models.MultipleForm;

namespace AuthScreen1.Repo
{
    public interface IMultiTest
    {
        void AddAllTableValue(List<NameTable> nameTables);
        Task<IEnumerable<NameTable>> GetAll();
    }
}