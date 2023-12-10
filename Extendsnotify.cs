

namespace RastreioLogi.ViewModel
{
    public abstract class Extendsnotify : BindableObject
    {
        public void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            var name = GetMemberInfo(property).Name;
            OnPropertyChanged(name);
        }

    }

}

