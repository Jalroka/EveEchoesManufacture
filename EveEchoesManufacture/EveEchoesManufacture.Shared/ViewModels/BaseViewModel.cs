using EveEchoesManufacture.Contracts;
using EveEchoesManufacture.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveEchoesManufacture.ViewModels
{
    public class BaseViewModel : BaseObservable
    {
        protected SettingsServices settings = new SettingsServices();
    }
}
