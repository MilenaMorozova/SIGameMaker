using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace SIGameMaker.ViewModels.Base;

public class ViewModel: INotifyPropertyChanged, IDisposable
{
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if(Equals(field, value)) return false;

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    public void Dispose()
    {
        Dispose(true);
    }

    private bool _disposed;
    protected void Dispose(bool disposing)
    {
       if(!disposing || _disposed) return;
       _disposed = true;
    }
}